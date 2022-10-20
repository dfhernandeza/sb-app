<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores))
        Me.DetalleDGV = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.EditarBtn = New System.Windows.Forms.Button()
        Me.EliminarBtn = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DetalleDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DetalleDGV
        '
        Me.DetalleDGV.AllowUserToAddRows = False
        Me.DetalleDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetalleDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DetalleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Email, Me.Fono, Me.Direccion, Me.Comentarios, Me.Check})
        Me.DetalleDGV.Location = New System.Drawing.Point(30, 131)
        Me.DetalleDGV.Name = "DetalleDGV"
        Me.DetalleDGV.RowHeadersVisible = False
        Me.DetalleDGV.Size = New System.Drawing.Size(790, 301)
        Me.DetalleDGV.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.WindowsApp3.My.Resources.Resources.supplier__1_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(30, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 66)
        Me.Button2.TabIndex = 112
        Me.Button2.Text = "Nuevo Proveedor"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EditarBtn
        '
        Me.EditarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.EditarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditarBtn.Image = Global.WindowsApp3.My.Resources.Resources.edit__1_
        Me.EditarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditarBtn.Location = New System.Drawing.Point(245, 37)
        Me.EditarBtn.Name = "EditarBtn"
        Me.EditarBtn.Size = New System.Drawing.Size(66, 68)
        Me.EditarBtn.TabIndex = 114
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
        Me.EliminarBtn.Location = New System.Drawing.Point(156, 37)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(66, 68)
        Me.EliminarBtn.TabIndex = 113
        Me.EliminarBtn.Text = "Eliminar"
        Me.EliminarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'ID
        '
        DataGridViewCellStyle1.Format = "##,###,###-#"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ID.DefaultCellStyle = DataGridViewCellStyle1
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
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
        'Direccion
        '
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.Name = "Direccion"
        '
        'Comentarios
        '
        Me.Comentarios.HeaderText = "Comentarios"
        Me.Comentarios.Name = "Comentarios"
        '
        'Check
        '
        Me.Check.HeaderText = "Check"
        Me.Check.Name = "Check"
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(853, 478)
        Me.Controls.Add(Me.EditarBtn)
        Me.Controls.Add(Me.EliminarBtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DetalleDGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        CType(Me.DetalleDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DetalleDGV As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents EditarBtn As Button
    Friend WithEvents EliminarBtn As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Fono As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Comentarios As DataGridViewTextBoxColumn
    Friend WithEvents Check As DataGridViewCheckBoxColumn
End Class
