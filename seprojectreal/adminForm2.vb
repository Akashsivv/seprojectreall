Imports System.Data.SqlClient

Public Class adminform2
    Inherits System.Windows.Forms.Form

    ' Connection string for your database
    Private connectionString As String = "Data Source=LAPTOP-AGD0GN4V;Initial Catalog=Gustroomgmt;Integrated Security=True"

    Public Sub New()
        InitializeComponent()

        ' Load the form with the current booking status
        UpdateRoomBookingStatus()
    End Sub

    ' Function to update the booking status of each room
    Private Sub UpdateRoomBookingStatus()
        ' Query the Bookings table to check the booking status of each room
        Dim bookedRooms As List(Of String) = GetBookedRooms()

        ' Update the progress bars based on the booking status
        For Each roomNumber As String In bookedRooms
            Select Case roomNumber
                Case "101"
                    ProgressBar101.Value = 100 ' Room booked, set ProgressBar to full
                Case "102"
                    ProgressBar102.Value = 100 ' Room booked, set ProgressBar to full
                Case "103"
                    ProgressBar103.Value = 100 ' Room booked, set ProgressBar to full
                Case "104"
                    ProgressBar104.Value = 100 ' Room booked, set ProgressBar to full
                Case "105"
                    ProgressBar105.Value = 100 ' Room booked, set ProgressBar to full
                Case "201"
                    ProgressBar201.Value = 100 ' Room booked, set ProgressBar to full
                Case "202"
                    ProgressBar202.Value = 100 ' Room booked, set ProgressBar to full
                Case "203"
                    ProgressBar203.Value = 100 ' Room booked, set ProgressBar to full
                Case "204"
                    ProgressBar204.Value = 100 ' Room booked, set ProgressBar to full
                Case "205"
                    ProgressBar205.Value = 100 ' Room booked, set ProgressBar to full
            End Select
        Next
    End Sub

    ' Function to retrieve a list of room numbers that are currently booked
    Private Function GetBookedRooms() As List(Of String)
        Dim bookedRooms As List(Of String) = New List(Of String)

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT DISTINCT RoomNumber FROM Bookings WHERE CheckInDate <= GETDATE() AND CheckOutDate >= GETDATE()"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            bookedRooms.Add(reader.GetString(0))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error occurred while retrieving booking status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return bookedRooms
    End Function

    ' Other methods and event handlers of your form go here...

End Class


