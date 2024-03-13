<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.txtIdVendedor = New System.Windows.Forms.TextBox()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.TblVendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HondaPartsDataSet = New AutoPartsHonda.HondaPartsDataSet()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtFechaDeComienzo = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtPueblo = New System.Windows.Forms.TextBox()
        Me.txtDPostal = New System.Windows.Forms.TextBox()
        Me.txtDFisica = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtPasswordCreate = New System.Windows.Forms.TextBox()
        Me.txtUserCreate = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TblVendedorTableAdapter = New AutoPartsHonda.HondaPartsDataSetTableAdapters.tblVendedorTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblVendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HondaPartsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.Label)
        Me.GroupBox1.Controls.Add(Me.txtIdVendedor)
        Me.GroupBox1.Controls.Add(Me.txtEspecialidad)
        Me.GroupBox1.Controls.Add(Me.txtDepartamento)
        Me.GroupBox1.Controls.Add(Me.txtFechaDeComienzo)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtZipCode)
        Me.GroupBox1.Controls.Add(Me.txtPueblo)
        Me.GroupBox1.Controls.Add(Me.txtDPostal)
        Me.GroupBox1.Controls.Add(Me.txtDFisica)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
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
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(37, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 348)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insertar los datos"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(389, 280)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(93, 21)
        Me.Label.TabIndex = 23
        Me.Label.Text = "IdVendedor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtIdVendedor
        '
        Me.txtIdVendedor.Location = New System.Drawing.Point(579, 280)
        Me.txtIdVendedor.Name = "txtIdVendedor"
        Me.txtIdVendedor.Size = New System.Drawing.Size(100, 28)
        Me.txtIdVendedor.TabIndex = 22
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendedorBindingSource, "Especialidad", True))
        Me.txtEspecialidad.Location = New System.Drawing.Point(579, 206)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(100, 28)
        Me.txtEspecialidad.TabIndex = 21
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
        'txtDepartamento
        '
        Me.txtDepartamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendedorBindingSource, "Departamento", True))
        Me.txtDepartamento.Location = New System.Drawing.Point(579, 168)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(100, 28)
        Me.txtDepartamento.TabIndex = 20
        '
        'txtFechaDeComienzo
        '
        Me.txtFechaDeComienzo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendedorBindingSource, "FechaDeComienzo", True))
        Me.txtFechaDeComienzo.Location = New System.Drawing.Point(579, 127)
        Me.txtFechaDeComienzo.Name = "txtFechaDeComienzo"
        Me.txtFechaDeComienzo.Size = New System.Drawing.Size(100, 28)
        Me.txtFechaDeComienzo.TabIndex = 19
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendedorBindingSource, "Telefono", True))
        Me.txtTelefono.Location = New System.Drawing.Point(579, 82)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 28)
        Me.txtTelefono.TabIndex = 18
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendedorBindingSource, "Email", True))
        Me.txtEmail.Location = New System.Drawing.Point(579, 37)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 28)
        Me.txtEmail.TabIndex = 17
        '
        'txtZipCode
        '
        Me.txtZipCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendedorBindingSource, "ZipCode", True))
        Me.txtZipCode.Location = New System.Drawing.Point(215, 247)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(100, 28)
        Me.txtZipCode.TabIndex = 16
        '
        'txtPueblo
        '
        Me.txtPueblo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendedorBindingSource, "Pueblo", True))
        Me.txtPueblo.Location = New System.Drawing.Point(215, 206)
        Me.txtPueblo.Name = "txtPueblo"
        Me.txtPueblo.Size = New System.Drawing.Size(100, 28)
        Me.txtPueblo.TabIndex = 15
        '
        'txtDPostal
        '
        Me.txtDPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendedorBindingSource, "DireccionPostal", True))
        Me.txtDPostal.Location = New System.Drawing.Point(215, 168)
        Me.txtDPostal.Name = "txtDPostal"
        Me.txtDPostal.Size = New System.Drawing.Size(100, 28)
        Me.txtDPostal.TabIndex = 14
        '
        'txtDFisica
        '
        Me.txtDFisica.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendedorBindingSource, "DireccionFisica", True))
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
        Me.Label11.Location = New System.Drawing.Point(389, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 21)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Especialidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(389, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Departamento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(389, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Fecha de Comienzo"
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnCreate)
        Me.GroupBox2.Controls.Add(Me.txtPasswordCreate)
        Me.GroupBox2.Controls.Add(Me.txtUserCreate)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(177, 402)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(454, 231)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "\"
        '
        'btnUpdate
        '
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.Location = New System.Drawing.Point(358, 178)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 30)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(358, 131)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 29)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Location = New System.Drawing.Point(358, 82)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 29)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCreate.Location = New System.Drawing.Point(358, 35)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 28)
        Me.btnCreate.TabIndex = 22
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtPasswordCreate
        '
        Me.txtPasswordCreate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendedorBindingSource, "Contrasena", True))
        Me.txtPasswordCreate.Location = New System.Drawing.Point(189, 125)
        Me.txtPasswordCreate.Name = "txtPasswordCreate"
        Me.txtPasswordCreate.Size = New System.Drawing.Size(100, 28)
        Me.txtPasswordCreate.TabIndex = 18
        '
        'txtUserCreate
        '
        Me.txtUserCreate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendedorBindingSource, "Usuario", True))
        Me.txtUserCreate.Location = New System.Drawing.Point(189, 29)
        Me.txtUserCreate.Name = "txtUserCreate"
        Me.txtUserCreate.Size = New System.Drawing.Size(100, 28)
        Me.txtUserCreate.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(79, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 21)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Password"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(79, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 21)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "User"
        '
        'TblVendedorTableAdapter
        '
        Me.TblVendedorTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(857, 674)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblVendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HondaPartsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEspecialidad As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtFechaDeComienzo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtPueblo As TextBox
    Friend WithEvents txtDPostal As TextBox
    Friend WithEvents txtDFisica As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtPasswordCreate As TextBox
    Friend WithEvents txtUserCreate As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents HondaPartsDataSet As HondaPartsDataSet
    Friend WithEvents TblVendedorBindingSource As BindingSource
    Friend WithEvents TblVendedorTableAdapter As HondaPartsDataSetTableAdapters.tblVendedorTableAdapter
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label As Label
    Friend WithEvents txtIdVendedor As TextBox
End Class
