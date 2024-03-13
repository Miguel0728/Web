'MIGUEL A. MELENDEZ HERNANDEZ
'Y00598196
'TRABAJO FINAL VISUAL BASIC


Imports System.Data.SqlClient

Public Class Form3
    ' Cadena de conexión a la base de datos (sustituye con tus propios detalles)
    Dim connectionString As String = "Data Source=MIGUELMELENDEZ\SQLEXPRESS;Initial Catalog=HondaParts;Integrated Security=True"

    Private Sub btnInsertarVendedor_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            ' Valores que deseas insertar (puedes obtenerlos desde los controles del formulario)
            Dim idVendedor As Integer = Convert.ToInt32(txtIdVendedor.Text)
            Dim apellidos As String = txtApellidos.Text
            Dim nombre As String = txtNombre.Text
            Dim direccionFisica As String = txtDFisica.Text
            Dim direccionPostal As String = txtDPostal.Text
            Dim pueblo As String = txtPueblo.Text
            Dim zipCode As String = txtZipCode.Text
            Dim email As String = txtEmail.Text
            Dim telefono As String = txtTelefono.Text
            Dim fechaNacimiento As Date = Convert.ToDateTime(txtFechaDeComienzo.Text)
            Dim Departamento As String = txtDepartamento.Text
            Dim Especialidad As String = txtEspecialidad.Text
            Dim Usuario As String = txtUserCreate.Text
            Dim Password As String = txtPasswordCreate.Text

            ' Crear la conexión SQL
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta SQL para la inserción en la tabla Vendedor
                Dim insertQuery As String = "INSERT INTO Vendedor " &
                    "(IdVendedor, Apellidos, Nombre, DireccionFisica, DireccionPostal, Pueblo, ZipCode, Email, Telefono, FechaDeNacimiento, Departamento, Especialidad, Usuario, Contrasena) " &
                    "VALUES (@IdVendedor, @Apellidos, @Nombre, @DireccionFisica, @DireccionPostal, @Pueblo, @ZipCode, @Email, @Telefono, @FechaDeNacimiento, @Departamento, @Especialidad, @Usuario, @Contrasena)"

                ' Crear el comando SQL
                Using command As New SqlCommand(insertQuery, connection)
                    ' Parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@IdVendedor", idVendedor)
                    command.Parameters.AddWithValue("@Apellidos", apellidos)
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@DireccionFisica", direccionFisica)
                    command.Parameters.AddWithValue("@DireccionPostal", direccionPostal)
                    command.Parameters.AddWithValue("@Pueblo", pueblo)
                    command.Parameters.AddWithValue("@ZipCode", zipCode)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Telefono", telefono)
                    command.Parameters.AddWithValue("@FechaDeNacimiento", fechaNacimiento)
                    command.Parameters.AddWithValue("@Departamento", Departamento)
                    command.Parameters.AddWithValue("@Especialidad", Especialidad)
                    command.Parameters.AddWithValue("@Usuario", Usuario)
                    command.Parameters.AddWithValue("@Contrasena", Password)
                    ' Ejecutar la consulta
                    command.ExecuteNonQuery()

                    MsgBox("Datos de Vendedor insertados con éxito.")
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier excepción
            MsgBox($"Error al insertar datos de Vendedor: {ex.Message}")
        End Try
    End Sub

    Private Sub btnEliminarVendedor_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Obtener el IdVendedor que deseas eliminar (puedes obtenerlo desde los controles del formulario)
            Dim idVendedor As Integer = Convert.ToInt32(txtIdVendedor.Text)

            ' Crear la conexión SQL
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta SQL para eliminar el registro de la tabla Vendedor
                Dim deleteQuery As String = "DELETE FROM Vendedor WHERE IdVendedor = @IdVendedor"

                ' Crear el comando SQL
                Using command As New SqlCommand(deleteQuery, connection)
                    ' Parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@IdVendedor", idVendedor)

                    ' Ejecutar la consulta
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MsgBox("Registro de Vendedor eliminado con éxito.")
                    Else
                        MsgBox("No se encontró el registro con el IdVendedor proporcionado.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier excepción
            MsgBox($"Error al eliminar datos de Vendedor: {ex.Message}")
        End Try
    End Sub


    Private Sub btnActualizarContrasena_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ' Obtener el IdVendedor y la nueva contraseña (puedes obtenerlos desde los controles del formulario)
            Dim idVendedor As Integer = Convert.ToInt32(txtIdVendedor.Text)
            Dim nuevaContrasena As String = txtPasswordCreate.Text

            ' Crear la conexión SQL
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta SQL para actualizar la contraseña de un Vendedor
                Dim updateQuery As String = "UPDATE Vendedor SET Contrasena = @NuevaContrasena WHERE IdVendedor = @IdVendedor"

                ' Crear el comando SQL
                Using command As New SqlCommand(updateQuery, connection)
                    ' Parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@NuevaContrasena", nuevaContrasena)
                    command.Parameters.AddWithValue("@IdVendedor", idVendedor)

                    ' Ejecutar la consulta
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MsgBox("Contraseña de Vendedor actualizada con éxito.")
                    Else
                        MsgBox("No se encontró el registro con el IdVendedor proporcionado.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier excepción
            MsgBox($"Error al actualizar la contraseña de Vendedor: {ex.Message}")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtApellidos.Clear()
        txtNombre.Clear()
        txtDFisica.Clear()
        txtDPostal.Clear()
        txtEmail.Clear()
        txtEspecialidad.Clear()
        txtFechaDeComienzo.Clear()
        txtIdVendedor.Clear()
        txtPueblo.Clear()
        txtZipCode.Clear()
        txtUserCreate.Clear()
        txtTelefono.Clear()
        txtPasswordCreate.Clear()
        txtDepartamento.Clear()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
