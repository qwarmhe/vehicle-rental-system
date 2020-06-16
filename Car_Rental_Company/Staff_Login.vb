Imports System.Data.SqlClient
Public Class Staff_Login
    Dim mysqlconn As SqlConnection
    Dim Command As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=Car_RentalSystem;Integrated Security=True"
        Dim Reader As SqlDataReader

        Try
            mysqlconn.Open()
            Dim Query As String
            Query = "
            select *from Registered_Staff where staff_id='" & Staff_Id.Text & "' and staff_password='" & Staff_Password.Text & "' "
            Command = New SqlCommand(Query, mysqlconn)
            Reader = Command.ExecuteReader

            If Reader.HasRows Then
                Me.Close()
                Staff_Page.Show()

            Else
                MessageBox.Show("Incorrect Username or Password")
            End If

            mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            mysqlconn.Dispose()
        End Try
    End Sub
End Class