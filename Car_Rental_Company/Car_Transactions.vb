Public Class Car_Transactions
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Home.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Admin_Page.Show()
    End Sub

    Private Sub Car_Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Car_RentalSystemDataSet2.Car_History' table. You can move, or remove it, as needed.
        Me.Car_HistoryTableAdapter.Fill(Me.Car_RentalSystemDataSet2.Car_History)

    End Sub
End Class