Imports System.IO
Public Class DataHandler

    Private filePath As String = "submissions.txt"

    Public Sub SaveSubmission(submission As Submission)
        File.AppendAllText(filePath, $"{submission.Name},{submission.Email},{submission.Phone},{submission.GithubLink},{submission.StopwatchTime}{Environment.NewLine}")
    End Sub

    Public Function LoadSubmissions() As List(Of Submission)
        Dim submissions As New List(Of Submission)()
        If File.Exists(filePath) Then
            Dim lines() As String = File.ReadAllLines(filePath)
            For Each line As String In lines
                If Not String.IsNullOrWhiteSpace(line) Then
                    Dim parts() As String = line.Split(","c)
                    Dim submission As New Submission() With {
                        .Name = parts(0),
                        .Email = parts(1),
                        .Phone = parts(2),
                        .GithubLink = parts(3),
                        .StopwatchTime = parts(4)
                    }
                    submissions.Add(submission)
                End If
            Next
        End If
        Return submissions
    End Function

    Public Sub DeleteSubmission(index As Integer)
        If File.Exists(filePath) Then
            Dim lines As List(Of String) = File.ReadAllLines(filePath).ToList()
            If index >= 0 And index < lines.Count Then
                lines.RemoveAt(index)
                File.WriteAllLines(filePath, lines)
            End If
        End If
    End Sub

    Public Sub UpdateSubmission(index As Integer, submission As Submission)
        If File.Exists(filePath) Then
            Dim lines As List(Of String) = File.ReadAllLines(filePath).ToList()
            If index >= 0 And index < lines.Count Then
                lines(index) = $"{submission.Name},{submission.Email},{submission.Phone},{submission.GithubLink},{submission.StopwatchTime}"
                File.WriteAllLines(filePath, lines)
            End If
        End If
    End Sub
End Class
