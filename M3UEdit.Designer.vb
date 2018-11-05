Partial Class M3UEdit
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
        Me.components = New System.ComponentModel.Container()
        Me.lstFiles = New System.Windows.Forms.ListView()
        Me.colHeadFile = New System.Windows.Forms.ColumnHeader()
        Me.colHeadLength = New System.Windows.Forms.ColumnHeader()
        Me.colHeadTitle = New System.Windows.Forms.ColumnHeader()
        Me.colHeadArtist = New System.Windows.Forms.ColumnHeader()
        Me.colHeadStartTime = New System.Windows.Forms.ColumnHeader()
        Me.colHeadEndTime = New System.Windows.Forms.ColumnHeader()
        Me.btnM3UBrowse = New System.Windows.Forms.Button()
        Me.txtM3UFile = New System.Windows.Forms.TextBox()
        Me.btnM3UEdit = New System.Windows.Forms.Button()
        Me.splitContainerMain = New System.Windows.Forms.SplitContainer()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMoveDown = New System.Windows.Forms.Button()
        Me.btnMoveUp = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpCustomTimes = New System.Windows.Forms.GroupBox()
        Me.btnEndTimeGet = New System.Windows.Forms.Button()
        Me.btnStartEndSetLength = New System.Windows.Forms.Button()
        Me.numEndTime = New System.Windows.Forms.NumericUpDown()
        Me.numStartTime = New System.Windows.Forms.NumericUpDown()
        Me.chkEndTime = New System.Windows.Forms.CheckBox()
        Me.chkStartTime = New System.Windows.Forms.CheckBox()
        Me.btnEndTimeConvert = New System.Windows.Forms.Button()
        Me.btnStartTimeConvert = New System.Windows.Forms.Button()
        Me.btnTestSelected = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpTrackInfo = New System.Windows.Forms.GroupBox()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.grpLength = New System.Windows.Forms.GroupBox()
        Me.btnLengthConvert = New System.Windows.Forms.Button()
        Me.btnLengthAuto = New System.Windows.Forms.Button()
        Me.numLength = New System.Windows.Forms.NumericUpDown()
        Me.grpFile = New System.Windows.Forms.GroupBox()
        Me.pbxFileExistence = New System.Windows.Forms.PictureBox()
        Me.lblFileExistence = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.btnFileSet = New System.Windows.Forms.Button()
        Me.grpM3UFile = New System.Windows.Forms.GroupBox()
        Me.timerBrowseDelay = New System.Windows.Forms.Timer(Me.components)
        Me.ofdSelectFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveAs = New System.Windows.Forms.SaveFileDialog()
        CType(Me.splitContainerMain,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainerMain.Panel1.SuspendLayout
        Me.splitContainerMain.Panel2.SuspendLayout
        Me.splitContainerMain.SuspendLayout
        Me.grpCustomTimes.SuspendLayout
        CType(Me.numEndTime,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numStartTime,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpTrackInfo.SuspendLayout
        Me.grpLength.SuspendLayout
        CType(Me.numLength,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpFile.SuspendLayout
        CType(Me.pbxFileExistence,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpM3UFile.SuspendLayout
        Me.SuspendLayout
        '
        'lstFiles
        '
        Me.lstFiles.AllowColumnReorder = true
        Me.lstFiles.AllowDrop = true
        Me.lstFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colHeadFile, Me.colHeadLength, Me.colHeadTitle, Me.colHeadArtist, Me.colHeadStartTime, Me.colHeadEndTime})
        Me.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstFiles.FullRowSelect = true
        Me.lstFiles.GridLines = true
        Me.lstFiles.HideSelection = false
        Me.lstFiles.Location = New System.Drawing.Point(0, 0)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(455, 440)
        Me.lstFiles.TabIndex = 0
        Me.lstFiles.UseCompatibleStateImageBehavior = false
        Me.lstFiles.View = System.Windows.Forms.View.Details
        '
        'colHeadFile
        '
        Me.colHeadFile.Text = "File"
        Me.colHeadFile.Width = 134
        '
        'colHeadLength
        '
        Me.colHeadLength.Text = "Length"
        '
        'colHeadTitle
        '
        Me.colHeadTitle.Text = "Title"
        '
        'colHeadArtist
        '
        Me.colHeadArtist.Text = "Artist"
        '
        'colHeadStartTime
        '
        Me.colHeadStartTime.Text = "Start Time"
        '
        'colHeadEndTime
        '
        Me.colHeadEndTime.Text = "End Time"
        '
        'btnM3UBrowse
        '
        Me.btnM3UBrowse.Location = New System.Drawing.Point(6, 19)
        Me.btnM3UBrowse.Name = "btnM3UBrowse"
        Me.btnM3UBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnM3UBrowse.TabIndex = 0
        Me.btnM3UBrowse.Text = "Browse..."
        Me.btnM3UBrowse.UseVisualStyleBackColor = true
        '
        'txtM3UFile
        '
        Me.txtM3UFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtM3UFile.Location = New System.Drawing.Point(87, 21)
        Me.txtM3UFile.Name = "txtM3UFile"
        Me.txtM3UFile.ReadOnly = true
        Me.txtM3UFile.Size = New System.Drawing.Size(273, 20)
        Me.txtM3UFile.TabIndex = 1
        '
        'btnM3UEdit
        '
        Me.btnM3UEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnM3UEdit.Location = New System.Drawing.Point(366, 19)
        Me.btnM3UEdit.Name = "btnM3UEdit"
        Me.btnM3UEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnM3UEdit.TabIndex = 2
        Me.btnM3UEdit.Text = "Edit"
        Me.btnM3UEdit.UseVisualStyleBackColor = true
        '
        'splitContainerMain
        '
        Me.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainerMain.Location = New System.Drawing.Point(0, 0)
        Me.splitContainerMain.Name = "splitContainerMain"
        '
        'splitContainerMain.Panel1
        '
        Me.splitContainerMain.Panel1.Controls.Add(Me.lstFiles)
        '
        'splitContainerMain.Panel2
        '
        Me.splitContainerMain.Panel2.Controls.Add(Me.lblVersion)
        Me.splitContainerMain.Panel2.Controls.Add(Me.btnExit)
        Me.splitContainerMain.Panel2.Controls.Add(Me.btnMoveDown)
        Me.splitContainerMain.Panel2.Controls.Add(Me.btnMoveUp)
        Me.splitContainerMain.Panel2.Controls.Add(Me.btnRemove)
        Me.splitContainerMain.Panel2.Controls.Add(Me.btnAdd)
        Me.splitContainerMain.Panel2.Controls.Add(Me.grpCustomTimes)
        Me.splitContainerMain.Panel2.Controls.Add(Me.btnTestSelected)
        Me.splitContainerMain.Panel2.Controls.Add(Me.btnTest)
        Me.splitContainerMain.Panel2.Controls.Add(Me.btnSaveAs)
        Me.splitContainerMain.Panel2.Controls.Add(Me.btnSave)
        Me.splitContainerMain.Panel2.Controls.Add(Me.grpTrackInfo)
        Me.splitContainerMain.Panel2.Controls.Add(Me.grpLength)
        Me.splitContainerMain.Panel2.Controls.Add(Me.grpFile)
        Me.splitContainerMain.Panel2.Controls.Add(Me.grpM3UFile)
        Me.splitContainerMain.Panel2MinSize = 460
        Me.splitContainerMain.Size = New System.Drawing.Size(928, 440)
        Me.splitContainerMain.SplitterDistance = 455
        Me.splitContainerMain.TabIndex = 0
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = true
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblVersion.Location = New System.Drawing.Point(448, 431)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(21, 9)
        Me.lblVersion.TabIndex = 14
        Me.lblVersion.Text = "1.0.0"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(427, 380)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(34, 52)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMoveDown.Location = New System.Drawing.Point(3, 409)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(100, 23)
        Me.btnMoveDown.TabIndex = 6
        Me.btnMoveDown.Text = "Move Down"
        Me.btnMoveDown.UseVisualStyleBackColor = true
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMoveUp.Location = New System.Drawing.Point(3, 380)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(100, 23)
        Me.btnMoveUp.TabIndex = 5
        Me.btnMoveUp.Text = "Move Up"
        Me.btnMoveUp.UseVisualStyleBackColor = true
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRemove.Location = New System.Drawing.Point(109, 409)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 23)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "Remove Track(s)"
        Me.btnRemove.UseVisualStyleBackColor = true
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAdd.Location = New System.Drawing.Point(109, 380)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add Track"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'grpCustomTimes
        '
        Me.grpCustomTimes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpCustomTimes.Controls.Add(Me.btnEndTimeGet)
        Me.grpCustomTimes.Controls.Add(Me.btnStartEndSetLength)
        Me.grpCustomTimes.Controls.Add(Me.numEndTime)
        Me.grpCustomTimes.Controls.Add(Me.numStartTime)
        Me.grpCustomTimes.Controls.Add(Me.chkEndTime)
        Me.grpCustomTimes.Controls.Add(Me.chkStartTime)
        Me.grpCustomTimes.Controls.Add(Me.btnEndTimeConvert)
        Me.grpCustomTimes.Controls.Add(Me.btnStartTimeConvert)
        Me.grpCustomTimes.Location = New System.Drawing.Point(10, 268)
        Me.grpCustomTimes.Name = "grpCustomTimes"
        Me.grpCustomTimes.Size = New System.Drawing.Size(447, 106)
        Me.grpCustomTimes.TabIndex = 4
        Me.grpCustomTimes.TabStop = false
        Me.grpCustomTimes.Text = "Track Start/End Time"
        '
        'btnEndTimeGet
        '
        Me.btnEndTimeGet.Location = New System.Drawing.Point(53, 76)
        Me.btnEndTimeGet.Name = "btnEndTimeGet"
        Me.btnEndTimeGet.Size = New System.Drawing.Size(172, 23)
        Me.btnEndTimeGet.TabIndex = 6
        Me.btnEndTimeGet.Text = "Get End Time from Track Length"
        Me.btnEndTimeGet.UseVisualStyleBackColor = true
        '
        'btnStartEndSetLength
        '
        Me.btnStartEndSetLength.Location = New System.Drawing.Point(231, 76)
        Me.btnStartEndSetLength.Name = "btnStartEndSetLength"
        Me.btnStartEndSetLength.Size = New System.Drawing.Size(100, 23)
        Me.btnStartEndSetLength.TabIndex = 7
        Me.btnStartEndSetLength.Text = "Set Track Length"
        Me.btnStartEndSetLength.UseVisualStyleBackColor = true
        '
        'numEndTime
        '
        Me.numEndTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.numEndTime.Location = New System.Drawing.Point(53, 50)
        Me.numEndTime.Maximum = New Decimal(New Integer() {268435455, 1042612833, 542101086, 0})
        Me.numEndTime.Name = "numEndTime"
        Me.numEndTime.Size = New System.Drawing.Size(307, 20)
        Me.numEndTime.TabIndex = 4
        '
        'numStartTime
        '
        Me.numStartTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.numStartTime.Location = New System.Drawing.Point(53, 21)
        Me.numStartTime.Maximum = New Decimal(New Integer() {268435455, 1042612833, 542101086, 0})
        Me.numStartTime.Name = "numStartTime"
        Me.numStartTime.Size = New System.Drawing.Size(307, 20)
        Me.numStartTime.TabIndex = 1
        '
        'chkEndTime
        '
        Me.chkEndTime.Location = New System.Drawing.Point(6, 52)
        Me.chkEndTime.Name = "chkEndTime"
        Me.chkEndTime.Size = New System.Drawing.Size(51, 17)
        Me.chkEndTime.TabIndex = 3
        Me.chkEndTime.Text = "End:"
        Me.chkEndTime.UseVisualStyleBackColor = true
        '
        'chkStartTime
        '
        Me.chkStartTime.Location = New System.Drawing.Point(6, 23)
        Me.chkStartTime.Name = "chkStartTime"
        Me.chkStartTime.Size = New System.Drawing.Size(51, 17)
        Me.chkStartTime.TabIndex = 0
        Me.chkStartTime.Text = "Start:"
        Me.chkStartTime.UseVisualStyleBackColor = true
        '
        'btnEndTimeConvert
        '
        Me.btnEndTimeConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnEndTimeConvert.Location = New System.Drawing.Point(366, 48)
        Me.btnEndTimeConvert.Name = "btnEndTimeConvert"
        Me.btnEndTimeConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnEndTimeConvert.TabIndex = 5
        Me.btnEndTimeConvert.Text = "Convert..."
        Me.btnEndTimeConvert.UseVisualStyleBackColor = true
        '
        'btnStartTimeConvert
        '
        Me.btnStartTimeConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnStartTimeConvert.Location = New System.Drawing.Point(366, 19)
        Me.btnStartTimeConvert.Name = "btnStartTimeConvert"
        Me.btnStartTimeConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnStartTimeConvert.TabIndex = 2
        Me.btnStartTimeConvert.Text = "Convert..."
        Me.btnStartTimeConvert.UseVisualStyleBackColor = true
        '
        'btnTestSelected
        '
        Me.btnTestSelected.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnTestSelected.Location = New System.Drawing.Point(321, 409)
        Me.btnTestSelected.Name = "btnTestSelected"
        Me.btnTestSelected.Size = New System.Drawing.Size(100, 23)
        Me.btnTestSelected.TabIndex = 12
        Me.btnTestSelected.Text = "Test Selected"
        Me.btnTestSelected.UseVisualStyleBackColor = true
        '
        'btnTest
        '
        Me.btnTest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnTest.Location = New System.Drawing.Point(215, 409)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(100, 23)
        Me.btnTest.TabIndex = 10
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = true
        '
        'btnSaveAs
        '
        Me.btnSaveAs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaveAs.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSaveAs.Location = New System.Drawing.Point(321, 380)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(100, 23)
        Me.btnSaveAs.TabIndex = 11
        Me.btnSaveAs.Text = "Save As..."
        Me.btnSaveAs.UseVisualStyleBackColor = true
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Location = New System.Drawing.Point(215, 380)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'grpTrackInfo
        '
        Me.grpTrackInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpTrackInfo.Controls.Add(Me.lblArtist)
        Me.grpTrackInfo.Controls.Add(Me.txtArtist)
        Me.grpTrackInfo.Controls.Add(Me.txtTitle)
        Me.grpTrackInfo.Location = New System.Drawing.Point(10, 177)
        Me.grpTrackInfo.Name = "grpTrackInfo"
        Me.grpTrackInfo.Size = New System.Drawing.Size(447, 85)
        Me.grpTrackInfo.TabIndex = 3
        Me.grpTrackInfo.TabStop = false
        Me.grpTrackInfo.Text = "Track Title:"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = true
        Me.lblArtist.Location = New System.Drawing.Point(6, 42)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(33, 13)
        Me.lblArtist.TabIndex = 1
        Me.lblArtist.Text = "Artist:"
        '
        'txtArtist
        '
        Me.txtArtist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtArtist.Location = New System.Drawing.Point(6, 58)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(435, 20)
        Me.txtArtist.TabIndex = 2
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtTitle.Location = New System.Drawing.Point(6, 19)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(435, 20)
        Me.txtTitle.TabIndex = 0
        '
        'grpLength
        '
        Me.grpLength.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpLength.Controls.Add(Me.btnLengthConvert)
        Me.grpLength.Controls.Add(Me.btnLengthAuto)
        Me.grpLength.Controls.Add(Me.numLength)
        Me.grpLength.Location = New System.Drawing.Point(10, 122)
        Me.grpLength.Name = "grpLength"
        Me.grpLength.Size = New System.Drawing.Size(447, 49)
        Me.grpLength.TabIndex = 2
        Me.grpLength.TabStop = false
        Me.grpLength.Text = "Track Length"
        '
        'btnLengthConvert
        '
        Me.btnLengthConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnLengthConvert.Location = New System.Drawing.Point(366, 19)
        Me.btnLengthConvert.Name = "btnLengthConvert"
        Me.btnLengthConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnLengthConvert.TabIndex = 2
        Me.btnLengthConvert.Text = "Convert..."
        Me.btnLengthConvert.UseVisualStyleBackColor = true
        '
        'btnLengthAuto
        '
        Me.btnLengthAuto.Location = New System.Drawing.Point(6, 19)
        Me.btnLengthAuto.Name = "btnLengthAuto"
        Me.btnLengthAuto.Size = New System.Drawing.Size(80, 23)
        Me.btnLengthAuto.TabIndex = 0
        Me.btnLengthAuto.Text = "Get From File"
        Me.btnLengthAuto.UseVisualStyleBackColor = true
        '
        'numLength
        '
        Me.numLength.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.numLength.Location = New System.Drawing.Point(92, 21)
        Me.numLength.Maximum = New Decimal(New Integer() {268435455, 1042612833, 542101086, 0})
        Me.numLength.Name = "numLength"
        Me.numLength.Size = New System.Drawing.Size(268, 20)
        Me.numLength.TabIndex = 1
        '
        'grpFile
        '
        Me.grpFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpFile.Controls.Add(Me.pbxFileExistence)
        Me.grpFile.Controls.Add(Me.lblFileExistence)
        Me.grpFile.Controls.Add(Me.txtFile)
        Me.grpFile.Controls.Add(Me.btnFileSet)
        Me.grpFile.Location = New System.Drawing.Point(10, 67)
        Me.grpFile.Name = "grpFile"
        Me.grpFile.Size = New System.Drawing.Size(447, 49)
        Me.grpFile.TabIndex = 1
        Me.grpFile.TabStop = false
        Me.grpFile.Text = "Track File"
        '
        'pbxFileExistence
        '
        Me.pbxFileExistence.Location = New System.Drawing.Point(74, -1)
        Me.pbxFileExistence.Name = "pbxFileExistence"
        Me.pbxFileExistence.Size = New System.Drawing.Size(16, 16)
        Me.pbxFileExistence.TabIndex = 23
        Me.pbxFileExistence.TabStop = false
        '
        'lblFileExistence
        '
        Me.lblFileExistence.AutoSize = true
        Me.lblFileExistence.Location = New System.Drawing.Point(92, 0)
        Me.lblFileExistence.Name = "lblFileExistence"
        Me.lblFileExistence.Size = New System.Drawing.Size(0, 13)
        Me.lblFileExistence.TabIndex = 22
        '
        'txtFile
        '
        Me.txtFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtFile.Location = New System.Drawing.Point(6, 21)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(354, 20)
        Me.txtFile.TabIndex = 0
        '
        'btnFileSet
        '
        Me.btnFileSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnFileSet.Location = New System.Drawing.Point(366, 19)
        Me.btnFileSet.Name = "btnFileSet"
        Me.btnFileSet.Size = New System.Drawing.Size(75, 23)
        Me.btnFileSet.TabIndex = 1
        Me.btnFileSet.Text = "Set..."
        Me.btnFileSet.UseVisualStyleBackColor = true
        '
        'grpM3UFile
        '
        Me.grpM3UFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpM3UFile.Controls.Add(Me.btnM3UBrowse)
        Me.grpM3UFile.Controls.Add(Me.txtM3UFile)
        Me.grpM3UFile.Controls.Add(Me.btnM3UEdit)
        Me.grpM3UFile.Location = New System.Drawing.Point(10, 12)
        Me.grpM3UFile.Name = "grpM3UFile"
        Me.grpM3UFile.Size = New System.Drawing.Size(447, 49)
        Me.grpM3UFile.TabIndex = 0
        Me.grpM3UFile.TabStop = false
        Me.grpM3UFile.Text = "M3U File"
        '
        'timerBrowseDelay
        '
        Me.timerBrowseDelay.Interval = 50
        '
        'ofdSelectFile
        '
        Me.ofdSelectFile.DefaultExt = "m3u"
        Me.ofdSelectFile.Filter = "M3U Playlists|*.m3u|All Files|*.*"
        Me.ofdSelectFile.Title = "Select file to open"
        '
        'sfdSaveAs
        '
        Me.sfdSaveAs.DefaultExt = "m3u"
        Me.sfdSaveAs.Filter = "M3U Playlists|*.m3u|All Files|*.*"
        Me.sfdSaveAs.Title = "Select Save Location"
        '
        'M3UEdit
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(928, 440)
        Me.Controls.Add(Me.splitContainerMain)
        Me.Icon = Global.M3UEdit.Resources.M3UEdit
        Me.Name = "M3UEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "M3UEdit"
        Me.splitContainerMain.Panel1.ResumeLayout(false)
        Me.splitContainerMain.Panel2.ResumeLayout(false)
        Me.splitContainerMain.Panel2.PerformLayout
        CType(Me.splitContainerMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainerMain.ResumeLayout(false)
        Me.grpCustomTimes.ResumeLayout(false)
        CType(Me.numEndTime,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numStartTime,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpTrackInfo.ResumeLayout(false)
        Me.grpTrackInfo.PerformLayout
        Me.grpLength.ResumeLayout(false)
        CType(Me.numLength,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFile.ResumeLayout(false)
        Me.grpFile.PerformLayout
        CType(Me.pbxFileExistence,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpM3UFile.ResumeLayout(false)
        Me.grpM3UFile.PerformLayout
        Me.ResumeLayout(false)
    End Sub
    Private lblFileExistence As System.Windows.Forms.Label
    Private pbxFileExistence As System.Windows.Forms.PictureBox
    Private lblVersion As System.Windows.Forms.Label
    Private sfdSaveAs As System.Windows.Forms.SaveFileDialog
    Private ofdSelectFile As System.Windows.Forms.OpenFileDialog
    Private WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents btnStartEndSetLength As System.Windows.Forms.Button
    Private WithEvents btnEndTimeGet As System.Windows.Forms.Button
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents btnRemove As System.Windows.Forms.Button
    Private WithEvents btnMoveUp As System.Windows.Forms.Button
    Private WithEvents btnMoveDown As System.Windows.Forms.Button
    Private WithEvents timerBrowseDelay As System.Windows.Forms.Timer
    Private grpM3UFile As System.Windows.Forms.GroupBox
    Private WithEvents btnFileSet As System.Windows.Forms.Button
    Private WithEvents txtFile As System.Windows.Forms.TextBox
    Private grpFile As System.Windows.Forms.GroupBox
    Private WithEvents numLength As System.Windows.Forms.NumericUpDown
    Private WithEvents btnLengthAuto As System.Windows.Forms.Button
    Private WithEvents btnLengthConvert As System.Windows.Forms.Button
    Private grpLength As System.Windows.Forms.GroupBox
    Private WithEvents txtTitle As System.Windows.Forms.TextBox
    Private WithEvents txtArtist As System.Windows.Forms.TextBox
    Private lblArtist As System.Windows.Forms.Label
    Private grpTrackInfo As System.Windows.Forms.GroupBox
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnSaveAs As System.Windows.Forms.Button
    Private WithEvents btnTest As System.Windows.Forms.Button
    Private WithEvents btnTestSelected As System.Windows.Forms.Button
    Private WithEvents numStartTime As System.Windows.Forms.NumericUpDown
    Private WithEvents btnStartTimeConvert As System.Windows.Forms.Button
    Private WithEvents numEndTime As System.Windows.Forms.NumericUpDown
    Private WithEvents btnEndTimeConvert As System.Windows.Forms.Button
    Private WithEvents chkStartTime As System.Windows.Forms.CheckBox
    Private WithEvents chkEndTime As System.Windows.Forms.CheckBox
    Private grpCustomTimes As System.Windows.Forms.GroupBox
    Private colHeadEndTime As System.Windows.Forms.ColumnHeader
    Private colHeadStartTime As System.Windows.Forms.ColumnHeader
    Private colHeadArtist As System.Windows.Forms.ColumnHeader
    Private colHeadTitle As System.Windows.Forms.ColumnHeader
    Private colHeadLength As System.Windows.Forms.ColumnHeader
    Private colHeadFile As System.Windows.Forms.ColumnHeader
    Private splitContainerMain As System.Windows.Forms.SplitContainer
    Private WithEvents btnM3UEdit As System.Windows.Forms.Button
    Private txtM3UFile As System.Windows.Forms.TextBox
    Private WithEvents btnM3UBrowse As System.Windows.Forms.Button
    Private WithEvents lstFiles As System.Windows.Forms.ListView
End Class
