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
        Me.lblDebug_prepToolExe = New System.Windows.Forms.Label()
        Me.grpCatalogFolder = New System.Windows.Forms.GroupBox()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelectPrepToolExe = New System.Windows.Forms.Button()
        Me.txtPathOfPrepToolExe = New System.Windows.Forms.TextBox()
        Me.opnfilediagSelectPrepToolExe = New System.Windows.Forms.OpenFileDialog()
        Me.btnStartPackaging = New System.Windows.Forms.Button()
        Me.lblDebug_installerPath = New System.Windows.Forms.Label()
        Me.lblDebug_installerFolder = New System.Windows.Forms.Label()
        Me.lblDebug_outputFolder = New System.Windows.Forms.Label()
        Me.lblDebug_catalogChoice = New System.Windows.Forms.Label()
        Me.lblDebug_args = New System.Windows.Forms.Label()
        Me.txtArguments = New System.Windows.Forms.TextBox()
        Me.lblDebug_installerFileName = New System.Windows.Forms.Label()
        Me.grpCatalogFolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPathOfInstaller
        '
        Me.txtPathOfInstaller.Location = New System.Drawing.Point(23, 145)
        Me.txtPathOfInstaller.Name = "txtPathOfInstaller"
        Me.txtPathOfInstaller.PlaceholderText = "Path of installer"
        Me.txtPathOfInstaller.ReadOnly = True
        Me.txtPathOfInstaller.Size = New System.Drawing.Size(516, 31)
        Me.txtPathOfInstaller.TabIndex = 0
        '
        'btnSelectInstaller
        '
        Me.btnSelectInstaller.Location = New System.Drawing.Point(545, 143)
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
        Me.lblPromptSelectInstaller.Location = New System.Drawing.Point(23, 117)
        Me.lblPromptSelectInstaller.Name = "lblPromptSelectInstaller"
        Me.lblPromptSelectInstaller.Size = New System.Drawing.Size(360, 25)
        Me.lblPromptSelectInstaller.TabIndex = 2
        Me.lblPromptSelectInstaller.Text = "Select setup file (e.g. setup.exe or setup.msi)"
        '
        'lblPromptSelectInstallerFolder
        '
        Me.lblPromptSelectInstallerFolder.AutoSize = True
        Me.lblPromptSelectInstallerFolder.Location = New System.Drawing.Point(23, 207)
        Me.lblPromptSelectInstallerFolder.Name = "lblPromptSelectInstallerFolder"
        Me.lblPromptSelectInstallerFolder.Size = New System.Drawing.Size(674, 25)
        Me.lblPromptSelectInstallerFolder.TabIndex = 3
        Me.lblPromptSelectInstallerFolder.Text = "Select the setup folder (All files in this folder will be compressed into .intune" &
    "win file.)"
        '
        'txtPathOfInstallerFolder
        '
        Me.txtPathOfInstallerFolder.Location = New System.Drawing.Point(23, 235)
        Me.txtPathOfInstallerFolder.Name = "txtPathOfInstallerFolder"
        Me.txtPathOfInstallerFolder.PlaceholderText = "Path of the folder that the installer is located in"
        Me.txtPathOfInstallerFolder.ReadOnly = True
        Me.txtPathOfInstallerFolder.Size = New System.Drawing.Size(516, 31)
        Me.txtPathOfInstallerFolder.TabIndex = 4
        '
        'btnSelectInstallerFolder
        '
        Me.btnSelectInstallerFolder.Location = New System.Drawing.Point(545, 235)
        Me.btnSelectInstallerFolder.Name = "btnSelectInstallerFolder"
        Me.btnSelectInstallerFolder.Size = New System.Drawing.Size(152, 33)
        Me.btnSelectInstallerFolder.TabIndex = 5
        Me.btnSelectInstallerFolder.Text = "Select Folder"
        Me.btnSelectInstallerFolder.UseVisualStyleBackColor = True
        '
        'btnSelectOutputFolder
        '
        Me.btnSelectOutputFolder.Location = New System.Drawing.Point(545, 321)
        Me.btnSelectOutputFolder.Name = "btnSelectOutputFolder"
        Me.btnSelectOutputFolder.Size = New System.Drawing.Size(152, 33)
        Me.btnSelectOutputFolder.TabIndex = 8
        Me.btnSelectOutputFolder.Text = "Select Folder"
        Me.btnSelectOutputFolder.UseVisualStyleBackColor = True
        '
        'txtOutputFolderPath
        '
        Me.txtOutputFolderPath.Location = New System.Drawing.Point(23, 321)
        Me.txtOutputFolderPath.Name = "txtOutputFolderPath"
        Me.txtOutputFolderPath.PlaceholderText = "Path of the folder that *.intunewin will be saved in"
        Me.txtOutputFolderPath.ReadOnly = True
        Me.txtOutputFolderPath.Size = New System.Drawing.Size(516, 31)
        Me.txtOutputFolderPath.TabIndex = 7
        '
        'lblPromptOutput
        '
        Me.lblPromptOutput.AutoSize = True
        Me.lblPromptOutput.Location = New System.Drawing.Point(23, 293)
        Me.lblPromptOutput.Name = "lblPromptOutput"
        Me.lblPromptOutput.Size = New System.Drawing.Size(571, 25)
        Me.lblPromptOutput.TabIndex = 6
        Me.lblPromptOutput.Text = "Select the output folder (Where the generated .intunewin will be saved)"
        '
        'lblDebug_prepToolExe
        '
        Me.lblDebug_prepToolExe.AutoSize = True
        Me.lblDebug_prepToolExe.Location = New System.Drawing.Point(951, 55)
        Me.lblDebug_prepToolExe.Name = "lblDebug_prepToolExe"
        Me.lblDebug_prepToolExe.Size = New System.Drawing.Size(181, 25)
        Me.lblDebug_prepToolExe.TabIndex = 9
        Me.lblDebug_prepToolExe.Text = "Debug prepToolExe : "
        '
        'grpCatalogFolder
        '
        Me.grpCatalogFolder.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpCatalogFolder.Controls.Add(Me.radNo)
        Me.grpCatalogFolder.Controls.Add(Me.radYes)
        Me.grpCatalogFolder.Location = New System.Drawing.Point(23, 387)
        Me.grpCatalogFolder.Name = "grpCatalogFolder"
        Me.grpCatalogFolder.Size = New System.Drawing.Size(273, 72)
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
        Me.radYes.Location = New System.Drawing.Point(50, 39)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(62, 29)
        Me.radYes.TabIndex = 0
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the Microsoft Content Prep Tool EXE"
        '
        'btnSelectPrepToolExe
        '
        Me.btnSelectPrepToolExe.Location = New System.Drawing.Point(545, 57)
        Me.btnSelectPrepToolExe.Name = "btnSelectPrepToolExe"
        Me.btnSelectPrepToolExe.Size = New System.Drawing.Size(152, 34)
        Me.btnSelectPrepToolExe.TabIndex = 12
        Me.btnSelectPrepToolExe.Text = "Select File"
        Me.btnSelectPrepToolExe.UseVisualStyleBackColor = True
        '
        'txtPathOfPrepToolExe
        '
        Me.txtPathOfPrepToolExe.Location = New System.Drawing.Point(23, 59)
        Me.txtPathOfPrepToolExe.Name = "txtPathOfPrepToolExe"
        Me.txtPathOfPrepToolExe.PlaceholderText = "Path of prep tool executable"
        Me.txtPathOfPrepToolExe.ReadOnly = True
        Me.txtPathOfPrepToolExe.Size = New System.Drawing.Size(516, 31)
        Me.txtPathOfPrepToolExe.TabIndex = 11
        '
        'opnfilediagSelectPrepToolExe
        '
        '
        'btnStartPackaging
        '
        Me.btnStartPackaging.Location = New System.Drawing.Point(545, 401)
        Me.btnStartPackaging.Name = "btnStartPackaging"
        Me.btnStartPackaging.Size = New System.Drawing.Size(152, 58)
        Me.btnStartPackaging.TabIndex = 14
        Me.btnStartPackaging.Text = "Generate .intunewin"
        Me.btnStartPackaging.UseVisualStyleBackColor = True
        '
        'lblDebug_installerPath
        '
        Me.lblDebug_installerPath.AutoSize = True
        Me.lblDebug_installerPath.Location = New System.Drawing.Point(951, 141)
        Me.lblDebug_installerPath.Name = "lblDebug_installerPath"
        Me.lblDebug_installerPath.Size = New System.Drawing.Size(179, 25)
        Me.lblDebug_installerPath.TabIndex = 15
        Me.lblDebug_installerPath.Text = "Debug installerPath : "
        '
        'lblDebug_installerFolder
        '
        Me.lblDebug_installerFolder.AutoSize = True
        Me.lblDebug_installerFolder.Location = New System.Drawing.Point(951, 227)
        Me.lblDebug_installerFolder.Name = "lblDebug_installerFolder"
        Me.lblDebug_installerFolder.Size = New System.Drawing.Size(195, 25)
        Me.lblDebug_installerFolder.TabIndex = 16
        Me.lblDebug_installerFolder.Text = "Debug installerFolder : "
        '
        'lblDebug_outputFolder
        '
        Me.lblDebug_outputFolder.AutoSize = True
        Me.lblDebug_outputFolder.Location = New System.Drawing.Point(951, 313)
        Me.lblDebug_outputFolder.Name = "lblDebug_outputFolder"
        Me.lblDebug_outputFolder.Size = New System.Drawing.Size(189, 25)
        Me.lblDebug_outputFolder.TabIndex = 17
        Me.lblDebug_outputFolder.Text = "Debug outputFolder : "
        '
        'lblDebug_catalogChoice
        '
        Me.lblDebug_catalogChoice.AutoSize = True
        Me.lblDebug_catalogChoice.Location = New System.Drawing.Point(957, 418)
        Me.lblDebug_catalogChoice.Name = "lblDebug_catalogChoice"
        Me.lblDebug_catalogChoice.Size = New System.Drawing.Size(193, 25)
        Me.lblDebug_catalogChoice.TabIndex = 18
        Me.lblDebug_catalogChoice.Text = "Debug catalog choice: "
        '
        'lblDebug_args
        '
        Me.lblDebug_args.AutoSize = True
        Me.lblDebug_args.Location = New System.Drawing.Point(808, 528)
        Me.lblDebug_args.Name = "lblDebug_args"
        Me.lblDebug_args.Size = New System.Drawing.Size(165, 25)
        Me.lblDebug_args.TabIndex = 19
        Me.lblDebug_args.Text = "Debug arguments: "
        '
        'txtArguments
        '
        Me.txtArguments.Location = New System.Drawing.Point(802, 583)
        Me.txtArguments.Name = "txtArguments"
        Me.txtArguments.Size = New System.Drawing.Size(280, 31)
        Me.txtArguments.TabIndex = 20
        '
        'lblDebug_installerFileName
        '
        Me.lblDebug_installerFileName.AutoSize = True
        Me.lblDebug_installerFileName.Location = New System.Drawing.Point(23, 618)
        Me.lblDebug_installerFileName.Name = "lblDebug_installerFileName"
        Me.lblDebug_installerFileName.Size = New System.Drawing.Size(148, 25)
        Me.lblDebug_installerFileName.TabIndex = 21
        Me.lblDebug_installerFileName.Text = "Installer name is: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 652)
        Me.Controls.Add(Me.lblDebug_installerFileName)
        Me.Controls.Add(Me.txtArguments)
        Me.Controls.Add(Me.lblDebug_args)
        Me.Controls.Add(Me.lblDebug_catalogChoice)
        Me.Controls.Add(Me.lblDebug_outputFolder)
        Me.Controls.Add(Me.lblDebug_installerFolder)
        Me.Controls.Add(Me.lblDebug_installerPath)
        Me.Controls.Add(Me.btnStartPackaging)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelectPrepToolExe)
        Me.Controls.Add(Me.txtPathOfPrepToolExe)
        Me.Controls.Add(Me.grpCatalogFolder)
        Me.Controls.Add(Me.lblDebug_prepToolExe)
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
        Me.Text = "Win32 Content Prep Tool GUI"
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
    Friend WithEvents lblDebug_prepToolExe As Label
    Friend WithEvents grpCatalogFolder As GroupBox
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSelectPrepToolExe As Button
    Friend WithEvents txtPathOfPrepToolExe As TextBox
    Friend WithEvents opnfilediagSelectPrepToolExe As OpenFileDialog
    Friend WithEvents btnStartPackaging As Button
    Friend WithEvents lblDebug_installerPath As Label
    Friend WithEvents lblDebug_installerFolder As Label
    Friend WithEvents lblDebug_outputFolder As Label
    Friend WithEvents lblDebug_catalogChoice As Label
    Friend WithEvents lblDebug_args As Label
    Friend WithEvents txtArguments As TextBox
    Friend WithEvents lblDebug_installerFileName As Label
End Class
