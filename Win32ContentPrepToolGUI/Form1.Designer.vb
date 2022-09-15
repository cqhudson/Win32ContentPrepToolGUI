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
        Me.lblDebug = New System.Windows.Forms.Label()
        Me.grpCatalogFolder = New System.Windows.Forms.GroupBox()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.grpCatalogFolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPathOfInstaller
        '
        Me.txtPathOfInstaller.Location = New System.Drawing.Point(106, 61)
        Me.txtPathOfInstaller.Name = "txtPathOfInstaller"
        Me.txtPathOfInstaller.PlaceholderText = "Path of installer"
        Me.txtPathOfInstaller.ReadOnly = True
        Me.txtPathOfInstaller.Size = New System.Drawing.Size(434, 31)
        Me.txtPathOfInstaller.TabIndex = 0
        '
        'btnSelectInstaller
        '
        Me.btnSelectInstaller.Location = New System.Drawing.Point(546, 59)
        Me.btnSelectInstaller.Name = "btnSelectInstaller"
        Me.btnSelectInstaller.Size = New System.Drawing.Size(152, 34)
        Me.btnSelectInstaller.TabIndex = 1
        Me.btnSelectInstaller.Text = "Select File"
        Me.btnSelectInstaller.UseVisualStyleBackColor = True
        '
        'opnfilediagSelectInstaller
        '
        '
        'lblPromptSelectInstaller
        '
        Me.lblPromptSelectInstaller.AutoSize = True
        Me.lblPromptSelectInstaller.Location = New System.Drawing.Point(224, 33)
        Me.lblPromptSelectInstaller.Name = "lblPromptSelectInstaller"
        Me.lblPromptSelectInstaller.Size = New System.Drawing.Size(316, 25)
        Me.lblPromptSelectInstaller.TabIndex = 2
        Me.lblPromptSelectInstaller.Text = "Select the installer (usually .exe or .msi)"
        '
        'lblPromptSelectInstallerFolder
        '
        Me.lblPromptSelectInstallerFolder.AutoSize = True
        Me.lblPromptSelectInstallerFolder.Location = New System.Drawing.Point(164, 117)
        Me.lblPromptSelectInstallerFolder.Name = "lblPromptSelectInstallerFolder"
        Me.lblPromptSelectInstallerFolder.Size = New System.Drawing.Size(426, 25)
        Me.lblPromptSelectInstallerFolder.TabIndex = 3
        Me.lblPromptSelectInstallerFolder.Text = "Select the source folder (folder that the installer is in)"
        '
        'txtPathOfInstallerFolder
        '
        Me.txtPathOfInstallerFolder.Location = New System.Drawing.Point(106, 145)
        Me.txtPathOfInstallerFolder.Name = "txtPathOfInstallerFolder"
        Me.txtPathOfInstallerFolder.PlaceholderText = "Path of the folder that the installer is located in"
        Me.txtPathOfInstallerFolder.ReadOnly = True
        Me.txtPathOfInstallerFolder.Size = New System.Drawing.Size(434, 31)
        Me.txtPathOfInstallerFolder.TabIndex = 4
        '
        'btnSelectInstallerFolder
        '
        Me.btnSelectInstallerFolder.Location = New System.Drawing.Point(546, 145)
        Me.btnSelectInstallerFolder.Name = "btnSelectInstallerFolder"
        Me.btnSelectInstallerFolder.Size = New System.Drawing.Size(152, 34)
        Me.btnSelectInstallerFolder.TabIndex = 5
        Me.btnSelectInstallerFolder.Text = "Select Folder"
        Me.btnSelectInstallerFolder.UseVisualStyleBackColor = True
        '
        'btnSelectOutputFolder
        '
        Me.btnSelectOutputFolder.Location = New System.Drawing.Point(546, 231)
        Me.btnSelectOutputFolder.Name = "btnSelectOutputFolder"
        Me.btnSelectOutputFolder.Size = New System.Drawing.Size(152, 34)
        Me.btnSelectOutputFolder.TabIndex = 8
        Me.btnSelectOutputFolder.Text = "Select Folder"
        Me.btnSelectOutputFolder.UseVisualStyleBackColor = True
        '
        'txtOutputFolderPath
        '
        Me.txtOutputFolderPath.Location = New System.Drawing.Point(106, 231)
        Me.txtOutputFolderPath.Name = "txtOutputFolderPath"
        Me.txtOutputFolderPath.PlaceholderText = "Path of the folder that *.intunewin will be saved in"
        Me.txtOutputFolderPath.ReadOnly = True
        Me.txtOutputFolderPath.Size = New System.Drawing.Size(434, 31)
        Me.txtOutputFolderPath.TabIndex = 7
        '
        'lblPromptOutput
        '
        Me.lblPromptOutput.AutoSize = True
        Me.lblPromptOutput.Location = New System.Drawing.Point(147, 203)
        Me.lblPromptOutput.Name = "lblPromptOutput"
        Me.lblPromptOutput.Size = New System.Drawing.Size(460, 25)
        Me.lblPromptOutput.TabIndex = 6
        Me.lblPromptOutput.Text = "Select the output folder (where *.intunewin will be saved)"
        '
        'lblDebug
        '
        Me.lblDebug.AutoSize = True
        Me.lblDebug.Location = New System.Drawing.Point(808, 66)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(63, 25)
        Me.lblDebug.TabIndex = 9
        Me.lblDebug.Text = "Label1"
        '
        'grpCatalogFolder
        '
        Me.grpCatalogFolder.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpCatalogFolder.Controls.Add(Me.radNo)
        Me.grpCatalogFolder.Controls.Add(Me.radYes)
        Me.grpCatalogFolder.Location = New System.Drawing.Point(211, 297)
        Me.grpCatalogFolder.Name = "grpCatalogFolder"
        Me.grpCatalogFolder.Size = New System.Drawing.Size(273, 84)
        Me.grpCatalogFolder.TabIndex = 10
        Me.grpCatalogFolder.TabStop = False
        Me.grpCatalogFolder.Text = "Specify catalog folder (Yes/No):"
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Checked = True
        Me.radNo.Location = New System.Drawing.Point(160, 39)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(61, 29)
        Me.radNo.TabIndex = 1
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Enabled = False
        Me.radYes.Location = New System.Drawing.Point(50, 39)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(62, 29)
        Me.radYes.TabIndex = 0
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 450)
        Me.Controls.Add(Me.grpCatalogFolder)
        Me.Controls.Add(Me.lblDebug)
        Me.Controls.Add(Me.btnSelectOutputFolder)
        Me.Controls.Add(Me.txtOutputFolderPath)
        Me.Controls.Add(Me.lblPromptOutput)
        Me.Controls.Add(Me.btnSelectInstallerFolder)
        Me.Controls.Add(Me.txtPathOfInstallerFolder)
        Me.Controls.Add(Me.lblPromptSelectInstallerFolder)
        Me.Controls.Add(Me.lblPromptSelectInstaller)
        Me.Controls.Add(Me.btnSelectInstaller)
        Me.Controls.Add(Me.txtPathOfInstaller)
        Me.Name = "Form1"
        Me.Text = "Win32 Content Prep Tool GUI by Connor Hudson"
        Me.grpCatalogFolder.ResumeLayout(False)
        Me.grpCatalogFolder.PerformLayout()
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
    Friend WithEvents lblDebug As Label
    Friend WithEvents grpCatalogFolder As GroupBox
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
End Class
