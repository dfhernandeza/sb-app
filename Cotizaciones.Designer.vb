<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cotizaciones
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cotizaciones))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionesIncompletasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AprobadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionesCompletasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescartarUnaCotizaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.filtrofecha = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.abrircotbtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.Location = New System.Drawing.Point(53, 138)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(765, 295)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoClienteToolStripMenuItem, Me.VerToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(896, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoClienteToolStripMenuItem
        '
        Me.NuevoClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CotizaciónToolStripMenuItem})
        Me.NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        Me.NuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.NuevoClienteToolStripMenuItem.Text = "Nueva"
        '
        'CotizaciónToolStripMenuItem
        '
        Me.CotizaciónToolStripMenuItem.Name = "CotizaciónToolStripMenuItem"
        Me.CotizaciónToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CotizaciónToolStripMenuItem.Text = "Cotización"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CotizacionesIncompletasToolStripMenuItem, Me.AprobadasToolStripMenuItem, Me.CotizacionesCompletasToolStripMenuItem, Me.TodasToolStripMenuItem, Me.PendienteToolStripMenuItem, Me.PreciosToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'CotizacionesIncompletasToolStripMenuItem
        '
        Me.CotizacionesIncompletasToolStripMenuItem.Name = "CotizacionesIncompletasToolStripMenuItem"
        Me.CotizacionesIncompletasToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CotizacionesIncompletasToolStripMenuItem.Text = "Abiertas"
        '
        'AprobadasToolStripMenuItem
        '
        Me.AprobadasToolStripMenuItem.Name = "AprobadasToolStripMenuItem"
        Me.AprobadasToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.AprobadasToolStripMenuItem.Text = "Aprobadas"
        '
        'CotizacionesCompletasToolStripMenuItem
        '
        Me.CotizacionesCompletasToolStripMenuItem.Name = "CotizacionesCompletasToolStripMenuItem"
        Me.CotizacionesCompletasToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CotizacionesCompletasToolStripMenuItem.Text = "Cerradas"
        '
        'TodasToolStripMenuItem
        '
        Me.TodasToolStripMenuItem.Name = "TodasToolStripMenuItem"
        Me.TodasToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.TodasToolStripMenuItem.Text = "Todas"
        '
        'PendienteToolStripMenuItem
        '
        Me.PendienteToolStripMenuItem.Name = "PendienteToolStripMenuItem"
        Me.PendienteToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PendienteToolStripMenuItem.Text = "Pendientes"
        '
        'PreciosToolStripMenuItem
        '
        Me.PreciosToolStripMenuItem.Name = "PreciosToolStripMenuItem"
        Me.PreciosToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PreciosToolStripMenuItem.Text = "Precios"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DescartarUnaCotizaciónToolStripMenuItem})
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.EliminarToolStripMenuItem.Text = "Descartar"
        '
        'DescartarUnaCotizaciónToolStripMenuItem
        '
        Me.DescartarUnaCotizaciónToolStripMenuItem.Name = "DescartarUnaCotizaciónToolStripMenuItem"
        Me.DescartarUnaCotizaciónToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.DescartarUnaCotizaciónToolStripMenuItem.Text = "Descartar una cotización"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(682, 95)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 32)
        Me.ComboBox1.TabIndex = 73
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(440, 98)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 29)
        Me.TextBox1.TabIndex = 72
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'filtrofecha
        '
        Me.filtrofecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filtrofecha.Location = New System.Drawing.Point(665, 58)
        Me.filtrofecha.Name = "filtrofecha"
        Me.filtrofecha.Size = New System.Drawing.Size(153, 20)
        Me.filtrofecha.TabIndex = 76
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.WindowsApp3.My.Resources.Resources.random
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(194, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 39)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "Cambiar estado"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'abrircotbtn
        '
        Me.abrircotbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.abrircotbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abrircotbtn.Image = Global.WindowsApp3.My.Resources.Resources.business
        Me.abrircotbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.abrircotbtn.Location = New System.Drawing.Point(53, 88)
        Me.abrircotbtn.Name = "abrircotbtn"
        Me.abrircotbtn.Size = New System.Drawing.Size(125, 39)
        Me.abrircotbtn.TabIndex = 75
        Me.abrircotbtn.Text = "Abrir Cotización"
        Me.abrircotbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.abrircotbtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Image = Global.WindowsApp3.My.Resources.Resources.eye
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(577, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 35)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Buscar por:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.interface__4_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(52, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 39)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Actualizar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(896, 542)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.filtrofecha)
        Me.Controls.Add(Me.abrircotbtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cotizaciones"
        Me.Text = "Cotizaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CotizaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CotizacionesCompletasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CotizacionesIncompletasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescartarUnaCotizaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AprobadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents abrircotbtn As Button
    Friend WithEvents filtrofecha As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents PendienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem As ToolStripMenuItem
End Class
