Public Class Form1
    Private Sub TablaLoginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TablaLoginBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TablaLoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoginCrudDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginCrudDataSet.TablaLogin' table. You can move, or remove it, as needed.
        Me.TablaLoginTableAdapter.Fill(Me.LoginCrudDataSet.TablaLogin)
        IdTextBox.Text = ""
        ContraseñaTextBox.Text = ""
        RollTextBox.Text = ""

    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Dim fn = frmAdministrador
        If IdTextBox.Text <> "" And ContraseñaTextBox.Text <> "" And RollTextBox.Text <> "" Then
            If Me.TablaLoginTableAdapter.Login(Me.LoginCrudDataSet.TablaLogin, IdTextBox.Text, ContraseñaTextBox.Text, RollTextBox.Text) Then
                If RollTextBox.Text = "Administrador" Then
                    Dim strCadena As String = IdTextBox.Text
                    Dim frmAdministrador As New frmAdministrador(strCadena)
                    frmAdministrador.Show()
                    Me.Hide()
                    MessageBox.Show("Bienvenido administrador")
                End If
                If RollTextBox.Text = "Secretario" Then
                    Dim strCadena As String = IdTextBox.Text
                    Dim frmSecretario As New frmAdministrador(strCadena)
                    frmAdministrador.Show()
                    Me.Hide()
                    fn.btn_eliminar.Visible = False
                    fn.btn_actualizar.Visible = False
                    fn.btn_factura.Visible = False
                    MessageBox.Show("Bienvenido secretario")
                End If
                If RollTextBox.Text = "Usuario" Then
                    Dim strCadena As String = IdTextBox.Text
                    Dim frmUsuario As New frmAdministrador(strCadena)
                    frmAdministrador.Show()
                    Me.Hide()
                    fn.btn_actualizar.Visible = False
                    fn.btn_eliminar.Visible = False
                    fn.btn_insertar.Visible = False
                    fn.Label2.Visible = False
                    fn.TextBox2.Visible = False
                    fn.Label3.Visible = False
                    fn.TextBox3.Visible = False
                    fn.Label4.Visible = False
                    fn.TextBox4.Visible = False
                    fn.Label5.Visible = False
                    fn.TextBox5.Visible = False
                    fn.Label6.Visible = False
                    fn.TextBox6.Visible = False
                    fn.Label7.Visible = False
                    fn.TextBox7.Visible = False
                    fn.Label8.Visible = False
                    fn.txt_verificar_contraseña.Visible = False
                    fn.btn_factura.Visible = False
                    MessageBox.Show("Bienvenido usuario")
                End If
                IdTextBox.Text = ""
                ContraseñaTextBox.Text = ""
                RollTextBox.Text = ""
            Else
                MsgBox("Id, contraseña o roll equivocado")
            End If
        Else
            MessageBox.Show("No se permiten valores en blanco")
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.Exit()
    End Sub
End Class
