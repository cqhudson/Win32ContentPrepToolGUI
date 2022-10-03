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
        Me.txtPathOfInstaller = New System.Windows.Forms.TextBox()
        Me.btnSelectInstaller = New System.Windows.Forms.Button()
        Me.opnfilediagSelectInstaller = New System.Windows.Forms.OpenFileDialog()
        Me.lblPromptSelectInstaller = New System.Windows.Forms.Label()
        Me.lblPromptSelectInstallerFolder = New System.Windows.Forms.Label()
        Me.txtPathOfInstallerFolder = New System.Windows.Forms.TextBox()
        Me.btnSelectInstallerFolder = New System.Windows.Forms.Button()
        Me.fbdiagSelectSourceFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSelectOutputFolder = New System.Windows.Forms.Button()
        Me.txtOutputFolderPath = New System.Windows.Forms.TextBox()
        Me.lblPromptOutput = New System.Windows.Forms.Label()
        Me.fbdiagSelectOutputFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelectPrepToolExe = New System.Windows.Forms.Button()
        Me.txtPathOfPrepToolExe = New System.Windows.Forms.TextBox()
        Me.opnfilediagSelectPrepToolExe = New System.Windows.Forms.OpenFileDialog()
        Me.btnStartPackaging = New System.Windows.Forms.Button()
        Me.btnSelectCatalogFolder = New System.Windows.Forms.Button()
        Me.txtCatalogFolder = New System.Windows.Forms.TextBox()
        Me.lblPromptCatalogFolder = New System.Windows.Forms.Label()
        Me.fbdiagSelectCatalogFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblCopyrightNotice = New System.Windows.Forms.Label()
        Me.chkCatalogFolder = New System.Windows.Forms.CheckBox()
        Me.chkQuietMode = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtPathOfInstaller
        '
        Me.txtPathOfInstaller.Location = New System.Drawing.Point(13, 139)
        Me.txtPathOfInstaller.Name = "txtPathOfInstaller"
        Me.txtPathOfInstaller.PlaceholderText = "Path of installer"
        Me.txtPathOfInstaller.ReadOnly = True
        Me.txtPathOfInstaller.Size = New System.Drawing.Size(516, 31)
        Me.txtPathOfInstaller.TabIndex = 3
        '
        'btnSelectInstaller
        '
        Me.btnSelectInstaller.Location = New System.Drawing.Point(535, 137)
        Me.btnSelectInstaller.Name = "btnSelectInstaller"
        Me.btnSelectInstaller.Size = New System.Drawing.Size(152, 34)
        Me.btnSelectInstaller.TabIndex = 2
        Me.btnSelectInstaller.Text = "Select File"
        Me.btnSelectInstaller.UseVisualStyleBackColor = True
        '
        'opnfilediagSelectInstaller
        '
        '
        'lblPromptSelectInstaller
        '
        Me.lblPromptSelectInstaller.AutoSize = True
        Me.lblPromptSelectInstaller.Location = New System.Drawing.Point(13, 111)
        Me.lblPromptSelectInstaller.Name = "lblPromptSelectInstaller"
        Me.lblPromptSelectInstaller.Size = New System.Drawing.Size(360, 25)
        Me.lblPromptSelectInstaller.TabIndex = 2
        Me.lblPromptSelectInstaller.Text = "Select setup file (e.g. setup.exe or setup.msi)"
        '
        'lblPromptSelectInstallerFolder
        '
        Me.lblPromptSelectInstallerFolder.AutoSize = True
        Me.lblPromptSelectInstallerFolder.Location = New System.Drawing.Point(13, 201)
        Me.lblPromptSelectInstallerFolder.Name = "lblPromptSelectInstallerFolder"
        Me.lblPromptSelectInstallerFolder.Size = New System.Drawing.Size(674, 25)
        Me.lblPromptSelectInstallerFolder.TabIndex = 3
        Me.lblPromptSelectInstallerFolder.Text = "Select the setup folder (All files in this folder will be compressed into .intune" &
    "win file.)"
        '
        'txtPathOfInstallerFolder
        '
        Me.txtPathOfInstallerFolder.Location = New System.Drawing.Point(13, 229)
        Me.txtPathOfInstallerFolder.Name = "txtPathOfInstallerFolder"
        Me.txtPathOfInstallerFolder.PlaceholderText = "Path of the folder that the installer is located in"
        Me.txtPathOfInstallerFolder.ReadOnly = True
        Me.txtPathOfInstallerFolder.Size = New System.Drawing.Size(516, 31)
        Me.txtPathOfInstallerFolder.TabIndex = 5
        '
        'btnSelectInstallerFolder
        '
        Me.btnSelectInstallerFolder.Location = New System.Drawing.Point(535, 229)
        Me.btnSelectInstallerFolder.Name = "btnSelectInstallerFolder"
        Me.btnSelectInstallerFolder.Size = New System.Drawing.Size(152, 33)
        Me.btnSelectInstallerFolder.TabIndex = 4
        Me.btnSelectInstallerFolder.Text = "Select Folder"
        Me.btnSelectInstallerFolder.UseVisualStyleBackColor = True
        '
        'btnSelectOutputFolder
        '
        Me.btnSelectOutputFolder.Location = New System.Drawing.Point(535, 315)
        Me.btnSelectOutputFolder.Name = "btnSelectOutputFolder"
        Me.btnSelectOutputFolder.Size = New System.Drawing.Size(152, 33)
        Me.btnSelectOutputFolder.TabIndex = 6
        Me.btnSelectOutputFolder.Text = "Select Folder"
        Me.btnSelectOutputFolder.UseVisualStyleBackColor = True
        '
        'txtOutputFolderPath
        '
        Me.txtOutputFolderPath.Location = New System.Drawing.Point(13, 315)
        Me.txtOutputFolderPath.Name = "txtOutputFolderPath"
        Me.txtOutputFolderPath.PlaceholderText = "Path of the folder that *.intunewin will be saved in"
        Me.txtOutputFolderPath.ReadOnly = True
        Me.txtOutputFolderPath.Size = New System.Drawing.Size(516, 31)
        Me.txtOutputFolderPath.TabIndex = 7
        '
        'lblPromptOutput
        '
        Me.lblPromptOutput.AutoSize = True
        Me.lblPromptOutput.Location = New System.Drawing.Point(13, 287)
        Me.lblPromptOutput.Name = "lblPromptOutput"
        Me.lblPromptOutput.Size = New System.Drawing.Size(571, 25)
        Me.lblPromptOutput.TabIndex = 6
        Me.lblPromptOutput.Text = "Select the output folder (Where the generated .intunewin will be saved)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the Microsoft Content Prep Tool EXE"
        '
        'btnSelectPrepToolExe
        '
        Me.btnSelectPrepToolExe.Location = New System.Drawing.Point(535, 51)
        Me.btnSelectPrepToolExe.Name = "btnSelectPrepToolExe"
        Me.btnSelectPrepToolExe.Size = New System.Drawing.Size(152, 34)
        Me.btnSelectPrepToolExe.TabIndex = 0
        Me.btnSelectPrepToolExe.Text = "Select File"
        Me.btnSelectPrepToolExe.UseVisualStyleBackColor = True
        '
        'txtPathOfPrepToolExe
        '
        Me.txtPathOfPrepToolExe.Location = New System.Drawing.Point(13, 53)
        Me.txtPathOfPrepToolExe.Name = "txtPathOfPrepToolExe"
        Me.txtPathOfPrepToolExe.PlaceholderText = "Path of prep tool executable"
        Me.txtPathOfPrepToolExe.ReadOnly = True
        Me.txtPathOfPrepToolExe.Size = New System.Drawing.Size(516, 31)
        Me.txtPathOfPrepToolExe.TabIndex = 1
        '
        'opnfilediagSelectPrepToolExe
        '
        '
        'btnStartPackaging
        '
        Me.btnStartPackaging.Location = New System.Drawing.Point(535, 475)
        Me.btnStartPackaging.Name = "btnStartPackaging"
        Me.btnStartPackaging.Size = New System.Drawing.Size(152, 58)
        Me.btnStartPackaging.TabIndex = 12
        Me.btnStartPackaging.Text = "Generate .intunewin"
        Me.btnStartPackaging.UseVisualStyleBackColor = True
        '
        'btnSelectCatalogFolder
        '
        Me.btnSelectCatalogFolder.Enabled = False
        Me.btnSelectCatalogFolder.Location = New System.Drawing.Point(535, 399)
        Me.btnSelectCatalogFolder.Name = "btnSelectCatalogFolder"
        Me.btnSelectCatalogFolder.Size = New System.Drawing.Size(152, 33)
        Me.btnSelectCatalogFolder.TabIndex = 8
        Me.btnSelectCatalogFolder.Text = "Select Folder"
        Me.btnSelectCatalogFolder.UseVisualStyleBackColor = True
        '
        'txtCatalogFolder
        '
        Me.txtCatalogFolder.Enabled = False
        Me.txtCatalogFolder.Location = New System.Drawing.Point(13, 399)
        Me.txtCatalogFolder.Name = "txtCatalogFolder"
        Me.txtCatalogFolder.PlaceholderText = "Path of catalog folder"
        Me.txtCatalogFolder.ReadOnly = True
        Me.txtCatalogFolder.Size = New System.Drawing.Size(516, 31)
        Me.txtCatalogFolder.TabIndex = 9
        '
        'lblPromptCatalogFolder
        '
        Me.lblPromptCatalogFolder.AutoSize = True
        Me.lblPromptCatalogFolder.Location = New System.Drawing.Point(13, 371)
        Me.lblPromptCatalogFolder.Name = "lblPromptCatalogFolder"
        Me.lblPromptCatalogFolder.Size = New System.Drawing.Size(173, 25)
        Me.lblPromptCatalogFolder.TabIndex = 22
        Me.lblPromptCatalogFolder.Text = "Select catalog folder"
        '
        'lblCopyrightNotice
        '
        Me.lblCopyrightNotice.AutoSize = True
        Me.lblCopyrightNotice.Location = New System.Drawing.Point(6, 475)
        Me.lblCopyrightNotice.Name = "lblCopyrightNotice"
        Me.lblCopyrightNotice.Size = New System.Drawing.Size(0, 25)
        Me.lblCopyrightNotice.TabIndex = 25
        '
        'chkCatalogFolder
        '
        Me.chkCatalogFolder.AutoSize = True
        Me.chkCatalogFolder.Location = New System.Drawing.Point(12, 456)
        Me.chkCatalogFolder.Name = "chkCatalogFolder"
        Me.chkCatalogFolder.Size = New System.Drawing.Size(185, 29)
        Me.chkCatalogFolder.TabIndex = 10
        Me.chkCatalogFolder.Text = "(-a) Catalog Folder"
        Me.chkCatalogFolder.UseVisualStyleBackColor = True
        '
        'chkQuietMode
        '
        Me.chkQuietMode.AutoSize = True
        Me.chkQuietMode.Location = New System.Drawing.Point(12, 491)
        Me.chkQuietMode.Name = "chkQuietMode"
        Me.chkQuietMode.Size = New System.Drawing.Size(166, 29)
        Me.chkQuietMode.TabIndex = 11
        Me.chkQuietMode.Text = "(-q) Quiet Mode"
        Me.chkQuietMode.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 546)
        Me.Controls.Add(Me.chkQuietMode)
        Me.Controls.Add(Me.chkCatalogFolder)
        Me.Controls.Add(Me.lblCopyrightNotice)
        Me.Controls.Add(Me.btnSelectCatalogFolder)
        Me.Controls.Add(Me.txtCatalogFolder)
        Me.Controls.Add(Me.lblPromptCatalogFolder)
        Me.Controls.Add(Me.btnStartPackaging)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelectPrepToolExe)
        Me.Controls.Add(Me.txtPathOfPrepToolExe)
        Me.Controls.Add(Me.btnSelectOutputFolder)
        Me.Controls.Add(Me.txtOutputFolderPath)
        Me.Controls.Add(Me.lblPromptOutput)
        Me.Controls.Add(Me.btnSelectInstallerFolder)
        Me.Controls.Add(Me.txtPathOfInstallerFolder)
        Me.Controls.Add(Me.lblPromptSelectInstallerFolder)
        Me.Controls.Add(Me.lblPromptSelectInstaller)
        Me.Controls.Add(Me.btnSelectInstaller)
        Me.Controls.Add(Me.txtPathOfInstaller)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Win32 Content Prep Tool GUI   |   © 2022 - Connor Hudson"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
