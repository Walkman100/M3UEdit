Option Explicit On
Option Strict On
Option Compare Binary
Option Infer On

Imports System.IO
Imports System.Xml

Public Partial Class Settings
    Public Sub New()
        Me.InitializeComponent()
    End Sub
    
    ' ==================== UI Behaviour ====================
    
    Sub optTestSpecific_CheckedChanged(sender As Object, e As EventArgs) Handles optTestSpecific.CheckedChanged
        grpTestSpecific.Enabled = optTestSpecific.Checked
    End Sub
    
    Sub optTestAskBrowse_CheckedChanged(sender As Object, e As EventArgs) Handles optTestAskBrowse.CheckedChanged
        lblTestAskBrowse.Enabled = optTestAskBrowse.Checked
        txtTestAskBrowse.Enabled = optTestAskBrowse.Checked
        btnTestAskBrowse.Enabled = optTestAskBrowse.Checked
    End Sub
    
    Sub btnTestSpecificPathBrowse_Click(sender As Object, e As EventArgs) Handles btnTestSpecificPathBrowse.Click
        ofdSelectProgram.InitialDirectory = Environment.GetEnvironmentVariable("ProgramFiles")
        ofdSelectProgram.FileName = txtTestSpecificPath.Text
        
        If ofdSelectProgram.ShowDialog() = DialogResult.OK Then
            txtTestSpecificPath.Text = ofdSelectProgram.FileName
        End If
    End Sub
    
    Sub btnTestSpecificVLCAdd_Click(sender As Object, e As EventArgs) Handles btnTestSpecificVLCAdd.Click
        txtTestSpecificArgs.Text = "--started-from-file --playlist-enqueue ""{0}"""
    End Sub
    
    Sub btnTestSpecificVLCPlay_Click(sender As Object, e As EventArgs) Handles btnTestSpecificVLCPlay.Click
        txtTestSpecificArgs.Text = "--started-from-file --no-playlist-enqueue ""{0}"""
    End Sub
    
    Sub btnTestAskBrowse_Click(sender As Object, e As EventArgs) Handles btnTestAskBrowse.Click
        ofdSelectProgram.InitialDirectory = Environment.GetEnvironmentVariable("ProgramFiles")
        ofdSelectProgram.FileName = txtTestAskBrowse.Text
        
        If ofdSelectProgram.ShowDialog() = DialogResult.OK Then
            txtTestAskBrowse.Text = ofdSelectProgram.FileName
        End If
    End Sub
    
    Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveSettings()
    End Sub
    
    Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If File.Exists(configFilePath) Then
            LoadSettings
        End If
    End Sub
    
    Sub btnDefaults_Click(sender As Object, e As EventArgs) Handles btnDefaults.Click
        optTestDefault.Checked = True
        txtTestSpecificPath.Text = ""
        txtTestSpecificArgs.Text = """{0}"""
        txtTestAskBrowse.Text = ""
        optSetPathNone.Checked = True
    End Sub
    
    ' ==================== Actual Saving & Loading ====================
    
    Dim configFileName As String = "M3UEdit.xml"
    Dim Friend configFilePath As String = ""
    
    Sub SetConfigFilePath()
        If Environment.GetEnvironmentVariable("OS") = "Windows_NT" Then
            If Not       Directory.Exists(Path.Combine(Environment.GetEnvironmentVariable("AppData"), "WalkmanOSS")) Then
                Directory.CreateDirectory(Path.Combine(Environment.GetEnvironmentVariable("AppData"), "WalkmanOSS"))
            End If
            configFilePath =              Path.Combine(Environment.GetEnvironmentVariable("AppData"), "WalkmanOSS", configFileName)
        Else
            If Not       Directory.Exists(Path.Combine(Environment.GetEnvironmentVariable("HOME"), ".config", "WalkmanOSS")) Then
                Directory.CreateDirectory(Path.Combine(Environment.GetEnvironmentVariable("HOME"), ".config", "WalkmanOSS"))
            End If
            configFilePath =              Path.Combine(Environment.GetEnvironmentVariable("HOME"), ".config", "WalkmanOSS", configFileName)
        End If
        
        If       File.Exists(Path.Combine(Application.StartupPath, configFileName)) Then
            configFilePath = Path.Combine(Application.StartupPath, configFileName)
        ElseIf File.Exists(configFileName) Then
            configFilePath = (New FileInfo(configFileName)).FullName
        End If
    End Sub
    
    Sub LoadSettings()
        Dim reader As XmlReader = XmlReader.Create(configFilePath)
        Try
            reader.Read()
        Catch ex As XmlException
            reader.Close
            Exit Sub
        End Try
        
        If reader.IsStartElement() AndAlso reader.Name = "M3UEdit" Then
            If reader.Read AndAlso reader.IsStartElement() AndAlso reader.Name = "Settings" Then
                While reader.read
                    If reader.IsStartElement Then
                        Select Case reader.Name
                            Case "TestProgram"
                                reader.Read
                                Select Case reader.Value
                                    Case "Default": optTestDefault.Checked = True
                                    Case "Specific": optTestSpecific.Checked = True
                                    Case "AskSystem": optTestAskSystem.Checked = True
                                    Case "AskBrowse": optTestAskBrowse.Checked = True
                                End Select
                            Case "TestProgramSpecificPath"
                                reader.Read
                                txtTestSpecificPath.Text = reader.Value
                            Case "TestProgramSpecificArgs"
                                reader.Read
                                txtTestSpecificArgs.Text = reader.Value
                            Case "TestProgramAskDefaultValue"
                                reader.Read
                                txtTestAskBrowse.Text = reader.Value
                            Case "SetNewPathDefault"
                                reader.Read
                                Select Case reader.Value
                                    Case "None": optSetPathNone.Checked = True
                                    Case "Absolute": optSetPathAbsolute.Checked = True
                                    Case "RelativeContained": optSetPathRelativeContained.Checked = True
                                    Case "RelativeExternal": optSetPathRelativeExternal.Checked = True
                                End Select
                        End Select
                    End If
                End While
            End If
        End If
        
        reader.Close
    End Sub
    
    Sub SaveSettings()
        Dim XMLwSettings As New XmlWriterSettings()
        XMLwSettings.Indent = True
        Dim writer As XmlWriter = XmlWriter.Create(configFilePath, XMLwSettings)
        
        Try
            writer.WriteStartDocument()
            writer.WriteStartElement("M3UEdit")
            
            writer.WriteStartElement("Settings")
                If     optTestDefault.Checked  Then: writer.WriteElementString("TestProgram", "Default")
                ElseIf optTestSpecific.Checked Then: writer.WriteElementString("TestProgram", "Specific")
                ElseIf optTestAskSystem.Checked Then: writer.WriteElementString("TestProgram", "AskSystem")
                ElseIf optTestAskBrowse.Checked Then: writer.WriteElementString("TestProgram", "AskBrowse")
                End If
                
                writer.WriteElementString("TestProgramSpecificPath", txtTestSpecificPath.Text)
                writer.WriteElementString("TestProgramSpecificArgs", txtTestSpecificArgs.Text)
                writer.WriteElementString("TestProgramAskDefaultValue", txtTestAskBrowse.Text)
                
                If optSetPathNone.Checked Then: writer.WriteElementString("SetNewPathDefault", "None")
                ElseIf optSetPathAbsolute.Checked Then: writer.WriteElementString("SetNewPathDefault", "Absolute")
                ElseIf optSetPathRelativeContained.Checked Then: writer.WriteElementString("SetNewPathDefault", "RelativeContained")
                ElseIf optSetPathRelativeExternal.Checked Then: writer.WriteElementString("SetNewPathDefault", "RelativeExternal")
                End If
            writer.WriteEndElement()
            
            writer.WriteEndElement()
            writer.WriteEndDocument()
        Finally
            writer.Close
        End Try
    End Sub
End Class
