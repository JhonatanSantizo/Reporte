<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetReporte = New Login_con_Crud.DataSetReporte()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReporteTableAdapter = New Login_con_Crud.DataSetReporteTableAdapters.ReporteTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.ReporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReporteBindingSource
        '
        Me.ReporteBindingSource.DataMember = "Reporte"
        Me.ReporteBindingSource.DataSource = Me.DataSetReporte
        '
        'DataSetReporte
        '
        Me.DataSetReporte.DataSetName = "DataSetReporte"
        Me.DataSetReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource8.Name = "Reporte"
        ReportDataSource8.Value = Me.ReporteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Login_con_Crud.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(23, 91)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(725, 317)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReporteTableAdapter
        '
        Me.ReporteTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monospac821 BT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reporte-Factura"
        '
        'btn_regresar
        '
        Me.btn_regresar.Location = New System.Drawing.Point(673, 430)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(75, 23)
        Me.btn_regresar.TabIndex = 68
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(23, 430)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 71
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(778, 478)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_regresar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte"
        CType(Me.ReporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteBindingSource As BindingSource
    Friend WithEvents DataSetReporte As DataSetReporte
    Friend WithEvents ReporteTableAdapter As DataSetReporteTableAdapters.ReporteTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_regresar As Button
    Friend WithEvents btn_salir As Button
End Class
