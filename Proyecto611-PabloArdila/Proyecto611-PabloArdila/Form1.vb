Imports MySql.Data.MySqlClient


Public Class Form1

    Dim conect As New MySqlConnection
    Dim consulta As String
    Dim dataadapter As MySqlDataAdapter
    Dim dataset As New DataSet


    Private Sub SesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SesionToolStripMenuItem.Click
        PanelInicio.Location = New Point(118, 68)
        PanelInicio.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim perfil As Integer
        Dim user, pass As String

        user = TxTUsuario.Text
        pass = TxTPass.Text



        Try
            conect.ConnectionString = "server=127.0.0.1;database=sistema2;user id=root;password=;"
            'MsgBox("Conexion exitosa")
            consulta = "SELECT * FROM usuario WHERE nombre_usu = '" & user & "' AND pass_usu =MD5('" & pass & "');"
            conect.Open()
            dataadapter = New MySqlDataAdapter(consulta, conect)
            dataset.Clear()
            dataadapter.Fill(dataset, "usuario")

            Dim querry As New MySqlCommand(consulta, conect)
            Dim datareader As MySqlDataReader

            datareader = querry.ExecuteReader

            While datareader.Read()
                perfil = (datareader.GetInt32(2))
            End While

            If (dataset.Tables("usuario").Rows.Count() <> 0) Then
                Select Case perfil
                    Case 1
                        MsgBox("Administrador, Bienvenido al sistema",, "Software")
                        PanelInicio.Visible = False
                        TxTUsuario.Text = ""
                        TxTPass.Text = ""
                        Me.MenuStrip1.Items(1).Enabled = True
                        Me.MenuStrip1.Items(2).Enabled = True
                        Me.MenuStrip1.Items(3).Enabled = True
                        Me.MenuStrip1.Items(4).Enabled = True
                        Me.MenuStrip1.Items(5).Enabled = True
                        conect.Close()
                    Case 2
                        MsgBox("Secretaria, Bienvenida al sistema",, "Software")
                        PanelInicio.Visible = False
                        TxTUsuario.Text = ""
                        TxTPass.Text = ""
                        Me.MenuStrip1.Items(1).Enabled = False
                        Me.MenuStrip1.Items(2).Enabled = True
                        Me.MenuStrip1.Items(3).Enabled = True
                        Me.MenuStrip1.Items(4).Enabled = False
                        Me.MenuStrip1.Items(5).Enabled = False
                        conect.Close()
                    Case 3
                        MsgBox("Vendedor, Bienvenido al sistema",, "Software")
                        PanelInicio.Visible = False
                        TxTUsuario.Text = ""
                        TxTPass.Text = ""
                        Me.MenuStrip1.Items(1).Enabled = False
                        Me.MenuStrip1.Items(2).Enabled = True
                        Me.MenuStrip1.Items(3).Enabled = False
                        Me.MenuStrip1.Items(4).Enabled = True
                        Me.MenuStrip1.Items(5).Enabled = False
                        conect.Close()
                    Case 4
                        MsgBox("Cliente, Bienvenido al sistema",, "Software")
                        PanelInicio.Visible = False
                        TxTUsuario.Text = ""
                        TxTPass.Text = ""
                        Me.MenuStrip1.Items(1).Enabled = False
                        Me.MenuStrip1.Items(2).Enabled = False
                        Me.MenuStrip1.Items(3).Enabled = False
                        Me.MenuStrip1.Items(4).Enabled = False
                        Me.MenuStrip1.Items(5).Enabled = True
                        conect.Close()
                    Case Else
                        MsgBox("Cliente de perfil ", "Software")
                        PanelInicio.Visible = False
                        TxTUsuario.Text = ""
                        TxTPass.Text = ""
                        conect.Close()
                End Select
            Else
                MessageBox.Show("nombre de  usuario y/0 contraseña incorrectos")
                TxTUsuario.Text = ""
                TxTPass.Text = ""
            End If
            conect.Close()
        Catch ex As Exception
            MsgBox("Error al conectar rozo rosca: " & ex.Message)
            conect.Close()
        End Try
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxTUsuario.Clear()
        TxTPass.Clear()
        PanelInicio.Visible = False

    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Form2.ShowDialog()

        Me.Hide()
    End Sub
End Class
