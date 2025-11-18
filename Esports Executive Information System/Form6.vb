Public Class Form6

    Private Sub TblAchievementsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblAchievementsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblAchievements' table. You can move, or remove it, as needed.
        Me.TblAchievementsTableAdapter.Fill(Me.TeamLiquidDataSet.tblAchievements)

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Form12.Show()
        Form12.tblAchievementsTableAdapter.Search(Me.TeamLiquidDataSet.tblAchievements, Guna2TextBox1.Text)
        Form12.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        TblAchievementsBindingSource.AddNew()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Validate()
        Me.TblAchievementsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        Me.TblAchievementsTableAdapter.Fill(Me.TeamLiquidDataSet.tblAchievements)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If MsgBox("Do you want to delete this data?", vbYesNo) = vbYes Then
            TblAchievementsBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TblAchievementsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
            Me.TblAchievementsTableAdapter.Fill(Me.TeamLiquidDataSet.tblAchievements)
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Validate()
        Me.TblAchievementsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        Me.TblAchievementsTableAdapter.Fill(Me.TeamLiquidDataSet.tblAchievements)
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Me.TblAchievementsTableAdapter.Search(Me.TeamLiquidDataSet.tblAchievements, Guna2TextBox1.Text + "%")
    End Sub
End Class