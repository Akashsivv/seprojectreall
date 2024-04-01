Public Class guestformx
    Inherits System.Windows.Forms.Form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create an instance of the guestform
        Dim guestForm As New guestform

        ' Show the guestform
        guestForm.Show()
    End Sub

    ' Event handler for Button2 (REQUEST HOUSEKEEPING)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Write your code to handle Button2 click event here
        ' For example, you can open another form or perform some action
    End Sub
End Class
