Public Partial Class PathEdit
    Public Sub New()
        Me.InitializeComponent()
    End Sub
    
    Function SetAndShow(ByRef filePath As String, currentDirectory As String) As Boolean
        txtCD.Text = currentDirectory
        
        txtOutput.Text = filePath
        
        If ShowDialog() = DialogResult.OK Then
            filePath = txtOutput.Text
            Return True
        Else
            Return False
        End If
    End Function
    
    Sub txtOutput_TextChanged() Handles txtOutput.TextChanged
        ' decode and set decoded text
    End Sub
    
    Sub btnURLEncode_Click() Handles btnURLEncode.Click
        ' encode txtDecoded to txtOutput
    End Sub
    
    Sub txtDecoded_TextChanged() Handles txtDecoded.TextChanged
        ' check for file existence and update label and pbx
    End Sub
    
    Sub optSetPathAbsolute_CheckedChanged() Handles optSetPathAbsolute.CheckedChanged
        btnBrowse.Enabled = True
    End Sub
    
    Sub optSetPathRelative_CheckedChanged() Handles optSetPathRelative.CheckedChanged
        btnBrowse.Enabled = True
        gbxSetPathRelative.Enabled = optSetPathRelative.Checked
    End Sub
    
    Sub btnBrowse_Click() Handles btnBrowse.Click
        ofdSelectFile.FileName = txtDecoded.Text
        ofdSelectFile.InitialDirectory = txtCD.Text
        
        If ofdSelectFile.ShowDialog() = DialogResult.OK Then
            If optSetPathAbsolute.Checked Then
                txtOutput.Text = ofdSelectFile.FileName
            ElseIf optSetPathRelativeContained.Checked
                txtOutput.Text = ofdSelectFile.FileName.Substring(txtCD.Text.Length + 1)
            ElseIf optSetPathRelativeExternal.Checked
                txtOutput.Text = ".."
                Dim scanText As String
                Try
                    scanText = txtCD.Text.Substring( ofdSelectFile.FileName.Replace("/", "\").LastIndexOf("\") +1 ).Replace("/", "\")
                    If scanText.Contains("\") Then
                        For Each character As Char In scanText
                            If character = "\" Then
                                txtOutput.Text &= "\.."
                            End If
                        Next
                    End If
                Catch
                End Try
                
                txtOutput.Text &= ofdSelectFile.FileName.Substring( ofdSelectFile.FileName.Replace("/", "\").LastIndexOf("\") )
            Else
                MsgBox("Please select an option!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
End Class
