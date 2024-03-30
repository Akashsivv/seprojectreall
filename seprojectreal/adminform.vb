Imports System.Windows.Forms

Partial Public Class adminform
    Inherits System.Windows.Forms.Form

    ' Define instances of the forms you want to open
    Private adminForm2 As New adminForm2()
    Private adminForm3 As New adminForm3()
    Private adminForm4 As New adminForm4()

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

    ' Handle the Click event of Button3
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        ' Show adminform4 when Button3 is clicked
        adminForm4.Show()
    End Sub
End Class
