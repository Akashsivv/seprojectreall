Public Class adminForm2
    Inherits System.Windows.Forms.Form

    ' Define a dictionary to keep track of the locked state of each room
    Private roomLockStatus As New Dictionary(Of Integer, Boolean)()

    Public Sub New()
        InitializeComponent()

        ' Initialize the dictionary with the initial lock status of each room (assumed to be unlocked initially)
        For i As Integer = 1 To 10
            roomLockStatus.Add(i, False)
        Next
    End Sub

    ' Handle CheckBox check events to lock/unlock rooms
    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged,
                                                                                    CheckBox2.CheckedChanged,
                                                                                    CheckBox3.CheckedChanged,
                                                                                    CheckBox4.CheckedChanged,
                                                                                    CheckBox5.CheckedChanged,
                                                                                    CheckBox6.CheckedChanged,
                                                                                    CheckBox7.CheckedChanged,
                                                                                    CheckBox8.CheckedChanged,
                                                                                    CheckBox9.CheckedChanged,
                                                                                    CheckBox10.CheckedChanged
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        Dim roomNumber As Integer = Integer.Parse(checkBox.Name.Substring("CheckBox".Length))

        If checkBox.Checked Then
            LockRoom(roomNumber)
        Else
            UnlockRoom(roomNumber)
        End If
    End Sub

    ' Method to lock a room
    Private Sub LockRoom(roomNumber As Integer)
        ' Add logic to lock the room (e.g., update database, set room status)
        roomLockStatus(roomNumber) = True ' Update the lock status for the room
        MessageBox.Show("Room " & roomNumber.ToString() & " is now locked.")
    End Sub

    ' Method to unlock a room
    Private Sub UnlockRoom(roomNumber As Integer)
        ' Add logic to unlock the room (e.g., update database, set room status)
        roomLockStatus(roomNumber) = False ' Update the lock status for the room
        MessageBox.Show("Room " & roomNumber.ToString() & " is now unlocked.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form (adminForm2)
        Me.Close()

        ' Show the admin form again
        Dim adminform As New adminform()
        adminform.Show()
    End Sub
End Class

