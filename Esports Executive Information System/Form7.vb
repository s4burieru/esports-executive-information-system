Public Class Form7

    Private Sub TblSponsorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblSponsorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblSponsors' table. You can move, or remove it, as needed.
        Me.TblSponsorsTableAdapter.Fill(Me.TeamLiquidDataSet.tblSponsors)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        TblSponsorsBindingSource.AddNew()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Validate()
        Me.TblSponsorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        Me.TblSponsorsTableAdapter.Fill(Me.TeamLiquidDataSet.tblSponsors)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Validate()
        Me.TblSponsorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        Me.TblSponsorsTableAdapter.Fill(Me.TeamLiquidDataSet.tblSponsors)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If MsgBox("Do you want to delete this data?", vbYesNo) = vbYes Then
            TblSponsorsBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TblSponsorsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
            Me.TblSponsorsTableAdapter.Fill(Me.TeamLiquidDataSet.tblSponsors)
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Me.TblSponsorsTableAdapter.Search(Me.TeamLiquidDataSet.tblSponsors, Guna2TextBox1.Text + "%")
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Form13.Show()
        Me.TblSponsorsTableAdapter.Search(Me.TeamLiquidDataSet.tblSponsors, Guna2TextBox1.Text)
    End Sub
End Class