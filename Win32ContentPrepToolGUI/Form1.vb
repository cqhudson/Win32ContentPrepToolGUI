'
' Copyright 2022-2023 © CONNOR HUDSON
'
' AUTHOR: Connor Hudson ---> My site: https://hudson.tel
'
'
' DESCRIPTION: 
'   This application is supposed to make packaging applications into *.intunewin files easier. It's effectively a GUI wrapper for Microsoft's official Win32 Content Prep Tool.
'

Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.Win32

Public Class Form1

    Dim HomeDrive As String = Environment.GetEnvironmentVariable("HOMEDRIVE")

    Dim SetupFile As String
    Dim SetupFolder As String
    Dim OutputFolder As String
    Dim PrepToolExePath As String
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
            Dim Args As String

            Args = GenerateArguments()
            StartContentPrep(PowerShell, Args)

        End If

    End Sub

    Private Sub btnSelectInstallerFolder_Click(sender As Object, e As EventArgs) Handles btnSelectInstallerFolder.Click

        SelectFolder(fbdiagSelectSourceFolder, txtPathOfInstallerFolder)
        SetupFolder = WrapFilePathsInSingleQuotes(txtPathOfInstallerFolder.Text)

    End Sub
    Private Sub btnSelectOutputFolder_Click(sender As Object, e As EventArgs) Handles btnSelectOutputFolder.Click

        SelectFolder(fbdiagSelectOutputFolder, txtOutputFolderPath)
        OutputFolder = WrapFilePathsInSingleQuotes(txtOutputFolderPath.Text)

    End Sub
    Private Sub btnSelectPrepToolExe_Click(sender As Object, e As EventArgs) Handles btnSelectPrepToolExe.Click

        Dim ofd As OpenFileDialog = opnfilediagSelectPrepToolExe

        ofd.Title = "Select IntuneWinAppUtil.exe"
        ofd.InitialDirectory = HomeDrive
        ofd.ShowDialog()

    End Sub
    Private Sub btnSelectCatalogFolder_Click(sender As Object, e As EventArgs) Handles btnSelectCatalogFolder.Click

        SelectFolder(fbdiagSelectCatalogFolder, txtCatalogFolder)
        CatalogFolder = WrapFilePathsInSingleQuotes(txtCatalogFolder.Text)

    End Sub

#End Region

#Region " Open File Dialogs "

    Private Sub opnfilediagSelectInstaller_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opnfilediagSelectInstaller.FileOk

        SelectFile(opnfilediagSelectInstaller, txtPathOfInstaller)
        SetupFile = WrapFilePathsInSingleQuotes(txtPathOfInstaller.Text)

    End Sub
    Private Sub opnfilediagSelectPrepToolExe_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opnfilediagSelectPrepToolExe.FileOk

        SelectFile(opnfilediagSelectPrepToolExe, txtPathOfPrepToolExe)
        PrepToolExePath = WrapFilePathsInSingleQuotes(txtPathOfPrepToolExe.Text)

    End Sub

#End Region

#Region " Sub Procedures and Functions "

    Function GetCurrentDirectory() As String
        Return AppContext.BaseDirectory
    End Function

    ' This is to allow file paths containing spaces to be used with IntuneWinAppUtil.exe
    Function WrapFilePathsInSingleQuotes(Path As String) As String

        Dim folders As String() = Path.Split("\"c)
        Dim QuotedFolders As String() = folders.Select(Function(folder) If(folder = folders.First(), folder, $"'{folder}'")).ToArray()
        Dim QuotedPath As String = String.Join("\", QuotedFolders)
        QuotedPath = """" & QuotedPath & """"

        Return QuotedPath

    End Function

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

    Sub StartContentPrep(Executable As String, Args As String)

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

    Function GenerateArguments() As String

        Dim Args As String
        Dim ArgBuilder As New StringBuilder

        Dim Param_SetupFolder As String = "-c"
        Dim Param_SetupFile As String = "-s"
        Dim Param_OutputFolder As String = "-o"
        Dim Param_CatalogFolder As String = "-a"
        Dim Param_QuietMode As String = "-q"
        Dim Space As String = " "

        If chkCatalogFolder.Checked Then ' If true, then generate args including a catalog folder

            ArgBuilder.Append(PrepToolExePath).Append(Space)
            ArgBuilder.Append(Param_SetupFolder).Append(Space).Append(SetupFolder)
            ArgBuilder.Append(Space).Append(Param_SetupFile).Append(Space).Append(SetupFile)
            ArgBuilder.Append(Space).Append(Param_OutputFolder).Append(Space).Append(OutputFolder)
            ArgBuilder.Append(Space).Append(Param_CatalogFolder).Append(Space).Append(CatalogFolder)

            ' Enable quiet mode if true
            If chkQuietMode.Checked Then
                ArgBuilder.Append(Space).Append(Param_QuietMode).ToString()
            End If

        Else

            ArgBuilder.Append(PrepToolExePath).Append(Space)
            ArgBuilder.Append(Param_SetupFolder).Append(Space).Append(SetupFolder)
            ArgBuilder.Append(Space).Append(Param_SetupFile).Append(Space).Append(SetupFile)
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

        If PrepToolExePath = "" Then
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        '
        ' Super ugly way of checking if a regkey exists to autofill the location for IntuneWinAppUtil.exe
        '
        ' The key "HKEY_CURRENT_USER\WIN32_CONTENT_PREP_TOOL_GUI_CONFIG" has a value called "IntuneWinAppUtil_Location"
        ' Change the value to whatever filepath your IntuneWinAppUtil.exe is located at. 
        '
        ' When testing, I used the filepath "C:\Users\Connor\Desktop\Microsoft-Win32 Content-Prep-Tool-1.8.4\IntuneWinAppUtil.exe" as the value for "IntuneWinAppUtil_Location"
        ' This seems to work perfectly.
        '

        Dim defaultPathToAppUtil As String = HomeDrive & "\IWAU\IntuneWinAppUtil.exe"
        Dim RegKey As String = "WIN32_CONTENT_PREP_TOOL_GUI_CONFIG"

        If My.Computer.Registry.CurrentUser.OpenSubKey(RegKey) Is Nothing Then
            My.Computer.Registry.CurrentUser.CreateSubKey(RegKey)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\" & RegKey, "IntuneWinAppUtil_Location", defaultPathToAppUtil)
        End If


        Dim keyName As String = "HKEY_CURRENT_USER\WIN32_CONTENT_PREP_TOOL_GUI_CONFIG"
        Dim valueName As String = "IntuneWinAppUtil_Location"
        Dim filePath As String = Registry.GetValue(keyName, valueName, Nothing)

        If filePath IsNot Nothing Then
            If File.Exists(filePath) Then
                ' If the file specified at the regkey exists, autofill
                txtPathOfPrepToolExe.Text = filePath
                PrepToolExePath = WrapFilePathsInSingleQuotes(filePath)
            End If
        End If


    End Sub
End Class
