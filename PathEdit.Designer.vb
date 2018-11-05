
Partial Class PathEdit
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
        Me.gbxSetPathRelative = New System.Windows.Forms.GroupBox()
        Me.optSetPathRelativeContained = New System.Windows.Forms.RadioButton()
        Me.optSetPathRelativeExternal = New System.Windows.Forms.RadioButton()
        Me.optSetPathRelative = New System.Windows.Forms.RadioButton()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.optSetPathAbsolute = New System.Windows.Forms.RadioButton()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnURLEncode = New System.Windows.Forms.Button()
        Me.txtDecoded = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblDecoded = New System.Windows.Forms.Label()
        Me.lblFileExistence = New System.Windows.Forms.Label()
        Me.pbxFileExistence = New System.Windows.Forms.PictureBox()
        Me.gbxSetPath = New System.Windows.Forms.GroupBox()
        Me.txtCD = New System.Windows.Forms.TextBox()
        Me.lblCD = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ofdSelectFile = New System.Windows.Forms.OpenFileDialog()
        Me.lblOutputWarning = New System.Windows.Forms.Label()
        Me.gbxSetPathRelative.SuspendLayout
        CType(Me.pbxFileExistence,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbxSetPath.SuspendLayout
        Me.SuspendLayout
        '
        'gbxSetPathRelative
        '
        Me.gbxSetPathRelative.Controls.Add(Me.optSetPathRelativeContained)
        Me.gbxSetPathRelative.Controls.Add(Me.optSetPathRelativeExternal)
        Me.gbxSetPathRelative.Enabled = false
        Me.gbxSetPathRelative.Location = New System.Drawing.Point(6, 44)
        Me.gbxSetPathRelative.Name = "gbxSetPathRelative"
        Me.gbxSetPathRelative.Size = New System.Drawing.Size(150, 65)
        Me.gbxSetPathRelative.TabIndex = 2
        Me.gbxSetPathRelative.TabStop = false
        '
        'optSetPathRelativeContained
        '
        Me.optSetPathRelativeContained.AutoSize = true
        Me.optSetPathRelativeContained.Checked = true
        Me.optSetPathRelativeContained.Location = New System.Drawing.Point(6, 19)
        Me.optSetPathRelativeContained.Name = "optSetPathRelativeContained"
        Me.optSetPathRelativeContained.Size = New System.Drawing.Size(113, 17)
        Me.optSetPathRelativeContained.TabIndex = 0
        Me.optSetPathRelativeContained.TabStop = true
        Me.optSetPathRelativeContained.Text = "Contained in folder"
        Me.optSetPathRelativeContained.UseVisualStyleBackColor = true
        '
        'optSetPathRelativeExternal
        '
        Me.optSetPathRelativeExternal.AutoSize = true
        Me.optSetPathRelativeExternal.Location = New System.Drawing.Point(6, 42)
        Me.optSetPathRelativeExternal.Name = "optSetPathRelativeExternal"
        Me.optSetPathRelativeExternal.Size = New System.Drawing.Size(142, 17)
        Me.optSetPathRelativeExternal.TabIndex = 1
        Me.optSetPathRelativeExternal.TabStop = true
        Me.optSetPathRelativeExternal.Text = "Relative outside of folder"
        Me.optSetPathRelativeExternal.UseVisualStyleBackColor = true
        '
        'optSetPathRelative
        '
        Me.optSetPathRelative.AutoSize = true
        Me.optSetPathRelative.Location = New System.Drawing.Point(6, 42)
        Me.optSetPathRelative.Name = "optSetPathRelative"
        Me.optSetPathRelative.Size = New System.Drawing.Size(67, 17)
        Me.optSetPathRelative.TabIndex = 1
        Me.optSetPathRelative.TabStop = true
        Me.optSetPathRelative.Text = "Relative:"
        Me.optSetPathRelative.UseVisualStyleBackColor = true
        '
        'btnBrowse
        '
        Me.btnBrowse.AutoSize = true
        Me.btnBrowse.Enabled = false
        Me.btnBrowse.Location = New System.Drawing.Point(297, 86)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = true
        '
        'optSetPathAbsolute
        '
        Me.optSetPathAbsolute.AutoSize = true
        Me.optSetPathAbsolute.Location = New System.Drawing.Point(6, 19)
        Me.optSetPathAbsolute.Name = "optSetPathAbsolute"
        Me.optSetPathAbsolute.Size = New System.Drawing.Size(66, 17)
        Me.optSetPathAbsolute.TabIndex = 0
        Me.optSetPathAbsolute.TabStop = true
        Me.optSetPathAbsolute.Text = "Absolute"
        Me.optSetPathAbsolute.UseVisualStyleBackColor = true
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtOutput.Location = New System.Drawing.Point(12, 25)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(493, 20)
        Me.txtOutput.TabIndex = 1
        '
        'btnURLEncode
        '
        Me.btnURLEncode.Location = New System.Drawing.Point(134, 51)
        Me.btnURLEncode.Name = "btnURLEncode"
        Me.btnURLEncode.Size = New System.Drawing.Size(256, 23)
        Me.btnURLEncode.TabIndex = 2
        Me.btnURLEncode.Text = "URL Encode... (From ↓ to ↑)"
        Me.btnURLEncode.UseVisualStyleBackColor = true
        '
        'txtDecoded
        '
        Me.txtDecoded.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtDecoded.Location = New System.Drawing.Point(12, 80)
        Me.txtDecoded.Name = "txtDecoded"
        Me.txtDecoded.Size = New System.Drawing.Size(493, 20)
        Me.txtDecoded.TabIndex = 4
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = true
        Me.lblOutput.Location = New System.Drawing.Point(12, 9)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(67, 13)
        Me.lblOutput.TabIndex = 0
        Me.lblOutput.Text = "Output Path:"
        '
        'lblDecoded
        '
        Me.lblDecoded.AutoSize = true
        Me.lblDecoded.Location = New System.Drawing.Point(12, 64)
        Me.lblDecoded.Name = "lblDecoded"
        Me.lblDecoded.Size = New System.Drawing.Size(79, 13)
        Me.lblDecoded.TabIndex = 3
        Me.lblDecoded.Text = "URL Decoded:"
        '
        'lblFileExistence
        '
        Me.lblFileExistence.AutoSize = true
        Me.lblFileExistence.Location = New System.Drawing.Point(414, 107)
        Me.lblFileExistence.Name = "lblFileExistence"
        Me.lblFileExistence.Size = New System.Drawing.Size(87, 13)
        Me.lblFileExistence.TabIndex = 6
        Me.lblFileExistence.Text = "File Doesn't Exist"
        '
        'pbxFileExistence
        '
        Me.pbxFileExistence.Location = New System.Drawing.Point(396, 106)
        Me.pbxFileExistence.Name = "pbxFileExistence"
        Me.pbxFileExistence.Size = New System.Drawing.Size(16, 16)
        Me.pbxFileExistence.TabIndex = 21
        Me.pbxFileExistence.TabStop = false
        '
        'gbxSetPath
        '
        Me.gbxSetPath.Controls.Add(Me.optSetPathRelative)
        Me.gbxSetPath.Controls.Add(Me.optSetPathAbsolute)
        Me.gbxSetPath.Controls.Add(Me.gbxSetPathRelative)
        Me.gbxSetPath.Controls.Add(Me.btnBrowse)
        Me.gbxSetPath.Location = New System.Drawing.Point(12, 106)
        Me.gbxSetPath.Name = "gbxSetPath"
        Me.gbxSetPath.Size = New System.Drawing.Size(378, 115)
        Me.gbxSetPath.TabIndex = 5
        Me.gbxSetPath.TabStop = false
        Me.gbxSetPath.Text = "Set New Path"
        '
        'txtCD
        '
        Me.txtCD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtCD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCD.Location = New System.Drawing.Point(107, 227)
        Me.txtCD.Name = "txtCD"
        Me.txtCD.ReadOnly = true
        Me.txtCD.Size = New System.Drawing.Size(398, 13)
        Me.txtCD.TabIndex = 10
        '
        'lblCD
        '
        Me.lblCD.AutoSize = true
        Me.lblCD.Location = New System.Drawing.Point(12, 227)
        Me.lblCD.Name = "lblCD"
        Me.lblCD.Size = New System.Drawing.Size(89, 13)
        Me.lblCD.TabIndex = 9
        Me.lblCD.Text = "Current Directory:"
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Location = New System.Drawing.Point(418, 142)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(418, 171)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'ofdSelectFile
        '
        Me.ofdSelectFile.DefaultExt = "mp3"
        Me.ofdSelectFile.Filter = "Media Files|*.mp3; *.mp4; *.wav; *.m4a; *.wma; *.wmv; *.mov; *.mpg|All Files|*.*"
        '
        'lblOutputWarning
        '
        Me.lblOutputWarning.AutoSize = true
        Me.lblOutputWarning.ForeColor = System.Drawing.Color.Maroon
        Me.lblOutputWarning.Location = New System.Drawing.Point(84, 9)
        Me.lblOutputWarning.Name = "lblOutputWarning"
        Me.lblOutputWarning.Size = New System.Drawing.Size(0, 13)
        Me.lblOutputWarning.TabIndex = 22
        '
        'PathEdit
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(517, 248)
        Me.Controls.Add(Me.lblOutputWarning)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblCD)
        Me.Controls.Add(Me.txtCD)
        Me.Controls.Add(Me.gbxSetPath)
        Me.Controls.Add(Me.pbxFileExistence)
        Me.Controls.Add(Me.lblFileExistence)
        Me.Controls.Add(Me.lblDecoded)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtDecoded)
        Me.Controls.Add(Me.btnURLEncode)
        Me.Controls.Add(Me.txtOutput)
        Me.Name = "PathEdit"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Track Path"
        Me.gbxSetPathRelative.ResumeLayout(false)
        Me.gbxSetPathRelative.PerformLayout
        CType(Me.pbxFileExistence,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbxSetPath.ResumeLayout(false)
        Me.gbxSetPath.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Private lblOutputWarning As System.Windows.Forms.Label
    Private ofdSelectFile As System.Windows.Forms.OpenFileDialog
    Private btnCancel As System.Windows.Forms.Button
    Private btnSave As System.Windows.Forms.Button
    Private lblCD As System.Windows.Forms.Label
    Private txtCD As System.Windows.Forms.TextBox
    Private gbxSetPath As System.Windows.Forms.GroupBox
    Private pbxFileExistence As System.Windows.Forms.PictureBox
    Private lblFileExistence As System.Windows.Forms.Label
    Private lblDecoded As System.Windows.Forms.Label
    Private lblOutput As System.Windows.Forms.Label
    Private WithEvents txtDecoded As System.Windows.Forms.TextBox
    Private WithEvents btnURLEncode As System.Windows.Forms.Button
    Private WithEvents txtOutput As System.Windows.Forms.TextBox
    Private WithEvents optSetPathAbsolute As System.Windows.Forms.RadioButton
    Private WithEvents btnBrowse As System.Windows.Forms.Button
    Private WithEvents optSetPathRelative As System.Windows.Forms.RadioButton
    Private optSetPathRelativeExternal As System.Windows.Forms.RadioButton
    Private optSetPathRelativeContained As System.Windows.Forms.RadioButton
    Private gbxSetPathRelative As System.Windows.Forms.GroupBox
End Class
