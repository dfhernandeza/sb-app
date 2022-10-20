<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarItem))
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ItemTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.VentaTextBox = New System.Windows.Forms.TextBox()
        Me.CompraTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(83, 41)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(27, 24)
        IDLabel.TabIndex = 19
        IDLabel.Text = "ID"
        '
        'ItemLabel
        '
        ItemLabel.AutoSize = True
        ItemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ItemLabel.Location = New System.Drawing.Point(66, 76)
        ItemLabel.Name = "ItemLabel"
        ItemLabel.Size = New System.Drawing.Size(45, 24)
        ItemLabel.TabIndex = 21
        ItemLabel.Text = "Item"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.Location = New System.Drawing.Point(21, 112)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(90, 24)
        CategoriaLabel.TabIndex = 27
        CategoriaLabel.Text = "Categoria"
        '
        'VentaLabel
        '
        VentaLabel.AutoSize = True
        VentaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VentaLabel.Location = New System.Drawing.Point(51, 147)
        VentaLabel.Name = "VentaLabel"
        VentaLabel.Size = New System.Drawing.Size(59, 24)
        VentaLabel.TabIndex = 29
        VentaLabel.Text = "Venta"
        '
        'CompraLabel
        '
        CompraLabel.AutoSize = True
        CompraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CompraLabel.Location = New System.Drawing.Point(33, 182)
        CompraLabel.Name = "CompraLabel"
        CompraLabel.Size = New System.Drawing.Size(77, 24)
        CompraLabel.TabIndex = 31
        CompraLabel.Text = "Compra"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StockLabel.Location = New System.Drawing.Point(51, 217)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(56, 24)
        StockLabel.TabIndex = 33
        StockLabel.Text = "Stock"
        '
        'IDTextBox
        '
        Me.IDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(126, 36)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(196, 29)
        Me.IDTextBox.TabIndex = 20
        '
        'ItemTextBox
        '
        Me.ItemTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ItemTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemTextBox.Location = New System.Drawing.Point(126, 71)
        Me.ItemTextBox.Name = "ItemTextBox"
        Me.ItemTextBox.Size = New System.Drawing.Size(196, 29)
        Me.ItemTextBox.TabIndex = 22
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CategoriaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(126, 107)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(196, 29)
        Me.CategoriaTextBox.TabIndex = 28
        '
        'VentaTextBox
        '
        Me.VentaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VentaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentaTextBox.Location = New System.Drawing.Point(126, 142)
        Me.VentaTextBox.Name = "VentaTextBox"
        Me.VentaTextBox.Size = New System.Drawing.Size(196, 29)
        Me.VentaTextBox.TabIndex = 30
        '
        'CompraTextBox
        '
        Me.CompraTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CompraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompraTextBox.Location = New System.Drawing.Point(125, 177)
        Me.CompraTextBox.Name = "CompraTextBox"
        Me.CompraTextBox.Size = New System.Drawing.Size(196, 29)
        Me.CompraTextBox.TabIndex = 32
        '
        'StockTextBox
        '
        Me.StockTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StockTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockTextBox.Location = New System.Drawing.Point(126, 212)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(195, 29)
        Me.StockTextBox.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(126, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 69)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Actualizar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EditarItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(371, 387)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(ItemLabel)
        Me.Controls.Add(Me.ItemTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(VentaLabel)
        Me.Controls.Add(Me.VentaTextBox)
        Me.Controls.Add(CompraLabel)
        Me.Controls.Add(Me.CompraTextBox)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditarItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarItem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents ItemTextBox As TextBox
    Friend WithEvents CategoriaTextBox As TextBox
    Friend WithEvents VentaTextBox As TextBox
    Friend WithEvents CompraTextBox As TextBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
