<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim SponsorLabel As System.Windows.Forms.Label
        Dim TypeofsponsorLabel As System.Windows.Forms.Label
        Dim AmountofsponsorshipLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TeamLiquidDataSet = New Esports_Executive_Information_System.TeamLiquidDataSet()
        Me.TblSponsorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSponsorsTableAdapter = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblSponsorsTableAdapter()
        Me.TableAdapterManager = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager()
        Me.TblSponsorsGuna2DataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SponsorTextBox = New System.Windows.Forms.TextBox()
        Me.TypeofsponsorTextBox = New System.Windows.Forms.TextBox()
        Me.AmountofsponsorshipTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        SponsorLabel = New System.Windows.Forms.Label()
        TypeofsponsorLabel = New System.Windows.Forms.Label()
        AmountofsponsorshipLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSponsorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSponsorsGuna2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(29, 181)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(61, 45)
        IDLabel.TabIndex = 24
        IDLabel.Text = "ID:"
        '
        'SponsorLabel
        '
        SponsorLabel.AutoSize = True
        SponsorLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SponsorLabel.Location = New System.Drawing.Point(29, 265)
        SponsorLabel.Name = "SponsorLabel"
        SponsorLabel.Size = New System.Drawing.Size(162, 45)
        SponsorLabel.TabIndex = 26
        SponsorLabel.Text = "sponsor:"
        '
        'TypeofsponsorLabel
        '
        TypeofsponsorLabel.AutoSize = True
        TypeofsponsorLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypeofsponsorLabel.Location = New System.Drawing.Point(29, 349)
        TypeofsponsorLabel.Name = "TypeofsponsorLabel"
        TypeofsponsorLabel.Size = New System.Drawing.Size(270, 45)
        TypeofsponsorLabel.TabIndex = 28
        TypeofsponsorLabel.Text = "typeofsponsor:"
        '
        'AmountofsponsorshipLabel
        '
        AmountofsponsorshipLabel.AutoSize = True
        AmountofsponsorshipLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountofsponsorshipLabel.Location = New System.Drawing.Point(29, 433)
        AmountofsponsorshipLabel.Name = "AmountofsponsorshipLabel"
        AmountofsponsorshipLabel.Size = New System.Drawing.Size(393, 45)
        AmountofsponsorshipLabel.TabIndex = 30
        AmountofsponsorshipLabel.Text = "amountofsponsorship:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(1384, 181)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(118, 45)
        EmailLabel.TabIndex = 32
        EmailLabel.Text = "email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kaneda Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 134)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sponsors"
        '
        'TeamLiquidDataSet
        '
        Me.TeamLiquidDataSet.DataSetName = "TeamLiquidDataSet"
        Me.TeamLiquidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSponsorsBindingSource
        '
        Me.TblSponsorsBindingSource.DataMember = "tblSponsors"
        Me.TblSponsorsBindingSource.DataSource = Me.TeamLiquidDataSet
        '
        'TblSponsorsTableAdapter
        '
        Me.TblSponsorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAchievementsTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeesTableAdapter = Nothing
        Me.TableAdapterManager.tblExecutivesTableAdapter = Nothing
        Me.TableAdapterManager.tblFinanceTableAdapter = Nothing
        Me.TableAdapterManager.tblSponsorsTableAdapter = Me.TblSponsorsTableAdapter
        Me.TableAdapterManager.tblTeamsPlayersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSponsorsGuna2DataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.TblSponsorsGuna2DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TblSponsorsGuna2DataGridView.AutoGenerateColumns = False
        Me.TblSponsorsGuna2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblSponsorsGuna2DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblSponsorsGuna2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblSponsorsGuna2DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TblSponsorsGuna2DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblSponsorsGuna2DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TblSponsorsGuna2DataGridView.ColumnHeadersHeight = 40
        Me.TblSponsorsGuna2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblSponsorsGuna2DataGridView.DataSource = Me.TblSponsorsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("DM Sans 14pt Medium", 9.857142!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TblSponsorsGuna2DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.TblSponsorsGuna2DataGridView.EnableHeadersVisualStyles = False
        Me.TblSponsorsGuna2DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblSponsorsGuna2DataGridView.Location = New System.Drawing.Point(29, 684)
        Me.TblSponsorsGuna2DataGridView.Name = "TblSponsorsGuna2DataGridView"
        Me.TblSponsorsGuna2DataGridView.RowHeadersVisible = False
        Me.TblSponsorsGuna2DataGridView.RowTemplate.Height = 30
        Me.TblSponsorsGuna2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblSponsorsGuna2DataGridView.Size = New System.Drawing.Size(2448, 889)
        Me.TblSponsorsGuna2DataGridView.TabIndex = 4
        Me.TblSponsorsGuna2DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.HeaderStyle.Height = 40
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.ReadOnly = False
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("DM Sans 14pt Medium", 9.857142!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.RowsStyle.Height = 30
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblSponsorsGuna2DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 76
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sponsor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sponsor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "typeofsponsor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type of Sponsor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "amountofsponsorship"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Amount of Sponsorship"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
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
        Me.Guna2Button4.TabIndex = 24
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
        Me.Guna2Button3.Location = New System.Drawing.Point(1870, 19)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(270, 114)
        Me.Guna2Button3.TabIndex = 23
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
        Me.Guna2Button2.Location = New System.Drawing.Point(1574, 19)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(270, 114)
        Me.Guna2Button2.TabIndex = 22
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
        Me.Guna2Button1.Location = New System.Drawing.Point(1278, 19)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(270, 114)
        Me.Guna2Button1.TabIndex = 21
        Me.Guna2Button1.Text = "ADD"
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(0, 3)
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSponsorsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(448, 178)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(904, 50)
        Me.IDTextBox.TabIndex = 25
        '
        'SponsorTextBox
        '
        Me.SponsorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSponsorsBindingSource, "sponsor", True))
        Me.SponsorTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SponsorTextBox.Location = New System.Drawing.Point(448, 262)
        Me.SponsorTextBox.Name = "SponsorTextBox"
        Me.SponsorTextBox.Size = New System.Drawing.Size(904, 50)
        Me.SponsorTextBox.TabIndex = 27
        '
        'TypeofsponsorTextBox
        '
        Me.TypeofsponsorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSponsorsBindingSource, "typeofsponsor", True))
        Me.TypeofsponsorTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeofsponsorTextBox.Location = New System.Drawing.Point(448, 346)
        Me.TypeofsponsorTextBox.Name = "TypeofsponsorTextBox"
        Me.TypeofsponsorTextBox.Size = New System.Drawing.Size(904, 50)
        Me.TypeofsponsorTextBox.TabIndex = 29
        '
        'AmountofsponsorshipTextBox
        '
        Me.AmountofsponsorshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSponsorsBindingSource, "amountofsponsorship", True))
        Me.AmountofsponsorshipTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountofsponsorshipTextBox.Location = New System.Drawing.Point(448, 430)
        Me.AmountofsponsorshipTextBox.Name = "AmountofsponsorshipTextBox"
        Me.AmountofsponsorshipTextBox.Size = New System.Drawing.Size(904, 50)
        Me.AmountofsponsorshipTextBox.TabIndex = 31
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSponsorsBindingSource, "email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(1508, 176)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(928, 50)
        Me.EmailTextBox.TabIndex = 33
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
        Me.Guna2Button5.TabIndex = 36
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
        Me.Guna2TextBox1.Location = New System.Drawing.Point(253, 563)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(9, 14, 9, 14)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(1013, 84)
        Me.Guna2TextBox1.TabIndex = 35
        Me.Guna2TextBox1.TextOffset = New System.Drawing.Point(10, 0)
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
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Search:"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(2497, 1513)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(SponsorLabel)
        Me.Controls.Add(Me.SponsorTextBox)
        Me.Controls.Add(TypeofsponsorLabel)
        Me.Controls.Add(Me.TypeofsponsorTextBox)
        Me.Controls.Add(AmountofsponsorshipLabel)
        Me.Controls.Add(Me.AmountofsponsorshipTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.TblSponsorsGuna2DataGridView)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSponsorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSponsorsGuna2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TeamLiquidDataSet As Esports_Executive_Information_System.TeamLiquidDataSet
    Friend WithEvents TblSponsorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSponsorsTableAdapter As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblSponsorsTableAdapter
    Friend WithEvents TableAdapterManager As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSponsorsGuna2DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SponsorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeofsponsorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountofsponsorshipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
