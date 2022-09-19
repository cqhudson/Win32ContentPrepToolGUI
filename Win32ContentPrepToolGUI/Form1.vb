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

    Dim rootOfDrive As String = System.Environment.GetEnvironmentVariable("HOMEDRIVE")
    Dim installerPath As String
    Dim sourceFolder As String
    Dim outputFolder As String
    Dim prepToolExe As String
    Dim installerFileName As String
    'Dim catalogChoice As Boolean = False

#Region " Buttons "

    Private Sub btnSelectInstaller_Click(sender As Object, e As EventArgs) Handles btnSelectInstaller.Click

        Dim ofd As OpenFileDialog = opnfilediagSelectInstaller

        ofd.Title = "Select Installer File (.exe or .msi)"
        ofd.InitialDirectory = rootOfDrive
        ofd.ShowDialog()

    End Sub
    Private Sub btnStartPackaging_Click(sender As Object, e As EventArgs) Handles btnStartPackaging.Click

        Dim properties As New ProcessStartInfo

        Dim param_setupFolder As String = "-c"
        Dim param_setupFile As String = "-s"
        Dim param_outputFolder As String = "-o"
        'Dim param_catalogFolder As String = "-a" ' This will be used in the future
        Dim param_quietMode As String = "-q"
        Dim sp As String = " "
        Dim powershell As String = "powershell.exe"

        Dim sb As New StringBuilder()
        Dim sb2 As New StringBuilder()
        Dim args As String

        Dim fixedInstaller As String
        fixedInstaller = sb2.Append(Chr(34)).Append(sourceFolder).Append("\").Append(installerFileName).Append(Chr(34)).ToString()

        sb.Append(prepToolExe).Append(sp)
        sb.Append(param_setupFolder).Append(sp).Append(sourceFolder)
        sb.Append(sp).Append(param_setupFile).Append(sp).Append(fixedInstaller) '.Append(installerFileName_ForPowershell)
        sb.Append(sp).Append(param_outputFolder).Append(sp).Append(outputFolder)
        sb.Append(sp).Append(param_quietMode).ToString()

        args = sb.ToString()
        txtArguments.Text = args

        debugMessages("Debug args: ", lblDebug_args, args)




        'properties.FileName = prepToolExe
        'properties.Arguments = args
        'properties.WindowStyle = ProcessWindowStyle.Normal

        StartContentPrep(prepToolExe, args)

    End Sub

    Private Sub btnSelectInstallerFolder_Click(sender As Object, e As EventArgs) Handles btnSelectInstallerFolder.Click

        SelectFolder(fbdiagSelectSourceFolder, txtPathOfInstallerFolder)
        sourceFolder = txtPathOfInstallerFolder.Text
        debugMessages("Debug installerFolder: ", lblDebug_installerFolder, sourceFolder)

    End Sub
    Private Sub btnSelectOutputFolder_Click(sender As Object, e As EventArgs) Handles btnSelectOutputFolder.Click

        SelectFolder(fbdiagSelectOutputFolder, txtOutputFolderPath)
        outputFolder = txtOutputFolderPath.Text
        debugMessages("Debug outputFolder: ", lblDebug_outputFolder, outputFolder)

    End Sub
    Private Sub btnSelectPrepToolExe_Click(sender As Object, e As EventArgs) Handles btnSelectPrepToolExe.Click

        Dim ofd As OpenFileDialog = opnfilediagSelectPrepToolExe

        ofd.Title = "Select IntuneWinAppUtil.exe"
        ofd.InitialDirectory = rootOfDrive
        ofd.ShowDialog()

    End Sub

#End Region

#Region " Open File Dialogs "

    Private Sub opnfilediagSelectInstaller_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opnfilediagSelectInstaller.FileOk

        Dim sb As New StringBuilder()
        Dim reversedFilePath As String
        Dim index As Integer
        Dim singleQuote As Integer = 39

        SelectFile(opnfilediagSelectInstaller, txtPathOfInstaller)
        installerPath = txtPathOfInstaller.Text

        reversedFilePath = StrReverse(installerPath)

        debugMessages("Debug installerPath: ", lblDebug_installerPath, installerPath)


        ' This loop is so we can capture the filename of the executable we want to pack.
        ' Unfortunately, if there are spaces in the filename, IntuneWinAppUtil.exe throws
        ' some errors unless it is wrapped in quotes.

        For Each c As Char In reversedFilePath
            index += 1
            If c = "\" Then
                installerFileName = reversedFilePath.Substring(0, index - 1)
                installerFileName = StrReverse(installerFileName)

                installerFileName = sb.Append(Chr(singleQuote)).Append(installerFileName).Append(Chr(singleQuote)).ToString() ' Add double quotation marks to the beginning and ending of filename

                debugMessages("Installer filename is: ", lblDebug_installerFileName, installerFileName)
                Exit For
            End If
        Next

    End Sub
    Private Sub opnfilediagSelectPrepToolExe_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opnfilediagSelectPrepToolExe.FileOk

        SelectFile(opnfilediagSelectPrepToolExe, txtPathOfPrepToolExe)
        prepToolExe = txtPathOfPrepToolExe.Text
        debugMessages("Debug prepToolExe: ", lblDebug_prepToolExe, prepToolExe)

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

    Sub StartContentPrep(prepExe As String, args As String) ' prepExe is the IntuneWinAppUtil.exe filepath

        Dim sb As New StringBuilder()
        sb.Append("").Append(args)
        args = sb.ToString()


        Try
            Dim proc As New Process
            proc = Process.Start("powershell.exe", args)
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

        Dim rbtn As RadioButton = grpBox.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()

        If rbtn.Name = "radNo" Then
            debugMessages("Debug catalogChoice: ", lblDebug_catalogChoice, "N")
        Else
            debugMessages("Debug catalogChoice: ", lblDebug_catalogChoice, "Y")
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
