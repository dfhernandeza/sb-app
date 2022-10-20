<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Trabajos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trabajos))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnCursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirTrabajosEnCursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.filtrofecha = New System.Windows.Forms.DateTimePicker()
        Me.VerVehiculobtn = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Pagarbtn = New System.Windows.Forms.Button()
        Me.abrircotbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EditarMecanicoBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
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
        Me.DataGridView1.Location = New System.Drawing.Point(41, 140)
        Me.DataGridView1.MultiSelect = False
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
        Me.DataGridView1.Size = New System.Drawing.Size(1293, 254)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VistaToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 41
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VistaToolStripMenuItem
        '
        Me.VistaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodosToolStripMenuItem, Me.EnCursoToolStripMenuItem, Me.TerminadosToolStripMenuItem})
        Me.VistaToolStripMenuItem.Name = "VistaToolStripMenuItem"
        Me.VistaToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.VistaToolStripMenuItem.Text = "Vista"
        '
        'TodosToolStripMenuItem
        '
        Me.TodosToolStripMenuItem.Name = "TodosToolStripMenuItem"
        Me.TodosToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.TodosToolStripMenuItem.Text = "Todos"
        '
        'EnCursoToolStripMenuItem
        '
        Me.EnCursoToolStripMenuItem.Name = "EnCursoToolStripMenuItem"
        Me.EnCursoToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.EnCursoToolStripMenuItem.Text = "En curso"
        '
        'TerminadosToolStripMenuItem
        '
        Me.TerminadosToolStripMenuItem.Name = "TerminadosToolStripMenuItem"
        Me.TerminadosToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.TerminadosToolStripMenuItem.Text = "Terminados"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirTrabajosEnCursoToolStripMenuItem})
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ImprimirTrabajosEnCursoToolStripMenuItem
        '
        Me.ImprimirTrabajosEnCursoToolStripMenuItem.Name = "ImprimirTrabajosEnCursoToolStripMenuItem"
        Me.ImprimirTrabajosEnCursoToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ImprimirTrabajosEnCursoToolStripMenuItem.Text = "Imprimir Trabajos en Curso"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1236, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Buscar por"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1199, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(135, 28)
        Me.ComboBox1.TabIndex = 45
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1029, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 29)
        Me.TextBox1.TabIndex = 44
        '
        'filtrofecha
        '
        Me.filtrofecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filtrofecha.Location = New System.Drawing.Point(1184, 41)
        Me.filtrofecha.Name = "filtrofecha"
        Me.filtrofecha.Size = New System.Drawing.Size(153, 20)
        Me.filtrofecha.TabIndex = 52
        '
        'VerVehiculobtn
        '
        Me.VerVehiculobtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.VerVehiculobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerVehiculobtn.Image = Global.WindowsApp3.My.Resources.Resources.transportation
        Me.VerVehiculobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VerVehiculobtn.Location = New System.Drawing.Point(487, 94)
        Me.VerVehiculobtn.Name = "VerVehiculobtn"
        Me.VerVehiculobtn.Size = New System.Drawing.Size(118, 39)
        Me.VerVehiculobtn.TabIndex = 81
        Me.VerVehiculobtn.Text = "Ver Vehículo"
        Me.VerVehiculobtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VerVehiculobtn.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.WindowsApp3.My.Resources.Resources.clock
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(487, 50)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(108, 39)
        Me.Button6.TabIndex = 80
        Me.Button6.Text = "Programa"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.WindowsApp3.My.Resources.Resources.edit__1_
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(324, 94)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(155, 39)
        Me.Button5.TabIndex = 79
        Me.Button5.Text = "Añadir Observaciones"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.WindowsApp3.My.Resources.Resources.random
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(324, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 39)
        Me.Button4.TabIndex = 78
        Me.Button4.Text = "Cambiar estado"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.WindowsApp3.My.Resources.Resources.social__1_
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(194, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 39)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "Ver Cliente"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.WindowsApp3.My.Resources.Resources.interface__2_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(194, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 39)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Imprimir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Pagarbtn
        '
        Me.Pagarbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Pagarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pagarbtn.Image = Global.WindowsApp3.My.Resources.Resources.business__2_
        Me.Pagarbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Pagarbtn.Location = New System.Drawing.Point(41, 95)
        Me.Pagarbtn.Name = "Pagarbtn"
        Me.Pagarbtn.Size = New System.Drawing.Size(96, 39)
        Me.Pagarbtn.TabIndex = 50
        Me.Pagarbtn.Text = "Pagar"
        Me.Pagarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Pagarbtn.UseVisualStyleBackColor = True
        '
        'abrircotbtn
        '
        Me.abrircotbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.abrircotbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abrircotbtn.Image = Global.WindowsApp3.My.Resources.Resources.business
        Me.abrircotbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.abrircotbtn.Location = New System.Drawing.Point(41, 50)
        Me.abrircotbtn.Name = "abrircotbtn"
        Me.abrircotbtn.Size = New System.Drawing.Size(125, 39)
        Me.abrircotbtn.TabIndex = 49
        Me.abrircotbtn.Text = "Abrir Cotización"
        Me.abrircotbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.abrircotbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.interface__4_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(41, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 39)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Actualizar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EditarMecanicoBtn
        '
        Me.EditarMecanicoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.EditarMecanicoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditarMecanicoBtn.Image = Global.WindowsApp3.My.Resources.Resources.electronics__1_
        Me.EditarMecanicoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditarMecanicoBtn.Location = New System.Drawing.Point(611, 94)
        Me.EditarMecanicoBtn.Name = "EditarMecanicoBtn"
        Me.EditarMecanicoBtn.Size = New System.Drawing.Size(148, 39)
        Me.EditarMecanicoBtn.TabIndex = 82
        Me.EditarMecanicoBtn.Text = "Actualizar Mecánico"
        Me.EditarMecanicoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditarMecanicoBtn.UseVisualStyleBackColor = True
        '
        'Trabajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 450)
        Me.Controls.Add(Me.EditarMecanicoBtn)
        Me.Controls.Add(Me.VerVehiculobtn)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.filtrofecha)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Pagarbtn)
        Me.Controls.Add(Me.abrircotbtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Trabajos"
        Me.Text = "Trabajos en Curso"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VistaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnCursoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TerminadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents abrircotbtn As Button
    Friend WithEvents Pagarbtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents filtrofecha As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirTrabajosEnCursoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents VerVehiculobtn As Button
    Friend WithEvents EditarMecanicoBtn As Button
End Class
