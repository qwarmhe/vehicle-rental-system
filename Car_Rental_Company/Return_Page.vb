Imports System.Data.SqlClient
Public Class Return_Page
    Dim mysqlconn As SqlConnection
    Dim Command As SqlCommand
    Dim TrackCommand As SqlCommand
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Previous.Click
        Me.Close()
        Home.Close()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=Car_RentalSystem;Integrated Security=True"
        Dim Reader As SqlDataReader

        Try
            mysqlconn.Open()
            Dim Query As String
           
            Query = " insert into Car_Track(customer_name,customer_id,car_name,car_id,issued_date,due_date,returned_date) values  
            ('" & Customer_Name.Text & "','" & Customer_ID.Text & "','" & Car_Name.Text & "','" & Car_ID.Text & "','" & Issued_Date.Text & "','" & Due_Date.Text & "','" & Returned_Date.Text & "' ) "


            Command = New SqlCommand(Query, mysqlconn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Customer Successfully Registered")
            mysqlconn.Close()
            Me.Close()
            Buy_Transactions.Show()
            Me.Close()
            Staff_Page.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
        Staff_Page.Show()
    End Sub
End Class