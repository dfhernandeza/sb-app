<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoCliente
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoCliente))
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.FonoTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fechatxt = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.idinternabox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.MaskedTextBox()
        IDLabel = New System.Windows.Forms.Label()
        ItemLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        UnidadLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(105, 16)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(18, 13)
        IDLabel.TabIndex = 37
        IDLabel.Text = "ID"
        '
        'ItemLabel
        '
        ItemLabel.AutoSize = True
        ItemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ItemLabel.Location = New System.Drawing.Point(234, 16)
        ItemLabel.Name = "ItemLabel"
        ItemLabel.Size = New System.Drawing.Size(44, 13)
        ItemLabel.TabIndex = 39
        ItemLabel.Text = "Nombre"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(35, 71)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(44, 13)
        TipoLabel.TabIndex = 41
        TipoLabel.Text = "Apellido"
        '
        'UnidadLabel
        '
        UnidadLabel.AutoSize = True
        UnidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UnidadLabel.Location = New System.Drawing.Point(34, 127)
        UnidadLabel.Name = "UnidadLabel"
        UnidadLabel.Size = New System.Drawing.Size(49, 13)
        UnidadLabel.TabIndex = 43
        UnidadLabel.Text = "Teléfono"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.Location = New System.Drawing.Point(219, 127)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(32, 13)
        CategoriaLabel.TabIndex = 45
        CategoriaLabel.Text = "Email"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(219, 189)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(67, 13)
        Label1.TabIndex = 67
        Label1.Text = "Procedencia"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(35, 189)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(75, 13)
        Label2.TabIndex = 68
        Label2.Text = "Fecha Ingreso"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(35, 16)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(54, 13)
        Label3.TabIndex = 71
        Label3.Text = "ID Interna"
        '
        'NomTextBox
        '
        Me.NomTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomTextBox.Location = New System.Drawing.Point(237, 32)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(330, 29)
        Me.NomTextBox.TabIndex = 1
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ApellidoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(38, 87)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(528, 29)
        Me.ApellidoTextBox.TabIndex = 2
        '
        'FonoTextBox
        '
        Me.FonoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FonoTextBox.Location = New System.Drawing.Point(38, 143)
        Me.FonoTextBox.Name = "FonoTextBox"
        Me.FonoTextBox.Size = New System.Drawing.Size(178, 29)
        Me.FonoTextBox.TabIndex = 3
        '
        'MailTextBox
        '
        Me.MailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MailTextBox.Location = New System.Drawing.Point(222, 143)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(344, 29)
        Me.MailTextBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.social__1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(237, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 46)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Aceptar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fechatxt
        '
        Me.fechatxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fechatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechatxt.Location = New System.Drawing.Point(38, 205)
        Me.fechatxt.Name = "fechatxt"
        Me.fechatxt.Size = New System.Drawing.Size(178, 29)
        Me.fechatxt.TabIndex = 65
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(222, 205)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(345, 28)
        Me.ComboBox1.TabIndex = 69
        '
        'idinternabox
        '
        Me.idinternabox.BackColor = System.Drawing.Color.White
        Me.idinternabox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.idinternabox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idinternabox.Location = New System.Drawing.Point(38, 32)
        Me.idinternabox.Name = "idinternabox"
        Me.idinternabox.ReadOnly = True
        Me.idinternabox.Size = New System.Drawing.Size(64, 29)
        Me.idinternabox.TabIndex = 70
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(108, 32)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(123, 29)
        Me.IDTextBox.TabIndex = 0
        Me.IDTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'NuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(602, 355)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.idinternabox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.fechatxt)
        Me.Controls.Add(Label2)
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
        Me.Name = "NuevoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NomTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents FonoTextBox As TextBox
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents fechatxt As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents idinternabox As TextBox
    Friend WithEvents IDTextBox As MaskedTextBox
End Class
