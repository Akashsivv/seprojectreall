Public Class guestformx
    Inherits System.Windows.Forms.Form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create an instance of the guestform
        Dim guestForm As New guestform

        ' Show the guestform
        guestForm.Show()
    End Sub

    ' Event handlPrivate Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    ' List of room numbers
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' List of room numbers
        Dim roomNumbers As String() = {"101", "102", "103", "104", "105", "201", "202", "203", "204", "205"}

        ' Open Guestform0 for each room
        For Each roomNumber As String In roomNumbers
            Dim guestForm As New GuestForm0(roomNumber)
            guestForm.Show()
        Next
    End Sub
End Class

