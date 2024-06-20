<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithub = New TextBox()
        lblStopwatch = New Label()
        Timer1 = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.Yellow
        btnToggleStopwatch.Location = New Point(70, 290)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(318, 34)
        btnToggleStopwatch.TabIndex = 0
        btnToggleStopwatch.Text = "Toggle Stopwatch (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.Location = New Point(199, 367)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(320, 34)
        btnSubmit.TabIndex = 1
        btnSubmit.Text = "Submit (Ctrl + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(369, 33)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(369, 90)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 3
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(369, 147)
        txtPhone.Name = "txtPhone"
        txtPhone.PlaceholderText = "Phone"
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 4
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(369, 227)
        txtGithub.Name = "txtGithub"
        txtGithub.PlaceholderText = "Github Repo Link"
        txtGithub.Size = New Size(150, 31)
        txtGithub.TabIndex = 5
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.BorderStyle = BorderStyle.Fixed3D
        lblStopwatch.Location = New Point(425, 286)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(94, 38)
        lblStopwatch.TabIndex = 6
        lblStopwatch.Text = "00:00:00"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(229, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(229, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 8
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(209, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 25)
        Label3.TabIndex = 9
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(168, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(147, 25)
        Label4.TabIndex = 10
        Label4.Text = "Github Repo Link"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblStopwatch)
        Controls.Add(txtGithub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "Shreyas Joshi , Slidely Task 2 - Create Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
