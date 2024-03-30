<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminform
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
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(78, 208)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 69)
        Button1.TabIndex = 0
        Button1.Text = "check room details"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(253, 208)
        Button2.Name = "Button2"
        Button2.Size = New Size(167, 69)
        Button2.TabIndex = 1
        Button2.Text = "GUEST DETAILS"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(452, 208)
        Button3.Name = "Button3"
        Button3.Size = New Size(200, 69)
        Button3.TabIndex = 2
        Button3.Text = "INITIATE ROOMSERVICE REQ."
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(265, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 23)
        Label1.TabIndex = 3
        Label1.Text = "WELCOME,ADMIN!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(253, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 23)
        Label2.TabIndex = 4
        Label2.Text = "APSARA GUESTROOMS"
        ' 
        ' adminform
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "adminform"
        Text = "adminform"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
