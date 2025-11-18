<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim TournamentnameLabel As System.Windows.Forms.Label
        Dim TypeofgameLabel As System.Windows.Forms.Label
        Dim OpponentLabel As System.Windows.Forms.Label
        Dim PrizepoolLabel As System.Windows.Forms.Label
        Dim PlacementLabel As System.Windows.Forms.Label
        Dim TournamentdateLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TeamLiquidDataSet = New Esports_Executive_Information_System.TeamLiquidDataSet()
        Me.TblAchievementsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAchievementsTableAdapter = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblAchievementsTableAdapter()
        Me.TableAdapterManager = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager()
        Me.TblAchievementsGuna2DataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.TournamentnameTextBox = New System.Windows.Forms.TextBox()
        Me.TypeofgameComboBox = New System.Windows.Forms.ComboBox()
        Me.OpponentTextBox = New System.Windows.Forms.TextBox()
        Me.PrizepoolTextBox = New System.Windows.Forms.TextBox()
        Me.PlacementComboBox = New System.Windows.Forms.ComboBox()
        Me.TournamentdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        IDLabel = New System.Windows.Forms.Label()
        TournamentnameLabel = New System.Windows.Forms.Label()
        TypeofgameLabel = New System.Windows.Forms.Label()
        OpponentLabel = New System.Windows.Forms.Label()
        PrizepoolLabel = New System.Windows.Forms.Label()
        PlacementLabel = New System.Windows.Forms.Label()
        TournamentdateLabel = New System.Windows.Forms.Label()
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAchievementsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAchievementsGuna2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.Transparent
        IDLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(29, 181)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(61, 45)
        IDLabel.TabIndex = 3
        IDLabel.Text = "ID:"
        '
        'TournamentnameLabel
        '
        TournamentnameLabel.AutoSize = True
        TournamentnameLabel.BackColor = System.Drawing.Color.Transparent
        TournamentnameLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TournamentnameLabel.Location = New System.Drawing.Point(29, 452)
        TournamentnameLabel.Name = "TournamentnameLabel"
        TournamentnameLabel.Size = New System.Drawing.Size(318, 45)
        TournamentnameLabel.TabIndex = 5
        TournamentnameLabel.Text = "tournamentname:"
        '
        'TypeofgameLabel
        '
        TypeofgameLabel.AutoSize = True
        TypeofgameLabel.BackColor = System.Drawing.Color.Transparent
        TypeofgameLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypeofgameLabel.Location = New System.Drawing.Point(29, 266)
        TypeofgameLabel.Name = "TypeofgameLabel"
        TypeofgameLabel.Size = New System.Drawing.Size(227, 45)
        TypeofgameLabel.TabIndex = 7
        TypeofgameLabel.Text = "typeofgame:"
        '
        'OpponentLabel
        '
        OpponentLabel.AutoSize = True
        OpponentLabel.BackColor = System.Drawing.Color.Transparent
        OpponentLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OpponentLabel.Location = New System.Drawing.Point(29, 362)
        OpponentLabel.Name = "OpponentLabel"
        OpponentLabel.Size = New System.Drawing.Size(190, 45)
        OpponentLabel.TabIndex = 9
        OpponentLabel.Text = "opponent:"
        '
        'PrizepoolLabel
        '
        PrizepoolLabel.AutoSize = True
        PrizepoolLabel.BackColor = System.Drawing.Color.Transparent
        PrizepoolLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrizepoolLabel.Location = New System.Drawing.Point(1287, 181)
        PrizepoolLabel.Name = "PrizepoolLabel"
        PrizepoolLabel.Size = New System.Drawing.Size(181, 45)
        PrizepoolLabel.TabIndex = 11
        PrizepoolLabel.Text = "prizepool:"
        '
        'PlacementLabel
        '
        PlacementLabel.AutoSize = True
        PlacementLabel.BackColor = System.Drawing.Color.Transparent
        PlacementLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlacementLabel.Location = New System.Drawing.Point(1287, 267)
        PlacementLabel.Name = "PlacementLabel"
        PlacementLabel.Size = New System.Drawing.Size(206, 45)
        PlacementLabel.TabIndex = 13
        PlacementLabel.Text = "placement:"
        '
        'TournamentdateLabel
        '
        TournamentdateLabel.AutoSize = True
        TournamentdateLabel.BackColor = System.Drawing.Color.Transparent
        TournamentdateLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TournamentdateLabel.Location = New System.Drawing.Point(1287, 361)
        TournamentdateLabel.Name = "TournamentdateLabel"
        TournamentdateLabel.Size = New System.Drawing.Size(301, 45)
        TournamentdateLabel.TabIndex = 15
        TournamentdateLabel.Text = "tournamentdate:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kaneda Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 134)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Achievements"
        '
        'TeamLiquidDataSet
        '
        Me.TeamLiquidDataSet.DataSetName = "TeamLiquidDataSet"
        Me.TeamLiquidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAchievementsBindingSource
        '
        Me.TblAchievementsBindingSource.DataMember = "tblAchievements"
        Me.TblAchievementsBindingSource.DataSource = Me.TeamLiquidDataSet
        '
        'TblAchievementsTableAdapter
        '
        Me.TblAchievementsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAchievementsTableAdapter = Me.TblAchievementsTableAdapter
        Me.TableAdapterManager.tblEmployeesTableAdapter = Nothing
        Me.TableAdapterManager.tblExecutivesTableAdapter = Nothing
        Me.TableAdapterManager.tblFinanceTableAdapter = Nothing
        Me.TableAdapterManager.tblSponsorsTableAdapter = Nothing
        Me.TableAdapterManager.tblTeamsPlayersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblAchievementsGuna2DataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.TblAchievementsGuna2DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TblAchievementsGuna2DataGridView.AutoGenerateColumns = False
        Me.TblAchievementsGuna2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblAchievementsGuna2DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblAchievementsGuna2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblAchievementsGuna2DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TblAchievementsGuna2DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblAchievementsGuna2DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TblAchievementsGuna2DataGridView.ColumnHeadersHeight = 40
        Me.TblAchievementsGuna2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TblAchievementsGuna2DataGridView.DataSource = Me.TblAchievementsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("DM Sans 14pt Medium", 9.857142!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TblAchievementsGuna2DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.TblAchievementsGuna2DataGridView.EnableHeadersVisualStyles = False
        Me.TblAchievementsGuna2DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblAchievementsGuna2DataGridView.Location = New System.Drawing.Point(29, 684)
        Me.TblAchievementsGuna2DataGridView.Name = "TblAchievementsGuna2DataGridView"
        Me.TblAchievementsGuna2DataGridView.RowHeadersVisible = False
        Me.TblAchievementsGuna2DataGridView.RowTemplate.Height = 30
        Me.TblAchievementsGuna2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblAchievementsGuna2DataGridView.Size = New System.Drawing.Size(2448, 809)
        Me.TblAchievementsGuna2DataGridView.TabIndex = 3
        Me.TblAchievementsGuna2DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.HeaderStyle.Height = 40
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.ReadOnly = False
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("DM Sans 14pt Medium", 9.857142!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.RowsStyle.Height = 30
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblAchievementsGuna2DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.FillWeight = 51.65436!
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 76
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tournamentname"
        Me.DataGridViewTextBoxColumn2.FillWeight = 173.947!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tournament Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 400
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "typeofgame"
        Me.DataGridViewTextBoxColumn3.FillWeight = 91.94998!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type of Game"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "opponent"
        Me.DataGridViewTextBoxColumn4.FillWeight = 91.94998!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Opponent"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "prizepool"
        Me.DataGridViewTextBoxColumn5.FillWeight = 91.94998!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Prize Pool"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "placement"
        Me.DataGridViewTextBoxColumn6.FillWeight = 91.94998!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Placement"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tournamentdate"
        Me.DataGridViewTextBoxColumn7.FillWeight = 106.599!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tournament Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAchievementsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(373, 178)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(878, 50)
        Me.IDTextBox.TabIndex = 4
        '
        'TournamentnameTextBox
        '
        Me.TournamentnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAchievementsBindingSource, "tournamentname", True))
        Me.TournamentnameTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TournamentnameTextBox.Location = New System.Drawing.Point(373, 449)
        Me.TournamentnameTextBox.Name = "TournamentnameTextBox"
        Me.TournamentnameTextBox.Size = New System.Drawing.Size(2063, 50)
        Me.TournamentnameTextBox.TabIndex = 6
        '
        'TypeofgameComboBox
        '
        Me.TypeofgameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAchievementsBindingSource, "typeofgame", True))
        Me.TypeofgameComboBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeofgameComboBox.FormattingEnabled = True
        Me.TypeofgameComboBox.Items.AddRange(New Object() {"Mobile Legends", "Valorant", "DOTA 2", "League of Legends", "PUBG", "Chess", "Rainbow 6", "Cross Fire", "Apex Legends", "Overwatch"})
        Me.TypeofgameComboBox.Location = New System.Drawing.Point(373, 268)
        Me.TypeofgameComboBox.Name = "TypeofgameComboBox"
        Me.TypeofgameComboBox.Size = New System.Drawing.Size(878, 51)
        Me.TypeofgameComboBox.TabIndex = 8
        '
        'OpponentTextBox
        '
        Me.OpponentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAchievementsBindingSource, "opponent", True))
        Me.OpponentTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpponentTextBox.Location = New System.Drawing.Point(373, 359)
        Me.OpponentTextBox.Name = "OpponentTextBox"
        Me.OpponentTextBox.Size = New System.Drawing.Size(878, 50)
        Me.OpponentTextBox.TabIndex = 10
        '
        'PrizepoolTextBox
        '
        Me.PrizepoolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAchievementsBindingSource, "prizepool", True))
        Me.PrizepoolTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrizepoolTextBox.Location = New System.Drawing.Point(1625, 178)
        Me.PrizepoolTextBox.Name = "PrizepoolTextBox"
        Me.PrizepoolTextBox.Size = New System.Drawing.Size(811, 50)
        Me.PrizepoolTextBox.TabIndex = 12
        '
        'PlacementComboBox
        '
        Me.PlacementComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAchievementsBindingSource, "placement", True))
        Me.PlacementComboBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlacementComboBox.FormattingEnabled = True
        Me.PlacementComboBox.Items.AddRange(New Object() {"1st Place", "2nd Place", "3rd Place", "4th Place"})
        Me.PlacementComboBox.Location = New System.Drawing.Point(1625, 263)
        Me.PlacementComboBox.Name = "PlacementComboBox"
        Me.PlacementComboBox.Size = New System.Drawing.Size(811, 51)
        Me.PlacementComboBox.TabIndex = 14
        '
        'TournamentdateDateTimePicker
        '
        Me.TournamentdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblAchievementsBindingSource, "tournamentdate", True))
        Me.TournamentdateDateTimePicker.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TournamentdateDateTimePicker.Location = New System.Drawing.Point(1625, 355)
        Me.TournamentdateDateTimePicker.Name = "TournamentdateDateTimePicker"
        Me.TournamentdateDateTimePicker.Size = New System.Drawing.Size(811, 50)
        Me.TournamentdateDateTimePicker.TabIndex = 16
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
        Me.Guna2Button1.Location = New System.Drawing.Point(1278, 19)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(270, 114)
        Me.Guna2Button1.TabIndex = 17
        Me.Guna2Button1.Text = "ADD"
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(0, 3)
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
        Me.Guna2Button2.Location = New System.Drawing.Point(1574, 19)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(270, 114)
        Me.Guna2Button2.TabIndex = 18
        Me.Guna2Button2.Text = "EDIT"
        Me.Guna2Button2.TextOffset = New System.Drawing.Point(0, 3)
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
        Me.Guna2Button3.Location = New System.Drawing.Point(1870, 19)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(270, 114)
        Me.Guna2Button3.TabIndex = 19
        Me.Guna2Button3.Text = "SAVE"
        Me.Guna2Button3.TextOffset = New System.Drawing.Point(0, 3)
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
        Me.Guna2Button4.Location = New System.Drawing.Point(2166, 19)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(270, 114)
        Me.Guna2Button4.TabIndex = 20
        Me.Guna2Button4.Text = "DELETE"
        Me.Guna2Button4.TextOffset = New System.Drawing.Point(0, 3)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("DM Sans", 21.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(27, 570)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 67)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Search:"
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
        Me.Guna2TextBox1.Location = New System.Drawing.Point(253, 563)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(9, 14, 9, 14)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(1013, 84)
        Me.Guna2TextBox1.TabIndex = 22
        Me.Guna2TextBox1.TextOffset = New System.Drawing.Point(10, 0)
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
        Me.Guna2Button5.Location = New System.Drawing.Point(1278, 561)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.Parent = Me.Guna2Button5
        Me.Guna2Button5.Size = New System.Drawing.Size(270, 93)
        Me.Guna2Button5.TabIndex = 23
        Me.Guna2Button5.Text = "Print"
        Me.Guna2Button5.TextOffset = New System.Drawing.Point(0, 3)
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(2497, 1513)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(TournamentnameLabel)
        Me.Controls.Add(Me.TournamentnameTextBox)
        Me.Controls.Add(TypeofgameLabel)
        Me.Controls.Add(Me.TypeofgameComboBox)
        Me.Controls.Add(OpponentLabel)
        Me.Controls.Add(Me.OpponentTextBox)
        Me.Controls.Add(PrizepoolLabel)
        Me.Controls.Add(Me.PrizepoolTextBox)
        Me.Controls.Add(PlacementLabel)
        Me.Controls.Add(Me.PlacementComboBox)
        Me.Controls.Add(TournamentdateLabel)
        Me.Controls.Add(Me.TournamentdateDateTimePicker)
        Me.Controls.Add(Me.TblAchievementsGuna2DataGridView)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAchievementsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAchievementsGuna2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TeamLiquidDataSet As Esports_Executive_Information_System.TeamLiquidDataSet
    Friend WithEvents TblAchievementsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAchievementsTableAdapter As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblAchievementsTableAdapter
    Friend WithEvents TableAdapterManager As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblAchievementsGuna2DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TournamentnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeofgameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OpponentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrizepoolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlacementComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TournamentdateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
End Class
