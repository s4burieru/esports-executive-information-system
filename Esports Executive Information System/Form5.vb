Public Class Form5

    Private Sub TblTeamsPlayersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

        Me.Validate()
        Me.TblTeamsPlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)

    End Sub

    Private Sub TblExecutivesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblExecutivesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.qryAchievementsSummary' table. You can move, or remove it, as needed.
        Me.QryAchievementsSummaryTableAdapter.Fill(Me.DataSet1.qryAchievementsSummary)
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblAchievements' table. You can move, or remove it, as needed.
        Me.TblAchievementsTableAdapter.Fill(Me.TeamLiquidDataSet.tblAchievements)
        Me.Validate()
        Me.TblAchievementsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblEmployees' table. You can move, or remove it, as needed.
        Me.TblEmployeesTableAdapter.Fill(Me.TeamLiquidDataSet.tblEmployees)
        Me.Validate()
        Me.TblEmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblExecutives' table. You can move, or remove it, as needed.
        Me.TblExecutivesTableAdapter.Fill(Me.TeamLiquidDataSet.tblExecutives)
        Me.Validate()
        Me.TblExecutivesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblFinance' table. You can move, or remove it, as needed.
        Me.TblFinanceTableAdapter.Fill(Me.TeamLiquidDataSet.tblFinance)
        Me.Validate()
        Me.TblFinanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblSponsors' table. You can move, or remove it, as needed.
        Me.TblSponsorsTableAdapter.Fill(Me.TeamLiquidDataSet.tblSponsors)
        Me.Validate()
        Me.TblSponsorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblTeamsPlayers' table. You can move, or remove it, as needed.
        Me.TblTeamsPlayersTableAdapter.Fill(Me.TeamLiquidDataSet.tblTeamsPlayers)
        Me.Validate()
        Me.TblTeamsPlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)

        Label6.Text = TblTeamsPlayersBindingSource.Count()
        Label7.Text = TblEmployeesBindingSource.Count()
        Label8.Text = TblExecutivesBindingSource.Count()
        Label9.Text = TblSponsorsBindingSource.Count()

    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Chart2_Click_1(sender As Object, e As EventArgs) Handles Chart2.Click

    End Sub
End Class