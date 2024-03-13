<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmboxIdVendedor = New System.Windows.Forms.ComboBox()
        Me.TblVendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HondaPartsDataSet = New AutoPartsHonda.HondaPartsDataSet()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCuota = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCompania = New System.Windows.Forms.TextBox()
        Me.txtFechaDeNacimiento = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtPueblo = New System.Windows.Forms.TextBox()
        Me.txtDPostal = New System.Windows.Forms.TextBox()
        Me.txtDFisica = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TblVendedorTableAdapter = New AutoPartsHonda.HondaPartsDataSetTableAdapters.tblVendedorTableAdapter()
        Me.TblClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HondaPartsDataSet2 = New AutoPartsHonda.HondaPartsDataSet2()
        Me.TblClienteTableAdapter = New AutoPartsHonda.HondaPartsDataSet2TableAdapters.tblClienteTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblVendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HondaPartsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HondaPartsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmboxIdVendedor)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.txtIdCliente)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtCuota)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtCompania)
        Me.GroupBox1.Controls.Add(Me.txtFechaDeNacimiento)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtZipCode)
        Me.GroupBox1.Controls.Add(Me.txtPueblo)
        Me.GroupBox1.Controls.Add(Me.txtDPostal)
        Me.GroupBox1.Controls.Add(Me.txtDFisica)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(36, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 396)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insertar los datos"
        '
        'cmboxIdVendedor
        '
        Me.cmboxIdVendedor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblVendedorBindingSource, "IdVendedor", True))
        Me.cmboxIdVendedor.DataSource = Me.TblVendedorBindingSource
        Me.cmboxIdVendedor.DisplayMember = "IdVendedor"
        Me.cmboxIdVendedor.FormattingEnabled = True
        Me.cmboxIdVendedor.Location = New System.Drawing.Point(579, 307)
        Me.cmboxIdVendedor.Name = "cmboxIdVendedor"
        Me.cmboxIdVendedor.Size = New System.Drawing.Size(121, 29)
        Me.cmboxIdVendedor.TabIndex = 3
        Me.cmboxIdVendedor.ValueMember = "IdVendedor"
        '
        'TblVendedorBindingSource
        '
        Me.TblVendedorBindingSource.DataMember = "tblVendedor"
        Me.TblVendedorBindingSource.DataSource = Me.HondaPartsDataSet
        '
        'HondaPartsDataSet
        '
        Me.HondaPartsDataSet.DataSetName = "HondaPartsDataSet"
        Me.HondaPartsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAdd
        '
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(240, 323)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 32)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Location = New System.Drawing.Point(343, 323)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 32)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.Location = New System.Drawing.Point(443, 323)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(579, 253)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 28)
        Me.txtIdCliente.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(388, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 21)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "IdCliente"
        '
        'txtCuota
        '
        Me.txtCuota.Location = New System.Drawing.Point(579, 206)
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.Size = New System.Drawing.Size(100, 28)
        Me.txtCuota.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(388, 206)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 21)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Cuota"
        '
        'txtCompania
        '
        Me.txtCompania.Location = New System.Drawing.Point(579, 165)
        Me.txtCompania.Name = "txtCompania"
        Me.txtCompania.Size = New System.Drawing.Size(100, 28)
        Me.txtCompania.TabIndex = 21
        '
        'txtFechaDeNacimiento
        '
        Me.txtFechaDeNacimiento.Location = New System.Drawing.Point(579, 127)
        Me.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento"
        Me.txtFechaDeNacimiento.Size = New System.Drawing.Size(100, 28)
        Me.txtFechaDeNacimiento.TabIndex = 19
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(579, 82)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 28)
        Me.txtTelefono.TabIndex = 18
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(579, 37)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 28)
        Me.txtEmail.TabIndex = 17
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(215, 250)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(100, 28)
        Me.txtZipCode.TabIndex = 16
        '
        'txtPueblo
        '
        Me.txtPueblo.Location = New System.Drawing.Point(215, 206)
        Me.txtPueblo.Name = "txtPueblo"
        Me.txtPueblo.Size = New System.Drawing.Size(100, 28)
        Me.txtPueblo.TabIndex = 15
        '
        'txtDPostal
        '
        Me.txtDPostal.Location = New System.Drawing.Point(215, 168)
        Me.txtDPostal.Name = "txtDPostal"
        Me.txtDPostal.Size = New System.Drawing.Size(100, 28)
        Me.txtDPostal.TabIndex = 14
        '
        'txtDFisica
        '
        Me.txtDFisica.Location = New System.Drawing.Point(215, 127)
        Me.txtDFisica.Name = "txtDFisica"
        Me.txtDFisica.Size = New System.Drawing.Size(100, 28)
        Me.txtDFisica.TabIndex = 13
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(215, 82)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 28)
        Me.txtNombre.TabIndex = 12
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(215, 36)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(100, 28)
        Me.txtApellidos.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(389, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 21)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Compania"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(389, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Fecha de Nacimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(389, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Telefono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(389, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ZipCode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pueblo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DireccionPostal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DireccionFisica"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellidos"
        '
        'TblVendedorTableAdapter
        '
        Me.TblVendedorTableAdapter.ClearBeforeFill = True
        '
        'TblClienteBindingSource
        '
        Me.TblClienteBindingSource.DataMember = "tblCliente"
        Me.TblClienteBindingSource.DataSource = Me.HondaPartsDataSet2
        '
        'HondaPartsDataSet2
        '
        Me.HondaPartsDataSet2.DataSetName = "HondaPartsDataSet2"
        Me.HondaPartsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblClienteTableAdapter
        '
        Me.TblClienteTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(851, 568)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblVendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HondaPartsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HondaPartsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCuota As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCompania As TextBox
    Friend WithEvents txtFechaDeNacimiento As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtPueblo As TextBox
    Friend WithEvents txtDPostal As TextBox
    Friend WithEvents txtDFisica As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents HondaPartsDataSet As HondaPartsDataSet
    Friend WithEvents TblVendedorBindingSource As BindingSource
    Friend WithEvents TblVendedorTableAdapter As HondaPartsDataSetTableAdapters.tblVendedorTableAdapter
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents HondaPartsDataSet2 As HondaPartsDataSet2
    Friend WithEvents TblClienteBindingSource As BindingSource
    Friend WithEvents TblClienteTableAdapter As HondaPartsDataSet2TableAdapters.tblClienteTableAdapter
    Friend WithEvents cmboxIdVendedor As ComboBox
End Class
