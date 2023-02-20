Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Public Class frmAdministrador
    Dim _strCadena As String = Nothing
    Dim con As SqlConnection = New SqlConnection(My.Settings.LoginCrudConnectionString)
    Dim sentencia, mensaje As String
    Sub Ejectarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal strParametro As String)
        Me.New()
        _strCadena = strParametro
    End Sub
    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Try
            Dim da As New SqlDataAdapter("Select *from TablaLogin", con)
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
        txt_verificar_contraseña.Text = ""
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And txt_verificar_contraseña.Text <> "" Then
            If TextBox1.Text < 1 Then
                MessageBox.Show("El Id no puede ser menor a 1")
            Else
                If TextBox1.TextLength < 1 Then
                    MessageBox.Show("El Id requiere almenos un digito")
                Else
                    Dim formato As String = "^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$"
                    If Regex.IsMatch(TextBox5.Text, formato) Then
                        If TextBox2.Text = txt_verificar_contraseña.Text Then
                            sentencia = "Insert into TablaLogin Values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')"
                            mensaje = "Usuario creado"
                            Ejectarsql(sentencia, mensaje)
                            Try
                                Dim da As New SqlDataAdapter("Select *from TablaLogin", con)
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
                            txt_verificar_contraseña.Text = ""
                        Else
                            MessageBox.Show("Las contraseñas no coinciden")
                        End If
                    Else
                        MessageBox.Show("El correo es inválido")
                    End If
                End If
            End If
        Else
            MessageBox.Show("No se permiten valores en blanco")
        End If
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And txt_verificar_contraseña.Text <> "" Then
            If TextBox1.Text < 1 Then
                MessageBox.Show("El Id no puede ser menor a 1")
            Else
                If TextBox1.TextLength < 1 Then
                    MessageBox.Show("El Id requiere almenos un digito")
                Else
                    Dim formato As String = "^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$"
                    If Regex.IsMatch(TextBox5.Text, formato) Then
                        If TextBox2.Text = txt_verificar_contraseña.Text Then
                            sentencia = "UPDATE TablaLogin Set Contraseña='" + TextBox2.Text + "',Roll='" + TextBox3.Text + "',Nombre='" + TextBox4.Text + "',Correo='" + TextBox5.Text + "',Pais='" + TextBox6.Text + "',Ocupacion='" + TextBox7.Text + "' where Id ='" + TextBox1.Text + "'"
                            mensaje = "Usuario actualizado"
                            Ejectarsql(sentencia, mensaje)
                            Try
                                Dim da As New SqlDataAdapter("Select *from TablaLogin", con)
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
                            txt_verificar_contraseña.Text = ""
                        Else
                            MessageBox.Show("Las contraseñas no coinciden")
                        End If
                    End If
                End If
            End If
        Else
            MessageBox.Show("No se permiten valores en blanco")
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sentencia = "Delete from TablaLogin Where Id='" + TextBox1.Text + "'"
        mensaje = "Usuario eliminado"
        Ejectarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select *from TablaLogin", con)
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
        txt_verificar_contraseña.Text = ""
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If TextBox1.TextLength = 3 Then
            e.Handled = True
            MessageBox.Show("El Id no puede exceder 3 digitos")
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Sólo se permiten letras")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Sólo se permiten letras")
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            MessageBox.Show("No se permite usar el portapapeles en este espacio")
        End If
    End Sub

    Private Sub txt_verificar_contraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_verificar_contraseña.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            MessageBox.Show("No se permite usar el portapapeles en este espacio")
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_factura_Click(sender As Object, e As EventArgs) Handles btn_factura.Click
        CrudFactura.Show()
        Me.Hide()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim da As New SqlDataAdapter("Select *from TablaLogin where id='" + TextBox1.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        txt_verificar_contraseña.Text = ""
    End Sub
End Class