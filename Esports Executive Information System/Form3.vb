Public Class Form3

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub TblExecutivesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblExecutivesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLiquidDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLiquidDataSet.tblExecutives' table. You can move, or remove it, as needed.
        Me.TblExecutivesTableAdapter.Update(Me.TeamLiquidDataSet.tblExecutives)
        Me.TblExecutivesBindingSource.EndEdit()
        Me.TblExecutivesBindingSource.AddNew()
    
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Me.TblExecutivesBindingSource.EndEdit()
        Me.TblExecutivesBindingSource.AddNew()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) OrElse
                 String.IsNullOrWhiteSpace(LastnameTextBox.Text) OrElse
                    String.IsNullOrWhiteSpace(BirthdateDateTimePicker.Text) OrElse
                        String.IsNullOrWhiteSpace(ExecutivetypeComboBox.Text) OrElse
                         String.IsNullOrWhiteSpace(AddressTextBox.Text) OrElse
                        String.IsNullOrWhiteSpace(ContactnumberTextBox.Text) OrElse
                      String.IsNullOrWhiteSpace(EmailTextBox.Text) OrElse
            String.IsNullOrWhiteSpace(UsernameTextBox.Text) OrElse
             String.IsNullOrWhiteSpace(PasswordTextBox.Text) Then
            MessageBox.Show("please fill all fields")
            Exit Sub
        End If
        Try
            Me.Validate()
            Me.TblExecutivesBindingSource.EndEdit()
            Me.TblExecutivesTableAdapter.Update(Me.TeamLiquidDataSet.tblExecutives)
            MessageBox.Show("Record saved successfully!")
        Catch ex As Exception
            MessageBox.Show("An error ocurred during saving:" & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    
End Class