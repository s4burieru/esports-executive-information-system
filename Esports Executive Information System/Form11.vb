Public Class Form11

    Private Sub TblExecutivesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblExecutivesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)

    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblExecutives' table. You can move, or remove it, as needed.
        Me.TblExecutivesTableAdapter.Fill(Me.TeamLiquidDataSet.tblExecutives)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        TblExecutivesBindingSource.AddNew()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Validate()
        Me.TblExecutivesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        Me.TblExecutivesTableAdapter.Fill(Me.TeamLiquidDataSet.tblExecutives)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Validate()
        Me.TblExecutivesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        Me.TblExecutivesTableAdapter.Fill(Me.TeamLiquidDataSet.tblExecutives)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If MsgBox("Do you want to delete this data?", vbYesNo) = vbYes Then
            TblExecutivesBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TblExecutivesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
            Me.TblExecutivesTableAdapter.Fill(Me.TeamLiquidDataSet.tblExecutives)
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Me.TblExecutivesTableAdapter.Search(Me.TeamLiquidDataSet.tblExecutives, Guna2TextBox1.Text + "%")
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Form17.Show()
        Form17.tblExecutivesTableAdapter.Search(Me.TeamLiquidDataSet.tblExecutives, Guna2TextBox1.Text)
        Form17.ReportViewer1.RefreshReport()
    End Sub
End Class