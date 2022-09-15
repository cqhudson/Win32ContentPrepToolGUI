'
' Author: Connor Hudson
'
' Date: 15-Sept-2022
'

Public Class Form1
    Private Sub btnSelectInstaller_Click(sender As Object, e As EventArgs) Handles btnSelectInstaller.Click

        ' When user presses this button, open dialog to select installer file

        opnfilediagSelectInstaller.Title = "Select Installer File (.exe or .msi)"
        opnfilediagSelectInstaller.InitialDirectory = GlobalVars.rootOfDrive
        opnfilediagSelectInstaller.ShowDialog()

    End Sub
    Private Sub opnfilediagSelectInstaller_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opnfilediagSelectInstaller.FileOk

        ' This code selects the Installer file and autofills the path into the textbox

        Dim stream As System.IO.Stream

        stream = opnfilediagSelectInstaller.OpenFile()
        txtPathOfInstaller.Text = opnfilediagSelectInstaller.FileName.ToString()

        GlobalVars.installerPath = txtPathOfInstaller.Text

    End Sub

    Private Sub btnSelectInstallerFolder_Click(sender As Object, e As EventArgs) Handles btnSelectInstallerFolder.Click

        ' When a user presses this button, open a dialog to select a source folder

        SelectFolder(fbdiagSelectSourceFolder, txtPathOfInstallerFolder)
        GlobalVars.sourceFolder = txtPathOfInstallerFolder.Text

    End Sub

    Private Sub PackageContentToIntunewin()

    End Sub

    Private Class GlobalVars
        Public Shared rootOfDrive As String = System.Environment.GetEnvironmentVariable("HOMEDRIVE")
        Public Shared installerPath As String = ""
        Public Shared sourceFolder As String = ""
        Public Shared outputFolder As String = ""
    End Class

    Private Sub btnSelectOutputFolder_Click(sender As Object, e As EventArgs) Handles btnSelectOutputFolder.Click

        ' When a user presses this button, open a dialog to select a source folder

        SelectFolder(fbdiagSelectOutputFolder, txtOutputFolderPath)
        GlobalVars.outputFolder = txtOutputFolderPath.Text

    End Sub

    Sub SelectFolder(fbdiag As FolderBrowserDialog, txtbox As TextBox)
        If (fbdiag.ShowDialog() = DialogResult.OK) Then
            txtbox.Text = fbdiag.SelectedPath()
        End If
    End Sub

End Class
