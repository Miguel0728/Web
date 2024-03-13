'MIGUEL A. MELENDEZ HERNANDEZ
'Y00598196
'TRABAJO FINAL VISUAL BASIC

Imports System.Data.SqlClient

Public Class Form2
    ' Cadena de conexión a la base de datos (sustituye con tus propios detalles)
    Dim connectionString As String = "Data Source=MIGUELMELENDEZ\SQLEXPRESS;Initial Catalog=HondaParts;Integrated Security=True"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar el ComboBox con los IdVendedor existentes en la tabla Vendedor
        FillComboBox()
    End Sub

    Private Sub FillComboBox()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta SQL para obtener los IdVendedor desde la tabla Vendedor
                Dim query As String = "SELECT IdVendedor FROM Vendedor"

                ' Crear el comando SQL
                Using command As New SqlCommand(query, connection)
                    ' Leer los resultados y llenar el ComboBox
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        cmboxIdVendedor.DataSource = dt
                        cmboxIdVendedor.DisplayMember = "IdVendedor"
                        cmboxIdVendedor.ValueMember = "IdVendedor"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier excepción
            MsgBox($"Error al llenar el ComboBox: {ex.Message}")
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Valores que deseas insertar (puedes obtenerlos desde los controles del formulario)
            Dim idCliente As Integer = Convert.ToInt32(txtIdCliente.Text)
            Dim apellidos As String = txtApellidos.Text
            Dim nombre As String = txtNombre.Text
            Dim direccionFisica As String = txtDFisica.Text
            Dim direccionPostal As String = txtDPostal.Text
            Dim pueblo As String = txtPueblo.Text
            Dim zipCode As String = txtZipCode.Text
            Dim email As String = txtEmail.Text
            Dim telefono As String = txtTelefono.Text
            Dim fechaNacimiento As Date = Convert.ToDateTime(txtFechaDeNacimiento.Text)
            Dim compania As String = txtCompania.Text
            Dim cuota As String = txtCuota.Text

            ' Obtener el IdVendedor seleccionado del ComboBox
            Dim idVendedor As Integer = Convert.ToInt32(cmboxIdVendedor.SelectedValue)

            ' Crear la conexión SQL
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta SQL para la inserción
                Dim insertQuery As String = "INSERT INTO [dbo].[Cliente] " &
                    "(IdCliente, Apellidos, Nombre, DireccionFisica, DireccionPostal, Pueblo, ZipCode, Email, Telefono, FechaDeNacimiento, Compania, Cuota, IdVendedor) " &
                    "VALUES (@IdCliente, @Apellidos, @Nombre, @DireccionFisica, @DireccionPostal, @Pueblo, @ZipCode, @Email, @Telefono, @FechaDeNacimiento, @Compania, @Cuota, @IdVendedor)"

                ' Crear el comando SQL
                Using command As New SqlCommand(insertQuery, connection)
                    ' Parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@IdCliente", idCliente)
                    command.Parameters.AddWithValue("@Apellidos", apellidos)
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@DireccionFisica", direccionFisica)
                    command.Parameters.AddWithValue("@DireccionPostal", direccionPostal)
                    command.Parameters.AddWithValue("@Pueblo", pueblo)
                    command.Parameters.AddWithValue("@ZipCode", zipCode)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Telefono", telefono)
                    command.Parameters.AddWithValue("@FechaDeNacimiento", fechaNacimiento)
                    command.Parameters.AddWithValue("@Compania", compania)
                    command.Parameters.AddWithValue("@Cuota", cuota)
                    command.Parameters.AddWithValue("@IdVendedor", idVendedor)

                    ' Ejecutar la consulta
                    command.ExecuteNonQuery()

                    MsgBox("Datos insertados con éxito.")
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier excepción
            MsgBox($"Error al insertar datos: {ex.Message}")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Obtener el IdCliente que deseas eliminar (puedes obtenerlo desde los controles del formulario)
            Dim idCliente As Integer = Convert.ToInt32(txtIdCliente.Text)

            ' Crear la conexión SQL
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta SQL para eliminar el registro de la tabla Cliente
                Dim deleteQuery As String = "DELETE FROM [dbo].[Cliente] WHERE IdCliente = @IdCliente"

                ' Crear el comando SQL
                Using command As New SqlCommand(deleteQuery, connection)
                    ' Parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@IdCliente", idCliente)

                    ' Ejecutar la consulta
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MsgBox("Registro eliminado con éxito.")
                    Else
                        MsgBox("No se encontró el registro con el IdCliente proporcionado.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier excepción
            MsgBox($"Error al eliminar datos: {ex.Message}")
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
