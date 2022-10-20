<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CotiNeumaticos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CotiNeumaticos))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.IDClienteInternaBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RutClienteBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DetalleBox = New System.Windows.Forms.TextBox()
        Me.ClienteBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IDPEdidoBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BuscarClienteBox = New System.Windows.Forms.TextBox()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NuevoClienteBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DescuentoBtn = New System.Windows.Forms.Button()
        Me.DescuentoBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GuardarBtn = New System.Windows.Forms.Button()
        Me.IngresarBtn = New System.Windows.Forms.Button()
        Me.ManualBtn = New System.Windows.Forms.Button()
        Me.TotalBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVDetalle = New System.Windows.Forms.DataGridView()
        Me.Ancho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Radio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Velocidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVInventario = New System.Windows.Forms.DataGridView()
        Me.BuscarItemBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.IDClienteInternaBox)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.RutClienteBox)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.DetalleBox)
        Me.GroupBox4.Controls.Add(Me.ClienteBox)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.IDPEdidoBox)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(259, 271)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle Cotización"
        '
        'IDClienteInternaBox
        '
        Me.IDClienteInternaBox.BackColor = System.Drawing.Color.White
        Me.IDClienteInternaBox.Location = New System.Drawing.Point(120, 44)
        Me.IDClienteInternaBox.Name = "IDClienteInternaBox"
        Me.IDClienteInternaBox.ReadOnly = True
        Me.IDClienteInternaBox.Size = New System.Drawing.Size(133, 20)
        Me.IDClienteInternaBox.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(120, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 17)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "ID Cliente Interrna"
        '
        'RutClienteBox
        '
        Me.RutClienteBox.BackColor = System.Drawing.Color.White
        Me.RutClienteBox.Location = New System.Drawing.Point(13, 87)
        Me.RutClienteBox.Name = "RutClienteBox"
        Me.RutClienteBox.ReadOnly = True
        Me.RutClienteBox.Size = New System.Drawing.Size(238, 20)
        Me.RutClienteBox.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "ID Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Detalles"
        '
        'DetalleBox
        '
        Me.DetalleBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DetalleBox.Location = New System.Drawing.Point(13, 178)
        Me.DetalleBox.Multiline = True
        Me.DetalleBox.Name = "DetalleBox"
        Me.DetalleBox.Size = New System.Drawing.Size(240, 76)
        Me.DetalleBox.TabIndex = 50
        '
        'ClienteBox
        '
        Me.ClienteBox.BackColor = System.Drawing.Color.White
        Me.ClienteBox.Location = New System.Drawing.Point(13, 132)
        Me.ClienteBox.Name = "ClienteBox"
        Me.ClienteBox.ReadOnly = True
        Me.ClienteBox.Size = New System.Drawing.Size(238, 20)
        Me.ClienteBox.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Cliente"
        '
        'IDPEdidoBox
        '
        Me.IDPEdidoBox.BackColor = System.Drawing.Color.White
        Me.IDPEdidoBox.Location = New System.Drawing.Point(13, 43)
        Me.IDPEdidoBox.Name = "IDPEdidoBox"
        Me.IDPEdidoBox.ReadOnly = True
        Me.IDPEdidoBox.Size = New System.Drawing.Size(101, 20)
        Me.IDPEdidoBox.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "N° Pedido"
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.BuscarClienteBox)
        Me.GroupBox3.Controls.Add(Me.DGVClientes)
        Me.GroupBox3.Controls.Add(Me.NuevoClienteBtn)
        Me.GroupBox3.Location = New System.Drawing.Point(277, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 273)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clientes"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Buscar Cliente"
        '
        'BuscarClienteBox
        '
        Me.BuscarClienteBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BuscarClienteBox.Location = New System.Drawing.Point(13, 51)
        Me.BuscarClienteBox.Name = "BuscarClienteBox"
        Me.BuscarClienteBox.Size = New System.Drawing.Size(146, 20)
        Me.BuscarClienteBox.TabIndex = 47
        '
        'DGVClientes
        '
        Me.DGVClientes.AllowUserToAddRows = False
        Me.DGVClientes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVClientes.BackgroundColor = System.Drawing.Color.White
        Me.DGVClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.IDCliente, Me.Nombre, Me.Apellido})
        Me.DGVClientes.Location = New System.Drawing.Point(13, 88)
        Me.DGVClientes.MultiSelect = False
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.ReadOnly = True
        Me.DGVClientes.RowHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGVClientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVClientes.Size = New System.Drawing.Size(290, 166)
        Me.DGVClientes.TabIndex = 45
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'IDCliente
        '
        Me.IDCliente.HeaderText = "ID Cliente"
        Me.IDCliente.Name = "IDCliente"
        Me.IDCliente.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'NuevoClienteBtn
        '
        Me.NuevoClienteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.NuevoClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NuevoClienteBtn.Image = Global.WindowsApp3.My.Resources.Resources.social__1_
        Me.NuevoClienteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NuevoClienteBtn.Location = New System.Drawing.Point(176, 33)
        Me.NuevoClienteBtn.Name = "NuevoClienteBtn"
        Me.NuevoClienteBtn.Size = New System.Drawing.Size(127, 38)
        Me.NuevoClienteBtn.TabIndex = 43
        Me.NuevoClienteBtn.Text = "Nuevo Cliente"
        Me.NuevoClienteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NuevoClienteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.NuevoClienteBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DescuentoBtn)
        Me.GroupBox1.Controls.Add(Me.DescuentoBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.GuardarBtn)
        Me.GroupBox1.Controls.Add(Me.IngresarBtn)
        Me.GroupBox1.Controls.Add(Me.ManualBtn)
        Me.GroupBox1.Controls.Add(Me.TotalBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DGVDetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(598, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 491)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen"
        '
        'DescuentoBtn
        '
        Me.DescuentoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.DescuentoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DescuentoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescuentoBtn.Image = Global.WindowsApp3.My.Resources.Resources.commerce_and_shopping__1_
        Me.DescuentoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DescuentoBtn.Location = New System.Drawing.Point(13, 25)
        Me.DescuentoBtn.Name = "DescuentoBtn"
        Me.DescuentoBtn.Size = New System.Drawing.Size(120, 39)
        Me.DescuentoBtn.TabIndex = 57
        Me.DescuentoBtn.Text = "Descuento"
        Me.DescuentoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DescuentoBtn.UseVisualStyleBackColor = True
        '
        'DescuentoBox
        '
        Me.DescuentoBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescuentoBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescuentoBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.DescuentoBox.Location = New System.Drawing.Point(350, 180)
        Me.DescuentoBox.Name = "DescuentoBox"
        Me.DescuentoBox.ReadOnly = True
        Me.DescuentoBox.Size = New System.Drawing.Size(168, 49)
        Me.DescuentoBox.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(437, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "DESCUENTOS"
        '
        'GuardarBtn
        '
        Me.GuardarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.GuardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuardarBtn.Image = Global.WindowsApp3.My.Resources.Resources.interface__5_
        Me.GuardarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuardarBtn.Location = New System.Drawing.Point(13, 102)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(120, 50)
        Me.GuardarBtn.TabIndex = 42
        Me.GuardarBtn.Text = " Guardar"
        Me.GuardarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'IngresarBtn
        '
        Me.IngresarBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IngresarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.IngresarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IngresarBtn.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.IngresarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngresarBtn.Location = New System.Drawing.Point(556, 33)
        Me.IngresarBtn.Name = "IngresarBtn"
        Me.IngresarBtn.Size = New System.Drawing.Size(129, 79)
        Me.IngresarBtn.TabIndex = 41
        Me.IngresarBtn.Text = "Salir"
        Me.IngresarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IngresarBtn.UseVisualStyleBackColor = True
        '
        'ManualBtn
        '
        Me.ManualBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ManualBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManualBtn.Image = Global.WindowsApp3.My.Resources.Resources.electronics__1_
        Me.ManualBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManualBtn.Location = New System.Drawing.Point(13, 178)
        Me.ManualBtn.Name = "ManualBtn"
        Me.ManualBtn.Size = New System.Drawing.Size(102, 50)
        Me.ManualBtn.TabIndex = 39
        Me.ManualBtn.Text = "Manual"
        Me.ManualBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ManualBtn.UseVisualStyleBackColor = True
        '
        'TotalBox
        '
        Me.TotalBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TotalBox.Location = New System.Drawing.Point(556, 180)
        Me.TotalBox.Name = "TotalBox"
        Me.TotalBox.ReadOnly = True
        Me.TotalBox.Size = New System.Drawing.Size(168, 49)
        Me.TotalBox.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(682, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "TOTAL"
        '
        'DGVDetalle
        '
        Me.DGVDetalle.AllowUserToAddRows = False
        Me.DGVDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVDetalle.BackgroundColor = System.Drawing.Color.White
        Me.DGVDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ancho, Me.Perfil, Me.Radio, Me.Carga, Me.Velocidad, Me.Cantidad, Me.Precio, Me.IDDetalle})
        Me.DGVDetalle.Location = New System.Drawing.Point(13, 250)
        Me.DGVDetalle.MultiSelect = False
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGVDetalle.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDetalle.Size = New System.Drawing.Size(711, 224)
        Me.DGVDetalle.TabIndex = 36
        '
        'Ancho
        '
        Me.Ancho.HeaderText = "Ancho"
        Me.Ancho.Name = "Ancho"
        '
        'Perfil
        '
        Me.Perfil.HeaderText = "Perfil"
        Me.Perfil.Name = "Perfil"
        '
        'Radio
        '
        Me.Radio.HeaderText = "Radio"
        Me.Radio.Name = "Radio"
        '
        'Carga
        '
        Me.Carga.HeaderText = "Carga"
        Me.Carga.Name = "Carga"
        '
        'Velocidad
        '
        Me.Velocidad.HeaderText = "Velocidad"
        Me.Velocidad.Name = "Velocidad"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'IDDetalle
        '
        Me.IDDetalle.HeaderText = "IDDetalle"
        Me.IDDetalle.Name = "IDDetalle"
        Me.IDDetalle.Visible = False
        '
        'DGVInventario
        '
        Me.DGVInventario.AllowUserToAddRows = False
        Me.DGVInventario.AllowUserToDeleteRows = False
        Me.DGVInventario.AllowUserToResizeColumns = False
        Me.DGVInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DGVInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVInventario.BackgroundColor = System.Drawing.Color.White
        Me.DGVInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVInventario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInventario.Location = New System.Drawing.Point(36, 61)
        Me.DGVInventario.MultiSelect = False
        Me.DGVInventario.Name = "DGVInventario"
        Me.DGVInventario.ReadOnly = True
        Me.DGVInventario.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGVInventario.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVInventario.Size = New System.Drawing.Size(514, 134)
        Me.DGVInventario.TabIndex = 33
        '
        'BuscarItemBox
        '
        Me.BuscarItemBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BuscarItemBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BuscarItemBox.Location = New System.Drawing.Point(106, 35)
        Me.BuscarItemBox.Name = "BuscarItemBox"
        Me.BuscarItemBox.Size = New System.Drawing.Size(116, 20)
        Me.BuscarItemBox.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Buscar Ítem"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BuscarItemBox)
        Me.GroupBox2.Controls.Add(Me.DGVInventario)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 291)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(580, 212)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inventario"
        '
        'CotiNeumaticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 535)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CotiNeumaticos"
        Me.Text = "CotiNeumaticos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents IDClienteInternaBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RutClienteBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DetalleBox As TextBox
    Friend WithEvents ClienteBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents IDPEdidoBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BuscarClienteBox As TextBox
    Friend WithEvents DGVClientes As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents IDCliente As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents NuevoClienteBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DescuentoBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GuardarBtn As Button
    Friend WithEvents IngresarBtn As Button
    Friend WithEvents ManualBtn As Button
    Friend WithEvents TotalBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVDetalle As DataGridView
    Friend WithEvents Ancho As DataGridViewTextBoxColumn
    Friend WithEvents Perfil As DataGridViewTextBoxColumn
    Friend WithEvents Radio As DataGridViewTextBoxColumn
    Friend WithEvents Carga As DataGridViewTextBoxColumn
    Friend WithEvents Velocidad As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents DescuentoBtn As Button
    Friend WithEvents DGVInventario As DataGridView
    Friend WithEvents BuscarItemBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents IDDetalle As DataGridViewTextBoxColumn
End Class
