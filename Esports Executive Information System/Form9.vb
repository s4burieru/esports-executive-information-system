Public Class Form9

    Private Sub TblFinanceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblFinanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblFinance' table. You can move, or remove it, as needed.
        Me.TblFinanceTableAdapter.Fill(Me.TeamLiquidDataSet.tblFinance)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        TblFinanceBindingSource.AddNew()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Validate()
        Me.TblFinanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        Me.TblFinanceTableAdapter.Fill(Me.TeamLiquidDataSet.tblFinance)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Validate()
        Me.TblFinanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        Me.TblFinanceTableAdapter.Fill(Me.TeamLiquidDataSet.tblFinance)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If MsgBox("Do you want to delete this data?", vbYesNo) = vbYes Then
            TblFinanceBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TblFinanceBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
            Me.TblFinanceTableAdapter.Fill(Me.TeamLiquidDataSet.tblFinance)
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Me.TblFinanceTableAdapter.Search(Me.TeamLiquidDataSet.tblFinance, Guna2TextBox1.Text + "%")
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Form15.Show()
        Form15.tblFinanceTableAdapter.Search(Me.TeamLiquidDataSet.tblFinance, Guna2TextBox1.Text)
        Form15.ReportViewer1.RefreshReport()
    End Sub
End Class