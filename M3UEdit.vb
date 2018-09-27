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
        
        If txtM3UFile.Text = "" Then
            If ofdSelectFile.ShowDialog() = DialogResult.OK Then
                txtM3UFile.Text = ofdSelectFile.FileName
                
                'LoadFile()
            End If
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
            
            'LoadFile()
        End If
    End Sub
    
    Sub btnM3UEdit_Click(sender As Object, e As EventArgs) Handles btnM3UEdit.Click
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
                
                'LoadFile()
            Else
                MsgBox("File Not Found!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    
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
            If IsNumeric(lstFiles.SelectedItems(0).SubItems.Item(1).Text) Then
                numLength.Value = CType(lstFiles.SelectedItems(0).SubItems.Item(1).Text, Decimal)
            End If
            
            grpTrackInfo.Enabled = True
            If Not IsNothing(lstFiles.SelectedItems(0).SubItems.Item(2).Text) Then
                txtTitle.Text = lstFiles.SelectedItems(0).SubItems.Item(2).Text
            End If
            If Not IsNothing(lstFiles.SelectedItems(0).SubItems.Item(3).Text) Then
                txtArtist.Text = lstFiles.SelectedItems(0).SubItems.Item(3).Text
            End If
            
            grpCustomTimes.Enabled = True
            If IsNumeric(lstFiles.SelectedItems(0).SubItems.Item(4).Text) Then
                chkStartTime.Checked = True
                numStartTime.Value = CType(lstFiles.SelectedItems(0).SubItems.Item(4).Text, Decimal)
            Else
                chkStartTime.Checked = False
            End If
            If IsNumeric(lstFiles.SelectedItems(0).SubItems.Item(5).Text) Then
                chkEndTime.Checked = True
                numEndTime.Value = CType(lstFiles.SelectedItems(0).SubItems.Item(5).Text, Decimal)
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
            lstFiles.Sorting = DirectCast(IIf(lstFiles.Sorting = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending), SortOrder)
        Else
            'lstFiles.Sort(e.Column)
        End If
    End Sub
    
    ' ======================= Editing Track Properties =======================
    
    '  Track File
    Sub btnFileSet_Click(sender As Object, e As EventArgs) Handles btnFileSet.Click
        
    End Sub
    
    '  Track Length
    Sub btnLengthAuto_Click(sender As Object, e As EventArgs) Handles btnLengthAuto.Click
        
    End Sub
    
    Sub numLength_ValueChanged(sender As Object, e As EventArgs) Handles numLength.ValueChanged
        
    End Sub
    
    Sub btnLengthConvert_Click(sender As Object, e As EventArgs) Handles btnLengthConvert.Click
        
    End Sub
    
    '  Track Info
    Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        
    End Sub
    
    Sub txtArtist_TextChanged(sender As Object, e As EventArgs) Handles txtArtist.TextChanged
        
    End Sub
    
    '  Track Custom Times
    Sub chkStartTime_CheckedChanged() Handles chkStartTime.CheckedChanged
        
    End Sub
    
    Sub numStartTime_ValueChanged(sender As Object, e As EventArgs) Handles numStartTime.ValueChanged
        
    End Sub
    
    Sub btnStartTimeConvert_Click(sender As Object, e As EventArgs) Handles btnStartTimeConvert.Click
        
    End Sub
    
    Sub chkEndTime_CheckedChanged() Handles chkEndTime.CheckedChanged
        
    End Sub
    
    Sub numEndTime_ValueChanged(sender As Object, e As EventArgs) Handles numEndTime.ValueChanged
        
    End Sub
    
    Sub btnEndTimeConvert_Click(sender As Object, e As EventArgs) Handles btnEndTimeConvert.Click
        
    End Sub
    
    Sub btnEndTimeGet_Click(sender As Object, e As EventArgs) Handles btnEndTimeGet.Click
        
    End Sub
    
    Sub btnStartEndSetLength_Click(sender As Object, e As EventArgs) Handles btnStartEndSetLength.Click
        
    End Sub
    
    '  Standalone Buttons
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
        'SaveFile(txtM3UFile.Text)
    End Sub
    
    Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click
        sfdSaveAs.FileName = txtM3UFile.Text
        
        If sfdSaveAs.ShowDialog() = DialogResult.OK Then
            'SaveFile(sfdSaveAs.FileName)
        End If
    End Sub
    
    Sub btnTestSelected_Click(sender As Object, e As EventArgs) Handles btnTestSelected.Click
        
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
