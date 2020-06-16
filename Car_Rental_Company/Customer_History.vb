Public Class Customer_History
    Private Sub Customer_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Car_RentalSystemDataSet.Car_Track' table. You can move, or remove it, as needed.
        Me.Car_TrackTableAdapter.Fill(Me.Car_RentalSystemDataSet.Car_Track)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Admin_Page.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Home.Close()
    End Sub
End Class