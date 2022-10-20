<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoProveedor
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
        Dim ItemLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim UnidadLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoProveedor))
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.FonoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Comentariostxt = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.MaskedTextBox()
        ItemLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        UnidadLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ItemLabel
        '
        ItemLabel.AutoSize = True
        ItemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ItemLabel.Location = New System.Drawing.Point(165, 18)
        ItemLabel.Name = "ItemLabel"
        ItemLabel.Size = New System.Drawing.Size(44, 13)
        ItemLabel.TabIndex = 21
        ItemLabel.Text = "Nombre"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(34, 66)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(32, 13)
        TipoLabel.TabIndex = 23
        TipoLabel.Text = "Email"
        '
        'UnidadLabel
        '
        UnidadLabel.AutoSize = True
        UnidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UnidadLabel.Location = New System.Drawing.Point(267, 66)
        UnidadLabel.Name = "UnidadLabel"
        UnidadLabel.Size = New System.Drawing.Size(49, 13)
        UnidadLabel.TabIndex = 25
        UnidadLabel.Text = "Teléfono"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.Location = New System.Drawing.Point(34, 114)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(52, 13)
        CategoriaLabel.TabIndex = 27
        CategoriaLabel.Text = "Dirección"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(34, 18)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(18, 13)
        IDLabel.TabIndex = 19
        IDLabel.Text = "ID"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(34, 168)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(65, 13)
        Label1.TabIndex = 61
        Label1.Text = "Comentarios"
        '
        'NomTextBox
        '
        Me.NomTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomTextBox.Location = New System.Drawing.Point(168, 34)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(328, 29)
        Me.NomTextBox.TabIndex = 1
        '
        'EmailTextBox
        '
        Me.EmailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(37, 82)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(226, 29)
        Me.EmailTextBox.TabIndex = 2
        '
        'FonoTextBox
        '
        Me.FonoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FonoTextBox.Location = New System.Drawing.Point(270, 82)
        Me.FonoTextBox.Name = "FonoTextBox"
        Me.FonoTextBox.Size = New System.Drawing.Size(226, 29)
        Me.FonoTextBox.TabIndex = 3
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionTextBox.Location = New System.Drawing.Point(37, 130)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(459, 29)
        Me.DireccionTextBox.TabIndex = 4
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(168, 282)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(159, 69)
        Me.Button7.TabIndex = 60
        Me.Button7.Text = "Finalizar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Comentariostxt
        '
        Me.Comentariostxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Comentariostxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comentariostxt.Location = New System.Drawing.Point(37, 184)
        Me.Comentariostxt.Multiline = True
        Me.Comentariostxt.Name = "Comentariostxt"
        Me.Comentariostxt.Size = New System.Drawing.Size(459, 70)
        Me.Comentariostxt.TabIndex = 5
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(37, 34)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(123, 29)
        Me.IDTextBox.TabIndex = 0
        Me.IDTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'NuevoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(535, 363)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Comentariostxt)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(ItemLabel)
        Me.Controls.Add(Me.NomTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(UnidadLabel)
        Me.Controls.Add(Me.FonoTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NomTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents FonoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Comentariostxt As TextBox
    Friend WithEvents IDTextBox As MaskedTextBox
End Class
