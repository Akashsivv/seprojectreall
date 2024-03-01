Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        Dim selectedUserType As String = ""

        ' Check which checkboxes are checked
        If Chkadmin.Checked Then
            selectedUserType = "Admin"
        ElseIf ChkGuest.Checked Then
            selectedUserType = "Guest"
        ElseIf Chkhousekeeping.Checked Then
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
        Else
            MessageBox.Show("Invalid credentials for " & selectedUserType)
        End If
    End Sub

    Private Function AuthenticateUser(userType As String, username As String, password As String) As Boolean
        ' Perform authentication based on user type
        ' You need to implement this function to authenticate against the respective database/table for each user type
        ' Example pseudocode:
        ' If userType = "Admin", authenticate against admin database/table
        ' If userType = "Guest", authenticate against guest database/table
        ' If userType = "Housekeeping", authenticate against housekeeping database/table
        Return False ' Placeholder return value, replace with actual authentication logic
    End Function

    Private Sub linkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        ' Open the signup form
        Dim signUpForm As New signUpForm()
        signUpForm.Show()
        Me.Hide() ' Hide the login form
    End Sub


End Class
