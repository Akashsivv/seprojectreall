<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signUpForm
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
        btnSignUp = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtFullName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNo = New TextBox()
        txtCID = New TextBox()
        txtAadhaar = New TextBox()
        Label5 = New Label()
        txtNewUsername = New TextBox()
        txtNewPassword = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        btncancel = New Button()
        SuspendLayout()
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Location = New Point(260, 406)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(94, 29)
        btnSignUp.TabIndex = 0
        btnSignUp.Text = "SIGNUP"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(382, 406)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 1
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(128, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 23)
        Label1.TabIndex = 2
        Label1.Text = "FULL NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(147, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 23)
        Label2.TabIndex = 3
        Label2.Text = "EMAIL"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(138, 255)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 23)
        Label3.TabIndex = 4
        Label3.Text = "PHONE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(-2, 307)
        Label4.Name = "Label4"
        Label4.Size = New Size(238, 23)
        Label4.TabIndex = 5
        Label4.Text = "CID GIVEN BY RECEPTIONIST)"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(260, 135)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(244, 30)
        txtFullName.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(260, 188)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(244, 30)
        txtEmail.TabIndex = 7
        ' 
        ' txtPhoneNo
        ' 
        txtPhoneNo.Location = New Point(260, 248)
        txtPhoneNo.Name = "txtPhoneNo"
        txtPhoneNo.Size = New Size(244, 30)
        txtPhoneNo.TabIndex = 8
        ' 
        ' txtCID
        ' 
        txtCID.Location = New Point(260, 304)
        txtCID.Name = "txtCID"
        txtCID.Size = New Size(244, 30)
        txtCID.TabIndex = 9
        ' 
        ' txtAadhaar
        ' 
        txtAadhaar.Location = New Point(260, 355)
        txtAadhaar.Name = "txtAadhaar"
        txtAadhaar.Size = New Size(244, 30)
        txtAadhaar.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(107, 355)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 23)
        Label5.TabIndex = 11
        Label5.Text = "ADHAAR NO"
        ' 
        ' txtNewUsername
        ' 
        txtNewUsername.Location = New Point(260, 41)
        txtNewUsername.Name = "txtNewUsername"
        txtNewUsername.Size = New Size(244, 30)
        txtNewUsername.TabIndex = 12
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Location = New Point(260, 89)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(244, 30)
        txtNewPassword.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 23)
        Label6.TabIndex = 14
        Label6.Text = "Label6"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(110, 44)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 23)
        Label7.TabIndex = 15
        Label7.Text = "New Username"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(117, 96)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 23)
        Label8.TabIndex = 16
        Label8.Text = "New Password"
        ' 
        ' btncancel
        ' 
        btncancel.Location = New Point(498, 406)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(94, 29)
        btncancel.TabIndex = 17
        btncancel.Text = "CANCEL"
        btncancel.UseVisualStyleBackColor = True
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(828, 469)
        Controls.Add(btncancel)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(txtNewPassword)
        Controls.Add(txtNewUsername)
        Controls.Add(Label5)
        Controls.Add(txtAadhaar)
        Controls.Add(txtCID)
        Controls.Add(txtPhoneNo)
        Controls.Add(txtEmail)
        Controls.Add(txtFullName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(btnSignUp)
        Name = "SignUpForm"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSignUp As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents txtCID As TextBox
    Friend WithEvents txtAadhaar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btncancel As Button
End Class
