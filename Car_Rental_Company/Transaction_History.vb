Public Class Transaction_History
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Home.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Admin_Page.Show()
    End Sub

    Private Sub Transaction_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Car_RentalSystemDataSet1.Transaction_History' table. You can move, or remove it, as needed.
        Me.Transaction_HistoryTableAdapter.Fill(Me.Car_RentalSystemDataSet1.Transaction_History)

    End Sub
End Class