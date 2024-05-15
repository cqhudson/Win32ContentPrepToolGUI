<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtPathOfInstaller = New TextBox()
        btnSelectInstaller = New Button()
        opnfilediagSelectInstaller = New OpenFileDialog()
        lblPromptSelectInstaller = New Label()
        lblPromptSelectInstallerFolder = New Label()
        txtPathOfInstallerFolder = New TextBox()
        btnSelectInstallerFolder = New Button()
        fbdiagSelectSourceFolder = New FolderBrowserDialog()
        btnSelectOutputFolder = New Button()
        txtOutputFolderPath = New TextBox()
        lblPromptOutput = New Label()
        fbdiagSelectOutputFolder = New FolderBrowserDialog()
        Label1 = New Label()
        btnSelectPrepToolExe = New Button()
        txtPathOfPrepToolExe = New TextBox()
        opnfilediagSelectPrepToolExe = New OpenFileDialog()
        btnStartPackaging = New Button()
        btnSelectCatalogFolder = New Button()
        txtCatalogFolder = New TextBox()
        lblPromptCatalogFolder = New Label()
        fbdiagSelectCatalogFolder = New FolderBrowserDialog()
        lblCopyrightNotice = New Label()
        chkCatalogFolder = New CheckBox()
        chkQuietMode = New CheckBox()
        Label2 = New Label()
        btnInfo = New Button()
        SuspendLayout()
        ' 
        ' txtPathOfInstaller
        ' 
        txtPathOfInstaller.Location = New Point(13, 138)
        txtPathOfInstaller.Name = "txtPathOfInstaller"
        txtPathOfInstaller.PlaceholderText = "Path of installer"
        txtPathOfInstaller.ReadOnly = True
        txtPathOfInstaller.Size = New Size(515, 31)
        txtPathOfInstaller.TabIndex = 3
        ' 
        ' btnSelectInstaller
        ' 
        btnSelectInstaller.Location = New Point(534, 137)
        btnSelectInstaller.Name = "btnSelectInstaller"
        btnSelectInstaller.Size = New Size(151, 40)
        btnSelectInstaller.TabIndex = 2
        btnSelectInstaller.Text = "Select File"
        btnSelectInstaller.UseVisualStyleBackColor = True
        ' 
        ' opnfilediagSelectInstaller
        ' 
        ' 
        ' lblPromptSelectInstaller
        ' 
        lblPromptSelectInstaller.AutoSize = True
        lblPromptSelectInstaller.Location = New Point(13, 112)
        lblPromptSelectInstaller.Name = "lblPromptSelectInstaller"
        lblPromptSelectInstaller.Size = New Size(360, 25)
        lblPromptSelectInstaller.TabIndex = 2
        lblPromptSelectInstaller.Text = "Select setup file (e.g. setup.exe or setup.msi)"
        ' 
        ' lblPromptSelectInstallerFolder
        ' 
        lblPromptSelectInstallerFolder.AutoSize = True
        lblPromptSelectInstallerFolder.Location = New Point(13, 202)
        lblPromptSelectInstallerFolder.Name = "lblPromptSelectInstallerFolder"
        lblPromptSelectInstallerFolder.Size = New Size(674, 25)
        lblPromptSelectInstallerFolder.TabIndex = 3
        lblPromptSelectInstallerFolder.Text = "Select the setup folder (All files in this folder will be compressed into .intunewin file.)"
        ' 
        ' txtPathOfInstallerFolder
        ' 
        txtPathOfInstallerFolder.Location = New Point(13, 228)
        txtPathOfInstallerFolder.Name = "txtPathOfInstallerFolder"
        txtPathOfInstallerFolder.PlaceholderText = "Path of the folder that the installer is located in"
        txtPathOfInstallerFolder.ReadOnly = True
        txtPathOfInstallerFolder.Size = New Size(515, 31)
        txtPathOfInstallerFolder.TabIndex = 5
        ' 
        ' btnSelectInstallerFolder
        ' 
        btnSelectInstallerFolder.Location = New Point(534, 228)
        btnSelectInstallerFolder.Name = "btnSelectInstallerFolder"
        btnSelectInstallerFolder.Size = New Size(151, 38)
        btnSelectInstallerFolder.TabIndex = 4
        btnSelectInstallerFolder.Text = "Select Folder"
        btnSelectInstallerFolder.UseVisualStyleBackColor = True
        ' 
        ' btnSelectOutputFolder
        ' 
        btnSelectOutputFolder.Location = New Point(534, 315)
        btnSelectOutputFolder.Name = "btnSelectOutputFolder"
        btnSelectOutputFolder.Size = New Size(151, 38)
        btnSelectOutputFolder.TabIndex = 6
        btnSelectOutputFolder.Text = "Select Folder"
        btnSelectOutputFolder.UseVisualStyleBackColor = True
        ' 
        ' txtOutputFolderPath
        ' 
        txtOutputFolderPath.Location = New Point(13, 315)
        txtOutputFolderPath.Name = "txtOutputFolderPath"
        txtOutputFolderPath.PlaceholderText = "Path of the folder that *.intunewin will be saved in"
        txtOutputFolderPath.ReadOnly = True
        txtOutputFolderPath.Size = New Size(515, 31)
        txtOutputFolderPath.TabIndex = 7
        ' 
        ' lblPromptOutput
        ' 
        lblPromptOutput.AutoSize = True
        lblPromptOutput.Location = New Point(13, 287)
        lblPromptOutput.Name = "lblPromptOutput"
        lblPromptOutput.Size = New Size(571, 25)
        lblPromptOutput.TabIndex = 6
        lblPromptOutput.Text = "Select the output folder (Where the generated .intunewin will be saved)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(350, 25)
        Label1.TabIndex = 0
        Label1.Text = "Select the Microsoft Content Prep Tool EXE"
        ' 
        ' btnSelectPrepToolExe
        ' 
        btnSelectPrepToolExe.Location = New Point(534, 52)
        btnSelectPrepToolExe.Name = "btnSelectPrepToolExe"
        btnSelectPrepToolExe.Size = New Size(151, 40)
        btnSelectPrepToolExe.TabIndex = 0
        btnSelectPrepToolExe.Text = "Select File"
        btnSelectPrepToolExe.UseVisualStyleBackColor = True
        ' 
        ' txtPathOfPrepToolExe
        ' 
        txtPathOfPrepToolExe.Location = New Point(13, 53)
        txtPathOfPrepToolExe.Name = "txtPathOfPrepToolExe"
        txtPathOfPrepToolExe.PlaceholderText = "Path of prep tool executable"
        txtPathOfPrepToolExe.ReadOnly = True
        txtPathOfPrepToolExe.Size = New Size(515, 31)
        txtPathOfPrepToolExe.TabIndex = 1
        ' 
        ' opnfilediagSelectPrepToolExe
        ' 
        ' 
        ' btnStartPackaging
        ' 
        btnStartPackaging.Location = New Point(534, 475)
        btnStartPackaging.Name = "btnStartPackaging"
        btnStartPackaging.Size = New Size(151, 58)
        btnStartPackaging.TabIndex = 12
        btnStartPackaging.Text = "Generate .intunewin"
        btnStartPackaging.UseVisualStyleBackColor = True
        ' 
        ' btnSelectCatalogFolder
        ' 
        btnSelectCatalogFolder.Enabled = False
        btnSelectCatalogFolder.Location = New Point(534, 398)
        btnSelectCatalogFolder.Name = "btnSelectCatalogFolder"
        btnSelectCatalogFolder.Size = New Size(151, 38)
        btnSelectCatalogFolder.TabIndex = 8
        btnSelectCatalogFolder.Text = "Select Folder"
        btnSelectCatalogFolder.UseVisualStyleBackColor = True
        ' 
        ' txtCatalogFolder
        ' 
        txtCatalogFolder.Enabled = False
        txtCatalogFolder.Location = New Point(13, 398)
        txtCatalogFolder.Name = "txtCatalogFolder"
        txtCatalogFolder.PlaceholderText = "Path of catalog folder"
        txtCatalogFolder.ReadOnly = True
        txtCatalogFolder.Size = New Size(515, 31)
        txtCatalogFolder.TabIndex = 9
        ' 
        ' lblPromptCatalogFolder
        ' 
        lblPromptCatalogFolder.AutoSize = True
        lblPromptCatalogFolder.Location = New Point(13, 372)
        lblPromptCatalogFolder.Name = "lblPromptCatalogFolder"
        lblPromptCatalogFolder.Size = New Size(173, 25)
        lblPromptCatalogFolder.TabIndex = 22
        lblPromptCatalogFolder.Text = "Select catalog folder"
        ' 
        ' lblCopyrightNotice
        ' 
        lblCopyrightNotice.AutoSize = True
        lblCopyrightNotice.Location = New Point(6, 475)
        lblCopyrightNotice.Name = "lblCopyrightNotice"
        lblCopyrightNotice.Size = New Size(0, 25)
        lblCopyrightNotice.TabIndex = 25
        ' 
        ' chkCatalogFolder
        ' 
        chkCatalogFolder.AutoSize = True
        chkCatalogFolder.Location = New Point(11, 457)
        chkCatalogFolder.Name = "chkCatalogFolder"
        chkCatalogFolder.Size = New Size(185, 29)
        chkCatalogFolder.TabIndex = 10
        chkCatalogFolder.Text = "(-a) Catalog Folder"
        chkCatalogFolder.UseVisualStyleBackColor = True
        ' 
        ' chkQuietMode
        ' 
        chkQuietMode.AutoSize = True
        chkQuietMode.Location = New Point(11, 492)
        chkQuietMode.Name = "chkQuietMode"
        chkQuietMode.Size = New Size(166, 29)
        chkQuietMode.TabIndex = 11
        chkQuietMode.Text = "(-q) Quiet Mode"
        chkQuietMode.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 587)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(558, 25)
        Label2.TabIndex = 27
        Label2.Text = "Copyright 2022-2024 © CONNOR HUDSON   ---   https://hudson.tel"
        ' 
        ' btnInfo
        ' 
        btnInfo.Location = New Point(617, 573)
        btnInfo.Margin = New Padding(4, 5, 4, 5)
        btnInfo.Name = "btnInfo"
        btnInfo.Size = New Size(69, 38)
        btnInfo.TabIndex = 28
        btnInfo.Text = "INFO"
        btnInfo.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(699, 627)
        Controls.Add(btnInfo)
        Controls.Add(Label2)
        Controls.Add(chkQuietMode)
        Controls.Add(chkCatalogFolder)
        Controls.Add(lblCopyrightNotice)
        Controls.Add(btnSelectCatalogFolder)
        Controls.Add(txtCatalogFolder)
        Controls.Add(lblPromptCatalogFolder)
        Controls.Add(btnStartPackaging)
        Controls.Add(Label1)
        Controls.Add(btnSelectPrepToolExe)
        Controls.Add(txtPathOfPrepToolExe)
        Controls.Add(btnSelectOutputFolder)
        Controls.Add(txtOutputFolderPath)
        Controls.Add(lblPromptOutput)
        Controls.Add(btnSelectInstallerFolder)
        Controls.Add(txtPathOfInstallerFolder)
        Controls.Add(lblPromptSelectInstallerFolder)
        Controls.Add(lblPromptSelectInstaller)
        Controls.Add(btnSelectInstaller)
        Controls.Add(txtPathOfInstaller)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        Name = "Form1"
        ShowIcon = False
        Text = "Win32 Content Prep Tool GUI"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPathOfInstaller As TextBox
    Friend WithEvents btnSelectInstaller As Button
    Friend WithEvents opnfilediagSelectInstaller As OpenFileDialog
    Friend WithEvents lblPromptSelectInstaller As Label
    Friend WithEvents lblPromptSelectInstallerFolder As Label
    Friend WithEvents txtPathOfInstallerFolder As TextBox
    Friend WithEvents btnSelectInstallerFolder As Button
    Friend WithEvents fbdiagSelectSourceFolder As FolderBrowserDialog
    Friend WithEvents btnSelectOutputFolder As Button
    Friend WithEvents txtOutputFolderPath As TextBox
    Friend WithEvents lblPromptOutput As Label
    Friend WithEvents fbdiagSelectOutputFolder As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSelectPrepToolExe As Button
    Friend WithEvents txtPathOfPrepToolExe As TextBox
    Friend WithEvents opnfilediagSelectPrepToolExe As OpenFileDialog
    Friend WithEvents btnStartPackaging As Button
    Friend WithEvents btnSelectCatalogFolder As Button
    Friend WithEvents txtCatalogFolder As TextBox
    Friend WithEvents lblPromptCatalogFolder As Label
    Friend WithEvents fbdiagSelectCatalogFolder As FolderBrowserDialog
    Friend WithEvents lblCopyrightNotice As Label
    Friend WithEvents chkCatalogFolder As CheckBox
    Friend WithEvents chkQuietMode As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInfo As Button
End Class
