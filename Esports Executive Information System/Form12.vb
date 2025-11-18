Public Class Form12

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblSponsors' table. You can move, or remove it, as needed.
        Me.tblSponsorsTableAdapter.Fill(Me.TeamLiquidDataSet.tblSponsors)
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblAchievements' table. You can move, or remove it, as needed.
        Me.tblAchievementsTableAdapter.Fill(Me.TeamLiquidDataSet.tblAchievements)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class