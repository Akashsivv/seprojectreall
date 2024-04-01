Public Class guestform
    Inherits System.Windows.Forms.Form

    ' Initialize ComboBox options for room types and room numbers
    Private roomTypes As String() = {"AC", "Non-AC"}
    Private roomNumbers As String() = {"101", "102", "103", "104", "105"}

    Public Sub New()
        InitializeComponent()

        ' Populate ComboBox for room types
        ComboBox1.Items.AddRange(roomTypes)
        ComboBox1.SelectedIndex = 0 ' Select the first option by default

        ' Disable ComboBox for room numbers initially
        ComboBox2.Enabled = False
    End Sub

    ' Handle ComboBox1 (Room Type) selection change event
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Enable ComboBox for room numbers when a room type is selected
        ComboBox2.Enabled = True

        ' Populate ComboBox for room numbers based on selected room type
        ' For simplicity, assume all room numbers are available for both AC and Non-AC types
        ComboBox2.Items.Clear()
        ComboBox2.Items.AddRange(roomNumbers)
        ComboBox2.SelectedIndex = 0 ' Select the first option by default
    End Sub

    ' Handle "Book Room" button click event
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Perform validation
        If DateTimePicker1.Value >= DateTimePicker2.Value Then
            MessageBox.Show("Check-out date must be after check-in date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Perform booking logic here
        ' You can access the selected values using DateTimePicker1.Value, DateTimePicker2.Value,
        ' ComboBox1.SelectedItem (room type), and ComboBox2.SelectedItem (room number)

        ' Display confirmation message
        MessageBox.Show("Room booked successfully!", "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Clear the form or perform any other actions as needed
        ResetForm()
    End Sub

    ' Reset the form to its initial state
    Private Sub ResetForm()
        DateTimePicker1.Value = DateTime.Today ' Reset check-in date to today
        DateTimePicker2.Value = DateTime.Today.AddDays(1) ' Reset check-out date to tomorrow
        ComboBox1.SelectedIndex = 0 ' Reset room type to the first option
        ComboBox2.SelectedIndex = 0 ' Reset room number to the first option
    End Sub

    ' Handle "Back" button click event
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form (guestform) to go back to guestformx
        Me.Close()

        ' Show the guestformx form
        Dim guestFormX As New guestformx()
        guestFormX.Show()
    End Sub

    ' Handle "Request Housekeeping" button click event

End Class
