Public Class EditSubmissionForm
    Public Property Submission As Submission

    Public Sub New(submission As Submission)
        InitializeComponent()
        Me.Submission = submission
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhone.Text = submission.Phone
        txtGithub.Text = submission.GithubLink
        lblStopwatch.Text = submission.StopwatchTime
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Submission.Name = txtName.Text
        Submission.Email = txtEmail.Text
        Submission.Phone = txtPhone.Text
        Submission.GithubLink = txtGithub.Text
        Submission.StopwatchTime = lblStopwatch.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub EditSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
