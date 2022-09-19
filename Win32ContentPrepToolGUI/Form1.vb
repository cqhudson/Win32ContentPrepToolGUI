'
' Author: Connor Hudson
'
' Date: 15-Sept-2022
'




'
' TODO:
'
'  - Execute the content prepper
'   1 Figure out how to start a process and execute external applications,
'
'   2 Pass args to the content prepper
'
'   3 Make sure that no processes start UNLESS the selected app is the microsoft content prepper
'
'  - Make an option for catalog folders
'

'
'

Imports System.Text

Public Class Form1

    Dim HomeDrive As String = Environment.GetEnvironmentVariable("HOMEDRIVE")
    Dim SetupFile As String
    Dim SetupFolder As String
    Dim OutputFolder As String
    Dim PrepToolExe As String
    Dim SetupFileName As String
    Dim CatalogFolder As String
    Dim CatalogChoice As Boolean = False

#Region " Buttons "

    Private Sub btnSelectInstaller_Click(sender As Object, e As EventArgs) Handles btnSelectInstaller.Click

        Dim ofd As OpenFileDialog = opnfilediagSelectInstaller

        ofd.Title = "Select Installer File (.exe or .msi)"
        ofd.InitialDirectory = HomeDrive
        ofd.ShowDialog()

    End Sub
    Private Sub btnStartPackaging_Click(sender As Object, e As EventArgs) Handles btnStartPackaging.Click

        Dim properties As New ProcessStartInfo

        Dim Param_SetupFolder As String = "-c"
        Dim Param_SetupFile As String = "-s"
        Dim Param_OutputFolder As String = "-o"
        Dim Param_CatalogFolder As String = "-a"
        Dim Param_QuietMode As String = "-q"
        Dim Space As String = " "
        Dim PowerShell As String = "powershell.exe"

        Dim sb As New StringBuilder()
        Dim sb2 As New StringBuilder()
        Dim Args As String

        Dim PatchedSetupFilePath As String ' Use this to wrap the setup_file path in double quotations for PowerShell
        PatchedSetupFilePath = sb2.Append(Chr(34)).Append(SetupFolder).Append("\").Append(SetupFileName).Append(Chr(34)).ToString()

        sb.Append(PrepToolExe).Append(Space)
        sb.Append(Param_SetupFolder).Append(Space).Append(SetupFolder)
        sb.Append(Space).Append(Param_SetupFile).Append(Space).Append(PatchedSetupFilePath)
        sb.Append(Space).Append(Param_OutputFolder).Append(Space).Append(OutputFolder)
        sb.Append(Space).Append(Param_QuietMode).ToString()

        Args = sb.ToString()
        txtArguments.Text = Args

        StartContentPrep(PowerShell, Args)

    End Sub

    Private Sub btnSelectInstallerFolder_Click(sender As Object, e As EventArgs) Handles btnSelectInstallerFolder.Click

        SelectFolder(fbdiagSelectSourceFolder, txtPathOfInstallerFolder)
        SetupFolder = txtPathOfInstallerFolder.Text

    End Sub
    Private Sub btnSelectOutputFolder_Click(sender As Object, e As EventArgs) Handles btnSelectOutputFolder.Click

        SelectFolder(fbdiagSelectOutputFolder, txtOutputFolderPath)
        OutputFolder = txtOutputFolderPath.Text

    End Sub
    Private Sub btnSelectPrepToolExe_Click(sender As Object, e As EventArgs) Handles btnSelectPrepToolExe.Click

        Dim ofd As OpenFileDialog = opnfilediagSelectPrepToolExe

        ofd.Title = "Select IntuneWinAppUtil.exe"
        ofd.InitialDirectory = HomeDrive
        ofd.ShowDialog()

    End Sub

#End Region

#Region " Open File Dialogs "

    Private Sub opnfilediagSelectInstaller_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opnfilediagSelectInstaller.FileOk

        Dim sb As New StringBuilder()
        Dim ReversedFilePath As String
        Dim Index As Integer
        Dim SingleQuote As Integer = 39

        SelectFile(opnfilediagSelectInstaller, txtPathOfInstaller)
        SetupFile = txtPathOfInstaller.Text

        ReversedFilePath = StrReverse(SetupFile)

        ' This loop is so we can capture the filename of the executable we want to pack.
        ' Unfortunately, if there are spaces in the filename, IntuneWinAppUtil.exe throws
        ' some errors unless it is wrapped in quotes.

        For Each character As Char In ReversedFilePath
            Index += 1
            If character = "\" Then
                SetupFileName = ReversedFilePath.Substring(0, Index - 1)
                SetupFileName = StrReverse(SetupFileName)

                SetupFileName = sb.Append(Chr(SingleQuote)).Append(SetupFileName).Append(Chr(SingleQuote)).ToString() ' Add double quotation marks to the beginning and ending of filename

                debugMessages("Installer filename is: ", lblDebug_installerFileName, SetupFileName)
                Exit For
            End If
        Next

    End Sub
    Private Sub opnfilediagSelectPrepToolExe_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opnfilediagSelectPrepToolExe.FileOk

        SelectFile(opnfilediagSelectPrepToolExe, txtPathOfPrepToolExe)
        PrepToolExe = txtPathOfPrepToolExe.Text

    End Sub

#End Region

#Region " Sub Procedures and Functions "
    Sub SelectFolder(fbdiag As FolderBrowserDialog, txtbox As TextBox)

        If (fbdiag.ShowDialog() = DialogResult.OK) Then
            txtbox.Text = fbdiag.SelectedPath()
        End If

    End Sub

    Sub SelectFile(openFileDiag As OpenFileDialog, txtBox As TextBox)

        Dim stream As System.IO.Stream
        stream = openFileDiag.OpenFile()
        txtBox.Text = openFileDiag.FileName.ToString()

    End Sub

    Sub StartContentPrep(Executable As String, Args As String) ' prepExe is the IntuneWinAppUtil.exe filepath, I would like to directly call this instead of calling powershell later.

        Dim sb As New StringBuilder()
        sb.Append("").Append(Args)
        Args = sb.ToString()

        Try
            Dim proc As New Process
            proc = Process.Start(Executable, Args)
            proc.WaitForExit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub debugMessages(debugMsg As String, debugLabel As Label, Optional debugValue As String = "")
        debugLabel.Text = debugMsg + debugValue
    End Sub
#End Region

#Region " Catalog Choice Group Box "
    Private Sub GetGroupBoxCheckedRadioButton(grpBox As GroupBox)

        Dim RBtn As RadioButton = grpBox.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()

        If RBtn.Name = "radNo" Then
            CatalogChoice = False
        Else
            CatalogChoice = True
        End If

    End Sub

    Private Sub radYes_CheckedChanged(sender As Object, e As EventArgs) Handles radYes.CheckedChanged
        GetGroupBoxCheckedRadioButton(grpCatalogFolder)
    End Sub

    Private Sub radNo_CheckedChanged(sender As Object, e As EventArgs) Handles radNo.CheckedChanged
        GetGroupBoxCheckedRadioButton(grpCatalogFolder)
    End Sub

#End Region

End Class
