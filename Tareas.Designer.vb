<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tareas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tareas))
        Me.DGVTareas = New System.Windows.Forms.DataGridView()
        Me.IDRecurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.I = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoEdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoArrastreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservarElevadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.amfmbox = New System.Windows.Forms.ComboBox()
        Me.elevadorbox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Limpiarbtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DGVTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVTareas
        '
        Me.DGVTareas.AllowDrop = True
        Me.DGVTareas.AllowUserToAddRows = False
        Me.DGVTareas.AllowUserToDeleteRows = False
        Me.DGVTareas.AllowUserToResizeColumns = False
        Me.DGVTareas.AllowUserToResizeRows = False
        Me.DGVTareas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTareas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTareas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDRecurso, Me.I, Me.A, Me.B, Me.C, Me.D, Me.E, Me.F, Me.G, Me.H})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVTareas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVTareas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DGVTareas.EnableHeadersVisualStyles = False
        Me.DGVTareas.GridColor = System.Drawing.Color.Black
        Me.DGVTareas.Location = New System.Drawing.Point(38, 117)
        Me.DGVTareas.MultiSelect = False
        Me.DGVTareas.Name = "DGVTareas"
        Me.DGVTareas.ReadOnly = True
        Me.DGVTareas.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTareas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVTareas.RowTemplate.Height = 100
        Me.DGVTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGVTareas.Size = New System.Drawing.Size(883, 548)
        Me.DGVTareas.TabIndex = 0
        '
        'IDRecurso
        '
        Me.IDRecurso.HeaderText = "IDRecurso"
        Me.IDRecurso.Name = "IDRecurso"
        Me.IDRecurso.ReadOnly = True
        Me.IDRecurso.Visible = False
        '
        'I
        '
        Me.I.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.I.HeaderText = " "
        Me.I.Name = "I"
        Me.I.ReadOnly = True
        Me.I.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.I.Width = 17
        '
        'A
        '
        Me.A.HeaderText = "09:00-10:00"
        Me.A.Name = "A"
        Me.A.ReadOnly = True
        Me.A.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.A.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'B
        '
        Me.B.HeaderText = "10:00-11:00"
        Me.B.Name = "B"
        Me.B.ReadOnly = True
        Me.B.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.B.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'C
        '
        Me.C.HeaderText = "11:00-12:00"
        Me.C.Name = "C"
        Me.C.ReadOnly = True
        Me.C.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.C.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'D
        '
        Me.D.HeaderText = "12:00-13:00"
        Me.D.Name = "D"
        Me.D.ReadOnly = True
        Me.D.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.D.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'E
        '
        Me.E.HeaderText = "14:00-15:00"
        Me.E.Name = "E"
        Me.E.ReadOnly = True
        Me.E.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.E.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'F
        '
        Me.F.HeaderText = "15:00-16:00"
        Me.F.Name = "F"
        Me.F.ReadOnly = True
        Me.F.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.F.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'G
        '
        Me.G.HeaderText = "16:00-17:00"
        Me.G.Name = "G"
        Me.G.ReadOnly = True
        Me.G.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.G.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'H
        '
        Me.H.HeaderText = "17:00-18:00"
        Me.H.Name = "H"
        Me.H.ReadOnly = True
        Me.H.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.H.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(264, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.VistaToolStripMenuItem, Me.ModoArrastreToolStripMenuItem, Me.RecursosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(958, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramadorToolStripMenuItem})
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'ProgramadorToolStripMenuItem
        '
        Me.ProgramadorToolStripMenuItem.Name = "ProgramadorToolStripMenuItem"
        Me.ProgramadorToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ProgramadorToolStripMenuItem.Text = "Programador"
        '
        'VistaToolStripMenuItem
        '
        Me.VistaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinToolStripMenuItem, Me.MinToolStripMenuItem1, Me.ModoEdiciónToolStripMenuItem})
        Me.VistaToolStripMenuItem.Name = "VistaToolStripMenuItem"
        Me.VistaToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.VistaToolStripMenuItem.Text = "Vista"
        '
        'MinToolStripMenuItem
        '
        Me.MinToolStripMenuItem.Name = "MinToolStripMenuItem"
        Me.MinToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.MinToolStripMenuItem.Text = "30 min"
        '
        'MinToolStripMenuItem1
        '
        Me.MinToolStripMenuItem1.Name = "MinToolStripMenuItem1"
        Me.MinToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.MinToolStripMenuItem1.Text = "60 min"
        '
        'ModoEdiciónToolStripMenuItem
        '
        Me.ModoEdiciónToolStripMenuItem.Name = "ModoEdiciónToolStripMenuItem"
        Me.ModoEdiciónToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ModoEdiciónToolStripMenuItem.Text = "Activar Modo Edición"
        '
        'ModoArrastreToolStripMenuItem
        '
        Me.ModoArrastreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.MoverToolStripMenuItem})
        Me.ModoArrastreToolStripMenuItem.Name = "ModoArrastreToolStripMenuItem"
        Me.ModoArrastreToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ModoArrastreToolStripMenuItem.Text = "Modo Arrastre"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'MoverToolStripMenuItem
        '
        Me.MoverToolStripMenuItem.Name = "MoverToolStripMenuItem"
        Me.MoverToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.MoverToolStripMenuItem.Text = "Mover"
        '
        'RecursosToolStripMenuItem
        '
        Me.RecursosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirToolStripMenuItem, Me.ReservarElevadorToolStripMenuItem})
        Me.RecursosToolStripMenuItem.Name = "RecursosToolStripMenuItem"
        Me.RecursosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.RecursosToolStripMenuItem.Text = "Recursos"
        '
        'AñadirToolStripMenuItem
        '
        Me.AñadirToolStripMenuItem.Name = "AñadirToolStripMenuItem"
        Me.AñadirToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AñadirToolStripMenuItem.Text = "Añadir"
        '
        'ReservarElevadorToolStripMenuItem
        '
        Me.ReservarElevadorToolStripMenuItem.Name = "ReservarElevadorToolStripMenuItem"
        Me.ReservarElevadorToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ReservarElevadorToolStripMenuItem.Text = "Reservar Elevador"
        '
        'amfmbox
        '
        Me.amfmbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.amfmbox.ForeColor = System.Drawing.Color.Black
        Me.amfmbox.FormattingEnabled = True
        Me.amfmbox.Items.AddRange(New Object() {"Mañana", "Tarde"})
        Me.amfmbox.Location = New System.Drawing.Point(793, 80)
        Me.amfmbox.Name = "amfmbox"
        Me.amfmbox.Size = New System.Drawing.Size(150, 21)
        Me.amfmbox.TabIndex = 5
        Me.amfmbox.Visible = False
        '
        'elevadorbox
        '
        Me.elevadorbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.elevadorbox.ForeColor = System.Drawing.Color.Black
        Me.elevadorbox.FormattingEnabled = True
        Me.elevadorbox.Location = New System.Drawing.Point(793, 53)
        Me.elevadorbox.Name = "elevadorbox"
        Me.elevadorbox.Size = New System.Drawing.Size(150, 21)
        Me.elevadorbox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(894, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Elevador"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.WindowsApp3.My.Resources.Resources.back2
        Me.Button2.Location = New System.Drawing.Point(69, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 42)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AllowDrop = True
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.next1
        Me.Button1.Location = New System.Drawing.Point(710, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Limpiarbtn
        '
        Me.Limpiarbtn.Location = New System.Drawing.Point(41, 680)
        Me.Limpiarbtn.Name = "Limpiarbtn"
        Me.Limpiarbtn.Size = New System.Drawing.Size(86, 22)
        Me.Limpiarbtn.TabIndex = 8
        Me.Limpiarbtn.Text = "Limpiar"
        Me.Limpiarbtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AllowDrop = True
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(927, 119)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 546)
        Me.Button3.TabIndex = 9
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AllowDrop = True
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(5, 119)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 546)
        Me.Button4.TabIndex = 10
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Tareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(958, 723)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Limpiarbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.elevadorbox)
        Me.Controls.Add(Me.amfmbox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVTareas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Tareas"
        Me.Text = "Tareas"
        CType(Me.DGVTareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVTareas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VistaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents amfmbox As ComboBox
    Friend WithEvents elevadorbox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ModoEdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModoArrastreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Limpiarbtn As Button
    Friend WithEvents IDRecurso As DataGridViewTextBoxColumn
    Friend WithEvents I As DataGridViewTextBoxColumn
    Friend WithEvents A As DataGridViewTextBoxColumn
    Friend WithEvents B As DataGridViewTextBoxColumn
    Friend WithEvents C As DataGridViewTextBoxColumn
    Friend WithEvents D As DataGridViewTextBoxColumn
    Friend WithEvents E As DataGridViewTextBoxColumn
    Friend WithEvents F As DataGridViewTextBoxColumn
    Friend WithEvents G As DataGridViewTextBoxColumn
    Friend WithEvents H As DataGridViewTextBoxColumn
    Friend WithEvents ReservarElevadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
