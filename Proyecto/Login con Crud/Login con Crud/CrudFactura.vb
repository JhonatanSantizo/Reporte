Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Public Class CrudFactura
    Dim con As SqlConnection = New SqlConnection(My.Settings.con)
    Dim sentencia, mensaje As String
    Sub Ejectarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception

            con.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CrudFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        frmAdministrador.Show()
        Me.Close()
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim da As New SqlDataAdapter("Select *from Reporte where IdFactura='" + TextBox1.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Dim formato As String = "^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$"
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" And TextBox10.Text <> "" And TextBox11.Text <> "" And TextBox12.Text <> "" And TextBox13.Text <> "" And TextBox14.Text <> "" And TextBox15.Text <> "" And TextBox16.Text <> "" And TextBox17.Text <> "" And TextBox18.Text <> "" And TextBox19.Text <> "" And TextBox20.Text <> "" And TextBox21.Text <> "" And TextBox22.Text <> "" And TextBox23.Text <> "" And TextBox24.Text <> "" And TextBox25.Text <> "" Then
            If TextBox24.TextLength < 8 Or TextBox25.TextLength < 8 Then
                MessageBox.Show("El numero telefonico debe ser de 8 digitos")
            Else
                If TextBox1.Text < 1 Or TextBox5.Text < 1 Or TextBox6.Text < 1 Or TextBox9.Text < 1 Or TextBox15.Text < 1 Or TextBox20.Text < 1 Or TextBox24.Text < 1 Or TextBox25.Text < 1 Then
                    MessageBox.Show("Error al ingresar numeros negativos o nulos")
                Else
                    If Regex.IsMatch(TextBox14.Text, formato) Then
                        sentencia = "Insert into Reporte Values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + TextBox16.Text + "','" + TextBox17.Text + "','" + TextBox18.Text + "','" + TextBox19.Text + "','" + TextBox20.Text + "','" + TextBox21.Text + "','" + TextBox22.Text + "','" + TextBox23.Text + "','" + TextBox24.Text + "','" + TextBox25.Text + "')"
                        mensaje = "Datos ingresados"
                        Ejectarsql(sentencia, mensaje)
                        Try
                            Dim da As New SqlDataAdapter("Select *from Reporte", con)
                            Dim ds As New DataSet
                            da.Fill(ds)
                            Me.DataGridView1.DataSource = ds.Tables(0)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            con.Close()
                        End Try
                    Else
                        MessageBox.Show("Correo invalido")
                    End If
                End If
            End If
        Else
            MessageBox.Show("No se permiten valores en blanco")
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sentencia = "Delete from Reporte Where IdFactura='" + TextBox1.Text + "'"
        mensaje = "Datos eliminados"
        Ejectarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select *from Reporte", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim formato As String = "^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$"
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" And TextBox10.Text <> "" And TextBox11.Text <> "" And TextBox12.Text <> "" And TextBox13.Text <> "" And TextBox14.Text <> "" And TextBox15.Text <> "" And TextBox16.Text <> "" And TextBox17.Text <> "" And TextBox18.Text <> "" And TextBox19.Text <> "" And TextBox20.Text <> "" And TextBox21.Text <> "" And TextBox22.Text <> "" And TextBox23.Text <> "" And TextBox24.Text <> "" And TextBox25.Text <> "" Then
            If TextBox24.TextLength < 8 Or TextBox25.TextLength < 8 Then
                MessageBox.Show("El numero telefonico debe ser de 8 digitos")
            Else
                If TextBox1.Text < 1 Or TextBox5.Text < 1 Or TextBox6.Text < 1 Or TextBox9.Text < 1 Or TextBox15.Text < 1 Or TextBox20.Text < 1 Or TextBox24.Text < 1 Or TextBox25.Text < 1 Then
                    MessageBox.Show("Error al ingresar numeros negativos o nulos")
                Else
                    If Regex.IsMatch(TextBox14.Text, formato) Then
                        sentencia = "UPDATE Reporte Set fecha='" + TextBox2.Text + "',hora='" + TextBox3.Text + "',producto='" + TextBox4.Text + "',cod_producto='" + TextBox5.Text + "',cantidad_producto='" + TextBox6.Text + "',precio_unitario='" + TextBox7.Text + "',precio_total='" + TextBox8.Text + "',Cod_cliente='" + TextBox9.Text + "',nombre1_cliente='" + TextBox10.Text + "',nombre2_cliente='" + TextBox11.Text + "',apellido1_cliente='" + TextBox12.Text + "',apellido2_cliente='" + TextBox13.Text + "',correo='" + TextBox14.Text + "',codigo_postal='" + TextBox15.Text + "',pais='" + TextBox16.Text + "',region='" + TextBox17.Text + "',departamento='" + TextBox18.Text + "',municipio='" + TextBox19.Text + "',zona='" + TextBox20.Text + "',colonia='" + TextBox21.Text + "',avenida='" + TextBox22.Text + "',numero_casa='" + TextBox23.Text + "',telefono1_cliente='" + TextBox24.Text + "',telefono2_cliente='" + TextBox25.Text + "' where IdFactura ='" + TextBox1.Text + "'"
                        mensaje = "Datos actualizados"
                        Ejectarsql(sentencia, mensaje)
                        Try
                            Dim da As New SqlDataAdapter("Select *from Reporte", con)
                            Dim ds As New DataSet
                            da.Fill(ds)
                            Me.DataGridView1.DataSource = ds.Tables(0)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            con.Close()
                        End Try
                    End If
                End If
            End If
        Else
            MessageBox.Show("No se permiten valores en blanco")
        End If

    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Sólo se permiten letras")
        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Sólo se permiten letras")
        End If
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Sólo se permiten letras")
        End If
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Sólo se permiten letras")
        End If
    End Sub

    Private Sub TextBox24_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox24.KeyPress
        If TextBox24.TextLength = 8 Then
            e.Handled = True
            MessageBox.Show("El numero telefonico no puede exceder 8 digitos")
            TextBox24.Text = ""
        End If
    End Sub

    Private Sub TextBox25_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox25.KeyPress
        If TextBox25.TextLength = 8 Then
            e.Handled = True
            MessageBox.Show("El numero telefonico no puede exceder 8 digitos")
            TextBox25.Text = ""
        End If
    End Sub

    Private Sub btn_factura_Click(sender As Object, e As EventArgs) Handles btn_factura.Click
        Hide()
        Reporte.Show()
    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Try
            Dim da As New SqlDataAdapter("Select *from Reporte", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
        TextBox24.Text = ""
        TextBox25.Text = ""
    End Sub
End Class