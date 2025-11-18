<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Me.tblEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblEmployeesTableAdapter = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblEmployeesTableAdapter()
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblEmployeesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Esports_Executive_Information_System.Report6.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1159, 485)
        Me.ReportViewer1.TabIndex = 0
        '
        'TeamLiquidDataSet
        '
        Me.TeamLiquidDataSet.DataSetName = "TeamLiquidDataSet"
        Me.TeamLiquidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblEmployeesBindingSource
        '
        Me.tblEmployeesBindingSource.DataMember = "tblEmployees"
        Me.tblEmployeesBindingSource.DataSource = Me.TeamLiquidDataSet
        '
        'tblEmployeesTableAdapter
        '
        Me.tblEmployeesTableAdapter.ClearBeforeFill = True
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 485)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form16"
        Me.Text = "Form16"
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeamLiquidDataSet As Esports_Executive_Information_System.TeamLiquidDataSet
    Friend WithEvents tblEmployeesTableAdapter As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblEmployeesTableAdapter
End Class
