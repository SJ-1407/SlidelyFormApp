<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        btnPrevious = New Button()
        btnNext = New Button()
        txtStopWatch = New TextBox()
        txtGithub = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Yellow
        btnPrevious.Location = New Point(152, 379)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(199, 34)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "Previous (Ctrl + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightBlue
        btnNext.Location = New Point(403, 379)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(200, 34)
        btnNext.TabIndex = 1
        btnNext.Text = "Next (Ctrl +N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' txtStopWatch
        ' 
        txtStopWatch.Location = New Point(334, 319)
        txtStopWatch.Name = "txtStopWatch"
        txtStopWatch.ReadOnly = True
        txtStopWatch.Size = New Size(150, 31)
        txtStopWatch.TabIndex = 2
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(334, 251)
        txtGithub.Name = "txtGithub"
        txtGithub.ReadOnly = True
        txtGithub.Size = New Size(150, 31)
        txtGithub.TabIndex = 3
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(334, 173)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(334, 106)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 5
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(334, 41)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(241, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(241, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 8
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(238, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 25)
        Label3.TabIndex = 9
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(213, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 25)
        Label4.TabIndex = 10
        Label4.Text = "Githuib Link"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(180, 325)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 25)
        Label5.TabIndex = 11
        Label5.Text = "Stopwatch Time"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtName)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtGithub)
        Controls.Add(txtStopWatch)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "Shreyas Joshi , Slidely Task 2 - View Subissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtStopWatch As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
