<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim DateofpurchaseLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim TypeofpurchaseLabel As System.Windows.Forms.Label
        Dim PurchasedbyLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TeamLiquidDataSet = New Esports_Executive_Information_System.TeamLiquidDataSet()
        Me.TblFinanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblFinanceTableAdapter = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblFinanceTableAdapter()
        Me.TableAdapterManager = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager()
        Me.TblFinanceGuna2DataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DateofpurchaseDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.TypeofpurchaseTextBox = New System.Windows.Forms.TextBox()
        Me.PurchasedbyComboBox = New System.Windows.Forms.ComboBox()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        DateofpurchaseLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        TypeofpurchaseLabel = New System.Windows.Forms.Label()
        PurchasedbyLabel = New System.Windows.Forms.Label()
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFinanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFinanceGuna2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(29, 181)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(61, 45)
        IDLabel.TabIndex = 4
        IDLabel.Text = "ID:"
        '
        'DateofpurchaseLabel
        '
        DateofpurchaseLabel.AutoSize = True
        DateofpurchaseLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateofpurchaseLabel.Location = New System.Drawing.Point(29, 265)
        DateofpurchaseLabel.Name = "DateofpurchaseLabel"
        DateofpurchaseLabel.Size = New System.Drawing.Size(292, 45)
        DateofpurchaseLabel.TabIndex = 6
        DateofpurchaseLabel.Text = "dateofpurchase:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountLabel.Location = New System.Drawing.Point(29, 349)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(157, 45)
        AmountLabel.TabIndex = 8
        AmountLabel.Text = "amount:"
        '
        'TypeofpurchaseLabel
        '
        TypeofpurchaseLabel.AutoSize = True
        TypeofpurchaseLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypeofpurchaseLabel.Location = New System.Drawing.Point(29, 433)
        TypeofpurchaseLabel.Name = "TypeofpurchaseLabel"
        TypeofpurchaseLabel.Size = New System.Drawing.Size(292, 45)
        TypeofpurchaseLabel.TabIndex = 10
        TypeofpurchaseLabel.Text = "typeofpurchase:"
        '
        'PurchasedbyLabel
        '
        PurchasedbyLabel.AutoSize = True
        PurchasedbyLabel.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurchasedbyLabel.Location = New System.Drawing.Point(1378, 181)
        PurchasedbyLabel.Name = "PurchasedbyLabel"
        PurchasedbyLabel.Size = New System.Drawing.Size(245, 45)
        PurchasedbyLabel.TabIndex = 12
        PurchasedbyLabel.Text = "purchasedby:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kaneda Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 134)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Finance"
        '
        'TeamLiquidDataSet
        '
        Me.TeamLiquidDataSet.DataSetName = "TeamLiquidDataSet"
        Me.TeamLiquidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblFinanceBindingSource
        '
        Me.TblFinanceBindingSource.DataMember = "tblFinance"
        Me.TblFinanceBindingSource.DataSource = Me.TeamLiquidDataSet
        '
        'TblFinanceTableAdapter
        '
        Me.TblFinanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAchievementsTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeesTableAdapter = Nothing
        Me.TableAdapterManager.tblExecutivesTableAdapter = Nothing
        Me.TableAdapterManager.tblFinanceTableAdapter = Me.TblFinanceTableAdapter
        Me.TableAdapterManager.tblSponsorsTableAdapter = Nothing
        Me.TableAdapterManager.tblTeamsPlayersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblFinanceGuna2DataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.TblFinanceGuna2DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TblFinanceGuna2DataGridView.AutoGenerateColumns = False
        Me.TblFinanceGuna2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblFinanceGuna2DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblFinanceGuna2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblFinanceGuna2DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TblFinanceGuna2DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblFinanceGuna2DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TblFinanceGuna2DataGridView.ColumnHeadersHeight = 40
        Me.TblFinanceGuna2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblFinanceGuna2DataGridView.DataSource = Me.TblFinanceBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("DM Sans 14pt Medium", 9.857142!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TblFinanceGuna2DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.TblFinanceGuna2DataGridView.EnableHeadersVisualStyles = False
        Me.TblFinanceGuna2DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblFinanceGuna2DataGridView.Location = New System.Drawing.Point(29, 684)
        Me.TblFinanceGuna2DataGridView.Name = "TblFinanceGuna2DataGridView"
        Me.TblFinanceGuna2DataGridView.RowHeadersVisible = False
        Me.TblFinanceGuna2DataGridView.RowTemplate.Height = 30
        Me.TblFinanceGuna2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblFinanceGuna2DataGridView.Size = New System.Drawing.Size(2448, 889)
        Me.TblFinanceGuna2DataGridView.TabIndex = 4
        Me.TblFinanceGuna2DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.TblFinanceGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.TblFinanceGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.TblFinanceGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.TblFinanceGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.TblFinanceGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.TblFinanceGuna2DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.TblFinanceGuna2DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblFinanceGuna2DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TblFinanceGuna2DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TblFinanceGuna2DataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblFinanceGuna2DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.TblFinanceGuna2DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.TblFinanceGuna2DataGridView.ThemeStyle.HeaderStyle.Height = 40
        Me.TblFinanceGuna2DataGridView.ThemeStyle.ReadOnly = False
        Me.TblFinanceGuna2DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.TblFinanceGuna2DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TblFinanceGuna2DataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("DM Sans 14pt Medium", 9.857142!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblFinanceGuna2DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.TblFinanceGuna2DataGridView.ThemeStyle.RowsStyle.Height = 30
        Me.TblFinanceGuna2DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblFinanceGuna2DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "dateofpurchase"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date of Purchase"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "typeofpurchase"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Type of Purchase"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "purchasedby"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Purchased By"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFinanceBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(346, 178)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(988, 50)
        Me.IDTextBox.TabIndex = 5
        '
        'DateofpurchaseDateTimePicker
        '
        Me.DateofpurchaseDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblFinanceBindingSource, "dateofpurchase", True))
        Me.DateofpurchaseDateTimePicker.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateofpurchaseDateTimePicker.Location = New System.Drawing.Point(346, 259)
        Me.DateofpurchaseDateTimePicker.Name = "DateofpurchaseDateTimePicker"
        Me.DateofpurchaseDateTimePicker.Size = New System.Drawing.Size(988, 50)
        Me.DateofpurchaseDateTimePicker.TabIndex = 7
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFinanceBindingSource, "amount", True))
        Me.AmountTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(346, 346)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(988, 50)
        Me.AmountTextBox.TabIndex = 9
        '
        'TypeofpurchaseTextBox
        '
        Me.TypeofpurchaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFinanceBindingSource, "typeofpurchase", True))
        Me.TypeofpurchaseTextBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeofpurchaseTextBox.Location = New System.Drawing.Point(346, 430)
        Me.TypeofpurchaseTextBox.Name = "TypeofpurchaseTextBox"
        Me.TypeofpurchaseTextBox.Size = New System.Drawing.Size(988, 50)
        Me.TypeofpurchaseTextBox.TabIndex = 11
        '
        'PurchasedbyComboBox
        '
        Me.PurchasedbyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFinanceBindingSource, "purchasedby", True))
        Me.PurchasedbyComboBox.Font = New System.Drawing.Font("DM Sans", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchasedbyComboBox.FormattingEnabled = True
        Me.PurchasedbyComboBox.Items.AddRange(New Object() {"CEO", "CTO", "COO", "CHRO", "CFO", "CMO", "CPO", "CCO", "CIO"})
        Me.PurchasedbyComboBox.Location = New System.Drawing.Point(1639, 178)
        Me.PurchasedbyComboBox.Name = "PurchasedbyComboBox"
        Me.PurchasedbyComboBox.Size = New System.Drawing.Size(795, 51)
        Me.PurchasedbyComboBox.TabIndex = 13
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
        Me.Guna2Button4.Location = New System.Drawing.Point(2164, 12)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(270, 114)
        Me.Guna2Button4.TabIndex = 28
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
        Me.Guna2Button3.TabIndex = 27
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
        Me.Guna2Button2.TabIndex = 26
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
        Me.Guna2Button1.TabIndex = 25
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
        Me.Guna2Button5.Location = New System.Drawing.Point(1278, 561)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.Parent = Me.Guna2Button5
        Me.Guna2Button5.Size = New System.Drawing.Size(270, 93)
        Me.Guna2Button5.TabIndex = 39
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
        Me.Guna2TextBox1.TabIndex = 38
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
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Search:"
        '
        'Form9
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
        Me.Controls.Add(DateofpurchaseLabel)
        Me.Controls.Add(Me.DateofpurchaseDateTimePicker)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(TypeofpurchaseLabel)
        Me.Controls.Add(Me.TypeofpurchaseTextBox)
        Me.Controls.Add(PurchasedbyLabel)
        Me.Controls.Add(Me.PurchasedbyComboBox)
        Me.Controls.Add(Me.TblFinanceGuna2DataGridView)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form9"
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFinanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFinanceGuna2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TeamLiquidDataSet As Esports_Executive_Information_System.TeamLiquidDataSet
    Friend WithEvents TblFinanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblFinanceTableAdapter As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblFinanceTableAdapter
    Friend WithEvents TableAdapterManager As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblFinanceGuna2DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateofpurchaseDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeofpurchaseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PurchasedbyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
