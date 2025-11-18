Public Class Form14

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblTeamsPlayers' table. You can move, or remove it, as needed.
        Me.tblTeamsPlayersTableAdapter.Fill(Me.TeamLiquidDataSet.tblTeamsPlayers)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class