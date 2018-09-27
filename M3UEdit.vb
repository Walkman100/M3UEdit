Option Explicit On
Option Strict On
Option Compare Binary
Option Infer On

Public Partial Class M3UEdit
    Public Sub New()
        Me.InitializeComponent()
    End Sub
    
    Sub M3UEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        
    End Sub
    
    Sub timerBrowseDelay_Tick(sender As Object, e As EventArgs) Handles timerBrowseDelay.Tick
        
    End Sub
    
    Sub btnM3UBrowse_Click(sender As Object, e As EventArgs) Handles btnM3UBrowse.Click
        
    End Sub
    
    Sub btnM3UEdit_Click(sender As Object, e As EventArgs) Handles btnM3UEdit.Click
        
    End Sub
    
    Sub PopulateEditSection() Handles lstFiles.SelectedIndexChanged
        
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
        
    End Sub
    
    Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnMoveDown.Click
        
    End Sub
    
    Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        
    End Sub
    
    Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        
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
