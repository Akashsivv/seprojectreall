<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class guestformx
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
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(135, 234)
        Button1.Name = "Button1"
        Button1.Size = New Size(196, 88)
        Button1.TabIndex = 0
        Button1.Text = "BOOK ROOM/ CHECK PRICES"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(453, 234)
        Button2.Name = "Button2"
        Button2.Size = New Size(198, 88)
        Button2.TabIndex = 1
        Button2.Text = "REQUEST HOUSEKEEPING "
        Button2.UseVisualStyleBackColor = True
        ' 
        ' guestformx
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "guestformx"
        Text = "guestformx"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
