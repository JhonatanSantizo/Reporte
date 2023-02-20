Public Class Reporte
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim var = CrudFactura
        Me.ReporteTableAdapter.FillBy(Me.DataSetReporte.Reporte, var.TextBox1.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Dim fn = CrudFactura
        fn.TextBox1.Text = ""
        fn.TextBox2.Text = ""
        fn.TextBox3.Text = ""
        fn.TextBox4.Text = ""
        fn.TextBox5.Text = ""
        fn.TextBox6.Text = ""
        fn.TextBox7.Text = ""
        fn.TextBox8.Text = ""
        fn.TextBox9.Text = ""
        fn.TextBox10.Text = ""
        fn.TextBox11.Text = ""
        fn.TextBox12.Text = ""
        fn.TextBox13.Text = ""
        fn.TextBox14.Text = ""
        fn.TextBox15.Text = ""
        fn.TextBox16.Text = ""
        fn.TextBox17.Text = ""
        fn.TextBox18.Text = ""
        fn.TextBox19.Text = ""
        fn.TextBox20.Text = ""
        fn.TextBox21.Text = ""
        fn.TextBox22.Text = ""
        fn.TextBox23.Text = ""
        fn.TextBox24.Text = ""
        fn.TextBox25.Text = ""
        CrudFactura.Show()
        Me.Close()
    End Sub
End Class