Public Class Form16

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblEmployees' table. You can move, or remove it, as needed.
        Me.tblEmployeesTableAdapter.Fill(Me.TeamLiquidDataSet.tblEmployees)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class