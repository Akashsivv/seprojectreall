Imports System.Data.SqlClient
Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim selectedUserType As String = ""

        ' Check which radio button is selected
        If radAdmin.Checked Then
            selectedUserType = "Admin"
        ElseIf radGuest.Checked Then
            selectedUserType = "Guest"
        ElseIf radHousekeeping.Checked Then
            selectedUserType = "Housekeeping"
        Else
            MessageBox.Show("Please select a user type.")
            Return
        End If

        ' Perform authentication based on the selected user type
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' For demonstration purposes, I'm just showing a message box
        If AuthenticateUser(selectedUserType, username, password) Then
            MessageBox.Show("Logged in as " & selectedUserType)
            ' Proceed to appropriate functionality based on user type
            Select Case selectedUserType
                Case "Admin"
                    Dim adminForm As New adminform()
                    adminForm.Show()
                    Me.Hide() ' Hide the login form
                Case "Guest"
                    Dim guestForm As New guestform()
                    guestForm.Show()
                    Me.Hide() ' Hide the login form
                Case "Housekeeping"
                    Dim housekeepingForm As New housekeepingform()
                    housekeepingForm.Show()
                    Me.Hide() ' Hide the login form
            End Select
        Else
            MessageBox.Show("Invalid credentials for " & selectedUserType)
        End If
    End Sub

    Private Function AuthenticateUser(userType As String, username As String, password As String) As Boolean
        Dim connectionString As String = "Data Source=LAPTOP-AGD0GN4V;Initial Catalog=Gustroomgmt;Integrated Security=True"
        Dim query As String = ""

        Select Case userType
            Case "Admin"
                query = "SELECT COUNT(*) FROM Admin WHERE Username = @Username AND Password = @Password"
            Case "Guest"
                query = "SELECT COUNT(*) FROM Guest WHERE Username = @Username AND Password = @Password"
            Case "Housekeeping"
                query = "SELECT COUNT(*) FROM Housekeeping WHERE Username = @Username AND Password = @Password"
            Case Else
                Return False ' Invalid user type
        End Select

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False ' Error occurred during authentication
        End Try
    End Function


    Private Sub linkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSignUp.LinkClicked
        ' Open the signup form
        Dim signUpForm As New SignUpForm()
        signUpForm.Show()
        Me.Hide() ' Hide the login form
    End Sub

End Class
