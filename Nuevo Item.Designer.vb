<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoItem
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim ItemLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim VentaLabel As System.Windows.Forms.Label
        Dim CompraLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoItem))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.IDT = New System.Windows.Forms.TextBox()
        Me.ItemT = New System.Windows.Forms.TextBox()
        Me.VentaT = New System.Windows.Forms.TextBox()
        Me.CompraT = New System.Windows.Forms.TextBox()
        Me.StockT = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cat = New System.Windows.Forms.ComboBox()
        IDLabel = New System.Windows.Forms.Label()
        ItemLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        VentaLabel = New System.Windows.Forms.Label()
        CompraLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(21, 21)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(18, 13)
        IDLabel.TabIndex = 19
        IDLabel.Text = "ID"
        '
        'ItemLabel
        '
        ItemLabel.AutoSize = True
        ItemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ItemLabel.Location = New System.Drawing.Point(21, 69)
        ItemLabel.Name = "ItemLabel"
        ItemLabel.Size = New System.Drawing.Size(27, 13)
        ItemLabel.TabIndex = 21
        ItemLabel.Text = "Item"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.Location = New System.Drawing.Point(21, 124)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(52, 13)
        CategoriaLabel.TabIndex = 27
        CategoriaLabel.Text = "Categoria"
        '
        'VentaLabel
        '
        VentaLabel.AutoSize = True
        VentaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VentaLabel.Location = New System.Drawing.Point(25, 175)
        VentaLabel.Name = "VentaLabel"
        VentaLabel.Size = New System.Drawing.Size(35, 13)
        VentaLabel.TabIndex = 29
        VentaLabel.Text = "Venta"
        '
        'CompraLabel
        '
        CompraLabel.AutoSize = True
        CompraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CompraLabel.Location = New System.Drawing.Point(136, 175)
        CompraLabel.Name = "CompraLabel"
        CompraLabel.Size = New System.Drawing.Size(43, 13)
        CompraLabel.TabIndex = 31
        CompraLabel.Text = "Compra"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StockLabel.Location = New System.Drawing.Point(256, 175)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(35, 13)
        StockLabel.TabIndex = 33
        StockLabel.Text = "Stock"
        '
        'IDT
        '
        Me.IDT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDT.Location = New System.Drawing.Point(24, 37)
        Me.IDT.Name = "IDT"
        Me.IDT.Size = New System.Drawing.Size(331, 29)
        Me.IDT.TabIndex = 20
        '
        'ItemT
        '
        Me.ItemT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ItemT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemT.Location = New System.Drawing.Point(24, 85)
        Me.ItemT.Name = "ItemT"
        Me.ItemT.Size = New System.Drawing.Size(331, 29)
        Me.ItemT.TabIndex = 22
        '
        'VentaT
        '
        Me.VentaT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VentaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentaT.Location = New System.Drawing.Point(24, 191)
        Me.VentaT.Name = "VentaT"
        Me.VentaT.Size = New System.Drawing.Size(109, 29)
        Me.VentaT.TabIndex = 30
        '
        'CompraT
        '
        Me.CompraT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CompraT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompraT.Location = New System.Drawing.Point(139, 191)
        Me.CompraT.Name = "CompraT"
        Me.CompraT.Size = New System.Drawing.Size(114, 29)
        Me.CompraT.TabIndex = 32
        '
        'StockT
        '
        Me.StockT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StockT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockT.Location = New System.Drawing.Point(259, 191)
        Me.StockT.Name = "StockT"
        Me.StockT.Size = New System.Drawing.Size(96, 29)
        Me.StockT.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(110, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 77)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Aceptar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cat
        '
        Me.cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat.FormattingEnabled = True
        Me.cat.Items.AddRange(New Object() {"AMPOLLETAS", "FILTROS DE ACEITE", "FILTROS DE AIRE", "FILTROS DE COMBUSTIBLE", "FILTROS DE POLEN", "FILTROS POLEN", "LUBRICANTES", "LUBRICANTES FUERA DEL INVENTARIO", "NEUMATICOS", "OTROS", "PLUMILLAS", "REPUESTOS", "SERVICIOS", "VÁLVULAS", "VULCANIZACIÓN"})
        Me.cat.Location = New System.Drawing.Point(25, 140)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(329, 28)
        Me.cat.TabIndex = 38
        '
        'NuevoItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(386, 338)
        Me.Controls.Add(Me.cat)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDT)
        Me.Controls.Add(ItemLabel)
        Me.Controls.Add(Me.ItemT)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(VentaLabel)
        Me.Controls.Add(Me.VentaT)
        Me.Controls.Add(CompraLabel)
        Me.Controls.Add(Me.CompraT)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NuevoItem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents IDT As TextBox
    Friend WithEvents ItemT As TextBox
    Friend WithEvents VentaT As TextBox
    Friend WithEvents CompraT As TextBox
    Friend WithEvents StockT As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cat As ComboBox
End Class
