'
' Author: Connor Hudson
'
' Date: 15-Sept-2022
'

Imports System.IO

Public Class Form1

#Region " Buttons "

    Private Sub btnSelectInstaller_Click(sender As Object, e As EventArgs) Handles btnSelectInstaller.Click

        Dim ofd As OpenFileDialog = opnfilediagSelectInstaller

        ofd.Title = "Select Installer File (.exe or .msi)"
        ofd.InitialDirectory = GlobalVars.rootOfDrive
        ofd.ShowDialog()

    End Sub
    Private Sub btnStartPackaging_Click(sender As Object, e As EventArgs) Handles btnStartPackaging.Click
        'Dim cmd
        'cmd = CreateObject("wscript.shell")
        'cmd.run("echo", "Hello world!")
    End Sub
    Private Sub btnSelectInstallerFolder_Click(sender As Object, e As EventArgs) Handles btnSelectInstallerFolder.Click

        SelectFolder(fbdiagSelectSourceFolder, txtPathOfInstallerFolder)
        GlobalVars.sourceFolder = txtPathOfInstallerFolder.Text
        debugMessages("Debug installerFolder: ", lblDebug_installerFolder, GlobalVars.sourceFolder)

    End Sub
    Private Sub btnSelectOutputFolder_Click(sender As Object, e As EventArgs) Handles btnSelectOutputFolder.Click

        SelectFolder(fbdiagSelectOutputFolder, txtOutputFolderPath)
        GlobalVars.outputFolder = txtOutputFolderPath.Text
        debugMessages("Debug outputFolder: ", lblDebug_outputFolder, GlobalVars.outputFolder)

    End Sub
    Private Sub btnSelectPrepToolExe_Click(sender As Object, e As EventArgs) Handles btnSelectPrepToolExe.Click

        Dim ofd As OpenFileDialog = opnfilediagSelectPrepToolExe

        ofd.Title = "Select IntuneWinAppUtil.exe"
        ofd.InitialDirectory = GlobalVars.rootOfDrive
        ofd.ShowDialog()

    End Sub

#End Region

#Region " Open File Dialogs "

    Private Sub opnfilediagSelectInstaller_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opnfilediagSelectInstaller.FileOk

        SelectFile(opnfilediagSelectInstaller, txtPathOfInstaller)
        GlobalVars.installerPath = txtPathOfInstaller.Text
        debugMessages("Debug installerPath: ", lblDebug_installerPath, GlobalVars.installerPath)

    End Sub
    Private Sub opnfilediagSelectPrepToolExe_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opnfilediagSelectPrepToolExe.FileOk

        SelectFile(opnfilediagSelectPrepToolExe, txtPathOfPrepToolExe)
        GlobalVars.prepToolExe = txtPathOfPrepToolExe.Text
        debugMessages("Debug prepToolExe: ", lblDebug_prepToolExe, GlobalVars.prepToolExe)

    End Sub

#End Region


    Private Class GlobalVars

        Public Shared rootOfDrive As String = System.Environment.GetEnvironmentVariable("HOMEDRIVE")
        Public Shared installerPath As String = ""
        Public Shared sourceFolder As String = ""
        Public Shared outputFolder As String = ""
        Public Shared prepToolExe As String = ""

    End Class



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


    Sub debugMessages(debugMsg As String, debugLabel As Label, debugValue As String)
        debugLabel.Text = debugMsg + debugValue
    End Sub


End Class
