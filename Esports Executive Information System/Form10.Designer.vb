<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim LastnameLabel As System.Windows.Forms.Label
        Dim ContactnumberLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim BirthdateLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim MonthlysalaryLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TeamLiquidDataSet = New Esports_Executive_Information_System.TeamLiquidDataSet()
        Me.TblEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployeesTableAdapter = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblEmployeesTableAdapter()
        Me.TableAdapterManager = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager()
        Me.TblEmployeesGuna2DataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FiirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.LastnameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactnumberTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.MonthlysalaryTextBox = New System.Windows.Forms.TextBox()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        LastnameLabel = New System.Windows.Forms.Label()
        ContactnumberLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        BirthdateLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        MonthlysalaryLabel = New System.Windows.Forms.Label()
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeesGuna2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(29, 166)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(61, 45)
        IDLabel.TabIndex = 4
        IDLabel.Text = "ID:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstnameLabel.Location = New System.Drawing.Point(29, 250)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(186, 45)
        FirstnameLabel.TabIndex = 6
        FirstnameLabel.Text = "firstname:"
        '
        'LastnameLabel
        '
        LastnameLabel.AutoSize = True
        LastnameLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastnameLabel.Location = New System.Drawing.Point(29, 334)
        LastnameLabel.Name = "LastnameLabel"
        LastnameLabel.Size = New System.Drawing.Size(181, 45)
        LastnameLabel.TabIndex = 8
        LastnameLabel.Text = "lastname:"
        '
        'ContactnumberLabel
        '
        ContactnumberLabel.AutoSize = True
        ContactnumberLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactnumberLabel.Location = New System.Drawing.Point(29, 418)
        ContactnumberLabel.Name = "ContactnumberLabel"
        ContactnumberLabel.Size = New System.Drawing.Size(287, 45)
        ContactnumberLabel.TabIndex = 10
        ContactnumberLabel.Text = "contactnumber:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PositionLabel.Location = New System.Drawing.Point(1112, 166)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(163, 45)
        PositionLabel.TabIndex = 12
        PositionLabel.Text = "position:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(1112, 250)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(226, 45)
        DepartmentLabel.TabIndex = 14
        DepartmentLabel.Text = "department:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(1112, 334)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(161, 45)
        AddressLabel.TabIndex = 16
        AddressLabel.Text = "address:"
        '
        'BirthdateLabel
        '
        BirthdateLabel.AutoSize = True
        BirthdateLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BirthdateLabel.Location = New System.Drawing.Point(1112, 418)
        BirthdateLabel.Name = "BirthdateLabel"
        BirthdateLabel.Size = New System.Drawing.Size(183, 45)
        BirthdateLabel.TabIndex = 18
        BirthdateLabel.Text = "birthdate:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(29, 496)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(118, 45)
        EmailLabel.TabIndex = 20
        EmailLabel.Text = "email:"
        '
        'MonthlysalaryLabel
        '
        MonthlysalaryLabel.AutoSize = True
        MonthlysalaryLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MonthlysalaryLabel.Location = New System.Drawing.Point(1112, 499)
        MonthlysalaryLabel.Name = "MonthlysalaryLabel"
        MonthlysalaryLabel.Size = New System.Drawing.Size(265, 45)
        MonthlysalaryLabel.TabIndex = 22
        MonthlysalaryLabel.Text = "monthlysalary:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kaneda Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 134)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Employees"
        '
        'TeamLiquidDataSet
        '
        Me.TeamLiquidDataSet.DataSetName = "TeamLiquidDataSet"
        Me.TeamLiquidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblEmployeesBindingSource
        '
        Me.TblEmployeesBindingSource.DataMember = "tblEmployees"
        Me.TblEmployeesBindingSource.DataSource = Me.TeamLiquidDataSet
        '
        'TblEmployeesTableAdapter
        '
        Me.TblEmployeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAchievementsTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeesTableAdapter = Me.TblEmployeesTableAdapter
        Me.TableAdapterManager.tblExecutivesTableAdapter = Nothing
        Me.TableAdapterManager.tblFinanceTableAdapter = Nothing
        Me.TableAdapterManager.tblSponsorsTableAdapter = Nothing
        Me.TableAdapterManager.tblTeamsPlayersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblEmployeesGuna2DataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.TblEmployeesGuna2DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TblEmployeesGuna2DataGridView.AutoGenerateColumns = False
        Me.TblEmployeesGuna2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblEmployeesGuna2DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblEmployeesGuna2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblEmployeesGuna2DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TblEmployeesGuna2DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblEmployeesGuna2DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TblEmployeesGuna2DataGridView.ColumnHeadersHeight = 37
        Me.TblEmployeesGuna2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TblEmployeesGuna2DataGridView.DataSource = Me.TblEmployeesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("DM Sans 14pt Medium", 9.857142!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TblEmployeesGuna2DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.TblEmployeesGuna2DataGridView.EnableHeadersVisualStyles = False
        Me.TblEmployeesGuna2DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblEmployeesGuna2DataGridView.Location = New System.Drawing.Point(29, 699)
        Me.TblEmployeesGuna2DataGridView.Name = "TblEmployeesGuna2DataGridView"
        Me.TblEmployeesGuna2DataGridView.RowHeadersVisible = False
        Me.TblEmployeesGuna2DataGridView.RowTemplate.Height = 31
        Me.TblEmployeesGuna2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblEmployeesGuna2DataGridView.Size = New System.Drawing.Size(2448, 809)
        Me.TblEmployeesGuna2DataGridView.TabIndex = 4
        Me.TblEmployeesGuna2DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.HeaderStyle.Height = 37
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.ReadOnly = False
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("DM Sans 14pt Medium", 9.857142!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.RowsStyle.Height = 31
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblEmployeesGuna2DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.FillWeight = 38.67067!
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fiirstname"
        Me.DataGridViewTextBoxColumn2.FillWeight = 91.37057!
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "lastname"
        Me.DataGridViewTextBoxColumn3.FillWeight = 89.42197!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "contactnumber"
        Me.DataGridViewTextBoxColumn4.FillWeight = 133.6653!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "position"
        Me.DataGridViewTextBoxColumn5.FillWeight = 88.462!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "department"
        Me.DataGridViewTextBoxColumn6.FillWeight = 97.93703!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn7.FillWeight = 152.345!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "birthdate"
        Me.DataGridViewTextBoxColumn8.FillWeight = 74.87579!
        Me.DataGridViewTextBoxColumn8.HeaderText = "Birthdate"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn9.FillWeight = 116.6258!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "monthlysalary"
        Me.DataGridViewTextBoxColumn10.FillWeight = 116.6258!
        Me.DataGridViewTextBoxColumn10.HeaderText = "Monthly Salary"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeesBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(333, 159)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(747, 50)
        Me.IDTextBox.TabIndex = 5
        '
        'FiirstnameTextBox
        '
        Me.FiirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeesBindingSource, "fiirstname", True))
        Me.FiirstnameTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiirstnameTextBox.Location = New System.Drawing.Point(333, 247)
        Me.FiirstnameTextBox.Name = "FiirstnameTextBox"
        Me.FiirstnameTextBox.Size = New System.Drawing.Size(747, 50)
        Me.FiirstnameTextBox.TabIndex = 7
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeesBindingSource, "lastname", True))
        Me.LastnameTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastnameTextBox.Location = New System.Drawing.Point(333, 331)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(747, 50)
        Me.LastnameTextBox.TabIndex = 9
        '
        'ContactnumberTextBox
        '
        Me.ContactnumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeesBindingSource, "contactnumber", True))
        Me.ContactnumberTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactnumberTextBox.Location = New System.Drawing.Point(333, 415)
        Me.ContactnumberTextBox.Name = "ContactnumberTextBox"
        Me.ContactnumberTextBox.Size = New System.Drawing.Size(747, 50)
        Me.ContactnumberTextBox.TabIndex = 11
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeesBindingSource, "position", True))
        Me.PositionTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionTextBox.Location = New System.Drawing.Point(1393, 159)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(1041, 50)
        Me.PositionTextBox.TabIndex = 13
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeesBindingSource, "department", True))
        Me.DepartmentComboBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Items.AddRange(New Object() {"Marketing", "Broadcaster", "Agent", "Content Creator", "Coach", "Journalist", "Referee", "Social Media Manager", "Design", "Event Management", "Sales Manager", "Senior Management", "IT"})
        Me.DepartmentComboBox.Location = New System.Drawing.Point(1393, 247)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(1041, 51)
        Me.DepartmentComboBox.TabIndex = 15
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeesBindingSource, "address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(1393, 331)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(1041, 50)
        Me.AddressTextBox.TabIndex = 17
        '
        'BirthdateDateTimePicker
        '
        Me.BirthdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblEmployeesBindingSource, "birthdate", True))
        Me.BirthdateDateTimePicker.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthdateDateTimePicker.Location = New System.Drawing.Point(1393, 412)
        Me.BirthdateDateTimePicker.Name = "BirthdateDateTimePicker"
        Me.BirthdateDateTimePicker.Size = New System.Drawing.Size(1041, 50)
        Me.BirthdateDateTimePicker.TabIndex = 19
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeesBindingSource, "email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(333, 496)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(747, 50)
        Me.EmailTextBox.TabIndex = 21
        '
        'MonthlysalaryTextBox
        '
        Me.MonthlysalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeesBindingSource, "monthlysalary", True))
        Me.MonthlysalaryTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlysalaryTextBox.Location = New System.Drawing.Point(1393, 496)
        Me.MonthlysalaryTextBox.Name = "MonthlysalaryTextBox"
        Me.MonthlysalaryTextBox.Size = New System.Drawing.Size(1041, 50)
        Me.MonthlysalaryTextBox.TabIndex = 23
        '
        'Guna2Button4
        '
        Me.Guna2Button4.AutoRoundedCorners = True
        Me.Guna2Button4.BorderRadius = 56
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.FillColor = System.Drawing.Color.Brown
        Me.Guna2Button4.Font = New System.Drawing.Font("DM Sans", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(2164, 16)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(270, 114)
        Me.Guna2Button4.TabIndex = 32
        Me.Guna2Button4.Text = "DELETE"
        Me.Guna2Button4.TextOffset = New System.Drawing.Point(0, 3)
        '
        'Guna2Button3
        '
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BorderRadius = 56
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.DarkBlue
        Me.Guna2Button3.Font = New System.Drawing.Font("DM Sans", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(1868, 16)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(270, 114)
        Me.Guna2Button3.TabIndex = 31
        Me.Guna2Button3.Text = "SAVE"
        Me.Guna2Button3.TextOffset = New System.Drawing.Point(0, 3)
        '
        'Guna2Button2
        '
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BorderRadius = 56
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Orange
        Me.Guna2Button2.Font = New System.Drawing.Font("DM Sans", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(1572, 16)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(270, 114)
        Me.Guna2Button2.TabIndex = 30
        Me.Guna2Button2.Text = "EDIT"
        Me.Guna2Button2.TextOffset = New System.Drawing.Point(0, 3)
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 56
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.DarkGreen
        Me.Guna2Button1.Font = New System.Drawing.Font("DM Sans", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(1276, 16)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(270, 114)
        Me.Guna2Button1.TabIndex = 29
        Me.Guna2Button1.Text = "ADD"
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(0, 3)
        '
        'Guna2Button5
        '
        Me.Guna2Button5.AutoRoundedCorners = True
        Me.Guna2Button5.BorderRadius = 45
        Me.Guna2Button5.CheckedState.Parent = Me.Guna2Button5
        Me.Guna2Button5.CustomImages.Parent = Me.Guna2Button5
        Me.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("DM Sans", 20.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Guna2Button5.HoverState.Parent = Me.Guna2Button5
        Me.Guna2Button5.Location = New System.Drawing.Point(1271, 588)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.Parent = Me.Guna2Button5
        Me.Guna2Button5.Size = New System.Drawing.Size(270, 93)
        Me.Guna2Button5.TabIndex = 47
        Me.Guna2Button5.Text = "Print"
        Me.Guna2Button5.TextOffset = New System.Drawing.Point(0, 3)
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BorderRadius = 41
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("DM Sans", 20.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(246, 590)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(9, 14, 9, 14)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(1013, 84)
        Me.Guna2TextBox1.TabIndex = 46
        Me.Guna2TextBox1.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("DM Sans", 21.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 597)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 67)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Search:"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(2497, 1593)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(FirstnameLabel)
        Me.Controls.Add(Me.FiirstnameTextBox)
        Me.Controls.Add(LastnameLabel)
        Me.Controls.Add(Me.LastnameTextBox)
        Me.Controls.Add(ContactnumberLabel)
        Me.Controls.Add(Me.ContactnumberTextBox)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(BirthdateLabel)
        Me.Controls.Add(Me.BirthdateDateTimePicker)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(MonthlysalaryLabel)
        Me.Controls.Add(Me.MonthlysalaryTextBox)
        Me.Controls.Add(Me.TblEmployeesGuna2DataGridView)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form10"
        Me.Text = "Form10"
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeesGuna2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TeamLiquidDataSet As Esports_Executive_Information_System.TeamLiquidDataSet
    Friend WithEvents TblEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployeesTableAdapter As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblEmployeesTableAdapter
    Friend WithEvents TableAdapterManager As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblEmployeesGuna2DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FiirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactnumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PositionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthdateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MonthlysalaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
