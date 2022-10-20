<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Procedencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EditarBtn = New System.Windows.Forms.Button()
        Me.EliminarBtn = New System.Windows.Forms.Button()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(903, 92)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(118, 20)
        Me.TextBox2.TabIndex = 91
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1036, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Buscar por"
        '
        'DGVClientes
        '
        Me.DGVClientes.AllowUserToAddRows = False
        Me.DGVClientes.AllowUserToDeleteRows = False
        Me.DGVClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVClientes.BackgroundColor = System.Drawing.Color.White
        Me.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.IDCliente, Me.Nombre, Me.Apellido, Me.Email, Me.Fono, Me.FechaIngreso, Me.Procedencia, Me.Check})
        Me.DGVClientes.Location = New System.Drawing.Point(24, 145)
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.RowHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVClientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVClientes.Size = New System.Drawing.Size(1190, 247)
        Me.DGVClientes.TabIndex = 87
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'IDCliente
        '
        Me.IDCliente.HeaderText = "IDCliente"
        Me.IDCliente.Name = "IDCliente"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'Fono
        '
        Me.Fono.HeaderText = "Fono"
        Me.Fono.Name = "Fono"
        '
        'FechaIngreso
        '
        Me.FechaIngreso.HeaderText = "Fecha Ingreso"
        Me.FechaIngreso.Name = "FechaIngreso"
        '
        'Procedencia
        '
        Me.Procedencia.HeaderText = "Procedencia"
        Me.Procedencia.Name = "Procedencia"
        '
        'Check
        '
        Me.Check.HeaderText = "Check"
        Me.Check.Name = "Check"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1109, 91)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(103, 21)
        Me.ComboBox1.TabIndex = 92
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1238, 24)
        Me.MenuStrip1.TabIndex = 94
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoClienteToolStripMenuItem})
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'NuevoClienteToolStripMenuItem
        '
        Me.NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        Me.NuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NuevoClienteToolStripMenuItem.Text = "Nuevo Cliente"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.interface__4_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1109, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 39)
        Me.Button1.TabIndex = 96
        Me.Button1.Text = "Actualizar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EditarBtn
        '
        Me.EditarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.EditarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditarBtn.Image = Global.WindowsApp3.My.Resources.Resources.edit__1_
        Me.EditarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditarBtn.Location = New System.Drawing.Point(107, 55)
        Me.EditarBtn.Name = "EditarBtn"
        Me.EditarBtn.Size = New System.Drawing.Size(66, 61)
        Me.EditarBtn.TabIndex = 98
        Me.EditarBtn.Text = "Editar"
        Me.EditarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditarBtn.UseVisualStyleBackColor = True
        '
        'EliminarBtn
        '
        Me.EliminarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarBtn.Image = Global.WindowsApp3.My.Resources.Resources.interface__3_
        Me.EliminarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EliminarBtn.Location = New System.Drawing.Point(24, 55)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(66, 61)
        Me.EliminarBtn.TabIndex = 97
        Me.EliminarBtn.Text = "Eliminar"
        Me.EliminarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1238, 439)
        Me.Controls.Add(Me.EditarBtn)
        Me.Controls.Add(Me.EliminarBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGVClientes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGVClientes As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents IDCliente As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Fono As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents Procedencia As DataGridViewTextBoxColumn
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents EditarBtn As Button
    Friend WithEvents EliminarBtn As Button
End Class
