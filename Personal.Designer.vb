<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personalform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Personalform))
        Me.DGVPersonal = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarBtn = New System.Windows.Forms.Button()
        Me.EditarBtn = New System.Windows.Forms.Button()
        Me.VerEmpleado = New System.Windows.Forms.Button()
        CType(Me.DGVPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVPersonal
        '
        Me.DGVPersonal.AllowUserToAddRows = False
        Me.DGVPersonal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPersonal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Apellido, Me.Especialidad, Me.Check})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPersonal.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPersonal.Location = New System.Drawing.Point(48, 107)
        Me.DGVPersonal.Name = "DGVPersonal"
        Me.DGVPersonal.RowHeadersVisible = False
        Me.DGVPersonal.Size = New System.Drawing.Size(699, 284)
        Me.DGVPersonal.TabIndex = 0
        '
        'ID
        '
        Me.ID.FillWeight = 76.14214!
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Nombre
        '
        Me.Nombre.FillWeight = 76.49915!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.FillWeight = 76.49915!
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'Especialidad
        '
        Me.Especialidad.FillWeight = 215.8901!
        Me.Especialidad.HeaderText = "Especialidad"
        Me.Especialidad.Name = "Especialidad"
        '
        'Check
        '
        Me.Check.FillWeight = 54.96946!
        Me.Check.HeaderText = "Check"
        Me.Check.Name = "Check"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem})
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'EliminarBtn
        '
        Me.EliminarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarBtn.Image = Global.WindowsApp3.My.Resources.Resources.interface__3_
        Me.EliminarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EliminarBtn.Location = New System.Drawing.Point(48, 38)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(66, 63)
        Me.EliminarBtn.TabIndex = 2
        Me.EliminarBtn.Text = "Eliminar"
        Me.EliminarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'EditarBtn
        '
        Me.EditarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.EditarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditarBtn.Image = Global.WindowsApp3.My.Resources.Resources.edit__1_
        Me.EditarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditarBtn.Location = New System.Drawing.Point(120, 38)
        Me.EditarBtn.Name = "EditarBtn"
        Me.EditarBtn.Size = New System.Drawing.Size(66, 63)
        Me.EditarBtn.TabIndex = 3
        Me.EditarBtn.Text = "Editar"
        Me.EditarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditarBtn.UseVisualStyleBackColor = True
        '
        'VerEmpleado
        '
        Me.VerEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.VerEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerEmpleado.Image = Global.WindowsApp3.My.Resources.Resources.social__1_
        Me.VerEmpleado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.VerEmpleado.Location = New System.Drawing.Point(192, 38)
        Me.VerEmpleado.Name = "VerEmpleado"
        Me.VerEmpleado.Size = New System.Drawing.Size(66, 63)
        Me.VerEmpleado.TabIndex = 4
        Me.VerEmpleado.Text = "Detalles"
        Me.VerEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.VerEmpleado.UseVisualStyleBackColor = True
        '
        'Personalform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.VerEmpleado)
        Me.Controls.Add(Me.EditarBtn)
        Me.Controls.Add(Me.EliminarBtn)
        Me.Controls.Add(Me.DGVPersonal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Personalform"
        Me.Text = "Personal"
        CType(Me.DGVPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVPersonal As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Especialidad As DataGridViewTextBoxColumn
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarBtn As Button
    Friend WithEvents EditarBtn As Button
    Friend WithEvents VerEmpleado As Button
End Class
