<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
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
        Me.tblExecutivesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblExecutivesTableAdapter = New Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblExecutivesTableAdapter()
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblExecutivesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblExecutivesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Esports_Executive_Information_System.Report7.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1201, 493)
        Me.ReportViewer1.TabIndex = 0
        '
        'TeamLiquidDataSet
        '
        Me.TeamLiquidDataSet.DataSetName = "TeamLiquidDataSet"
        Me.TeamLiquidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblExecutivesBindingSource
        '
        Me.tblExecutivesBindingSource.DataMember = "tblExecutives"
        Me.tblExecutivesBindingSource.DataSource = Me.TeamLiquidDataSet
        '
        'tblExecutivesTableAdapter
        '
        Me.tblExecutivesTableAdapter.ClearBeforeFill = True
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 493)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form17"
        Me.Text = "Form17"
        CType(Me.TeamLiquidDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblExecutivesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblExecutivesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeamLiquidDataSet As Esports_Executive_Information_System.TeamLiquidDataSet
    Friend WithEvents tblExecutivesTableAdapter As Esports_Executive_Information_System.TeamLiquidDataSetTableAdapters.tblExecutivesTableAdapter
End Class
