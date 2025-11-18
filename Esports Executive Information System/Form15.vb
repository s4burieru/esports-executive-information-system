Public Class Form15

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblFinance' table. You can move, or remove it, as needed.
        Me.tblFinanceTableAdapter.Fill(Me.TeamLiquidDataSet.tblFinance)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class