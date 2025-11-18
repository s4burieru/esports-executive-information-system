<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim ContactnumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ExecutivetypeLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim LastnameLabel As System.Windows.Forms.Label
        Dim BirthdateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.TblExecutivesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamLiquidDataSet = New Esports_Executive_Information_System.TeamLiquidDataSet()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TblExecutivesTableAdapter = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblExecutivesTableAdapter()
        Me.TableAdapterManager = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactnumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ExecutivetypeComboBox = New System.Windows.Forms.ComboBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LastnameTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        FirstnameLabel = New System.Windows.Forms.Label()
        ContactnumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ExecutivetypeLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        LastnameLabel = New System.Windows.Forms.Label()
        BirthdateLabel = New System.Windows.Forms.Label()
        CType(Me.TblExecutivesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstnameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        FirstnameLabel.Location = New System.Drawing.Point(68, 81)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(375, 81)
        FirstnameLabel.TabIndex = 4
        FirstnameLabel.Text = "First Name:"
        '
        'ContactnumberLabel
        '
        ContactnumberLabel.AutoSize = True
        ContactnumberLabel.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactnumberLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        ContactnumberLabel.Location = New System.Drawing.Point(68, 675)
        ContactnumberLabel.Name = "ContactnumberLabel"
        ContactnumberLabel.Size = New System.Drawing.Size(556, 81)
        ContactnumberLabel.TabIndex = 8
        ContactnumberLabel.Text = "Contact Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        EmailLabel.Location = New System.Drawing.Point(68, 881)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(213, 81)
        EmailLabel.TabIndex = 10
        EmailLabel.Text = "Email:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        AddressLabel.Location = New System.Drawing.Point(68, 469)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(299, 81)
        AddressLabel.TabIndex = 14
        AddressLabel.Text = "Address:"
        '
        'ExecutivetypeLabel
        '
        ExecutivetypeLabel.AutoSize = True
        ExecutivetypeLabel.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ExecutivetypeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        ExecutivetypeLabel.Location = New System.Drawing.Point(879, 270)
        ExecutivetypeLabel.Name = "ExecutivetypeLabel"
        ExecutivetypeLabel.Size = New System.Drawing.Size(507, 81)
        ExecutivetypeLabel.TabIndex = 16
        ExecutivetypeLabel.Text = "Executive Type:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(51, 1185)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(356, 81)
        UsernameLabel.TabIndex = 18
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        PasswordLabel.Location = New System.Drawing.Point(51, 1320)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(338, 81)
        PasswordLabel.TabIndex = 20
        PasswordLabel.Text = "Password:"
        '
        'LastnameLabel
        '
        LastnameLabel.AutoSize = True
        LastnameLabel.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastnameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        LastnameLabel.Location = New System.Drawing.Point(879, 81)
        LastnameLabel.Name = "LastnameLabel"
        LastnameLabel.Size = New System.Drawing.Size(369, 81)
        LastnameLabel.TabIndex = 22
        LastnameLabel.Text = "Last Name:"
        '
        'BirthdateLabel
        '
        BirthdateLabel.AutoSize = True
        BirthdateLabel.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BirthdateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        BirthdateLabel.Location = New System.Drawing.Point(68, 270)
        BirthdateLabel.Name = "BirthdateLabel"
        BirthdateLabel.Size = New System.Drawing.Size(352, 81)
        BirthdateLabel.TabIndex = 23
        BirthdateLabel.Text = "Birth Date:"
        '
        'TblExecutivesBindingSource
        '
        Me.TblExecutivesBindingSource.DataMember = "tblExecutives"
        Me.TblExecutivesBindingSource.DataSource = Me.TeamLiquidDataSet
        '
        'TeamLiquidDataSet
        '
        Me.TeamLiquidDataSet.DataSetName = "TeamLiquidDataSet"
        Me.TeamLiquidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderRadius = 220
        Me.Guna2Panel1.Controls.Add(Me.Guna2CircleButton1)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(1754, -25)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(3228, 1829)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.CheckedState.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.CustomImages.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.HoverState.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Image = Global.Esports_Executive_Information_System.My.Resources.Resources.reject238
        Me.Guna2CircleButton1.ImageSize = New System.Drawing.Size(45, 45)
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(1363, 72)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.ShadowDecoration.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(148, 148)
        Me.Guna2CircleButton1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Esports_Executive_Information_System.My.Resources.Resources._65f44cd1a36d0e7ade30289b_Crest_on_dark
        Me.PictureBox1.Location = New System.Drawing.Point(405, 755)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(845, 772)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Kaneda Gothic Medium", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(503, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(648, 202)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TEAM LIQUID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Kaneda Gothic Medium", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(355, 496)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(938, 202)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "EXECUTIVE SIGN UP"
        '
        'TblExecutivesTableAdapter
        '
        Me.TblExecutivesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAchievementsTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeesTableAdapter = Nothing
        Me.TableAdapterManager.tblExecutivesTableAdapter = Me.TblExecutivesTableAdapter
        Me.TableAdapterManager.tblFinanceTableAdapter = Nothing
        Me.TableAdapterManager.tblSponsorsTableAdapter = Nothing
        Me.TableAdapterManager.tblTeamsPlayersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.White
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExecutivesBindingSource, "firstname", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(68, 165)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(770, 87)
        Me.FirstNameTextBox.TabIndex = 5
        '
        'ContactnumberTextBox
        '
        Me.ContactnumberTextBox.BackColor = System.Drawing.Color.White
        Me.ContactnumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExecutivesBindingSource, "contactnumber", True))
        Me.ContactnumberTextBox.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactnumberTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ContactnumberTextBox.Location = New System.Drawing.Point(68, 768)
        Me.ContactnumberTextBox.Name = "ContactnumberTextBox"
        Me.ContactnumberTextBox.Size = New System.Drawing.Size(1597, 87)
        Me.ContactnumberTextBox.TabIndex = 9
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.White
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExecutivesBindingSource, "email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.EmailTextBox.Location = New System.Drawing.Point(68, 971)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(1601, 87)
        Me.EmailTextBox.TabIndex = 11
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.White
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExecutivesBindingSource, "address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.AddressTextBox.Location = New System.Drawing.Point(68, 563)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(1597, 87)
        Me.AddressTextBox.TabIndex = 15
        '
        'ExecutivetypeComboBox
        '
        Me.ExecutivetypeComboBox.BackColor = System.Drawing.Color.White
        Me.ExecutivetypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExecutivesBindingSource, "executivetype", True))
        Me.ExecutivetypeComboBox.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExecutivetypeComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ExecutivetypeComboBox.FormattingEnabled = True
        Me.ExecutivetypeComboBox.Items.AddRange(New Object() {"CEO", "CTO", "COO", "CHRO", "CFO", "CMO", "CPO", "CCO", "CIO"})
        Me.ExecutivetypeComboBox.Location = New System.Drawing.Point(879, 359)
        Me.ExecutivetypeComboBox.Name = "ExecutivetypeComboBox"
        Me.ExecutivetypeComboBox.Size = New System.Drawing.Size(790, 88)
        Me.ExecutivetypeComboBox.TabIndex = 17
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.White
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExecutivesBindingSource, "username", True))
        Me.UsernameTextBox.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.UsernameTextBox.Location = New System.Drawing.Point(413, 1182)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(1256, 87)
        Me.UsernameTextBox.TabIndex = 19
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.White
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExecutivesBindingSource, "password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.PasswordTextBox.Location = New System.Drawing.Point(413, 1313)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(1256, 87)
        Me.PasswordTextBox.TabIndex = 21
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.BackColor = System.Drawing.Color.White
        Me.LastnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExecutivesBindingSource, "lastname", True))
        Me.LastnameTextBox.Font = New System.Drawing.Font("DM Sans", 26.14286!)
        Me.LastnameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.LastnameTextBox.Location = New System.Drawing.Point(879, 165)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(786, 87)
        Me.LastnameTextBox.TabIndex = 23
        '
        'BirthdateDateTimePicker
        '
        Me.BirthdateDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BirthdateDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Gray
        Me.BirthdateDateTimePicker.Checked = False
        Me.BirthdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExecutivesBindingSource, "birthdate", True))
        Me.BirthdateDateTimePicker.Font = New System.Drawing.Font("DM Sans", 26.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthdateDateTimePicker.Location = New System.Drawing.Point(68, 359)
        Me.BirthdateDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.BirthdateDateTimePicker.Name = "BirthdateDateTimePicker"
        Me.BirthdateDateTimePicker.Size = New System.Drawing.Size(773, 87)
        Me.BirthdateDateTimePicker.TabIndex = 30
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("DM Sans", 20.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(68, 1540)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(1604, 121)
        Me.Guna2Button2.TabIndex = 31
        Me.Guna2Button2.Text = "SIGN UP"
        Me.Guna2Button2.TextOffset = New System.Drawing.Point(0, 3)
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(3204, 1764)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(BirthdateLabel)
        Me.Controls.Add(Me.BirthdateDateTimePicker)
        Me.Controls.Add(LastnameLabel)
        Me.Controls.Add(Me.LastnameTextBox)
        Me.Controls.Add(FirstnameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(ContactnumberLabel)
        Me.Controls.Add(Me.ContactnumberTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(ExecutivetypeLabel)
        Me.Controls.Add(Me.ExecutivetypeComboBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Executive Sign Up"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TblExecutivesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TeamLiquidDataSet As Esports_Executive_Information_System.TeamLiquidDataSet
    Friend WithEvents TblExecutivesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblExecutivesTableAdapter As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblExecutivesTableAdapter
    Friend WithEvents TableAdapterManager As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContactnumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExecutivetypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthdateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
End Class
