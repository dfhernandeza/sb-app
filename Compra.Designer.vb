<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compra))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tottxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ivatxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.subttxt = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OTComboBox = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.categoria2box = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.IDVentabox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cantidad2box = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ItemComboBox = New System.Windows.Forms.ComboBox()
        Me.preciobox2 = New System.Windows.Forms.TextBox()
        Me.rendiciondgv = New System.Windows.Forms.DataGridView()
        Me.Elemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ctdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.rendiciondgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Item, Me.Cantidad, Me.Precio, Me.Total, Me.Categoria, Me.IDVenta})
        Me.DataGridView1.Location = New System.Drawing.Point(70, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(903, 183)
        Me.DataGridView1.TabIndex = 103
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
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
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'IDVenta
        '
        Me.IDVenta.HeaderText = "IDVenta"
        Me.IDVenta.Name = "IDVenta"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(746, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 24)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Total"
        '
        'tottxt
        '
        Me.tottxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tottxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tottxt.Location = New System.Drawing.Point(813, 242)
        Me.tottxt.Name = "tottxt"
        Me.tottxt.Size = New System.Drawing.Size(120, 29)
        Me.tottxt.TabIndex = 108
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(434, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 24)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "IVA"
        '
        'ivatxt
        '
        Me.ivatxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ivatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ivatxt.Location = New System.Drawing.Point(480, 242)
        Me.ivatxt.Name = "ivatxt"
        Me.ivatxt.Size = New System.Drawing.Size(120, 29)
        Me.ivatxt.TabIndex = 106
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(119, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 24)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Subtotal"
        '
        'subttxt
        '
        Me.subttxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.subttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subttxt.Location = New System.Drawing.Point(202, 244)
        Me.subttxt.Name = "subttxt"
        Me.subttxt.Size = New System.Drawing.Size(120, 29)
        Me.subttxt.TabIndex = 104
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.tottxt)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.ivatxt)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.subttxt)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 305)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1022, 290)
        Me.GroupBox4.TabIndex = 117
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalles"
        '
        'OTComboBox
        '
        Me.OTComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OTComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OTComboBox.FormattingEnabled = True
        Me.OTComboBox.IntegralHeight = False
        Me.OTComboBox.Location = New System.Drawing.Point(15, 32)
        Me.OTComboBox.Name = "OTComboBox"
        Me.OTComboBox.Size = New System.Drawing.Size(145, 32)
        Me.OTComboBox.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 13)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "OT"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.categoria2box)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.IDVentabox)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.cantidad2box)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.ItemComboBox)
        Me.GroupBox5.Controls.Add(Me.preciobox2)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.OTComboBox)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(502, 252)
        Me.GroupBox5.TabIndex = 118
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Por OT"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.WindowsApp3.My.Resources.Resources.enter
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(323, 203)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 43)
        Me.Button4.TabIndex = 114
        Me.Button4.Text = "Ingresar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'categoria2box
        '
        Me.categoria2box.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.categoria2box.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoria2box.FormattingEnabled = True
        Me.categoria2box.Location = New System.Drawing.Point(15, 143)
        Me.categoria2box.Name = "categoria2box"
        Me.categoria2box.Size = New System.Drawing.Size(478, 32)
        Me.categoria2box.TabIndex = 119
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 117
        Me.Label14.Text = "IDVenta"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 118
        Me.Label15.Text = "Categoría"
        '
        'IDVentabox
        '
        Me.IDVentabox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.IDVentabox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDVentabox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDVentabox.Location = New System.Drawing.Point(15, 89)
        Me.IDVentabox.Name = "IDVentabox"
        Me.IDVentabox.Size = New System.Drawing.Size(145, 29)
        Me.IDVentabox.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(300, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 117
        Me.Label16.Text = "Cantidad"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(168, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Item"
        '
        'cantidad2box
        '
        Me.cantidad2box.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cantidad2box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cantidad2box.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad2box.Location = New System.Drawing.Point(303, 89)
        Me.cantidad2box.Name = "cantidad2box"
        Me.cantidad2box.Size = New System.Drawing.Size(193, 29)
        Me.cantidad2box.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(163, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 116
        Me.Label17.Text = "Precio"
        '
        'ItemComboBox
        '
        Me.ItemComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemComboBox.FormattingEnabled = True
        Me.ItemComboBox.IntegralHeight = False
        Me.ItemComboBox.Location = New System.Drawing.Point(171, 32)
        Me.ItemComboBox.Name = "ItemComboBox"
        Me.ItemComboBox.Size = New System.Drawing.Size(325, 32)
        Me.ItemComboBox.TabIndex = 8
        '
        'preciobox2
        '
        Me.preciobox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.preciobox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.preciobox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preciobox2.Location = New System.Drawing.Point(166, 89)
        Me.preciobox2.Name = "preciobox2"
        Me.preciobox2.Size = New System.Drawing.Size(128, 29)
        Me.preciobox2.TabIndex = 10
        '
        'rendiciondgv
        '
        Me.rendiciondgv.AllowUserToAddRows = False
        Me.rendiciondgv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rendiciondgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.rendiciondgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.rendiciondgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Elemento, Me.Ctdad, Me.Cat})
        Me.rendiciondgv.Location = New System.Drawing.Point(15, 32)
        Me.rendiciondgv.Name = "rendiciondgv"
        Me.rendiciondgv.RowHeadersVisible = False
        Me.rendiciondgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.rendiciondgv.Size = New System.Drawing.Size(457, 149)
        Me.rendiciondgv.TabIndex = 119
        '
        'Elemento
        '
        Me.Elemento.HeaderText = "Item"
        Me.Elemento.Name = "Elemento"
        '
        'Ctdad
        '
        Me.Ctdad.HeaderText = "Cantidad"
        Me.Ctdad.Name = "Ctdad"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(295, 181)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(166, 65)
        Me.Button3.TabIndex = 111
        Me.Button3.Text = "Terminar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.rendiciondgv)
        Me.GroupBox1.Location = New System.Drawing.Point(534, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 252)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rendido"
        '
        'Cat
        '
        Me.Cat.HeaderText = "Categoría"
        Me.Cat.Name = "Cat"
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1073, 641)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Compra"
        Me.Text = "Nuevo Gasto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.rendiciondgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents tottxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ivatxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents subttxt As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents OTComboBox As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ItemComboBox As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents IDVentabox As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents categoria2box As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cantidad2box As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents preciobox2 As TextBox
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents IDVenta As DataGridViewTextBoxColumn
    Friend WithEvents rendiciondgv As DataGridView
    Friend WithEvents Elemento As DataGridViewTextBoxColumn
    Friend WithEvents Ctdad As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cat As DataGridViewTextBoxColumn
End Class
