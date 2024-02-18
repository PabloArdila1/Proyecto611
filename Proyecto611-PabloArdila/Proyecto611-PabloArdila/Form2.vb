Imports MySql.Data.MySqlClient

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxTDocumento.Clear()
        TxtNombre.Clear()
        TxTApellido.Clear()
        TxTUsuario.Clear()
        TxTContra.Clear()

        Me.Hide()

        Form1.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conect As New MySqlConnection
        Dim consulta As String
        Dim comando As New MySqlCommand

        Try
            conect.ConnectionString = "server=127.0.0.1;database=sistema2;user id=root;password=;"
            consulta = "INSER INTO empleado () VALUES ();"
            conect.Open()

        Catch ex As Exception
            MsgBox("Error al conectar, rozo rosca: " & ex.Message)
            TxTDocumento.Clear()
            TxtNombre.Clear()
            TxTApellido.Clear()
            TxTUsuario.Clear()
            TxTContra.Clear()
            conect.Close()
            Close()
        End Try
    End Sub
End Class