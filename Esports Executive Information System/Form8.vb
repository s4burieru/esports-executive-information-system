Public Class Form8

    Private Sub TblTeamsPlayersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblTeamsPlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblTeamsPlayers' table. You can move, or remove it, as needed.
        Me.TblTeamsPlayersTableAdapter.Fill(Me.TeamLiquidDataSet.tblTeamsPlayers)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        TblTeamsPlayersBindingSource.AddNew()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Validate()
        Me.TblTeamsPlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        Me.TblTeamsPlayersTableAdapter.Fill(Me.TeamLiquidDataSet.tblTeamsPlayers)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Validate()
        Me.TblTeamsPlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        Me.TblTeamsPlayersTableAdapter.Fill(Me.TeamLiquidDataSet.tblTeamsPlayers)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If MsgBox("Do you want to delete this data?", vbYesNo) = vbYes Then
            TblTeamsPlayersBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TblTeamsPlayersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
            Me.TblTeamsPlayersTableAdapter.Fill(Me.TeamLiquidDataSet.tblTeamsPlayers)
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Me.TblTeamsPlayersTableAdapter.Search(Me.TeamLiquidDataSet.tblTeamsPlayers, Guna2TextBox1.Text + "%")
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Form14.Show()
        Form14.tblTeamsPlayersTableAdapter.Search(Me.TeamLiquidDataSet.tblTeamsPlayers, Guna2TextBox1.Text)
        Form14.ReportViewer1.RefreshReport()
    End Sub
End Class