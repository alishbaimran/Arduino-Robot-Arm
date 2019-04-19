Imports System.IO

Module GlobalVariables
    Public selPort As String = "Not Connected"
    Public data As String
End Module

Public Class main

    Public WithEvents SerialPort As New IO.Ports.SerialPort
    Public f1 As FileStream
    Public file As System.IO.StreamWriter
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            refreshPort()
            initialPosition()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub refreshPort()
        PORT.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            PORT.Items.Add(sp)
        Next
        If PORT.Items.Count > 0 Then
            PORT.SelectedIndex = 0
            selPort = PORT.Text
        End If
    End Sub

    Private Sub portRefresh_Click(sender As Object, e As EventArgs) Handles portRefresh.Click
        refreshPort()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        selPort = PORT.SelectedItem
        MessageBox.Show(selPort)
    End Sub

    Public Sub SPSetup()    'Serial Port Setup
        On Error Resume Next
        If SerialPort.IsOpen Then
            SerialPort.Close()
        End If
        SerialPort.PortName = selPort
        SerialPort.BaudRate = 9600
        SerialPort.DataBits = 8
        SerialPort.StopBits = IO.Ports.StopBits.One
        SerialPort.Handshake = IO.Ports.Handshake.None
        SerialPort.Parity = IO.Ports.Parity.None
        SerialPort.Open()
    End Sub

    Private Sub TrackBar5_Scroll(sender As Object, e As EventArgs) Handles gripper.Scroll
        Try
            If SerialPort.IsOpen Then
                SerialPort.Write("q") 'to start movement of gripper
                file.WriteLine("q")
                data = gripper.Value
                If data = 10 Then
                    file.WriteLine("0")
                    SerialPort.Write(0)
                    Threading.Thread.Sleep(35)
                Else
                    file.WriteLine(gripper.Value.ToString)
                    SerialPort.Write(gripper.Value)
                    Threading.Thread.Sleep(35)
                End If
            Else
                SPSetup()
                SerialPort.Write("q")
                file.WriteLine("q")
                data = gripper.Value
                If data = 10 Then
                    file.WriteLine("0")
                    SerialPort.Write(0)
                    Threading.Thread.Sleep(35)
                Else
                    file.WriteLine(gripper.Value.ToString)
                    SerialPort.Write(gripper.Value)
                    Threading.Thread.Sleep(35)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Arduino Port not set or no text to send.")
        End Try
    End Sub

    Private Sub wrist_Scroll(sender As Object, e As EventArgs) Handles wrist.Scroll
        Try
            If SerialPort.IsOpen Then
                SerialPort.Write("w") 'to start movement of gripper
                file.WriteLine("w")
                data = wrist.Value
                If data = 10 Then
                    SerialPort.Write(0)
                    Threading.Thread.Sleep(35)
                    file.WriteLine("0")
                Else
                    SerialPort.Write(wrist.Value)
                    Threading.Thread.Sleep(35)
                    file.WriteLine(wrist.Value.ToString)
                End If
            Else
                SPSetup()
                SerialPort.Write("w")
                file.WriteLine("w")
                data = wrist.Value

                If data = 10 Then
                    SerialPort.Write(0)
                    file.WriteLine("0")
                    Threading.Thread.Sleep(35)
                Else
                    SerialPort.Write(wrist.Value)
                    Threading.Thread.Sleep(35)
                    file.WriteLine(wrist.Value.ToString)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Arduino Port not set or no text to send.")
        End Try
    End Sub

    Private Sub ankle_Scroll(sender As Object, e As EventArgs) Handles ankle.Scroll
        Try
            If SerialPort.IsOpen Then
                SerialPort.Write("e") 'to start movement of gripper
                file.WriteLine("e")
                data = ankle.Value
                If data = 10 Then
                    SerialPort.Write(0)
                    Threading.Thread.Sleep(35)
                    file.WriteLine("0")
                Else
                    SerialPort.Write(ankle.Value)
                    Threading.Thread.Sleep(35)
                    file.WriteLine(ankle.Value.ToString)
                End If
            Else
                SPSetup()
                SerialPort.Write("e")
                file.WriteLine("e")
                data = ankle.Value
                If data = 10 Then
                    SerialPort.Write(0)
                    Threading.Thread.Sleep(35)
                    file.WriteLine("0")
                Else
                    SerialPort.Write(ankle.Value)
                    Threading.Thread.Sleep(35)
                    file.WriteLine(ankle.Value.ToString)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Arduino Port not set or no text to send.")
        End Try
    End Sub

    Private Sub upBase_Scroll(sender As Object, e As EventArgs) Handles upBase.Scroll
        Try
            If SerialPort.IsOpen Then
                SerialPort.Write("r") 'to start movement of gripper
                file.WriteLine("r")
                data = upBase.Value
                If data = 10 Then
                    SerialPort.Write(0)
                    Threading.Thread.Sleep(35)
                    file.WriteLine("0")
                Else
                    SerialPort.Write(upBase.Value)
                    Threading.Thread.Sleep(35)
                    file.WriteLine(upBase.Value.ToString)
                End If
            Else
                SPSetup()
                SerialPort.Write("r")
                file.WriteLine("r")
                data = upBase.Value
                If data = 10 Then
                    SerialPort.Write(0)
                    Threading.Thread.Sleep(35)
                    file.WriteLine("0")
                Else
                    SerialPort.Write(upBase.Value)
                    Threading.Thread.Sleep(35)
                    file.WriteLine(upBase.Value.ToString)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Arduino Port not set or no text to send.")
        End Try
    End Sub

    Private Sub base_Scroll(sender As Object, e As EventArgs) Handles base.Scroll
        Try
            If SerialPort.IsOpen Then
                SerialPort.Write("t") 'to start movement of gripper
                file.WriteLine("t")
                data = base.Value
                If data = 10 Then
                    SerialPort.Write(0)
                    Threading.Thread.Sleep(35)
                    file.WriteLine("0")
                Else
                    SerialPort.Write(base.Value)
                    Threading.Thread.Sleep(35)
                    file.WriteLine(base.Value.ToString)
                End If
            Else
                SPSetup()
                SerialPort.Write("t")
                file.WriteLine("t")
                data = base.Value
                If data = 10 Then
                    SerialPort.Write(0)
                    Threading.Thread.Sleep(35)
                    file.WriteLine("0")
                Else
                    SerialPort.Write(base.Value)
                    Threading.Thread.Sleep(35)
                    file.WriteLine(base.Value.ToString)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Arduino Port not set or no text to send." & ex.ToString)
        End Try
    End Sub

    Private Sub train_Click(sender As Object, e As EventArgs) Handles train.Click
        gripper.Enabled = True
        upBase.Enabled = True
        base.Enabled = True
        ankle.Enabled = True
        wrist.Enabled = True

        If IO.File.Exists("trainEvent.txt") Then
            Try

                IO.File.Delete("trainEvent.txt")
                file = My.Computer.FileSystem.OpenTextFileWriter("trainEvent.txt", True)
            Catch ex As Exception

            End Try
        Else
            IO.File.Create("trainEvent.txt")
            file = My.Computer.FileSystem.OpenTextFileWriter("trainEvent.txt", True)
        End If

        'file.WriteLine("est")
    End Sub

    Private Sub play_Click(sender As Object, e As EventArgs) Handles play.Click
        gripper.Enabled = False
        upBase.Enabled = False
        base.Enabled = False
        ankle.Enabled = False
        wrist.Enabled = False
        Try
            file.Close()
        Catch ex As Exception

        End Try

        'set servo motorposition to normal
        initialPosition()

        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader("trainEvent.txt")
        Dim stringReader As String

        While Not fileReader.EndOfStream
            Try
                stringReader = fileReader.ReadLine()
                If stringReader = "q" Or stringReader = "w" Or stringReader = "e" Or stringReader = "r" Or stringReader = "t" Then
                    SerialPort.Write(stringReader)
                Else
                    SerialPort.Write(Convert.ToInt16(stringReader))
                End If
            Catch ex As Exception

            End Try
        End While
        MessageBox.Show("I am done playing!!!")
    End Sub

    Public Sub initialPosition()
        SerialPort.Write("q")
        SerialPort.Write(90)
        Threading.Thread.Sleep(35)
        SerialPort.Write("w")
        SerialPort.Write(90)
        Threading.Thread.Sleep(35)
        SerialPort.Write("e")
        SerialPort.Write(90)
        Threading.Thread.Sleep(35)
        SerialPort.Write("r")
        SerialPort.Write(90)
        Threading.Thread.Sleep(35)
        SerialPort.Write("t")
        SerialPort.Write(90)
        Threading.Thread.Sleep(35)
    End Sub
End Class
