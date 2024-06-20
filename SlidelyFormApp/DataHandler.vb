Public Class DataHandler

    Private filePath As String = "submissions.txt"

        Public Sub SaveSubmission(submission As Submission)
            Dim line As String = $"{submission.Name},{submission.Email},{submission.Phone},{submission.GithubLink},{submission.StopwatchTime}"
            My.Computer.FileSystem.WriteAllText(filePath, line & Environment.NewLine, True)
        End Sub

        Public Function LoadSubmissions() As List(Of Submission)
            Dim submissions As New List(Of Submission)
            If My.Computer.FileSystem.FileExists(filePath) Then
                Dim lines() As String = My.Computer.FileSystem.ReadAllText(filePath).Split(Environment.NewLine)
                For Each line As String In lines
                    If Not String.IsNullOrWhiteSpace(line) Then
                        Dim parts() As String = line.Split(",")
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


End Class
