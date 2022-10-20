<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoItemRendicion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoItemRendicion))
        Me.documentobox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.itembox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cantidadbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.preciobox = New System.Windows.Forms.TextBox()
        Me.otcombobox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.aceptarbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IDItembox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.proveedorcbox = New System.Windows.Forms.ComboBox()
        Me.Categoriacbox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'documentobox
        '
        Me.documentobox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.documentobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.documentobox.Location = New System.Drawing.Point(33, 56)
        Me.documentobox.Name = "documentobox"
        Me.documentobox.Size = New System.Drawing.Size(387, 38)
        Me.documentobox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Item"
        '
        'itembox
        '
        Me.itembox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.itembox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itembox.Location = New System.Drawing.Point(231, 118)
        Me.itembox.Name = "itembox"
        Me.itembox.Size = New System.Drawing.Size(262, 38)
        Me.itembox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad"
        '
        'cantidadbox
        '
        Me.cantidadbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cantidadbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidadbox.Location = New System.Drawing.Point(36, 180)
        Me.cantidadbox.Name = "cantidadbox"
        Me.cantidadbox.Size = New System.Drawing.Size(189, 38)
        Me.cantidadbox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Precio"
        '
        'preciobox
        '
        Me.preciobox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.preciobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preciobox.Location = New System.Drawing.Point(231, 180)
        Me.preciobox.Name = "preciobox"
        Me.preciobox.Size = New System.Drawing.Size(262, 38)
        Me.preciobox.TabIndex = 6
        '
        'otcombobox
        '
        Me.otcombobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otcombobox.FormattingEnabled = True
        Me.otcombobox.Location = New System.Drawing.Point(499, 179)
        Me.otcombobox.Name = "otcombobox"
        Me.otcombobox.Size = New System.Drawing.Size(465, 39)
        Me.otcombobox.TabIndex = 7
        Me.otcombobox.Text = "-Seleccionar-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(496, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "OT"
        '
        'aceptarbtn
        '
        Me.aceptarbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.aceptarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarbtn.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.aceptarbtn.Location = New System.Drawing.Point(812, 264)
        Me.aceptarbtn.Name = "aceptarbtn"
        Me.aceptarbtn.Size = New System.Drawing.Size(152, 74)
        Me.aceptarbtn.TabIndex = 8
        Me.aceptarbtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ID Item"
        '
        'IDItembox
        '
        Me.IDItembox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDItembox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDItembox.Location = New System.Drawing.Point(33, 118)
        Me.IDItembox.Name = "IDItembox"
        Me.IDItembox.Size = New System.Drawing.Size(192, 38)
        Me.IDItembox.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(423, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Proveedor"
        '
        'proveedorcbox
        '
        Me.proveedorcbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proveedorcbox.FormattingEnabled = True
        Me.proveedorcbox.IntegralHeight = False
        Me.proveedorcbox.Location = New System.Drawing.Point(426, 55)
        Me.proveedorcbox.Name = "proveedorcbox"
        Me.proveedorcbox.Size = New System.Drawing.Size(538, 39)
        Me.proveedorcbox.TabIndex = 1
        '
        'Categoriacbox
        '
        Me.Categoriacbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categoriacbox.FormattingEnabled = True
        Me.Categoriacbox.IntegralHeight = False
        Me.Categoriacbox.Items.AddRange(New Object() {"REPUESTOS", "PUBLICIDAD", "SERVICIOS BÁSICOS", "SERVICIOS EXTERNOS", " LUBRICANTES", "FILTROS DE ACEITE", "FILTROS DE COMBUSTIBLE", "FILTROS DE AIRE", "PERSONAL", "OTROS"})
        Me.Categoriacbox.Location = New System.Drawing.Point(499, 118)
        Me.Categoriacbox.Name = "Categoriacbox"
        Me.Categoriacbox.Size = New System.Drawing.Size(465, 39)
        Me.Categoriacbox.TabIndex = 4
        Me.Categoriacbox.Text = "-Seleccionar-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(496, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Categoría"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.WindowsApp3.My.Resources.Resources.supplier__1_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(36, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 62)
        Me.Button2.TabIndex = 111
        Me.Button2.Text = "Nuevo Proveedor"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NuevoItemRendicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 375)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Categoriacbox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.proveedorcbox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.IDItembox)
        Me.Controls.Add(Me.aceptarbtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.otcombobox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.preciobox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cantidadbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.itembox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.documentobox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoItemRendicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NuevoItemRendicion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents documentobox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents itembox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cantidadbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents preciobox As TextBox
    Friend WithEvents otcombobox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents aceptarbtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents IDItembox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents proveedorcbox As ComboBox
    Friend WithEvents Categoriacbox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
