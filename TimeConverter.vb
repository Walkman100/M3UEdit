Option Explicit On
Option Strict On
Option Compare Binary
Option Infer On

Public Class TimeConverter
    Sub txtIn_TextChanged() Handles txtIn.TextChanged
        Dim txtInTextSplit = txtIn.Text.Split({":"}, StringSplitOptions.None)
        
        Select Case txtInTextSplit.Length
            Case 1
                txtSeconds.Text = txtInTextSplit(0)
                txtMinutes.Text = ""
                txtHours.Text = ""
            Case 2
                txtSeconds.Text = txtInTextSplit(1)
                txtMinutes.Text = txtInTextSplit(0)
                txtHours.Text = ""
            Case Else
                txtSeconds.Text = txtInTextSplit(txtInTextSplit.Length - 1)
                txtMinutes.Text = txtInTextSplit(txtInTextSplit.Length - 2)
                txtHours.Text = txtInTextSplit(txtInTextSplit.Length - 3)
        End Select
        
        Dim tmpOutNumber As Integer = 0
        
        If IsNumeric(txtSeconds.Text) Then
            txtSeconds.BackColor = System.Drawing.SystemColors.Control
            tmpOutNumber = Integer.Parse(txtSeconds.Text)
        Else
            txtSeconds.BackColor = System.Drawing.Color.MistyRose
        End If
        
        If txtMinutes.Text = "" Then
            txtMinutes.BackColor = Drawing.SystemColors.Control
        ElseIf IsNumeric(txtMinutes.Text) Then
            txtMinutes.BackColor = Drawing.SystemColors.Control
            tmpOutNumber += Integer.Parse(txtMinutes.Text) * 60
        Else
            txtMinutes.BackColor = Color.MistyRose
        End If
        
        If txtHours.Text = "" Then
            txtHours.BackColor = SystemColors.Control
        ElseIf IsNumeric(txtHours.Text) Then
            txtHours.BackColor = SystemColors.Control
            tmpOutNumber += Integer.Parse(txtHours.Text) * 3600
        Else
            txtHours.BackColor = Color.MistyRose
        End If
        
        txtOut.Text = tmpOutNumber.ToString
    End Sub

    Sub btnAutoConvert_Click() Handles btnAutoConvert.Click
        Try
            txtIn.Text = Clipboard.GetText
        Catch ex As Exception
            MsgBox("Error getting clipboard text: " & ex.Message)
            Exit Sub
        End Try
        Me.DialogResult = DialogResult.OK
    End Sub
    
    Function SetAndShow(ByRef seconds As Integer) As Boolean
        txtIn.Text = ""
        
        Dim tmpTxtInText = ""
        
        If seconds > 3600 Then
            tmpTxtInText = (seconds \ 3600).ToString & ":"  ' \ is / but floor the result
            seconds = seconds - ((seconds \ 3600) * 3600)
        End If
        
        If seconds > 60 Then
            tmpTxtInText &= (seconds \ 60).ToString & ":"
            seconds = seconds - ((seconds \ 60) * 60)
            
        ElseIf tmpTxtInText <> "" ' we have hours but not minutes
            tmpTxtInText &= "0:"
        End If
        
        tmpTxtInText &= seconds.ToString
        
        txtIn.Text = tmpTxtInText
        
        If ShowDialog() = DialogResult.OK Then
            seconds = Integer.Parse(txtOut.Text)
            Return True
        Else
            Return False
        End If
    End Function
End Class
