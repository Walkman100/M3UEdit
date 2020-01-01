
Partial Class Settings
    Inherits System.Windows.Forms.Form
    
    ''' <summary>
    ''' Designer variable used to keep track of non-visual components.
    ''' </summary>
    Private components As System.ComponentModel.IContainer
    
    ''' <summary>
    ''' Disposes resources used by the form.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    
    ''' <summary>
    ''' This method is required for Windows Forms designer support.
    ''' Do not change the method contents inside the source code editor. The Forms designer might
    ''' not be able to load this method if it was changed manually.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.grpTestSettings = New System.Windows.Forms.GroupBox()
        Me.btnTestAskBrowse = New System.Windows.Forms.Button()
        Me.txtTestAskBrowse = New System.Windows.Forms.TextBox()
        Me.lblTestAskBrowse = New System.Windows.Forms.Label()
        Me.optTestAskBrowse = New System.Windows.Forms.RadioButton()
        Me.optTestAskSystem = New System.Windows.Forms.RadioButton()
        Me.optTestSpecific = New System.Windows.Forms.RadioButton()
        Me.optTestDefault = New System.Windows.Forms.RadioButton()
        Me.grpTestSpecific = New System.Windows.Forms.GroupBox()
        Me.btnTestSpecificVLCPlay = New System.Windows.Forms.Button()
        Me.btnTestSpecificVLCAdd = New System.Windows.Forms.Button()
        Me.txtTestSpecificArgs = New System.Windows.Forms.TextBox()
        Me.lblTestSpecificArgs = New System.Windows.Forms.Label()
        Me.btnTestSpecificPathBrowse = New System.Windows.Forms.Button()
        Me.lblTestSpecificPath = New System.Windows.Forms.Label()
        Me.txtTestSpecificPath = New System.Windows.Forms.TextBox()
        Me.grpSetPath = New System.Windows.Forms.GroupBox()
        Me.optSetPathRelativeExternal = New System.Windows.Forms.RadioButton()
        Me.optSetPathRelativeContained = New System.Windows.Forms.RadioButton()
        Me.optSetPathAbsolute = New System.Windows.Forms.RadioButton()
        Me.optSetPathNone = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDefaults = New System.Windows.Forms.Button()
        Me.ofdSelectProgram = New System.Windows.Forms.OpenFileDialog()
        Me.grpTestSettings.SuspendLayout
        Me.grpTestSpecific.SuspendLayout
        Me.grpSetPath.SuspendLayout
        Me.SuspendLayout
        '
        'grpTestSettings
        '
        Me.grpTestSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpTestSettings.Controls.Add(Me.btnTestAskBrowse)
        Me.grpTestSettings.Controls.Add(Me.txtTestAskBrowse)
        Me.grpTestSettings.Controls.Add(Me.lblTestAskBrowse)
        Me.grpTestSettings.Controls.Add(Me.optTestAskBrowse)
        Me.grpTestSettings.Controls.Add(Me.optTestAskSystem)
        Me.grpTestSettings.Controls.Add(Me.optTestSpecific)
        Me.grpTestSettings.Controls.Add(Me.optTestDefault)
        Me.grpTestSettings.Controls.Add(Me.grpTestSpecific)
        Me.grpTestSettings.Location = New System.Drawing.Point(12, 12)
        Me.grpTestSettings.Name = "grpTestSettings"
        Me.grpTestSettings.Size = New System.Drawing.Size(568, 255)
        Me.grpTestSettings.TabIndex = 0
        Me.grpTestSettings.TabStop = false
        Me.grpTestSettings.Text = "Use to test playlist:"
        '
        'btnTestAskBrowse
        '
        Me.btnTestAskBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnTestAskBrowse.Enabled = false
        Me.btnTestAskBrowse.Location = New System.Drawing.Point(487, 225)
        Me.btnTestAskBrowse.Name = "btnTestAskBrowse"
        Me.btnTestAskBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnTestAskBrowse.TabIndex = 9
        Me.btnTestAskBrowse.Text = "Browse..."
        Me.btnTestAskBrowse.UseVisualStyleBackColor = true
        '
        'txtTestAskBrowse
        '
        Me.txtTestAskBrowse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtTestAskBrowse.Enabled = false
        Me.txtTestAskBrowse.Location = New System.Drawing.Point(113, 227)
        Me.txtTestAskBrowse.Name = "txtTestAskBrowse"
        Me.txtTestAskBrowse.Size = New System.Drawing.Size(368, 20)
        Me.txtTestAskBrowse.TabIndex = 8
        '
        'lblTestAskBrowse
        '
        Me.lblTestAskBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lblTestAskBrowse.AutoSize = true
        Me.lblTestAskBrowse.Enabled = false
        Me.lblTestAskBrowse.Location = New System.Drawing.Point(33, 230)
        Me.lblTestAskBrowse.Name = "lblTestAskBrowse"
        Me.lblTestAskBrowse.Size = New System.Drawing.Size(74, 13)
        Me.lblTestAskBrowse.TabIndex = 7
        Me.lblTestAskBrowse.Text = "Default Value:"
        '
        'optTestAskBrowse
        '
        Me.optTestAskBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.optTestAskBrowse.AutoSize = true
        Me.optTestAskBrowse.Location = New System.Drawing.Point(6, 210)
        Me.optTestAskBrowse.Name = "optTestAskBrowse"
        Me.optTestAskBrowse.Size = New System.Drawing.Size(220, 17)
        Me.optTestAskBrowse.TabIndex = 3
        Me.optTestAskBrowse.Text = "Ask Every Time (M3UEdit Browse Dialog)"
        Me.optTestAskBrowse.UseVisualStyleBackColor = true
        '
        'optTestAskSystem
        '
        Me.optTestAskSystem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.optTestAskSystem.AutoSize = true
        Me.optTestAskSystem.Location = New System.Drawing.Point(6, 187)
        Me.optTestAskSystem.Name = "optTestAskSystem"
        Me.optTestAskSystem.Size = New System.Drawing.Size(226, 17)
        Me.optTestAskSystem.TabIndex = 2
        Me.optTestAskSystem.Text = "Ask Every Time (System OpenWith Dialog)"
        Me.optTestAskSystem.UseVisualStyleBackColor = true
        '
        'optTestSpecific
        '
        Me.optTestSpecific.AutoSize = true
        Me.optTestSpecific.BackColor = System.Drawing.Color.Transparent
        Me.optTestSpecific.Location = New System.Drawing.Point(6, 42)
        Me.optTestSpecific.Name = "optTestSpecific"
        Me.optTestSpecific.Size = New System.Drawing.Size(108, 17)
        Me.optTestSpecific.TabIndex = 1
        Me.optTestSpecific.Text = "Specific Program:"
        Me.optTestSpecific.UseVisualStyleBackColor = false
        '
        'optTestDefault
        '
        Me.optTestDefault.AutoSize = true
        Me.optTestDefault.Checked = true
        Me.optTestDefault.Location = New System.Drawing.Point(6, 19)
        Me.optTestDefault.Name = "optTestDefault"
        Me.optTestDefault.Size = New System.Drawing.Size(96, 17)
        Me.optTestDefault.TabIndex = 0
        Me.optTestDefault.TabStop = true
        Me.optTestDefault.Text = "System Default"
        Me.optTestDefault.UseVisualStyleBackColor = true
        '
        'grpTestSpecific
        '
        Me.grpTestSpecific.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpTestSpecific.Controls.Add(Me.btnTestSpecificVLCPlay)
        Me.grpTestSpecific.Controls.Add(Me.btnTestSpecificVLCAdd)
        Me.grpTestSpecific.Controls.Add(Me.txtTestSpecificArgs)
        Me.grpTestSpecific.Controls.Add(Me.lblTestSpecificArgs)
        Me.grpTestSpecific.Controls.Add(Me.btnTestSpecificPathBrowse)
        Me.grpTestSpecific.Controls.Add(Me.lblTestSpecificPath)
        Me.grpTestSpecific.Controls.Add(Me.txtTestSpecificPath)
        Me.grpTestSpecific.Enabled = false
        Me.grpTestSpecific.Location = New System.Drawing.Point(6, 44)
        Me.grpTestSpecific.Name = "grpTestSpecific"
        Me.grpTestSpecific.Size = New System.Drawing.Size(556, 128)
        Me.grpTestSpecific.TabIndex = 10
        Me.grpTestSpecific.TabStop = false
        '
        'btnTestSpecificVLCPlay
        '
        Me.btnTestSpecificVLCPlay.Location = New System.Drawing.Point(118, 97)
        Me.btnTestSpecificVLCPlay.Name = "btnTestSpecificVLCPlay"
        Me.btnTestSpecificVLCPlay.Size = New System.Drawing.Size(98, 23)
        Me.btnTestSpecificVLCPlay.TabIndex = 11
        Me.btnTestSpecificVLCPlay.Text = "VLC Play Directly"
        Me.btnTestSpecificVLCPlay.UseVisualStyleBackColor = true
        '
        'btnTestSpecificVLCAdd
        '
        Me.btnTestSpecificVLCAdd.Location = New System.Drawing.Point(6, 97)
        Me.btnTestSpecificVLCAdd.Name = "btnTestSpecificVLCAdd"
        Me.btnTestSpecificVLCAdd.Size = New System.Drawing.Size(106, 23)
        Me.btnTestSpecificVLCAdd.TabIndex = 10
        Me.btnTestSpecificVLCAdd.Text = "VLC Add to Playlist"
        Me.btnTestSpecificVLCAdd.UseVisualStyleBackColor = true
        '
        'txtTestSpecificArgs
        '
        Me.txtTestSpecificArgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtTestSpecificArgs.Location = New System.Drawing.Point(6, 71)
        Me.txtTestSpecificArgs.Name = "txtTestSpecificArgs"
        Me.txtTestSpecificArgs.Size = New System.Drawing.Size(544, 20)
        Me.txtTestSpecificArgs.TabIndex = 9
        Me.txtTestSpecificArgs.Text = """{0}"""
        '
        'lblTestSpecificArgs
        '
        Me.lblTestSpecificArgs.AutoSize = true
        Me.lblTestSpecificArgs.Location = New System.Drawing.Point(6, 55)
        Me.lblTestSpecificArgs.Name = "lblTestSpecificArgs"
        Me.lblTestSpecificArgs.Size = New System.Drawing.Size(249, 13)
        Me.lblTestSpecificArgs.TabIndex = 8
        Me.lblTestSpecificArgs.Text = "Arguments (""{0}"" will be replaced with the file path):"
        '
        'btnTestSpecificPathBrowse
        '
        Me.btnTestSpecificPathBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnTestSpecificPathBrowse.Location = New System.Drawing.Point(475, 30)
        Me.btnTestSpecificPathBrowse.Name = "btnTestSpecificPathBrowse"
        Me.btnTestSpecificPathBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnTestSpecificPathBrowse.TabIndex = 7
        Me.btnTestSpecificPathBrowse.Text = "Browse..."
        Me.btnTestSpecificPathBrowse.UseVisualStyleBackColor = true
        '
        'lblTestSpecificPath
        '
        Me.lblTestSpecificPath.AutoSize = true
        Me.lblTestSpecificPath.Location = New System.Drawing.Point(6, 16)
        Me.lblTestSpecificPath.Name = "lblTestSpecificPath"
        Me.lblTestSpecificPath.Size = New System.Drawing.Size(32, 13)
        Me.lblTestSpecificPath.TabIndex = 6
        Me.lblTestSpecificPath.Text = "Path:"
        '
        'txtTestSpecificPath
        '
        Me.txtTestSpecificPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtTestSpecificPath.Location = New System.Drawing.Point(6, 32)
        Me.txtTestSpecificPath.Name = "txtTestSpecificPath"
        Me.txtTestSpecificPath.Size = New System.Drawing.Size(463, 20)
        Me.txtTestSpecificPath.TabIndex = 5
        '
        'grpSetPath
        '
        Me.grpSetPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpSetPath.Controls.Add(Me.optSetPathRelativeExternal)
        Me.grpSetPath.Controls.Add(Me.optSetPathRelativeContained)
        Me.grpSetPath.Controls.Add(Me.optSetPathAbsolute)
        Me.grpSetPath.Controls.Add(Me.optSetPathNone)
        Me.grpSetPath.Location = New System.Drawing.Point(12, 273)
        Me.grpSetPath.Name = "grpSetPath"
        Me.grpSetPath.Size = New System.Drawing.Size(568, 111)
        Me.grpSetPath.TabIndex = 1
        Me.grpSetPath.TabStop = false
        Me.grpSetPath.Text = "Set New Path default option:"
        '
        'optSetPathRelativeExternal
        '
        Me.optSetPathRelativeExternal.AutoSize = true
        Me.optSetPathRelativeExternal.Location = New System.Drawing.Point(6, 88)
        Me.optSetPathRelativeExternal.Name = "optSetPathRelativeExternal"
        Me.optSetPathRelativeExternal.Size = New System.Drawing.Size(109, 17)
        Me.optSetPathRelativeExternal.TabIndex = 4
        Me.optSetPathRelativeExternal.TabStop = true
        Me.optSetPathRelativeExternal.Text = "Relative - Outside"
        Me.optSetPathRelativeExternal.UseVisualStyleBackColor = true
        '
        'optSetPathRelativeContained
        '
        Me.optSetPathRelativeContained.AutoSize = true
        Me.optSetPathRelativeContained.Location = New System.Drawing.Point(6, 65)
        Me.optSetPathRelativeContained.Name = "optSetPathRelativeContained"
        Me.optSetPathRelativeContained.Size = New System.Drawing.Size(121, 17)
        Me.optSetPathRelativeContained.TabIndex = 3
        Me.optSetPathRelativeContained.TabStop = true
        Me.optSetPathRelativeContained.Text = "Relative - Contained"
        Me.optSetPathRelativeContained.UseVisualStyleBackColor = true
        '
        'optSetPathAbsolute
        '
        Me.optSetPathAbsolute.AutoSize = true
        Me.optSetPathAbsolute.Location = New System.Drawing.Point(6, 42)
        Me.optSetPathAbsolute.Name = "optSetPathAbsolute"
        Me.optSetPathAbsolute.Size = New System.Drawing.Size(66, 17)
        Me.optSetPathAbsolute.TabIndex = 2
        Me.optSetPathAbsolute.TabStop = true
        Me.optSetPathAbsolute.Text = "Absolute"
        Me.optSetPathAbsolute.UseVisualStyleBackColor = true
        '
        'optSetPathNone
        '
        Me.optSetPathNone.AutoSize = true
        Me.optSetPathNone.Checked = true
        Me.optSetPathNone.Location = New System.Drawing.Point(6, 19)
        Me.optSetPathNone.Name = "optSetPathNone"
        Me.optSetPathNone.Size = New System.Drawing.Size(51, 17)
        Me.optSetPathNone.TabIndex = 1
        Me.optSetPathNone.TabStop = true
        Me.optSetPathNone.Text = "None"
        Me.optSetPathNone.UseVisualStyleBackColor = true
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Location = New System.Drawing.Point(180, 390)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(261, 390)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'btnDefaults
        '
        Me.btnDefaults.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDefaults.Location = New System.Drawing.Point(342, 390)
        Me.btnDefaults.Name = "btnDefaults"
        Me.btnDefaults.Size = New System.Drawing.Size(75, 23)
        Me.btnDefaults.TabIndex = 4
        Me.btnDefaults.Text = "Defaults"
        Me.btnDefaults.UseVisualStyleBackColor = true
        '
        'ofdSelectProgram
        '
        Me.ofdSelectProgram.DefaultExt = "exe"
        Me.ofdSelectProgram.FileName = "openFileDialog1"
        Me.ofdSelectProgram.Filter = "Executables|*.exe;*.com;*.bat;*.cmd;*.vbs|All Files|*.*"
        Me.ofdSelectProgram.Title = "Select Program to use"
        '
        'Settings
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(592, 420)
        Me.Controls.Add(Me.btnDefaults)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpSetPath)
        Me.Controls.Add(Me.grpTestSettings)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Settings"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.grpTestSettings.ResumeLayout(false)
        Me.grpTestSettings.PerformLayout
        Me.grpTestSpecific.ResumeLayout(false)
        Me.grpTestSpecific.PerformLayout
        Me.grpSetPath.ResumeLayout(false)
        Me.grpSetPath.PerformLayout
        Me.ResumeLayout(false)
    End Sub
    Friend ofdSelectProgram As System.Windows.Forms.OpenFileDialog
    Private lblTestSpecificPath As System.Windows.Forms.Label
    Private WithEvents btnTestSpecificPathBrowse As System.Windows.Forms.Button
    Private lblTestSpecificArgs As System.Windows.Forms.Label
    Friend txtTestSpecificArgs As System.Windows.Forms.TextBox
    Private WithEvents btnTestSpecificVLCAdd As System.Windows.Forms.Button
    Private WithEvents btnTestSpecificVLCPlay As System.Windows.Forms.Button
    Private grpTestSpecific As System.Windows.Forms.GroupBox
    Private WithEvents btnDefaults As System.Windows.Forms.Button
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnSave As System.Windows.Forms.Button
    Friend optSetPathNone As System.Windows.Forms.RadioButton
    Friend optSetPathAbsolute As System.Windows.Forms.RadioButton
    Friend optSetPathRelativeContained As System.Windows.Forms.RadioButton
    Friend optSetPathRelativeExternal As System.Windows.Forms.RadioButton
    Friend optTestDefault As System.Windows.Forms.RadioButton
    Friend WithEvents optTestSpecific As System.Windows.Forms.RadioButton
    Friend optTestAskSystem As System.Windows.Forms.RadioButton
    Friend WithEvents optTestAskBrowse As System.Windows.Forms.RadioButton
    Friend txtTestSpecificPath As System.Windows.Forms.TextBox
    Private lblTestAskBrowse As System.Windows.Forms.Label
    Friend txtTestAskBrowse As System.Windows.Forms.TextBox
    Private WithEvents btnTestAskBrowse As System.Windows.Forms.Button
    Private grpSetPath As System.Windows.Forms.GroupBox
    Private grpTestSettings As System.Windows.Forms.GroupBox
End Class
