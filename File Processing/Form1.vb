Imports System.IO
Imports System.Linq

Public Class Form1

    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Dim numbers As New List(Of Integer)
        Dim input As String = ""

        Do
            input = InputBox("Enter a number (or leave blank to finish):", "Input")

            If String.IsNullOrWhiteSpace(input) Then
                Exit Do
            End If

            Dim n As Integer
            If Integer.TryParse(input, n) Then
                numbers.Add(n)
            Else
                MessageBox.Show("Invalid input. Please enter a valid number.", "Error")
            End If

        Loop

        If numbers.Count = 0 Then
            MessageBox.Show("No numbers entered.", "Info")
            Exit Sub
        End If

        Dim path As String = "numbers.txt"

        Using writer As New StreamWriter(path, False)
            For Each num In numbers
                writer.WriteLine(num)
            Next
        End Using

        MessageBox.Show("Numbers saved.", "Success")
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim path As String = "numbers.txt"

        If Not File.Exists(path) Then
            MessageBox.Show("File not found.", "Error")
            Exit Sub
        End If

        Using reader As New StreamReader(path)
            Dim content As String = reader.ReadToEnd()
            MessageBox.Show(content, "File Content")
        End Using
    End Sub

    Private Sub ButtonReadPerLine_Click(sender As Object, e As EventArgs) Handles ButtonReadPerLine.Click
        Dim path As String = "numbers.txt"

        If Not File.Exists(path) Then
            MessageBox.Show("File not found.", "Error")
            Exit Sub
        End If

        ListBox1.Items.Clear()

        Dim nums As New List(Of Integer)

        Using reader As New StreamReader(path)
            While Not reader.EndOfStream
                Dim line = reader.ReadLine()
                Dim n As Integer
                If Integer.TryParse(line, n) Then
                    nums.Add(n)
                End If
            End While
        End Using

        Dim sorted = nums.OrderBy(Function(x) x)

        For Each n In sorted
            ListBox1.Items.Add(n)
        Next
    End Sub

    Private Sub ButtonOpenFile_Click(sender As Object, e As EventArgs) Handles ButtonOpenFile.Click
        Dim dlg As New OpenFileDialog()
        dlg.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If dlg.ShowDialog() = DialogResult.OK Then
            Dim nums As New List(Of Integer)
            ListBox1.Items.Clear()

            Using reader As New StreamReader(dlg.FileName)
                While Not reader.EndOfStream
                    Dim line = reader.ReadLine()
                    Dim n As Integer
                    If Integer.TryParse(line, n) Then
                        nums.Add(n)
                    End If
                End While
            End Using

            Dim sorted = nums.OrderBy(Function(x) x)

            For Each n In sorted
                ListBox1.Items.Add(n)
            Next
        End If
    End Sub

End Class
