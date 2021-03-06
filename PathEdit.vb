﻿Option Explicit On
Option Strict On
Option Compare Binary
Option Infer On

Imports System.IO

Public Partial Class PathEdit
    Public Sub New()
        Me.InitializeComponent()
    End Sub
    
    Function SetAndShow(ByRef filePath As String, currentDirectory As String) As Boolean
        txtCD.Text = currentDirectory
        
        txtOutput.Text = filePath
        
        If Settings.optSetPathNone.Checked Then
            optSetPathAbsolute.Checked = False
            optSetPathRelative.Checked = False
            btnBrowse.Enabled = False
        ElseIf Settings.optSetPathAbsolute.Checked
            optSetPathAbsolute.Checked = True
        ElseIf Settings.optSetPathRelativeContained.Checked
            optSetPathRelative.Checked = True
            optSetPathRelativeContained.Checked = True
        ElseIf Settings.optSetPathRelativeExternal.Checked
            optSetPathRelative.Checked = True
            optSetPathRelativeExternal.Checked = True
        End If
        
        If ShowDialog() = DialogResult.OK Then
            filePath = txtOutput.Text
            Return True
        Else
            Return False
        End If
    End Function
    
    Sub txtOutput_TextChanged() Handles txtOutput.TextChanged
        txtDecoded.Text = Uri.UnescapeDataString(txtOutput.Text)
        If txtOutput.Text.Contains("#") Then
            lblOutputWarning.Text = "Warning! Output text contains a # - anything after this character will be ignored by VLC"
        Else
            lblOutputWarning.Text = ""
        End If
    End Sub
    
    Sub btnURLEncode_Click() Handles btnURLEncode.Click
        ' Uri.EscapeDataString replaces :, /, \ too, but
        ' Uri.EscapeUriString only replaces space and \
        '  Need to convert specifically #, so use EscapeDataString then convert %2F (/) and %5C (\) to /
        txtOutput.Text = Uri.EscapeDataString(txtDecoded.Text)
        txtOutput.Text = txtOutput.Text.Replace("%2F", "/").Replace("%5C", "/").Replace("%3A", ":")
    End Sub
    
    Sub txtDecoded_TextChanged() Handles txtDecoded.TextChanged
        If File.Exists(txtDecoded.Text) Then
            lblFileExistence.Text = "File Exists"
            pbxFileExistence.Image = Resources.accept
        Else
            lblFileExistence.Text = "File Doesn't Exist"
            pbxFileExistence.Image = Resources.warning
        End If
    End Sub
    
    Sub optSetPathAbsolute_CheckedChanged() Handles optSetPathAbsolute.CheckedChanged
        btnBrowse.Enabled = True
    End Sub
    Sub optSetPathRelative_CheckedChanged() Handles optSetPathRelative.CheckedChanged
        btnBrowse.Enabled = True
        gbxSetPathRelative.Enabled = optSetPathRelative.Checked
    End Sub
    
    Sub btnBrowse_Click() Handles btnBrowse.Click
        ofdSelectFile.FileName = txtDecoded.Text.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
        ofdSelectFile.InitialDirectory = txtCD.Text ' this should have the correct seperator characters as it's set from Environment.CurrentDirectory
        
        If ofdSelectFile.ShowDialog() = DialogResult.OK Then
            If optSetPathAbsolute.Checked Then
                txtOutput.Text = ofdSelectFile.FileName
            ElseIf optSetPathRelativeContained.Checked
                If txtCD.Text.EndsWith(Path.VolumeSeparatorChar & Path.DirectorySeparatorChar) Then
                    txtOutput.Text = ofdSelectFile.FileName.Substring(txtCD.Text.Length) ' Since on a drive (e.g. D:\) CD contains a trailing \
                Else
                    txtOutput.Text = ofdSelectFile.FileName.Substring(txtCD.Text.Length + 1)
                End If
            ElseIf optSetPathRelativeExternal.Checked
                txtOutput.Text = ".."
                Dim scanText As String
                Try
                    scanText = txtCD.Text.Substring( ofdSelectFile.FileName.LastIndexOf(Path.DirectorySeparatorChar) +1 )
                    
                    If scanText.Contains(Path.DirectorySeparatorChar) Then
                        For Each character As Char In scanText
                            If character = Path.DirectorySeparatorChar Then
                                txtOutput.Text &= Path.DirectorySeparatorChar & ".."
                            End If
                        Next
                    End If
                Catch
                End Try
                
                txtOutput.Text &= ofdSelectFile.FileName.Substring( ofdSelectFile.FileName.LastIndexOf(Path.DirectorySeparatorChar) )
            Else
                MsgBox("Please select an option!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
End Class
