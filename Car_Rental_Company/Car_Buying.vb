Imports System.Data.SqlClient
Public Class Car_Buying
    Dim mysqlconn As SqlConnection
    Dim Command As SqlCommand
    Dim TrackCommand As SqlCommand

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=Car_RentalSystem;Integrated Security=True"
        Dim Reader As SqlDataReader
        Dim Reader2 As SqlDataReader

        Try
            mysqlconn.Open()
            Dim Query As String
            Dim Query2 As String

            Query = " insert into Car_Buying(customer_name,customer_id,car_name,car_id,buying_price,date_bought) values  
            ('" & Customer_Name.Text & "','" & Customer_Id.Text & "','" & Car_Name.Text & "','" & Car_Id.Text & "','" & Car_Price.Text & "','" & Date_Bought.Text & "' ) "

            Query2 = " insert into Car_History(customer_name,customer_id,car_name,car_id,buying_price,date_bought) values  
            ('" & Customer_Name.Text & "','" & Customer_Id.Text & "','" & Car_Name.Text & "','" & Car_Id.Text & "','" & Car_Price.Text & "','" & Date_Bought.Text & "' ) "


            Command = New SqlCommand(Query, mysqlconn)
            Reader = Command.ExecuteReader
            TrackCommand = New SqlCommand(Query2, mysqlconn)
            Reader2 = TrackCommand.ExecuteReader

            MessageBox.Show("Customer Successfully Registered")
            mysqlconn.Close()
            Me.Close()
            Buy_Transactions.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My_Car.Image = Car_Show.Car_Picture.Image
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Home.Close()
    End Sub
End Class