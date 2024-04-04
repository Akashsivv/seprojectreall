Public Class guestformx
    Inherits System.Windows.Forms.Form

    ' Define a variable to hold the current instance of GuestForm0

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ' Event handler for Button1 click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create an instance of the guestform
        Dim guestForm As New guestform

        ' Show the guestform
        guestForm.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            ' Close the current form (HousekeepingForm)
            Me.Close()

        ' Show formvb
        Dim Form1 As New Form1()
        Form1.Show()
    End Sub
    End Class






