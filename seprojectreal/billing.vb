Public Class Billing
    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        ' Validate input fields
        If String.IsNullOrEmpty(txtCardNumber.Text) OrElse String.IsNullOrEmpty(txtCVV.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Perform payment processing here (not implemented in this example)
        ' You can add your payment processing logic here, such as connecting to a payment gateway, etc.

        ' Display payment success message
        MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Optionally, close the billing form after successful payment
        Me.Close()
    End Sub

    Private Sub BillingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate combo boxes for expiration month and year
        For i As Integer = 1 To 12
            cmbMonth.Items.Add(i.ToString("00")) ' Add leading zero if necessary
        Next

        Dim currentYear As Integer = DateTime.Now.Year
        For i As Integer = currentYear To currentYear + 10 ' Assume up to 10 years into the future
            cmbYear.Items.Add(i.ToString())
        Next

        ' Set default values for expiration month and year
        cmbMonth.SelectedIndex = 0 ' January
        cmbYear.SelectedIndex = 0 ' Current year
    End Sub
End Class
