Public Class Form13

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblSponsors' table. You can move, or remove it, as needed.
        Me.tblSponsorsTableAdapter.Fill(Me.TeamLiquidDataSet.tblSponsors)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class