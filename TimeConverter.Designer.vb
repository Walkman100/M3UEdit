<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeConverter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblIn = New System.Windows.Forms.Label()
        Me.txtIn = New System.Windows.Forms.TextBox()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.btnAutoConvert = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.gbxParsed = New System.Windows.Forms.GroupBox()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.gbxParsed.SuspendLayout
        Me.SuspendLayout
        '
        'lblIn
        '
        Me.lblIn.AutoSize = true
        Me.lblIn.Location = New System.Drawing.Point(12, 9)
        Me.lblIn.Name = "lblIn"
        Me.lblIn.Size = New System.Drawing.Size(34, 13)
        Me.lblIn.TabIndex = 13
        Me.lblIn.Text = "Input:"
        '
        'txtIn
        '
        Me.txtIn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtIn.Location = New System.Drawing.Point(12, 25)
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(159, 20)
        Me.txtIn.TabIndex = 11
        '
        'txtOut
        '
        Me.txtOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtOut.Location = New System.Drawing.Point(177, 25)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ReadOnly = true
        Me.txtOut.Size = New System.Drawing.Size(159, 20)
        Me.txtOut.TabIndex = 12
        '
        'lblOut
        '
        Me.lblOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblOut.AutoSize = true
        Me.lblOut.Location = New System.Drawing.Point(177, 9)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(115, 13)
        Me.lblOut.TabIndex = 14
        Me.lblOut.Text = "Output (Seconds only):"
        '
        'btnAutoConvert
        '
        Me.btnAutoConvert.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAutoConvert.Location = New System.Drawing.Point(80, 116)
        Me.btnAutoConvert.Name = "btnAutoConvert"
        Me.btnAutoConvert.Size = New System.Drawing.Size(192, 23)
        Me.btnAutoConvert.TabIndex = 18
        Me.btnAutoConvert.Text = "Get clipboard text, convert then save"
        Me.btnAutoConvert.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(177, 145)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Location = New System.Drawing.Point(96, 145)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'lblHours
        '
        Me.lblHours.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHours.AutoSize = true
        Me.lblHours.Location = New System.Drawing.Point(6, 16)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(38, 13)
        Me.lblHours.TabIndex = 21
        Me.lblHours.Text = "Hours:"
        '
        'txtHours
        '
        Me.txtHours.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtHours.Location = New System.Drawing.Point(6, 32)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.ReadOnly = true
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 22
        '
        'lblMinutes
        '
        Me.lblMinutes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMinutes.AutoSize = true
        Me.lblMinutes.Location = New System.Drawing.Point(112, 16)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(47, 13)
        Me.lblMinutes.TabIndex = 23
        Me.lblMinutes.Text = "Minutes:"
        '
        'gbxParsed
        '
        Me.gbxParsed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.gbxParsed.Controls.Add(Me.lblSeconds)
        Me.gbxParsed.Controls.Add(Me.txtSeconds)
        Me.gbxParsed.Controls.Add(Me.txtMinutes)
        Me.gbxParsed.Controls.Add(Me.txtHours)
        Me.gbxParsed.Controls.Add(Me.lblMinutes)
        Me.gbxParsed.Controls.Add(Me.lblHours)
        Me.gbxParsed.Location = New System.Drawing.Point(12, 51)
        Me.gbxParsed.Name = "gbxParsed"
        Me.gbxParsed.Size = New System.Drawing.Size(324, 59)
        Me.gbxParsed.TabIndex = 24
        Me.gbxParsed.TabStop = false
        Me.gbxParsed.Text = "Parsed:"
        '
        'lblSeconds
        '
        Me.lblSeconds.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSeconds.AutoSize = true
        Me.lblSeconds.Location = New System.Drawing.Point(218, 16)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(52, 13)
        Me.lblSeconds.TabIndex = 26
        Me.lblSeconds.Text = "Seconds:"
        '
        'txtSeconds
        '
        Me.txtSeconds.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSeconds.Location = New System.Drawing.Point(218, 32)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.ReadOnly = true
        Me.txtSeconds.Size = New System.Drawing.Size(100, 20)
        Me.txtSeconds.TabIndex = 25
        '
        'txtMinutes
        '
        Me.txtMinutes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMinutes.Location = New System.Drawing.Point(112, 32)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.ReadOnly = true
        Me.txtMinutes.Size = New System.Drawing.Size(100, 20)
        Me.txtMinutes.TabIndex = 24
        '
        'TimeConverter
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(348, 175)
        Me.Controls.Add(Me.gbxParsed)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblIn)
        Me.Controls.Add(Me.txtIn)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.btnAutoConvert)
        Me.Name = "TimeConverter"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Convert Time"
        Me.gbxParsed.ResumeLayout(false)
        Me.gbxParsed.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Private txtMinutes As System.Windows.Forms.TextBox
    Private txtSeconds As System.Windows.Forms.TextBox
    Private lblSeconds As System.Windows.Forms.Label
    Private gbxParsed As System.Windows.Forms.GroupBox
    Private lblMinutes As System.Windows.Forms.Label
    Private txtHours As System.Windows.Forms.TextBox
    Private lblHours As System.Windows.Forms.Label
    Private btnSave As System.Windows.Forms.Button
    Private lblIn As System.Windows.Forms.Label
    Private WithEvents txtIn As System.Windows.Forms.TextBox
    Private WithEvents txtOut As System.Windows.Forms.TextBox
    Private lblOut As System.Windows.Forms.Label
    Private WithEvents btnAutoConvert As System.Windows.Forms.Button
    Private btnCancel As System.Windows.Forms.Button
End Class
