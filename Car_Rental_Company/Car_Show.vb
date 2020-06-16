Imports System.Data.SqlClient
Public Class Car_Show
    Dim mysqlconn As SqlConnection
    Dim Command As SqlCommand
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Car_Buying.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Car_Rental.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=Car_RentalSystem;Integrated Security=True"
        Dim ImageQuery As String
        Dim adapter As New SqlDataAdapter
        Dim Data As New DataTable
        adapter = New SqlDataAdapter("select car_name,car_id,date_in,car_price,rental_price,car_image from Car_ShowCase", mysqlconn)
        Car_Name.Text = "car_name"
        Car_Id.Text = "car_id"
        Date_In.Text = "date_in"
        Rent_Price.Text = "rental_price"
        Buy_Price.Text = "car_price"

        Dim MyField_Query

        Dim commandbuild As New SqlCommandBuilder(adapter)
        adapter.Fill(Data)

        Dim picbyte() As Byte = Data.Rows(0).Item("car_image")
        Dim pic As New System.IO.MemoryStream(picbyte)
        Car_Picture.Image = Image.FromStream(pic)


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        Home.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Staff_Page.Show()

    End Sub

    Private Sub Car_Picture_Click(sender As Object, e As EventArgs) Handles Car_Picture.Click

    End Sub
End Class