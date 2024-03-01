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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(271, 362)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "SIGNUP"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(393, 362)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 1
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(127, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 23)
        Label1.TabIndex = 2
        Label1.Text = "FULL NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(157, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 23)
        Label2.TabIndex = 3
        Label2.Text = "EMAIL"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(148, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 23)
        Label3.TabIndex = 4
        Label3.Text = "PHONE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 241)
        Label4.Name = "Label4"
        Label4.Size = New Size(238, 23)
        Label4.TabIndex = 5
        Label4.Text = "CID GIVEN BY RECEPTIONIST)"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(232, 85)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(244, 30)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(232, 138)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(244, 30)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(232, 188)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(244, 30)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(282, 234)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(244, 30)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(282, 281)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(244, 30)
        TextBox5.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(157, 288)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 23)
        Label5.TabIndex = 11
        Label5.Text = "ADHAAR NO"
        ' 
        ' signUpForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "signUpForm"
        Text = "signUpForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
End Class
