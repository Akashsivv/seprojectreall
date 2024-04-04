Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class SignUpForm

    ' Define your connection string (replace with your actual connection string)
    Dim connectionString As String = "Data Source=LAPTOP-AGD0GN4V;Initial Catalog=Gustroomgmt;Integrated Security=True"

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        ' Get user input from textboxes
        Dim fullName As String = txtFullName.Text
        Dim email As String = txtEmail.Text
        Dim phoneNo As String = txtPhoneNo.Text
        Dim cid As String = txtCID.Text
        Dim aadhaar As String = txtAadhaar.Text
        Dim newUsername As String = txtNewUsername.Text
        Dim newPassword As String = txtNewPassword.Text

        ' Validate user input
        If String.IsNullOrWhiteSpace(fullName) OrElse
            Not IsValidEmail(email) OrElse
            Not IsValidPhone(phoneNo) OrElse
            Not IsValidCID(cid) OrElse
            Not IsValidAadhaar(aadhaar) OrElse
            String.IsNullOrWhiteSpace(newUsername) OrElse
            String.IsNullOrWhiteSpace(newPassword) Then
            MessageBox.Show("Please fill in all fields with valid data.")
            Return
        End If

        Try
            ' Create a SqlConnection object using the connection string
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Define the INSERT query
                Dim query As String = "INSERT INTO Guest (FullName, Email, PhoneNo, CID, Aadhaar, Username, Password) " &
                                      "VALUES (@FullName, @Email, @PhoneNo, @CID, @Aadhaar, @Username, @Password)"

                ' Create a SqlCommand object with the INSERT query and connection
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@FullName", fullName)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@PhoneNo", phoneNo)
                    command.Parameters.AddWithValue("@CID", cid)
                    command.Parameters.AddWithValue("@Aadhaar", aadhaar)
                    command.Parameters.AddWithValue("@Username", newUsername)
                    command.Parameters.AddWithValue("@Password", newPassword)

                    ' Execute the INSERT command
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if any rows were affected (indicating successful insertion)
                    If rowsAffected > 0 Then
                        MessageBox.Show("Sign up successful! New user added to the database.")
                        ' Optionally, clear the textboxes after sign up
                        ClearTextBoxes()
                    Else
                        MessageBox.Show("Sign up failed! Unable to add new user to the database.")
                    End If
                End Using
            End Using
        Catch ex As SqlException
            ' Display specific error messages based on SQL exceptions
            MessageBox.Show("SQL Error: " & ex.Number & vbCrLf & ex.Message)
            Console.WriteLine(ex.ToString()) ' Print the full exception details to the console for debugging purposes
        Catch ex As Exception
            ' Display generic error message for other exceptions
            MessageBox.Show("An error occurred while processing your request. Please try again later.")
            Console.WriteLine(ex.ToString()) ' Print the full exception details to the console for debugging purposes
        End Try
    End Sub

    ' Email validation function
    Private Function IsValidEmail(email As String) As Boolean
        ' Simple email pattern matching
        Return Regex.IsMatch(email, "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$")
    End Function

    ' Phone number validation function
    Private Function IsValidPhone(phone As String) As Boolean
        ' Check if phone number is numeric and has 10 digits
        Return Regex.IsMatch(phone, "^\d{10}$")
    End Function

    ' CID validation function
    Private Function IsValidCID(cid As String) As Boolean
        ' Check if CID is numeric and has 4 digits
        Return Regex.IsMatch(cid, "^\d{4}$")
    End Function

    ' Aadhaar number validation function
    Private Function IsValidAadhaar(aadhaar As String) As Boolean
        ' Check if Aadhaar is numeric and has 12 digits
        Return Regex.IsMatch(aadhaar, "^\d{12}$")
    End Function

    ' Clear all textboxes
    Private Sub ClearTextBoxes()
        txtFullName.Clear()
        txtEmail.Clear()
        txtPhoneNo.Clear()
        txtCID.Clear()
        txtAadhaar.Clear()
        txtNewUsername.Clear()
        txtNewPassword.Clear()
    End Sub
End Class

