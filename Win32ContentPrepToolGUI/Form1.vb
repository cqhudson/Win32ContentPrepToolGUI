'
' Copyright 2022-2023 © CONNOR HUDSON
'
' AUTHOR: Connor Hudson ---> My sites: https://hudson.tel
'                                      https://connorhudson.com 
'
'
' DESCRIPTION: 
'   This application is supposed to make packaging applications into *.intunewin files easier. It's effectively a GUI wrapper for Microsoft's official Win32 Content Prep Tool.
'

Imports System.IO
Imports System.Text
Imports Microsoft.Win32

Public Class Form1

    Dim HomeDrive As String = Environment.GetEnvironmentVariable("HOMEDRIVE")
    Dim RegKey As String = "HKEY_CURRENT_USER\SOFTWARE\WIN32_CONTENT_PREP_TOOL_GUI_CONFIG"
    Dim RegKeyWithoutHive As String = "SOFTWARE\WIN32_CONTENT_PREP_TOOL_GUI_CONFIG"
    Dim RegKeyValueName As String = "IntuneWinAppUtil_Location"
    Dim IWAU As String = "IntuneWinAppUtil.exe"
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

    Function WrapFilePathsInSingleQuotes(Path As String) As String

        ' Create array of substrings (each folder) using the backslash char as a delimiter
        Dim folders As String() = Path.Split("\"c)

        ' This creates a new array of strings by looping through the 'folders' array.
        ' If its the first 'folder' ( "C:" ), then we do nothing, no need to wrap the C: folder.
        ' Every other 'folder' in the 'folders' array is wrapped in single quotes.
        Dim QuotedFolders As String() = folders.Select(Function(folder) If(folder = folders.First(), folder, $"'{folder}'")).ToArray()

        ' Create the newly wrapped path by joining each substring together with a backslash.
        Dim QuotedPath As String = String.Join("\", QuotedFolders)

        ' Wrap the entire quoted path in double quote chars before returning
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

    Function GenerateArguments() As String

        Dim args As String
        Dim argBuilder As New StringBuilder

        Dim paramSetupFolder As String = "-c"
        Dim paramSetupFile As String = "-s"
        Dim paramOutputFolder As String = "-o"
        Dim paramCatalogFolder As String = "-a"
        Dim paramQuietMode As String = "-q"
        Dim space As String = " "

        If chkCatalogFolder.Checked Then ' If true, then generate args including a catalog folder

            argBuilder.Append(PrepToolExePath).Append(space)
            argBuilder.Append(paramSetupFolder).Append(space).Append(SetupFolder)
            argBuilder.Append(space).Append(paramSetupFile).Append(space).Append(SetupFile)
            argBuilder.Append(space).Append(paramOutputFolder).Append(space).Append(OutputFolder)
            argBuilder.Append(space).Append(paramCatalogFolder).Append(space).Append(CatalogFolder)

            ' Enable quiet mode if true
            If chkQuietMode.Checked Then
                argBuilder.Append(space).Append(paramQuietMode).ToString()
            End If

        Else

            argBuilder.Append(PrepToolExePath).Append(space)
            argBuilder.Append(paramSetupFolder).Append(space).Append(SetupFolder)
            argBuilder.Append(space).Append(paramSetupFile).Append(space).Append(SetupFile)
            argBuilder.Append(space).Append(paramOutputFolder).Append(space).Append(OutputFolder)

            ' Enable quiet mode if true
            If chkQuietMode.Checked Then
                argBuilder.Append(space).Append(paramQuietMode).ToString()
            End If

        End If

        args = argBuilder.ToString()

        Return args

    End Function

    Function CheckToEnablePackaging() As Boolean

        Const MsgTitle As String = "Please fill in all values."
        Const MsgError As String = "One or more arguments was not specified, please make sure you fill in all values!"

        ' Check if any paths are populated
        Dim prepToolPathIsPopulated As Boolean = (PrepToolExePath <> "")
        Dim setupFileIsPopulated As Boolean = (SetupFile <> "")
        Dim setupFolderIsPopulated As Boolean = (SetupFolder <> "")
        Dim outputFolderIsPopulated As Boolean = (OutputFolder <> "")

        ' Separate path check if using a catalog folder
        If chkCatalogFolder.Checked Then
            Dim catalogFolderIsPopulated As Boolean = (CatalogFolder <> "")

            If prepToolPathIsPopulated And setupFileIsPopulated And setupFolderIsPopulated And outputFolderIsPopulated And catalogFolderIsPopulated Then
                Return True
            End If

            MessageBox.Show(MsgError, MsgTitle)
            Return False
        End If

        ' If not using catalog folder, then only check the first 4 options
        If prepToolPathIsPopulated And setupFileIsPopulated And setupFolderIsPopulated And outputFolderIsPopulated Then
            Return True
        End If

        MessageBox.Show(MsgError, MsgTitle)
        Return False


    End Function

#End Region

    Private Sub chkCatalogFolder_CheckedChanged(sender As Object, e As EventArgs) Handles chkCatalogFolder.CheckedChanged

        ' If checked, enable the catalog folder options
        btnSelectCatalogFolder.Enabled = chkCatalogFolder.Checked
        txtCatalogFolder.Enabled = chkCatalogFolder.Checked

        ' If not checked, grey out and clear the catalog folder options
        If Not chkCatalogFolder.Checked Then
            CatalogFolder = ""
            txtCatalogFolder.Text = ""
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '
        ' Super ugly way of checking if a regkey exists to autofill the location for IntuneWinAppUtil.exe
        '
        ' When testing, I used the filepath "C:\Users\Connor\Desktop\Microsoft-Win32 Content-Prep-Tool-1.8.4\IntuneWinAppUtil.exe" as the value for "IntuneWinAppUtil_Location"
        ' This seems to work perfectly.
        '
        Dim iwauPath As String = GetCurrentDirectory() & IWAU
        Dim defaultPathToAppUtil As String = HomeDrive & "\IWAU\" & IWAU

        If File.Exists(iwauPath) Then
            txtPathOfPrepToolExe.Text = GetCurrentDirectory() & IWAU
            PrepToolExePath = WrapFilePathsInSingleQuotes(txtPathOfPrepToolExe.Text)


        Else

            ' If IWAU is not in the current working directory, then fallback to registry key location

            If Registry.CurrentUser.OpenSubKey(RegKeyWithoutHive) Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RegKeyWithoutHive)
                Registry.SetValue(RegKey, RegKeyValueName, defaultPathToAppUtil)
            End If

            Dim filePath As String = Registry.GetValue(RegKey, RegKeyValueName, Nothing)

            If filePath IsNot Nothing Then

                ' If IWAU is not at the specified location in the registry, then nothing will happen,
                ' you will have to fallback to manually choosing IWAU through diags

                If File.Exists(filePath) Then
                    ' If the file specified at the regkey exists, autofill
                    txtPathOfPrepToolExe.Text = filePath
                    PrepToolExePath = WrapFilePathsInSingleQuotes(filePath)
                End If
            End If


        End If

        ' If IWAU is found in the current working directory, then just make sure the regkey is created for later.
        If Registry.CurrentUser.OpenSubKey(RegKeyWithoutHive) Is Nothing Then
            Registry.CurrentUser.CreateSubKey(RegKeyWithoutHive)
            Registry.SetValue(RegKey, RegKeyValueName, defaultPathToAppUtil)
        End If


    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Dim regKeyValue As String = Registry.GetValue(RegKey, RegKeyValueName, Nothing)
        Dim defaultIntuneAppUtilPath As String = "Your current default path to " & IWAU & " is: " & vbCrLf & """" & regKeyValue & """" & vbCrLf & vbCrLf
        Dim regKeyPath As String = "According to the registry key: " & vbCrLf & """" & RegKey & """" & vbCrLf & vbCrLf
        Dim information As String = "You can change this value at any time by using the Registry Editor (regedit.exe) and navigating to the registry key above. Change the value stored in " & """" & RegKeyValueName & """" & " to the path you stored your " & IWAU & " file. You can also store the " & IWAU & " file in the same directory as this application."

        MessageBox.Show(regKeyPath & defaultIntuneAppUtilPath & information, "Config Info")
    End Sub
End Class
