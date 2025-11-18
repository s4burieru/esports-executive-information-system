<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TeamLiquidDataSet = New Esports_Executive_Information_System.TeamLiquidDataSet()
        Me.tblSponsorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblSponsorsTableAdapter = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblSponsorsTableAdapter()
        Me.tblAchievementsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblAchievementsTableAdapter = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblAchievementsTableAdapter()
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblSponsorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblAchievementsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblSponsorsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Esports_Executive_Information_System.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1108, 491)
        Me.ReportViewer1.TabIndex = 0
        '
        'TeamLiquidDataSet
        '
        Me.TeamLiquidDataSet.DataSetName = "TeamLiquidDataSet"
        Me.TeamLiquidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblSponsorsBindingSource
        '
        Me.tblSponsorsBindingSource.DataMember = "tblSponsors"
        Me.tblSponsorsBindingSource.DataSource = Me.TeamLiquidDataSet
        '
        'tblSponsorsTableAdapter
        '
        Me.tblSponsorsTableAdapter.ClearBeforeFill = True
        '
        'tblAchievementsBindingSource
        '
        Me.tblAchievementsBindingSource.DataMember = "tblAchievements"
        Me.tblAchievementsBindingSource.DataSource = Me.TeamLiquidDataSet
        '
        'tblAchievementsTableAdapter
        '
        Me.tblAchievementsTableAdapter.ClearBeforeFill = True
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 491)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form13"
        Me.Text = "Form13"
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblSponsorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblAchievementsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblSponsorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeamLiquidDataSet As Esports_Executive_Information_System.TeamLiquidDataSet
    Friend WithEvents tblSponsorsTableAdapter As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblSponsorsTableAdapter
    Friend WithEvents tblAchievementsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tblAchievementsTableAdapter As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblAchievementsTableAdapter
End Class
