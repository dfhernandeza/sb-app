<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cotizacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cotizacion))
        Me.DGVInventario = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVDetalle = New System.Windows.Forms.DataGridView()
        Me.CodItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDItemCot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DGVInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVInventario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInventario.Location = New System.Drawing.Point(36, 61)
        Me.DGVInventario.MultiSelect = False
        Me.DGVInventario.Name = "DGVInventario"
        Me.DGVInventario.ReadOnly = True
        Me.DGVInventario.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGVInventario.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVInventario.Size = New System.Drawing.Size(514, 161)
        Me.DGVInventario.TabIndex = 33
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(106, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 20)
        Me.TextBox1.TabIndex = 34
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
        Me.DGVDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodItem, Me.Item, Me.Cantidad, Me.Precio, Me.Total, Me.IDItemCot})
        Me.DGVDetalle.Location = New System.Drawing.Point(13, 250)
        Me.DGVDetalle.MultiSelect = False
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGVDetalle.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDetalle.Size = New System.Drawing.Size(467, 249)
        Me.DGVDetalle.TabIndex = 36
        '
        'CodItem
        '
        Me.CodItem.HeaderText = "CodItem"
        Me.CodItem.Name = "CodItem"
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
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
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'IDItemCot
        '
        Me.IDItemCot.HeaderText = "IDItemCot"
        Me.IDItemCot.Name = "IDItemCot"
        Me.IDItemCot.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextBox4.Location = New System.Drawing.Point(312, 195)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(168, 49)
        Me.TextBox4.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(438, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "TOTAL"
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGVClientes.RowsDefaultCellStyle = DataGridViewCellStyle4
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
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Buscar Cliente"
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Location = New System.Drawing.Point(13, 51)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(146, 20)
        Me.TextBox5.TabIndex = 47
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DGVDetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(598, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 516)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen"
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.WindowsApp3.My.Resources.Resources.commerce_and_shopping__1_
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(22, 201)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(120, 39)
        Me.Button9.TabIndex = 57
        Me.Button9.Text = "Descuento"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextBox9.Location = New System.Drawing.Point(312, 123)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(168, 49)
        Me.TextBox9.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(399, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "DESCUENTOS"
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.WindowsApp3.My.Resources.Resources.right
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(151, 141)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(102, 50)
        Me.Button8.TabIndex = 51
        Me.Button8.Text = "Aprobar"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.WindowsApp3.My.Resources.Resources.supplier__2_
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(151, 85)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 50)
        Me.Button7.TabIndex = 50
        Me.Button7.Text = "Inventariar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.WindowsApp3.My.Resources.Resources.interface__6_
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(13, 25)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 50)
        Me.Button6.TabIndex = 49
        Me.Button6.Text = "Descartar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.WindowsApp3.My.Resources.Resources.interface__5_
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(22, 88)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 50)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = " Guardar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(342, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 79)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Ingresar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.WindowsApp3.My.Resources.Resources.interface__2_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(151, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 50)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Imprimir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.electronics__1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(22, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 50)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Manual"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.DGVInventario)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(580, 239)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos y Servicios"
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.DGVClientes)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Location = New System.Drawing.Point(277, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 273)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clientes"
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.WindowsApp3.My.Resources.Resources.social__1_
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(176, 33)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 38)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "Nuevo Cliente"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "N° Cotización"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(13, 43)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(101, 20)
        Me.TextBox2.TabIndex = 31
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
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(13, 132)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(238, 20)
        Me.TextBox3.TabIndex = 46
        '
        'TextBox6
        '
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.Location = New System.Drawing.Point(13, 178)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(240, 76)
        Me.TextBox6.TabIndex = 50
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "ID Cliente"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(13, 87)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(238, 20)
        Me.TextBox7.TabIndex = 55
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TextBox8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.TextBox7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TextBox6)
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(259, 271)
        Me.GroupBox4.TabIndex = 59
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle Cotización"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(118, 43)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(133, 20)
        Me.TextBox8.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(120, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 17)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "ID Cliente Interrna"
        '
        'Cotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1095, 561)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cotizacion"
        Me.Text = "Cotizacion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVInventario As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVDetalle As DataGridView
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DGVClientes As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents CodItem As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents IDCliente As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents IDItemCot As DataGridViewTextBoxColumn
End Class
