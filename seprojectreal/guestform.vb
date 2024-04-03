﻿Imports System.Data.SqlClient
Imports System.Guid

Public Class guestform
    Inherits System.Windows.Forms.Form

    ' Initialize ComboBox options for room types and room numbers
    Private roomTypes As String() = {"AC", "Non-AC"}
    Private roomNumbers As String() = {"101", "102", "103", "104", "105"}

    ' Connection string for your database
    Private connectionString As String = "Data Source=LAPTOP-AGD0GN4V;Initial Catalog=Gustroomgmt;Integrated Security=True"

    Public Sub New()
        InitializeComponent()

        ' Populate ComboBox for room types
        ComboBox2.Items.AddRange(roomTypes)
        ComboBox2.SelectedIndex = 0 ' Select the first option by default
    End Sub

    ' Handle ComboBox2 (Room Type) selection change event
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Clear the existing items in ComboBox1
        ComboBox1.Items.Clear()

        ' Populate ComboBox1 with room numbers based on the selected room type
        If ComboBox2.SelectedItem IsNot Nothing Then
            If ComboBox2.SelectedItem.ToString() = "AC" Then
                ' Add AC room numbers (201 to 205) to ComboBox1
                ComboBox1.Items.AddRange({"201", "202", "203", "204", "205"})
            ElseIf ComboBox2.SelectedItem.ToString() = "Non-AC" Then
                ' Add Non-AC room numbers (101 to 105) to ComboBox1
                ComboBox1.Items.AddRange({"101", "102", "103", "104", "105"})
            End If
        End If

        ' Select the first item in ComboBox1 if it has items
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.SelectedIndex = 0
        End If
    End Sub

    ' Handle "Book Room" button click event
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Perform validation
        If DateTimePicker1.Value >= DateTimePicker2.Value Then
            MessageBox.Show("Check-out date must be after check-in date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Perform booking logic here
        Dim checkInDate As DateTime = DateTimePicker1.Value
        Dim checkOutDate As DateTime = DateTimePicker2.Value
        Dim roomType As String = ComboBox2.SelectedItem.ToString()
        Dim roomNumber As String = ComboBox1.SelectedItem.ToString()

        ' Check if the room is already booked for the selected dates
        If IsRoomBooked(roomNumber, checkInDate, checkOutDate) Then
            MessageBox.Show("This room is already booked for the selected dates. Please choose another room or select different dates.", "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Generate a random booking ID
        Dim bookingId As String = Guid.NewGuid().ToString()

        ' Open billing form modally
        Dim billingForm As New billing()
        If billingForm.ShowDialog() = DialogResult.OK Then
            ' Booking successful, proceed with booking
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO Bookings (BookingId, CheckInDate, CheckOutDate, RoomType, RoomNumber) VALUES (@bookingId, @checkIn, @checkOut, @roomType, @roomNumber)"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@bookingId", bookingId)
                        command.Parameters.AddWithValue("@checkIn", checkInDate)
                        command.Parameters.AddWithValue("@checkOut", checkOutDate)
                        command.Parameters.AddWithValue("@roomType", roomType)
                        command.Parameters.AddWithValue("@roomNumber", roomNumber)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Display confirmation message
                MessageBox.Show("Room booked successfully!", "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear the form or perform any other actions as needed
                ResetForm()

            Catch ex As Exception
                MessageBox.Show("Error occurred while booking the room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Check if the room is already booked for the selected dates
    Private Function IsRoomBooked(roomNumber As String, checkInDate As DateTime, checkOutDate As DateTime) As Boolean
        Dim isBooked As Boolean = False
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM Bookings WHERE RoomNumber = @roomNumber AND CheckInDate < @checkOut AND CheckOutDate > @checkIn"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@roomNumber", roomNumber)
                    command.Parameters.AddWithValue("@checkIn", checkInDate)
                    command.Parameters.AddWithValue("@checkOut", checkOutDate)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    isBooked = count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error occurred while checking room availability: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return isBooked
    End Function

    ' Reset the form to its initial state
    Private Sub ResetForm()
        DateTimePicker1.Value = DateTime.Today ' Reset check-in date to today
        DateTimePicker2.Value = DateTime.Today.AddDays(1) ' Reset check-out date to tomorrow
        ComboBox2.SelectedIndex = 0 ' Reset room type to the first option
        ComboBox1.Items.Clear() ' Clear room numbers selection
    End Sub

    ' Handle "Back" button click event
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the
        ' Close the current form (guestform) to go back to guestformx
        Me.Close()

        ' Show the guestformx form
        Dim guestFormX As New guestformx()
        guestFormX.Show()
    End Sub

    ' Handle "Request Housekeeping" button click event
End Class
