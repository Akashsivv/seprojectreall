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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(235, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 3
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(235, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(361, 148)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(161, 27)
        txtUsername.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(361, 206)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(161, 27)
        txtPassword.TabIndex = 6
        ' 
        ' linkSignUp
        ' 
        linkSignUp.AutoSize = True
        linkSignUp.Location = New Point(94, 343)
        linkSignUp.Name = "linkSignUp"
        linkSignUp.Size = New Size(57, 20)
        linkSignUp.TabIndex = 7
        linkSignUp.TabStop = True
        linkSignUp.Text = "signup!"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 343)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 8
        Label3.Text = "New Guest?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Green
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(268, 267)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 25)
        btnLogin.TabIndex = 9
        btnLogin.Text = "login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' radAdmin
        ' 
        radAdmin.AutoSize = True
        radAdmin.ForeColor = Color.Red
        radAdmin.Location = New Point(331, 339)
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
        radGuest.ForeColor = Color.Red
        radGuest.Location = New Point(416, 339)
        radGuest.Name = "radGuest"
        radGuest.Size = New Size(67, 24)
        radGuest.TabIndex = 11
        radGuest.TabStop = True
        radGuest.Text = "Guest"
        radGuest.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.ForeColor = Color.White
        Button1.Location = New Point(428, 267)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 29)
        Button1.TabIndex = 12
        Button1.Text = "close app"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(319, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 20)
        Label4.TabIndex = 13
        Label4.Text = "APSARA GUESTROOMS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(867, 447)
        Controls.Add(Label4)
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
        Text = "Login Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

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
    Friend WithEvents Label4 As Label
End Class

