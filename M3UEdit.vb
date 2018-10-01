Option Explicit On
Option Strict On
Option Compare Binary
Option Infer On

Imports System.IO.File
Imports System.Runtime.CompilerServices

Public Partial Class M3UEdit
    Public Sub New()
        Me.InitializeComponent()
        lstFiles.DoubleBuffered(True)
    End Sub
    
    ' ======================= Loading File (UI stuff) =======================
    
    Sub M3UEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each s As String In My.Application.CommandLineArgs
            If txtM3UFile.Text = "" Then
                txtM3UFile.Text = s
            Else
                Process.Start(Application.StartupPath & "\" & Process.GetCurrentProcess.ProcessName & ".exe", """" & s & """")
            End If
        Next
        
        timerBrowseDelay.Start
    End Sub
    
    Sub timerBrowseDelay_Tick(sender As Object, e As EventArgs) Handles timerBrowseDelay.Tick
        timerBrowseDelay.Stop
        PopulateEditSection()
        chkStartTime_CheckedChanged() ' safe because nothing can be selected yet
        chkEndTime_CheckedChanged()
        
        btnM3UEdit_Click() ' set textbox to editable
        
        If txtM3UFile.Text = "" Then
            If ofdSelectFile.ShowDialog() = DialogResult.OK Then
                txtM3UFile.Text = ofdSelectFile.FileName
                
                btnM3UEdit_Click() ' set textbox to readonly and load file
            End If
        Else
            btnM3UEdit_Click() ' set textbox to readonly and load file
        End If
    End Sub
    
    Sub btnM3UBrowse_Click(sender As Object, e As EventArgs) Handles btnM3UBrowse.Click
        ofdSelectFile.FileName = txtM3UFile.Text
        
        If ofdSelectFile.ShowDialog() = DialogResult.OK Then
            txtM3UFile.ReadOnly = True
            btnM3UEdit.Text = "Edit"
            btnSave.Enabled = True
            btnTest.Enabled = True
            
            txtM3UFile.Text = ofdSelectFile.FileName
            
            LoadFile(ofdSelectFile.FileName)
        End If
    End Sub
    
    Sub btnM3UEdit_Click() Handles btnM3UEdit.Click
        If btnM3UEdit.Text = "Edit" Then
            txtM3UFile.ReadOnly = False
            btnM3UEdit.Text = "Load"
            btnSave.Enabled = False
            btnTest.Enabled = False
            
        ElseIf btnM3UEdit.Text = "Load"
            If Exists(txtM3UFile.Text) Then
                txtM3UFile.ReadOnly = True
                btnM3UEdit.Text = "Edit"
                btnSave.Enabled = True
                btnTest.Enabled = True
                
                LoadFile(txtM3UFile.Text)
            Else
                MsgBox("File Not Found!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    
    ' ======================= Actual Load File =======================
    
    Sub LoadFile(path As String)
        If Exists(path) Then
            lstFiles.Sorting = SortOrder.None
            lstFiles.Items.Clear()
            
            Dim tmpListViewItem As New ListViewItem(New String() {"", "", "", "", "", ""})
            
            For Each line As String In ReadAllLines(path)
                If line = "#EXTM3U" Then
                    Continue For ' ignore M3U header
                ElseIf line.StartsWith("#EXTINF:", True, Nothing) '<length>,Artist - Title
                    ' check for existing info
                    If tmpListViewItem.SubItems.Item(1).Text <> "" Or tmpListViewItem.SubItems.Item(2).Text <> "" Or tmpListViewItem.SubItems.Item(3).Text <> "" Then
                        Dim msgBoxPrompt = "Duplicate info detected! Load new line:" & vbNewLine & vbNewLine & line & vbNewLine & vbNewLine & "over old information:" & vbNewLine & _
                            "Length: " & tmpListViewItem.SubItems.Item(1).Text & vbNewLine & "Track: " & tmpListViewItem.SubItems.Item(2).Text & vbNewLine & "Artist: " & tmpListViewItem.SubItems.Item(3).Text
                        
                        Select Case MsgBox(msgBoxPrompt, MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNoCancel)
                            Case MsgBoxResult.No
                                Continue For
                            Case MsgBoxResult.Cancel
                                Exit For
                        End Select
                    End If
                    
                    line = line.Substring(8) ' clear line start
                    
                    If line.Contains(",") Then
                        ' set length
                        tmpListViewItem.SubItems.Item(1).Text = line.Remove(line.IndexOf(","))
                        
                        ' remove length from string
                        line = line.Substring(line.IndexOf(",") +1)
                        
                        ' check for artist
                        If line.Contains(" - ") Then
                            ' set artist
                            tmpListViewItem.SubItems.Item(3).Text = line.Remove( line.IndexOf("-") ).Trim()
                            ' set title
                            tmpListViewItem.SubItems.Item(2).Text = line.Substring( line.IndexOf("-") +1 ).Trim()
                            
                        Else
                            ' no artist, just set title
                            tmpListViewItem.SubItems.Item(2).Text = line
                        End If
                        
                        ' use Decimal.TryParse instead of IsNumeric  to allow "." in cultures that use "," as decimal point
                    ElseIf Decimal.TryParse(line, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, Nothing) Then ' set length
                        tmpListViewItem.SubItems.Item(1).Text = line
                        
                    ElseIf line.Contains(" - ") Then ' check for artist
                        ' set artist
                        tmpListViewItem.SubItems.Item(3).Text = line.Remove( line.IndexOf("-") ).Trim()
                        ' set title
                        tmpListViewItem.SubItems.Item(2).Text = line.Substring( line.IndexOf("-") +1 ).Trim()
                        
                    Else ' no artist, just set title
                        tmpListViewItem.SubItems.Item(2).Text = line
                    End If
                    
                    
                ElseIf line.StartsWith("#EXTVLCOPT:start-time=", True, Nothing) ' #EXTVLCOPT:start-time=<starttime>
                    line = line.Substring(22) ' clear line start and start time label
                    
                    ' check for existing info
                    If tmpListViewItem.SubItems.Item(4).Text <> "" Then
                        Select Case MsgBox("Duplicate start time detected! Load new time """ & line & """ over old time """ & tmpListViewItem.SubItems.Item(4).Text & """?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNoCancel)
                            Case MsgBoxResult.No
                                Continue For
                            Case MsgBoxResult.Cancel
                                Exit For
                        End Select
                    End If
                    
                    ' use Decimal.TryParse to allow "." in cultures that use "," as decimal point
                    If Decimal.TryParse(line, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, Nothing) Then
                        
                        tmpListViewItem.SubItems.Item(4).Text = line
                    Else
                        MsgBox("Invalid start time detected: """ & line & """", MsgBoxStyle.Exclamation)
                    End If
                    
                ElseIf line.StartsWith("#EXTVLCOPT:stop-time=") ' #EXTVLCOPT:stop-time=<stoptime>
                    line = line.Substring(21) ' clear line start and end time label
                    
                    ' check for existing info
                    If tmpListViewItem.SubItems.Item(5).Text <> "" Then
                        Select Case MsgBox("Duplicate end time detected! Load new time """ & line & """ over old time """ & tmpListViewItem.SubItems.Item(4).Text & """?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNoCancel)
                            Case MsgBoxResult.No
                                Continue For
                            Case MsgBoxResult.Cancel
                                Exit For
                        End Select
                    End If
                    
                    ' use Decimal.TryParse to allow "." in cultures that use "," as decimal point
                    If Decimal.TryParse(line, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, Nothing) Then
                        
                        tmpListViewItem.SubItems.Item(5).Text = line
                    Else
                        MsgBox("Invalid end time detected: """ & line & """", MsgBoxStyle.Exclamation)
                    End If
                    
                Else ' file path
                    tmpListViewItem.Text = line
                    
                    lstFiles.Items.Add(tmpListViewItem)
                    
                    ' done adding item, clear values
                    tmpListViewItem = New ListViewItem(New String() {"", "", "", "", "", ""})
                End If
            Next
            
            lstFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            PopulateEditSection()
        Else
            MsgBox("""" & path & """ not found!", MsgBoxStyle.Exclamation)
        End If
    End Sub
    
    ' ======================= Save File =======================
    
    Sub SaveFile(path As String)
        Using writer As IO.StreamWriter = New IO.StreamWriter(path, False, System.Text.Encoding.UTF8)
            writer.WriteLine("#EXTM3U")
            
            For Each trackItem As ListViewItem In lstFiles.Items
                If trackItem.SubItems.Item(1).Text <> "" Or trackItem.SubItems.Item(2).Text <> "" Or trackItem.SubItems.Item(3).Text <> "" Then
                    writer.Write("#EXTINF:")
                End If
                
                '<length>,Artist - Title
                If trackItem.SubItems.Item(1).Text <> "" Then
                    writer.Write(trackItem.SubItems.Item(1).Text)
                Else
                    writer.Write(0)
                End If
                
                If trackItem.SubItems.Item(2).Text <> "" Or trackItem.SubItems.Item(3).Text <> "" Then
                    writer.Write(",")
                    
                    If trackItem.SubItems.Item(3).Text <> "" Then
                        writer.Write(trackItem.SubItems.Item(3).Text)
                        writer.Write(" - ")
                    End If
                    
                    writer.WriteLine(trackItem.SubItems.Item(2).Text)
                End If
                
                ' start time
                If trackItem.SubItems.Item(4).Text <> "" Then
                    writer.WriteLine("#EXTVLCOPT:start-time=" & trackItem.SubItems.Item(4).Text)
                End If
                ' stop time
                If trackItem.SubItems.Item(5).Text <> "" Then
                    writer.WriteLine("#EXTVLCOPT:stop-time=" & trackItem.SubItems.Item(5).Text)
                End If
                
                ' file
                writer.WriteLine(trackItem.Text)
            Next
        End Using
    End Sub
    
    ' ======================= Loading a track into edit section =======================
    
    Sub PopulateEditSection() Handles lstFiles.SelectedIndexChanged
        If lstFiles.SelectedItems.Count = 0 Then
            grpFile.Enabled = False
            txtFile.Text = ""
            
            grpLength.Enabled = False
            numLength.Value = 0
            
            grpTrackInfo.Enabled = False
            txtTitle.Text = ""
            txtArtist.Text = ""
            
            grpCustomTimes.Enabled = False
            chkStartTime.Checked = False
            numStartTime.Value = 0
            chkEndTime.Checked = False
            numEndTime.Value = 0
            
            btnMoveUp.Enabled = False
            btnMoveDown.Enabled = False
            btnRemove.Enabled = False
            btnTestSelected.Enabled = False
        Else
            grpFile.Enabled = True
            txtFile.Text = lstFiles.SelectedItems(0).Text
            
            grpLength.Enabled = True
            Decimal.TryParse(lstFiles.SelectedItems(0).SubItems.Item(1).Text, Globalization.NumberStyles.Any, _
              Globalization.CultureInfo.InvariantCulture, numLength.Value) ' result is ByRef, so TryParse updates it if it can
            
            grpTrackInfo.Enabled = True
            If Not IsNothing(lstFiles.SelectedItems(0).SubItems.Item(2).Text) Then
                txtTitle.Text = lstFiles.SelectedItems(0).SubItems.Item(2).Text
            End If
            If Not IsNothing(lstFiles.SelectedItems(0).SubItems.Item(3).Text) Then
                txtArtist.Text = lstFiles.SelectedItems(0).SubItems.Item(3).Text
            End If
            
            grpCustomTimes.Enabled = True
            If Decimal.TryParse(lstFiles.SelectedItems(0).SubItems.Item(4).Text, Globalization.NumberStyles.Any, _
              Globalization.CultureInfo.InvariantCulture, numStartTime.Value) Then ' result is ByRef, so TryParse updates it if it can
                chkStartTime.Checked = True
            Else
                chkStartTime.Checked = False
            End If
            If Decimal.TryParse(lstFiles.SelectedItems(0).SubItems.Item(5).Text, Globalization.NumberStyles.Any, _
              Globalization.CultureInfo.InvariantCulture, numEndTime.Value) Then ' result is ByRef, so TryParse updates it if it can
                chkEndTime.Checked = True
            Else
                chkEndTime.Checked = False
            End If
            
            numStartTime.Enabled = chkStartTime.Checked
            btnStartTimeConvert.Enabled = chkStartTime.Checked
            numEndTime.Enabled = chkEndTime.Checked
            btnEndTimeConvert.Enabled = chkEndTime.Checked
            btnEndTimeGet.Enabled = chkStartTime.Checked
            btnStartEndSetLength.Enabled = (chkStartTime.Checked And chkEndTime.Checked)
            
            btnMoveUp.Enabled = True
            btnMoveDown.Enabled = True
            btnRemove.Enabled = True
            btnTestSelected.Enabled = True
        End If
    End Sub
    
    Sub lstFiles_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstFiles.ColumnClick
        If e.Column = 0 Then
            lstFiles.BeginUpdate()
            lstFiles.Sorting = DirectCast(IIf(lstFiles.Sorting = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending), SortOrder)
            lstFiles.EndUpdate()
        Else
            'lstFiles.Sort(e.Column)
        End If
    End Sub
    
    ' ======================= Editing Track Properties =======================
    
    '  Track File
    Sub txtFile_TextChanged() Handles txtFile.TextChanged
        If lstFiles.SelectedItems.Count <> 0 Then
            lstFiles.SelectedItems(0).Text = txtFile.Text
        End If
    End Sub
    
    Sub btnFileSet_Click(sender As Object, e As EventArgs) Handles btnFileSet.Click
        Throw New NotImplementedException
    End Sub
    
    '  Track Length
    Sub btnLengthAuto_Click(sender As Object, e As EventArgs) Handles btnLengthAuto.Click
        Throw New NotImplementedException
    End Sub
    
    Sub numLength_ValueChanged(sender As Object, e As EventArgs) Handles numLength.ValueChanged
        If lstFiles.SelectedItems.Count <> 0 Then
            lstFiles.SelectedItems(0).SubItems.Item(1).Text = numLength.Value.ToString
        End If
    End Sub
    
    Sub btnLengthConvert_Click(sender As Object, e As EventArgs) Handles btnLengthConvert.Click
        Dim returnSeconds As Integer = Decimal.ToInt32(numLength.Value)
        If TimeConverter.SetAndShow(returnSeconds) Then
            numLength.Value = returnSeconds
        End If
    End Sub
    
    '  Track Info
    Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        If lstFiles.SelectedItems.Count <> 0 Then
            lstFiles.SelectedItems(0).SubItems.Item(2).Text = txtTitle.Text
        End If
    End Sub
    
    Sub txtArtist_TextChanged(sender As Object, e As EventArgs) Handles txtArtist.TextChanged
        If lstFiles.SelectedItems.Count <> 0 Then
            lstFiles.SelectedItems(0).SubItems.Item(3).Text = txtArtist.Text
        End If
    End Sub
    
    '  Track Custom Times
    Sub chkStartTime_CheckedChanged() Handles chkStartTime.Click ' use Click else selecting different items erases them because the checkbox is unchecked
        numStartTime.Enabled = chkStartTime.Checked
        btnStartTimeConvert.Enabled = chkStartTime.Checked
        
        btnEndTimeGet.Enabled = chkStartTime.Checked
        btnStartEndSetLength.Enabled = (chkStartTime.Checked And chkEndTime.Checked)
        
        If lstFiles.SelectedItems.Count <> 0 Then
            If chkStartTime.Checked Then
                lstFiles.SelectedItems(0).SubItems.Item(4).Text = numStartTime.Value.ToString()
            Else
                lstFiles.SelectedItems(0).SubItems.Item(4).Text = ""
            End If
        End If
    End Sub
    
    Sub numStartTime_ValueChanged(sender As Object, e As EventArgs) Handles numStartTime.ValueChanged
        If lstFiles.SelectedItems.Count <> 0 Then
            lstFiles.SelectedItems(0).SubItems.Item(4).Text = numStartTime.Value.ToString()
        End If
    End Sub
    
    Sub btnStartTimeConvert_Click(sender As Object, e As EventArgs) Handles btnStartTimeConvert.Click
        Dim returnSeconds As Integer = Decimal.ToInt32(numStartTime.Value)
        If TimeConverter.SetAndShow(returnSeconds) Then
            numStartTime.Value = returnSeconds
        End If
    End Sub
    
    Sub chkEndTime_CheckedChanged() Handles chkEndTime.Click ' use Click for same reason as above
        numEndTime.Enabled = chkEndTime.Checked
        btnEndTimeConvert.Enabled = chkEndTime.Checked
        
        btnStartEndSetLength.Enabled = (chkStartTime.Checked And chkEndTime.Checked)
        
        If lstFiles.SelectedItems.Count <> 0 Then
            If chkEndTime.Checked Then
                lstFiles.SelectedItems(0).SubItems.Item(5).Text = numEndTime.Value.ToString()
            Else
                lstFiles.SelectedItems(0).SubItems.Item(5).Text = ""
            End If
        End If
    End Sub
    
    Sub numEndTime_ValueChanged(sender As Object, e As EventArgs) Handles numEndTime.ValueChanged
        If lstFiles.SelectedItems.Count <> 0 Then
            lstFiles.SelectedItems(0).SubItems.Item(5).Text = numEndTime.Value.ToString()
        End If
    End Sub
    
    Sub btnEndTimeConvert_Click(sender As Object, e As EventArgs) Handles btnEndTimeConvert.Click
        Dim returnSeconds As Integer = Decimal.ToInt32(numEndTime.Value)
        If TimeConverter.SetAndShow(returnSeconds) Then
            numEndTime.Value = returnSeconds
        End If
    End Sub
    
    Sub btnEndTimeGet_Click(sender As Object, e As EventArgs) Handles btnEndTimeGet.Click
        chkEndTime.Checked = True
        numEndTime.Value = 0 ' clear possibly existing value, so that the ValueChanged event is fired if value is the same
        numEndTime.Value = numStartTime.Value + numLength.Value
        PopulateEditSection()
    End Sub
    
    Sub btnStartEndSetLength_Click(sender As Object, e As EventArgs) Handles btnStartEndSetLength.Click
        If numEndTime.Value - numStartTime.Value < 0 Then
            MsgBox("Cannot set length to a negative value!", MsgBoxStyle.Exclamation)
        Else
            numLength.Value = numEndTime.Value - numStartTime.Value
            PopulateEditSection()
        End If
    End Sub
    
    ' ======================= Standalone Buttons =======================
    
    Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click
        Try
            If lstFiles.SelectedItems.Count > 0 Then
                lstFiles.Sorting = SortOrder.None
                Dim selected As ListViewItem = lstFiles.SelectedItems(0)
                Dim selectedIndex As Integer = selected.Index
                Dim totalItems As Integer = lstFiles.Items.Count
                
                lstFiles.BeginUpdate()
                If selectedIndex = 0 Then
                    lstFiles.Items.Remove(selected)
                    lstFiles.Items.Insert(totalItems - 1, selected)
                Else
                    lstFiles.Items.Remove(selected)
                    lstFiles.Items.Insert(selectedIndex - 1, selected)
                End If
                lstFiles.EndUpdate()
                
                PopulateEditSection()
            Else
                btnMoveUp.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("There was an error moving the item: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    
    Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnMoveDown.Click
        Try
            If lstFiles.SelectedItems.Count > 0 Then
                lstFiles.Sorting = SortOrder.None
                Dim selected As ListViewItem = lstFiles.SelectedItems(0)
                Dim selectedIndex As Integer = selected.Index
                Dim totalItems As Integer = lstFiles.Items.Count
                
                lstFiles.BeginUpdate()
                If selectedIndex = totalItems - 1 Then
                    lstFiles.Items.Remove(selected)
                    lstFiles.Items.Insert(0, selected)
                Else
                    lstFiles.Items.Remove(selected)
                    lstFiles.Items.Insert(selectedIndex + 1, selected)
                End If
                lstFiles.EndUpdate()
                
                PopulateEditSection()
            Else
                btnMoveDown.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("There was an error moving the item: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    
    Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim tmpListViewItem As New ListViewItem(New String() {"", "", "", "", "", ""})
        lstFiles.Items.Add(tmpListViewItem).Selected = True
        tmpListViewItem.Focused = True
        
        PopulateEditSection()
    End Sub
    
    Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstFiles.SelectedItems.Count > 1 Then
            For Each item As ListViewItem In lstFiles.SelectedItems
                item.Remove
            Next
        Else
            lstFiles.SelectedItems(0).Remove
        End If
        PopulateEditSection()
    End Sub
    
    Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Process.Start(txtM3UFile.Text)
    End Sub
    
    Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveFile(txtM3UFile.Text)
    End Sub
    
    Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click
        sfdSaveAs.FileName = txtM3UFile.Text
        
        If sfdSaveAs.ShowDialog() = DialogResult.OK Then
            SaveFile(sfdSaveAs.FileName)
            
            If MsgBox("Read new file?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                txtM3UFile.ReadOnly = True
                btnM3UEdit.Text = "Edit"
                btnSave.Enabled = True
                btnTest.Enabled = True
                
                txtM3UFile.Text = sfdSaveAs.FileName
            End If
        End If
    End Sub
    
    Sub btnTestSelected_Click(sender As Object, e As EventArgs) Handles btnTestSelected.Click
        Throw New NotImplementedException
    End Sub
    
    Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class

Module ControlExtensions ' thanks to https://stackoverflow.com/a/15268338/2999220
    <Extension()>
    Public Sub DoubleBuffered(control As Control, enable As Boolean)
        Dim doubleBufferPropertyInfo = control.[GetType]().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
        doubleBufferPropertyInfo.SetValue(control, enable, Nothing)
    End Sub
End Module
