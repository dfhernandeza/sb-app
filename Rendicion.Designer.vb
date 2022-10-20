<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rendicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rendicion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Persona = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Traspaso = New System.Windows.Forms.ComboBox()
        Me.montototalbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalrendidobox = New System.Windows.Forms.TextBox()
        Me.DetalleDGV = New System.Windows.Forms.DataGridView()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NuevoItemBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.diferenciabox = New System.Windows.Forms.TextBox()
        Me.aceptarbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.origenbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DetalleDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Solicitante"
        '
        'Persona
        '
        Me.Persona.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Persona.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona.FormattingEnabled = True
        Me.Persona.Location = New System.Drawing.Point(22, 50)
        Me.Persona.Name = "Persona"
        Me.Persona.Size = New System.Drawing.Size(570, 39)
        Me.Persona.TabIndex = 2
        Me.Persona.Text = "-Seleccionar-"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(609, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Traspaso"
        '
        'Traspaso
        '
        Me.Traspaso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Traspaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Traspaso.FormattingEnabled = True
        Me.Traspaso.Location = New System.Drawing.Point(612, 50)
        Me.Traspaso.Name = "Traspaso"
        Me.Traspaso.Size = New System.Drawing.Size(569, 39)
        Me.Traspaso.TabIndex = 4
        Me.Traspaso.Text = "-Seleccionar-"
        '
        'montototalbox
        '
        Me.montototalbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.montototalbox.Location = New System.Drawing.Point(612, 119)
        Me.montototalbox.Name = "montototalbox"
        Me.montototalbox.Size = New System.Drawing.Size(569, 44)
        Me.montototalbox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(609, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total entregado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(612, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total rendido"
        '
        'totalrendidobox
        '
        Me.totalrendidobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalrendidobox.Location = New System.Drawing.Point(615, 233)
        Me.totalrendidobox.Name = "totalrendidobox"
        Me.totalrendidobox.Size = New System.Drawing.Size(159, 44)
        Me.totalrendidobox.TabIndex = 8
        '
        'DetalleDGV
        '
        Me.DetalleDGV.AllowUserToAddRows = False
        Me.DetalleDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DetalleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Documento, Me.IDItem, Me.Item, Me.Cantidad, Me.Precio, Me.OT, Me.Total, Me.Categoria, Me.Proveedor})
        Me.DetalleDGV.Location = New System.Drawing.Point(22, 305)
        Me.DetalleDGV.Name = "DetalleDGV"
        Me.DetalleDGV.RowHeadersVisible = False
        Me.DetalleDGV.Size = New System.Drawing.Size(1159, 273)
        Me.DetalleDGV.TabIndex = 10
        '
        'Documento
        '
        Me.Documento.HeaderText = "Documento"
        Me.Documento.Name = "Documento"
        '
        'IDItem
        '
        Me.IDItem.HeaderText = "ID Item"
        Me.IDItem.Name = "IDItem"
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
        'OT
        '
        Me.OT.HeaderText = "OT"
        Me.OT.Name = "OT"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoría"
        Me.Categoria.Name = "Categoria"
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        '
        'NuevoItemBtn
        '
        Me.NuevoItemBtn.BackColor = System.Drawing.Color.Transparent
        Me.NuevoItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.NuevoItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NuevoItemBtn.Image = Global.WindowsApp3.My.Resources.Resources.button
        Me.NuevoItemBtn.Location = New System.Drawing.Point(22, 233)
        Me.NuevoItemBtn.Name = "NuevoItemBtn"
        Me.NuevoItemBtn.Size = New System.Drawing.Size(92, 49)
        Me.NuevoItemBtn.TabIndex = 11
        Me.NuevoItemBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(797, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Diferencia"
        '
        'diferenciabox
        '
        Me.diferenciabox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diferenciabox.Location = New System.Drawing.Point(800, 233)
        Me.diferenciabox.Name = "diferenciabox"
        Me.diferenciabox.Size = New System.Drawing.Size(159, 44)
        Me.diferenciabox.TabIndex = 12
        '
        'aceptarbtn
        '
        Me.aceptarbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.aceptarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarbtn.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.aceptarbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.aceptarbtn.Location = New System.Drawing.Point(986, 188)
        Me.aceptarbtn.Name = "aceptarbtn"
        Me.aceptarbtn.Size = New System.Drawing.Size(118, 94)
        Me.aceptarbtn.TabIndex = 14
        Me.aceptarbtn.Text = "Ingresar"
        Me.aceptarbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.aceptarbtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Origen"
        '
        'origenbox
        '
        Me.origenbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.origenbox.Location = New System.Drawing.Point(22, 119)
        Me.origenbox.Name = "origenbox"
        Me.origenbox.Size = New System.Drawing.Size(570, 44)
        Me.origenbox.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.enter
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(1110, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 83)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Devolución Completa"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Rendicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1233, 617)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.origenbox)
        Me.Controls.Add(Me.aceptarbtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.diferenciabox)
        Me.Controls.Add(Me.NuevoItemBtn)
        Me.Controls.Add(Me.DetalleDGV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.totalrendidobox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.montototalbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Traspaso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Persona)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rendicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rendicion"
        CType(Me.DetalleDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Persona As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Traspaso As ComboBox
    Friend WithEvents montototalbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents totalrendidobox As TextBox
    Friend WithEvents DetalleDGV As DataGridView
    Friend WithEvents NuevoItemBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents diferenciabox As TextBox
    Friend WithEvents aceptarbtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents origenbox As TextBox
    Friend WithEvents Documento As DataGridViewTextBoxColumn
    Friend WithEvents IDItem As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents OT As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
