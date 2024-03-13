'MIGUEL A. MELENDEZ HERNANDEZ
'Y00598196
'TRABAJO FINAL VISUAL BASIC

Imports System.Data.SqlClient

Public Class Form1
    Dim connectionString As String = "Data Source=MIGUELMELENDEZ\SQLEXPRESS;Initial Catalog=HondaParts;Integrated Security=True"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim usuario As String = txtUser.Text
        Dim contrasena As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(usuario) OrElse String.IsNullOrWhiteSpace(contrasena) Then
            MessageBox.Show("Por favor, ingrese el usuario y la contraseña.")
            Return
        End If

        If ValidarCredenciales(usuario, contrasena) Then
            Form2.Show()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos.")
        End If
    End Sub

    Private Function ValidarCredenciales(usuario As String, contrasena As String) As Boolean
        Using conexion As New SqlConnection(connectionString)
            Try
                conexion.Open()

                ' Consulta SQL para validar las credenciales del usuario
                Dim query As String = "SELECT COUNT(*) FROM Vendedor WHERE Usuario = @Usuario AND Contrasena = @Contrasena"

                ' Usar SqlCommand y parámetros
                Using cmd As New SqlCommand(query, conexion)
                    cmd.Parameters.AddWithValue("@Usuario", usuario)
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena)

                    ' Ejecutar la consulta y obtener el resultado
                    Dim count As Integer = CInt(cmd.ExecuteScalar())

                    ' Si count es mayor que 0, significa que las credenciales son válidas
                    Return count > 0
                End Using
            Catch ex As SqlException
                MessageBox.Show("Error al validar las credenciales: " & ex.Message)
                Return False
            Finally
                conexion.Close()
            End Try
        End Using
    End Function

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form3.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form4.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
