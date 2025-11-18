Public Class Form2

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.TblExecutivesTableAdapter.Login(Me.TeamLiquidDataSet.tblExecutives, Guna2TextBox1.Text, Guna2TextBox2.Text)
        If TblExecutivesBindingSource.Count = 1 Then
            Form4.Show()
            Form4.Label1.Text = "Welcome, " + TblExecutivesBindingSource.Current.item("executivetype") + "!"
            Me.Close()
        Else
            MsgBox("Wrong username or password!")
        End If
    End Sub

    Private Sub TblExecutivesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblExecutivesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblExecutives' table. You can move, or remove it, as needed.
        Me.TblExecutivesTableAdapter.Fill(Me.TeamLiquidDataSet.tblExecutives)

    End Sub
End Class