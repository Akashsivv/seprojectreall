Public Class HousekeepingForm
    ' List of labels for non-AC rooms
    Private NonACLabels As New List(Of Label)

    ' List of labels for AC rooms
    Private ACLabels As New List(Of Label)

    ' Function to initialize the form
    Private Sub HousekeepingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add non-AC labels to the list
        NonACLabels.Add(nonAc101Label)
        NonACLabels.Add(nonAc102Label)
        NonACLabels.Add(nonAc103Label)
        NonACLabels.Add(nonAc104Label)
        NonACLabels.Add(nonAc105Label)

        ' Add AC labels to the list
        ACLabels.Add(ac201Label)
        ACLabels.Add(ac202Label)
        ACLabels.Add(ac203Label)
        ACLabels.Add(ac204Label)
        ACLabels.Add(ac205Label)
    End Sub

    ' Function to handle the click event for the labels
    Private Sub Label_Click(sender As Object, e As EventArgs) Handles nonAc101Label.Click, nonAc102Label.Click, nonAc103Label.Click, nonAc104Label.Click, nonAc105Label.Click,
                                                                     ac201Label.Click, ac202Label.Click, ac203Label.Click, ac204Label.Click, ac205Label.Click
        Dim clickedLabel As Label = DirectCast(sender, Label)

        ' Change the background color of the clicked label to red
        clickedLabel.BackColor = Color.Red
    End Sub
End Class

