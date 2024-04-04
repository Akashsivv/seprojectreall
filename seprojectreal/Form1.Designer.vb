<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        linkSignUp = New LinkLabel()
        Label3 = New Label()
        btnLogin = New Button()
        radAdmin = New RadioButton()
        radGuest = New RadioButton()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(150, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 3
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(149, 206)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(264, 142)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(181, 27)
        txtUsername.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(264, 206)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(181, 27)
        txtPassword.TabIndex = 6
        ' 
        ' linkSignUp
        ' 
        linkSignUp.AutoSize = True
        linkSignUp.Location = New Point(106, 343)
        linkSignUp.Name = "linkSignUp"
        linkSignUp.Size = New Size(57, 20)
        linkSignUp.TabIndex = 7
        linkSignUp.TabStop = True
        linkSignUp.Text = "signup!"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 343)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 8
        Label3.Text = "New Guest?"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(301, 267)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(84, 25)
        btnLogin.TabIndex = 9
        btnLogin.Text = "login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' radAdmin
        ' 
        radAdmin.AutoSize = True
        radAdmin.Location = New Point(372, 339)
        radAdmin.Name = "radAdmin"
        radAdmin.Size = New Size(74, 24)
        radAdmin.TabIndex = 10
        radAdmin.TabStop = True
        radAdmin.Text = "Admin"
        radAdmin.UseVisualStyleBackColor = True
        ' 
        ' radGuest
        ' 
        radGuest.AutoSize = True
        radGuest.Location = New Point(468, 339)
        radGuest.Name = "radGuest"
        radGuest.Size = New Size(67, 24)
        radGuest.TabIndex = 11
        radGuest.TabStop = True
        radGuest.Text = "Guest"
        radGuest.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(481, 267)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 12
        Button1.Text = "close app"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(711, 391)
        Controls.Add(Button1)
        Controls.Add(radGuest)
        Controls.Add(radAdmin)
        Controls.Add(btnLogin)
        Controls.Add(Label3)
        Controls.Add(linkSignUp)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "       "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ChkGuest As CheckBox
    Friend WithEvents Chkadmin As CheckBox
    Friend WithEvents Chkhousekeeping As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents linkSignUp As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents radAdmin As RadioButton
    Friend WithEvents radGuest As RadioButton
    Friend WithEvents Button1 As Button
End Class
