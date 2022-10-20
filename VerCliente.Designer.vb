<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerCliente))
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.FonoTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.MaskedTextBox()
        IDLabel = New System.Windows.Forms.Label()
        ItemLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        UnidadLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(35, 22)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(18, 13)
        IDLabel.TabIndex = 70
        IDLabel.Text = "ID"
        '
        'ItemLabel
        '
        ItemLabel.AutoSize = True
        ItemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ItemLabel.Location = New System.Drawing.Point(164, 22)
        ItemLabel.Name = "ItemLabel"
        ItemLabel.Size = New System.Drawing.Size(44, 13)
        ItemLabel.TabIndex = 71
        ItemLabel.Text = "Nombre"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(35, 70)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(44, 13)
        TipoLabel.TabIndex = 72
        TipoLabel.Text = "Apellido"
        '
        'UnidadLabel
        '
        UnidadLabel.AutoSize = True
        UnidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UnidadLabel.Location = New System.Drawing.Point(387, 118)
        UnidadLabel.Name = "UnidadLabel"
        UnidadLabel.Size = New System.Drawing.Size(49, 13)
        UnidadLabel.TabIndex = 73
        UnidadLabel.Text = "Teléfono"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.Location = New System.Drawing.Point(35, 118)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(32, 13)
        CategoriaLabel.TabIndex = 74
        CategoriaLabel.Text = "Email"
        '
        'NomTextBox
        '
        Me.NomTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomTextBox.Location = New System.Drawing.Point(167, 38)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(444, 29)
        Me.NomTextBox.TabIndex = 66
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ApellidoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(38, 86)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(573, 29)
        Me.ApellidoTextBox.TabIndex = 67
        '
        'FonoTextBox
        '
        Me.FonoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FonoTextBox.Location = New System.Drawing.Point(390, 134)
        Me.FonoTextBox.Name = "FonoTextBox"
        Me.FonoTextBox.Size = New System.Drawing.Size(221, 29)
        Me.FonoTextBox.TabIndex = 68
        '
        'MailTextBox
        '
        Me.MailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MailTextBox.Location = New System.Drawing.Point(38, 134)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(346, 29)
        Me.MailTextBox.TabIndex = 69
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.social__1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(262, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 39)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Aceptar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(38, 38)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(123, 29)
        Me.IDTextBox.TabIndex = 76
        '
        'VerCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(658, 263)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(ItemLabel)
        Me.Controls.Add(Me.NomTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(UnidadLabel)
        Me.Controls.Add(Me.FonoTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VerCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VerCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents NomTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents FonoTextBox As TextBox
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents IDTextBox As MaskedTextBox
End Class
