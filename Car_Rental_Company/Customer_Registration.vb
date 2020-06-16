Imports System.Data.SqlClient

Public Class Customer_Registration
    Dim mysqlconn As SqlConnection
    Dim Command As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=Car_RentalSystem;Integrated Security=True"
        Dim Reader As SqlDataReader

        Try
            mysqlconn.Open()
            Dim Query As String

            Query = " insert into Customer_Registration(customer_name,customer_id,contact,email,area_residence,gender) values  
            ('" & Customer_Name.Text & "','" & Customer_Id.Text & "','" & Contact.Text & "','" & Email.Text & "','" & Area_Residence.Text & "','" & Gender.Text & "' ) "

            Command = New SqlCommand(Query, mysqlconn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Customer Successfully Registered")
            mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Home.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=Car_RentalSystem;Integrated Security=True"
        Dim Reader As SqlDataReader
        Dim Opf As New OpenFileDialog

        Opf.Filter = "Choose Image(*.JPG;*PNG;*GIF)| *.jpg;*.png;*.gif"

        If Opf.ShowDialog = DialogResult.OK Then
            Customer_Picture.Image = Image.FromFile(Opf.FileName)

        End If

        Dim filename As String = Opf.FileName + ".jpg"
        Dim filesize As Int32

        Dim mstream As New System.IO.MemoryStream()
        Customer_Picture.Image.Save(mstream, Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        filesize = mstream.Length

        Dim Command As New SqlCommand
        mstream.Close()

        Dim ImageQuery As String = "
        insert into Customer_Registration(customer_picture,picture_name,picture_size) values
        (@Customer_Picture,@filename,@filesize)     "

        Try
            mysqlconn.Open()
            With Command
                .CommandText = ImageQuery
                .Connection = mysqlconn
                .Parameters.AddWithValue("@Customer_Picture", arrImage)
                .Parameters.AddWithValue("@filename", filename)
                .Parameters.AddWithValue("@filesize", filesize)

                If Command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Image Inserted")
                    Me.Close()
                    Car_Show.Show()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Staff_Page.Show()
    End Sub
End Class