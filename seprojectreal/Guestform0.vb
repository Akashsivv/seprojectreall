Public Class Guestform0

    Private selectedRoom As String

    Public Sub New(ByVal roomNumber As String)
        InitializeComponent()
        selectedRoom = roomNumber
        InitializeRoomLabels()
    End Sub

    Private Sub InitializeRoomLabels()
        ' Initialize room labels here
        ' Non-AC Rooms 101 to 105
        LabelNonAC101.BackColor = Color.Green
        LabelNonAC102.BackColor = Color.Green
        LabelNonAC103.BackColor = Color.Green
        LabelNonAC104.BackColor = Color.Green
        LabelNonAC105.BackColor = Color.Green
        ' AC Rooms 201 to 205
        LabelAC201.BackColor = Color.Green
        LabelAC202.BackColor = Color.Green
        LabelAC203.BackColor = Color.Green
        LabelAC204.BackColor = Color.Green
        LabelAC205.BackColor = Color.Green
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub RoomLabel_Click(sender As Object, e As EventArgs) Handles LabelNonAC101.Click, LabelNonAC102.Click, LabelNonAC103.Click, LabelNonAC104.Click, LabelNonAC105.Click, LabelAC201.Click, LabelAC202.Click, LabelAC203.Click, LabelAC204.Click, LabelAC205.Click
        ' Handle room label click event
        Dim clickedLabel As Label = CType(sender, Label)
        clickedLabel.BackColor = Color.Red ' Change the background color to red
    End Sub

End Class



