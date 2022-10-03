'
' © 2022 - Connor Hudson
'
' Author: Connor Hudson
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

#Region " Buttons "

    Private Sub btnSelectInstaller_Click(sender As Object, e As EventArgs) Handles btnSelectInstaller.Click

        Dim ofd As OpenFileDialog = opnfilediagSelectInstaller

        ofd.Title = "Select Installer File (.exe or .msi)"
        ofd.InitialDirectory = HomeDrive
        ofd.ShowDialog()

    End Sub
    Private Sub btnStartPackaging_Click(sender As Object, e As EventArgs) Handles btnStartPackaging.Click

        If CheckToEnablePackaging() Then
            Dim properties As New ProcessStartInfo

            Dim PowerShell As String = "powershell.exe"

            Dim sb As New StringBuilder()
            Dim sb2 As New StringBuilder()
            Dim Args As String

            Dim PatchedSetupFilePath As String ' Use this to wrap the setup_file path in double quotations for PowerShell
            PatchedSetupFilePath = sb2.Append(Chr(34)).Append(SetupFolder).Append("\").Append(SetupFileName).Append(Chr(34)).ToString()

            Args = GenerateArguments(PatchedSetupFilePath)

            StartContentPrep(PowerShell, Args)
        End If

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
    Private Sub btnSelectCatalogFolder_Click(sender As Object, e As EventArgs) Handles btnSelectCatalogFolder.Click

        SelectFolder(fbdiagSelectCatalogFolder, txtCatalogFolder)
        CatalogFolder = txtCatalogFolder.Text

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

    '
    ' Uncomment this function to use labels and textboxes for debugging
    '
    'Sub debugMessages(debugMsg As String, debugLabel As Label, Optional debugValue As String = "")

    '    debugLabel.Text = debugMsg + debugValue

    'End Sub

    Sub CatalogFolderChoice(btn As Button, txtbox As TextBox, choice As Boolean)

        txtbox.Text = ""
        CatalogFolder = ""

        If choice Then
            btn.Enabled = choice
        Else
            btn.Enabled = choice
        End If

    End Sub

    Function GenerateArguments(PatchedSetupFilePath As String) As String

        Dim Args As String
        Dim ArgBuilder As New StringBuilder

        Dim Param_SetupFolder As String = "-c"
        Dim Param_SetupFile As String = "-s"
        Dim Param_OutputFolder As String = "-o"
        Dim Param_CatalogFolder As String = "-a"
        Dim Param_QuietMode As String = "-q"
        Dim Space As String = " "

        If chkCatalogFolder.Checked Then ' If true, then generate args including a catalog folder

            ArgBuilder.Append(PrepToolExe).Append(Space)
            ArgBuilder.Append(Param_SetupFolder).Append(Space).Append(SetupFolder)
            ArgBuilder.Append(Space).Append(Param_SetupFile).Append(Space).Append(PatchedSetupFilePath)
            ArgBuilder.Append(Space).Append(Param_OutputFolder).Append(Space).Append(OutputFolder)
            ArgBuilder.Append(Space).Append(Param_CatalogFolder).Append(Space).Append(CatalogFolder)

            ' Enable quiet mode if true
            If chkQuietMode.Checked Then
                ArgBuilder.Append(Space).Append(Param_QuietMode).ToString()
            End If

        Else

            ArgBuilder.Append(PrepToolExe).Append(Space)
            ArgBuilder.Append(Param_SetupFolder).Append(Space).Append(SetupFolder)
            ArgBuilder.Append(Space).Append(Param_SetupFile).Append(Space).Append(PatchedSetupFilePath)
            ArgBuilder.Append(Space).Append(Param_OutputFolder).Append(Space).Append(OutputFolder)

            ' Enable quiet mode if true
            If chkQuietMode.Checked Then
                ArgBuilder.Append(Space).Append(Param_QuietMode).ToString()
            End If

        End If

        Args = ArgBuilder.ToString()
        Return Args

    End Function

    Function CheckToEnablePackaging() As Boolean

        Dim Check1, Check2, Check3, Check4, Check5 As Boolean
        Const MsgTitle As String = "Please fill in all values."
        Const MsgError As String = "One or more arguments was not specified, please make sure you fill in all values!"

        If PrepToolExe = "" Then
            Check1 = False
        Else
            Check1 = True
        End If

        If SetupFile = "" Then
            Check2 = False
        Else
            Check2 = True
        End If

        If SetupFolder = "" Then
            Check3 = False
        Else
            Check3 = True
        End If

        If OutputFolder = "" Then
            Check4 = False
        Else
            Check4 = True
        End If


        If chkCatalogFolder.Checked Then

            If CatalogFolder = "" Then
                Check5 = False
            Else
                Check5 = True
            End If

            If Check1 = False Or Check2 = False Or Check3 = False Or Check4 = False Or Check5 = False Then
                MessageBox.Show(MsgError, MsgTitle)
                Return False
            Else
                Return True
            End If

        Else

            If Check1 = False Or Check2 = False Or Check3 = False Or Check4 = False Then
                MessageBox.Show(MsgError, MsgTitle)
                Return False
            Else
                Return True
            End If

        End If


    End Function

#End Region

    Private Sub chkCatalogFolder_CheckedChanged(sender As Object, e As EventArgs) Handles chkCatalogFolder.CheckedChanged
        If chkCatalogFolder.Checked Then
            btnSelectCatalogFolder.Enabled = True
            txtCatalogFolder.Enabled = True
        Else
            btnSelectCatalogFolder.Enabled = False
            txtCatalogFolder.Enabled = False
            CatalogFolder = ""
            txtCatalogFolder.Text = ""
        End If
    End Sub

End Class
