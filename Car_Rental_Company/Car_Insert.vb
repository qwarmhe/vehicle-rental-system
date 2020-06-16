Imports System.Data.SqlClient
Public Class Car_Insert
    Dim mysqlconn As SqlConnection
    Dim Command As SqlCommand
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=Car_RentalSystem;Integrated Security=True"
        Dim Reader As SqlDataReader

        Try
            mysqlconn.Open()
            Dim Query As String

            Query = " insert into Car_Insertion
            (name,
            id,
            colour,
            in_date,
            maintenance_date,
            buying_price,
            rental_price) 
            values  
            (
            '" & Car_Name.Text & "',
            '" & ID.Text & "',
            '" & Colour.Text & "',
            '" & In_Date.Text & "',
            '" & Maintenance_Date.Text & "',
            '" & Buying_Price.Text & "',
            '" & Rental_Price.Text & "' 
            ) "

            Command = New SqlCommand(Query, mysqlconn)

            MessageBox.Show("Car Successfully Registered/Inserted")
            mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=Car_RentalSystem;Integrated Security=True"
        Dim Opf As New OpenFileDialog

        Opf.Filter = "Choose Image(*.JPG;*PNG;*GIF)| *.jpg;*.png;*.gif"

        If Opf.ShowDialog = DialogResult.OK Then
            Car_Picture.Image = Image.FromFile(Opf.FileName)

        End If

        Dim image_name As String = Opf.FileName + ".jpg"
        Dim image_size As Int32

        Dim mstream As New System.IO.MemoryStream()
        Car_Picture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        image_size = mstream.Length

        Dim Command As New SqlCommand
        mstream.Close()

        Dim ImageQuery As String = "
        insert into Car_Insert
        (image_name,
        image_size,
        car_picture
        ) values
        (@image_name,
        @image_size,
        @Car_Picture
        )     "

        Try
            mysqlconn.Open()
            With Command
                .CommandText = ImageQuery
                .Connection = mysqlconn
                .Parameters.AddWithValue("@Car_Picture", arrImage)
                .Parameters.AddWithValue("@image_name", image_name)
                .Parameters.AddWithValue("@image_size", image_size)

                If Command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Image Inserted")

                Else
                    MessageBox.Show("Image Not Inserted")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Home.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Admin_Page.Show()
    End Sub
End Class