'
' Author: Connor Hudson
'
' Date: 15-Sept-2022
'

Imports System.IO

Public Class Form1

    Dim rootOfDrive As String = System.Environment.GetEnvironmentVariable("HOMEDRIVE")
    Dim installerPath As String = ""
    Dim sourceFolder As String = ""
    Dim outputFolder As String = ""
    Dim prepToolExe As String = ""


#Region " Buttons "

    Private Sub btnSelectInstaller_Click(sender As Object, e As EventArgs) Handles btnSelectInstaller.Click

        Dim ofd As OpenFileDialog = opnfilediagSelectInstaller

        ofd.Title = "Select Installer File (.exe or .msi)"
        ofd.InitialDirectory = rootOfDrive
        ofd.ShowDialog()

    End Sub
    Private Sub btnStartPackaging_Click(sender As Object, e As EventArgs) Handles btnStartPackaging.Click
        'Dim cmd
        'cmd = CreateObject("wscript.shell")
        'cmd.run("echo", "Hello world!")
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

        SelectFile(opnfilediagSelectInstaller, txtPathOfInstaller)
        installerPath = txtPathOfInstaller.Text
        debugMessages("Debug installerPath: ", lblDebug_installerPath, installerPath)

    End Sub
    Private Sub opnfilediagSelectPrepToolExe_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opnfilediagSelectPrepToolExe.FileOk

        SelectFile(opnfilediagSelectPrepToolExe, txtPathOfPrepToolExe)
        prepToolExe = txtPathOfPrepToolExe.Text
        debugMessages("Debug prepToolExe: ", lblDebug_prepToolExe, prepToolExe)

    End Sub

#End Region

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

    Private Function GetGroupBoxCheckedRadioButton(grp As GroupBox) As RadioButton
        For Each btn As RadioButton In grp.Controls
            If btn.Checked Then Return btn
        Next
    End Function

    Private Sub radNo_CheckedChanged(sender As Object, e As EventArgs) Handles radNo.CheckedChanged
        GetGroupBoxCheckedRadioButton(grpCatalogFolder)
    End Sub
End Class
