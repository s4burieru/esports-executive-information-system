Public Class Form17

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblExecutives' table. You can move, or remove it, as needed.
        Me.tblExecutivesTableAdapter.Fill(Me.TeamLiquidDataSet.tblExecutives)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class