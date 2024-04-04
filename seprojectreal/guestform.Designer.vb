<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class guestform
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(guestform))
        Button1 = New Button()
        btnBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        nametext = New TextBox()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(504, 448)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 35)
        Button1.TabIndex = 0
        Button1.Text = "BOOK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(643, 448)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(135, 35)
        btnBack.TabIndex = 1
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 2
        Label1.Text = "CHECKIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(230, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 3
        Label2.Text = "CHECKOUT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(435, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 4
        Label3.Text = "ROOMTYPE"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(12, 148)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(181, 27)
        DateTimePicker1.TabIndex = 5
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(211, 148)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(182, 27)
        DateTimePicker2.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"201", "202", "203", "204", "205", "", "101", "102", "103", "104", "105"})
        ComboBox1.Location = New Point(580, 147)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 7
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"AC", "NONAC"})
        ComboBox2.Location = New Point(414, 147)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(284, 221)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(214, 149)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(28, 221)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(200, 160)
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(608, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 11
        Label4.Text = "ROOM NO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(28, 395)
        Label5.Name = "Label5"
        Label5.Size = New Size(208, 20)
        Label5.TabIndex = 12
        Label5.Text = "NON AC (RS.1500 PER NIGHT)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(315, 395)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 20)
        Label6.TabIndex = 13
        Label6.Text = "       "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(306, 395)
        Label7.Name = "Label7"
        Label7.Size = New Size(163, 20)
        Label7.TabIndex = 14
        Label7.Text = "AC(RS.2000 PERNIGHT)"
        ' 
        ' nametext
        ' 
        nametext.Location = New Point(103, 42)
        nametext.Name = "nametext"
        nametext.Size = New Size(125, 27)
        nametext.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(28, 49)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 20)
        Label8.TabIndex = 16
        Label8.Text = "NAME"
        ' 
        ' guestform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(816, 532)
        Controls.Add(Label8)
        Controls.Add(nametext)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Controls.Add(Button1)
        Name = "guestform"
        Text = "guestform"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nametext As TextBox
    Friend WithEvents Label8 As Label
End Class
