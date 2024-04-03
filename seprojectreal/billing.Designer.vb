<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class billing
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
        lblCardNumber = New Label()
        txtCardNumber = New TextBox()
        lblExpirationDate = New Label()
        cmbMonth = New ComboBox()
        cmbYear = New ComboBox()
        lblSlash = New Label()
        lblCVV = New Label()
        txtCVV = New TextBox()
        btnPayNow = New Button()
        SuspendLayout()
        ' 
        ' lblCardNumber
        ' 
        lblCardNumber.AutoSize = True
        lblCardNumber.Location = New Point(17, 20)
        lblCardNumber.Margin = New Padding(4, 0, 4, 0)
        lblCardNumber.Name = "lblCardNumber"
        lblCardNumber.Size = New Size(101, 20)
        lblCardNumber.TabIndex = 0
        lblCardNumber.Text = "Card Number:"
        ' 
        ' txtCardNumber
        ' 
        txtCardNumber.Location = New Point(21, 46)
        txtCardNumber.Margin = New Padding(4, 5, 4, 5)
        txtCardNumber.Name = "txtCardNumber"
        txtCardNumber.Size = New Size(265, 27)
        txtCardNumber.TabIndex = 1
        ' 
        ' lblExpirationDate
        ' 
        lblExpirationDate.AutoSize = True
        lblExpirationDate.Location = New Point(17, 97)
        lblExpirationDate.Margin = New Padding(4, 0, 4, 0)
        lblExpirationDate.Name = "lblExpirationDate"
        lblExpirationDate.Size = New Size(115, 20)
        lblExpirationDate.TabIndex = 2
        lblExpirationDate.Text = "Expiration Date:"
        ' 
        ' cmbMonth
        ' 
        cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMonth.FormattingEnabled = True
        cmbMonth.Location = New Point(21, 123)
        cmbMonth.Margin = New Padding(4, 5, 4, 5)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(88, 28)
        cmbMonth.TabIndex = 3
        ' 
        ' cmbYear
        ' 
        cmbYear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYear.FormattingEnabled = True
        cmbYear.Location = New Point(151, 123)
        cmbYear.Margin = New Padding(4, 5, 4, 5)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(136, 28)
        cmbYear.TabIndex = 4
        ' 
        ' lblSlash
        ' 
        lblSlash.AutoSize = True
        lblSlash.Location = New Point(119, 128)
        lblSlash.Margin = New Padding(4, 0, 4, 0)
        lblSlash.Name = "lblSlash"
        lblSlash.Size = New Size(15, 20)
        lblSlash.TabIndex = 5
        lblSlash.Text = "/"
        ' 
        ' lblCVV
        ' 
        lblCVV.AutoSize = True
        lblCVV.Location = New Point(17, 177)
        lblCVV.Margin = New Padding(4, 0, 4, 0)
        lblCVV.Name = "lblCVV"
        lblCVV.Size = New Size(39, 20)
        lblCVV.TabIndex = 6
        lblCVV.Text = "CVV:"
        ' 
        ' txtCVV
        ' 
        txtCVV.Location = New Point(21, 202)
        txtCVV.Margin = New Padding(4, 5, 4, 5)
        txtCVV.Name = "txtCVV"
        txtCVV.Size = New Size(132, 27)
        txtCVV.TabIndex = 7
        ' 
        ' btnPayNow
        ' 
        btnPayNow.Location = New Point(21, 262)
        btnPayNow.Margin = New Padding(4, 5, 4, 5)
        btnPayNow.Name = "btnPayNow"
        btnPayNow.Size = New Size(100, 35)
        btnPayNow.TabIndex = 8
        btnPayNow.Text = "Pay Now"
        btnPayNow.UseVisualStyleBackColor = True
        ' 
        ' billing
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(312, 326)
        Controls.Add(btnPayNow)
        Controls.Add(txtCVV)
        Controls.Add(lblCVV)
        Controls.Add(lblSlash)
        Controls.Add(cmbYear)
        Controls.Add(cmbMonth)
        Controls.Add(lblExpirationDate)
        Controls.Add(txtCardNumber)
        Controls.Add(lblCardNumber)
        Margin = New Padding(4, 5, 4, 5)
        Name = "billing"
        Text = "BillingForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCardNumber As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents lblExpirationDate As Label
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents lblSlash As Label
    Friend WithEvents lblCVV As Label
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents btnPayNow As Button
End Class

