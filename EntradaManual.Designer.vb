<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradaManual
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
        Dim TipoLabel As System.Windows.Forms.Label
        Dim UnidadLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim VentaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntradaManual))
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ItemTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.VentaTextBox = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        ItemLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        UnidadLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        VentaLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(46, 35)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(64, 24)
        IDLabel.TabIndex = 19
        IDLabel.Text = "Orden"
        '
        'ItemLabel
        '
        ItemLabel.AutoSize = True
        ItemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ItemLabel.Location = New System.Drawing.Point(54, 73)
        ItemLabel.Name = "ItemLabel"
        ItemLabel.Size = New System.Drawing.Size(51, 24)
        ItemLabel.TabIndex = 21
        ItemLabel.Text = "COD"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(60, 106)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(45, 24)
        TipoLabel.TabIndex = 23
        TipoLabel.Text = "Item"
        '
        'UnidadLabel
        '
        UnidadLabel.AutoSize = True
        UnidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UnidadLabel.Location = New System.Drawing.Point(21, 141)
        UnidadLabel.Name = "UnidadLabel"
        UnidadLabel.Size = New System.Drawing.Size(84, 24)
        UnidadLabel.TabIndex = 25
        UnidadLabel.Text = "Cantidad"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.Location = New System.Drawing.Point(24, 178)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(81, 24)
        CategoriaLabel.TabIndex = 27
        CategoriaLabel.Text = "P. Venta"
        '
        'VentaLabel
        '
        VentaLabel.AutoSize = True
        VentaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VentaLabel.Location = New System.Drawing.Point(6, 213)
        VentaLabel.Name = "VentaLabel"
        VentaLabel.Size = New System.Drawing.Size(99, 24)
        VentaLabel.TabIndex = 29
        VentaLabel.Text = "P. Compra"
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(111, 32)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 29)
        Me.IDTextBox.TabIndex = 20
        '
        'ItemTextBox
        '
        Me.ItemTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemTextBox.Location = New System.Drawing.Point(111, 68)
        Me.ItemTextBox.Name = "ItemTextBox"
        Me.ItemTextBox.Size = New System.Drawing.Size(200, 29)
        Me.ItemTextBox.TabIndex = 22
        '
        'TipoTextBox
        '
        Me.TipoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoTextBox.Location = New System.Drawing.Point(111, 103)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(200, 29)
        Me.TipoTextBox.TabIndex = 24
        '
        'UnidadTextBox
        '
        Me.UnidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnidadTextBox.Location = New System.Drawing.Point(111, 138)
        Me.UnidadTextBox.Name = "UnidadTextBox"
        Me.UnidadTextBox.Size = New System.Drawing.Size(200, 29)
        Me.UnidadTextBox.TabIndex = 26
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(111, 173)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(200, 29)
        Me.CategoriaTextBox.TabIndex = 28
        '
        'VentaTextBox
        '
        Me.VentaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentaTextBox.Location = New System.Drawing.Point(111, 208)
        Me.VentaTextBox.Name = "VentaTextBox"
        Me.VentaTextBox.Size = New System.Drawing.Size(200, 29)
        Me.VentaTextBox.TabIndex = 30
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(111, 280)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 69)
        Me.Button7.TabIndex = 59
        Me.Button7.Text = "Finalizar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'EntradaManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(323, 395)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(ItemLabel)
        Me.Controls.Add(Me.ItemTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(UnidadLabel)
        Me.Controls.Add(Me.UnidadTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(VentaLabel)
        Me.Controls.Add(Me.VentaTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EntradaManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EntradaManual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents ItemTextBox As TextBox
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents UnidadTextBox As TextBox
    Friend WithEvents CategoriaTextBox As TextBox
    Friend WithEvents VentaTextBox As TextBox
    Friend WithEvents Button7 As Button
End Class
