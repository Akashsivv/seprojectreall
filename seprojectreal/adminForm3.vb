Imports System.Data.SqlClient

Public Class adminForm3
    Dim connectionString As String = "Data Source=LAPTOP-AGD0GN4V;Initial Catalog=Gustroomgmt;Integrated Security=True"

    Private Sub adminForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView when the form loads
        LoadBookingDetails()
    End Sub

    Private Sub LoadBookingDetails()
        ' Create a SqlConnection using the connection string
        Using connection As New SqlConnection(connectionString)
            ' Open the connection
            connection.Open()

            ' Define the SQL query to select booking details with guest full names
            Dim query As String = "SELECT Guest.FullName, Bookings.* FROM Guest INNER JOIN Bookings ON Guest.CID = Bookings.CID"

            ' Create a SqlDataAdapter to execute the query and fill the DataTable
            Using adapter As New SqlDataAdapter(query, connection)
                ' Create a DataTable to hold the results
                Dim dataTable As New DataTable()

                ' Fill the DataTable with data from the query
                adapter.Fill(dataTable)

                ' Bind the DataTable to the DataGridView
                DataGridView1.DataSource = dataTable
            End Using
        End Using
    End Sub
End Class
