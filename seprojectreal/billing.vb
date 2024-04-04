Public Class billing
    Inherits System.Windows.Forms.Form

    Private _paymentAmount As Integer
    Private _paymentSuccessful As Boolean = False

    Public Sub New(ByVal paymentAmount As Integer)
        InitializeComponent()

        ' Set the payment amount
        _paymentAmount = paymentAmount
    End Sub

    Public ReadOnly Property PaymentSuccessful As Boolean
        Get
            Return _paymentSuccessful
        End Get
    End Property

    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        ' Perform payment processing logic here
        ' For demonstration purposes, let's assume payment is successful if CVV is provided
        If txtCVV.Text <> "" Then
            MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            _paymentSuccessful = True
            Me.Close()
        Else
            MessageBox.Show("Please enter CVV to proceed with payment.", "CVV Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
