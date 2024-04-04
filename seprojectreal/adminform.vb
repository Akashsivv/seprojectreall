Imports System.Windows.Forms

Partial Public Class adminform
    Inherits System.Windows.Forms.Form

    ' Define instances of the forms you want to open
    Private adminForm2 As New adminForm2()
    Private adminForm3 As New adminForm3()


    Public Sub New()
        InitializeComponent()
    End Sub

    ' Handle the Click event of Button1
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        ' Show adminform2 when Button1 is clicked
        adminForm2.Show()
    End Sub

    ' Handle the Click event of Button2
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        ' Show adminform3 when Button2 is clicked
        adminForm3.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Show form.vb
        Dim formInstance As New Form1()
        Form1.Show()
    End Sub


End Class
