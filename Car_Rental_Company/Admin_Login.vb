Imports System.Data.SqlClient

Public Class Admin_Login
    Dim mysqlconn As SqlConnection
    Dim Command As SqlCommand

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Admin_ID.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=Car_RentalSystem;Integrated Security=True"
        Dim Reader As SqlDataReader

        Try
            mysqlconn.Open()
            Dim Query As String
            Query = "
            select *from Registered_Admins where admin_id='" & Admin_ID.Text & "' and admin_password='" & Admin_Password.Text & "' "
            Command = New SqlCommand(Query, mysqlconn)
            Reader = Command.ExecuteReader

            If Reader.HasRows Then
                Me.Close()
                Admin_Page.Show()

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