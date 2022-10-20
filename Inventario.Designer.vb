<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarStoclToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventariarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.abrircotbtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.Location = New System.Drawing.Point(49, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(1144, 396)
        Me.DataGridView1.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(49, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 29)
        Me.TextBox1.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(343, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 32)
        Me.ComboBox1.TabIndex = 23
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemsToolStripMenuItem, Me.StockToolStripMenuItem, Me.VerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1245, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoItemToolStripMenuItem, Me.BorrarItemToolStripMenuItem})
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'NuevoItemToolStripMenuItem
        '
        Me.NuevoItemToolStripMenuItem.Name = "NuevoItemToolStripMenuItem"
        Me.NuevoItemToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.NuevoItemToolStripMenuItem.Text = "Nuevo Item"
        '
        'BorrarItemToolStripMenuItem
        '
        Me.BorrarItemToolStripMenuItem.Name = "BorrarItemToolStripMenuItem"
        Me.BorrarItemToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.BorrarItemToolStripMenuItem.Text = "Borrar Item"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarStoclToolStripMenuItem, Me.InventariarToolStripMenuItem})
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'ActualizarStoclToolStripMenuItem
        '
        Me.ActualizarStoclToolStripMenuItem.Name = "ActualizarStoclToolStripMenuItem"
        Me.ActualizarStoclToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ActualizarStoclToolStripMenuItem.Text = "Actualizar Stock"
        '
        'InventariarToolStripMenuItem
        '
        Me.InventariarToolStripMenuItem.Name = "InventariarToolStripMenuItem"
        Me.InventariarToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.InventariarToolStripMenuItem.Text = "Inventariar"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(340, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Buscar por"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.interface__4_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1088, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 39)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Actualizar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'abrircotbtn
        '
        Me.abrircotbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.abrircotbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abrircotbtn.Image = Global.WindowsApp3.My.Resources.Resources.business
        Me.abrircotbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.abrircotbtn.Location = New System.Drawing.Point(545, 54)
        Me.abrircotbtn.Name = "abrircotbtn"
        Me.abrircotbtn.Size = New System.Drawing.Size(106, 39)
        Me.abrircotbtn.TabIndex = 76
        Me.abrircotbtn.Text = "Editar Item"
        Me.abrircotbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.abrircotbtn.UseVisualStyleBackColor = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1245, 558)
        Me.Controls.Add(Me.abrircotbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inventario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarStoclToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents InventariarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents abrircotbtn As Button
End Class
