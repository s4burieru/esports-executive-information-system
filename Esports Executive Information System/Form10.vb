Public Class Form10

    Private Sub TblEmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblEmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblEmployees' table. You can move, or remove it, as needed.
        Me.TblEmployeesTableAdapter.Fill(Me.TeamLiquidDataSet.tblEmployees)

    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        TblEmployeesBindingSource.AddNew()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Validate()
        Me.TblEmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        Me.TblEmployeesTableAdapter.Fill(Me.TeamLiquidDataSet.tblEmployees)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Validate()
        Me.TblEmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
        Me.TblEmployeesTableAdapter.Fill(Me.TeamLiquidDataSet.tblEmployees)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If MsgBox("Do you want to delete this data?", vbYesNo) = vbYes Then
            TblEmployeesBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TblEmployeesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)
            Me.TblEmployeesTableAdapter.Fill(Me.TeamLiquidDataSet.tblEmployees)
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Me.TblEmployeesTableAdapter.Search(Me.TeamLiquidDataSet.tblEmployees, Guna2TextBox1.Text + "%")
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Form16.Show()
        Form16.tblEmployeesTableAdapter.Search(Me.TeamLiquidDataSet.tblEmployees, Guna2TextBox1.Text)
        Form16.ReportViewer1.RefreshReport()
    End Sub
End Class