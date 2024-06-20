Public Class ViewSubmissionsForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)
    Private dataHandler As New DataHandler()

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
        DisplayCurrentSubmission()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplayCurrentSubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplayCurrentSubmission()
        End If
    End Sub

    Private Sub DisplayCurrentSubmission()
        Dim submission = submissions(currentIndex)
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhone.Text = submission.Phone
        txtGithub.Text = submission.GithubLink
        txtStopWatch.Text = submission.StopwatchTime
    End Sub

    Private Sub LoadSubmissions()
        submissions = dataHandler.LoadSubmissions()
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If currentIndex >= 0 And currentIndex < submissions.Count Then
            dataHandler.DeleteSubmission(currentIndex)
            submissions = dataHandler.LoadSubmissions()
            If currentIndex >= submissions.Count Then
                currentIndex = submissions.Count - 1
            End If
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If currentIndex >= 0 And currentIndex < submissions.Count Then
            Dim editForm As New EditSubmissionForm(submissions(currentIndex))
            If editForm.ShowDialog() = DialogResult.OK Then
                submissions(currentIndex) = editForm.Submission
                dataHandler.UpdateSubmission(currentIndex, editForm.Submission)
                DisplaySubmission()
            End If
        End If
    End Sub

    Private Sub DisplaySubmission()
        If currentIndex >= 0 And currentIndex < submissions.Count Then
            txtName.Text = submissions(currentIndex).Name
            txtEmail.Text = submissions(currentIndex).Email
            txtPhone.Text = submissions(currentIndex).Phone
            txtGithub.Text = submissions(currentIndex).GithubLink
            txtStopWatch.Text = submissions(currentIndex).StopwatchTime
        Else
            txtName.Text = String.Empty
            txtEmail.Text = String.Empty
            txtPhone.Text = String.Empty
            txtGithub.Text = String.Empty
            txtStopWatch.Text = String.Empty
        End If
    End Sub

End Class