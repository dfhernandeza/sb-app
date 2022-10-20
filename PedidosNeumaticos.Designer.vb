<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosNeumaticos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidosNeumaticos))
        Me.DGVDetalle = New System.Windows.Forms.DataGridView()
        Me.ManualBtn = New System.Windows.Forms.Button()
        Me.NuevoPedidoBtn = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ancho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Radio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Velocidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInstalacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVDetalle
        '
        Me.DGVDetalle.AllowUserToAddRows = False
        Me.DGVDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Cliente, Me.Ancho, Me.Perfil, Me.Radio, Me.Carga, Me.Velocidad, Me.Cantidad, Me.Precio, Me.Estado, Me.FechaRecepcion, Me.FechaInstalacion, Me.Detalles, Me.Chk})
        Me.DGVDetalle.Location = New System.Drawing.Point(23, 105)
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.RowHeadersVisible = False
        Me.DGVDetalle.Size = New System.Drawing.Size(1238, 292)
        Me.DGVDetalle.TabIndex = 0
        '
        'ManualBtn
        '
        Me.ManualBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ManualBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManualBtn.Image = Global.WindowsApp3.My.Resources.Resources.calendar
        Me.ManualBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ManualBtn.Location = New System.Drawing.Point(131, 25)
        Me.ManualBtn.Name = "ManualBtn"
        Me.ManualBtn.Size = New System.Drawing.Size(102, 62)
        Me.ManualBtn.TabIndex = 40
        Me.ManualBtn.Text = "Editar"
        Me.ManualBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ManualBtn.UseVisualStyleBackColor = True
        '
        'NuevoPedidoBtn
        '
        Me.NuevoPedidoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.NuevoPedidoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NuevoPedidoBtn.Image = Global.WindowsApp3.My.Resources.Resources.electronics
        Me.NuevoPedidoBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NuevoPedidoBtn.Location = New System.Drawing.Point(23, 25)
        Me.NuevoPedidoBtn.Name = "NuevoPedidoBtn"
        Me.NuevoPedidoBtn.Size = New System.Drawing.Size(102, 62)
        Me.NuevoPedidoBtn.TabIndex = 41
        Me.NuevoPedidoBtn.Text = "Nuevo Pedido"
        Me.NuevoPedidoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NuevoPedidoBtn.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.HeaderText = "N°"
        Me.ID.Name = "ID"
        Me.ID.Width = 25
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Width = 200
        '
        'Ancho
        '
        Me.Ancho.HeaderText = "Ancho"
        Me.Ancho.Name = "Ancho"
        Me.Ancho.Width = 45
        '
        'Perfil
        '
        Me.Perfil.HeaderText = "Perfil"
        Me.Perfil.Name = "Perfil"
        Me.Perfil.Width = 45
        '
        'Radio
        '
        Me.Radio.HeaderText = "Radio"
        Me.Radio.Name = "Radio"
        Me.Radio.Width = 45
        '
        'Carga
        '
        Me.Carga.HeaderText = "Carga"
        Me.Carga.Name = "Carga"
        Me.Carga.Width = 45
        '
        'Velocidad
        '
        Me.Velocidad.HeaderText = "Velocidad"
        Me.Velocidad.Name = "Velocidad"
        Me.Velocidad.Width = 65
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 65
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 65
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.Width = 75
        '
        'FechaRecepcion
        '
        Me.FechaRecepcion.HeaderText = "Recepción"
        Me.FechaRecepcion.Name = "FechaRecepcion"
        Me.FechaRecepcion.Width = 115
        '
        'FechaInstalacion
        '
        Me.FechaInstalacion.HeaderText = "Instalación"
        Me.FechaInstalacion.Name = "FechaInstalacion"
        Me.FechaInstalacion.Width = 115
        '
        'Detalles
        '
        Me.Detalles.HeaderText = "Detalles"
        Me.Detalles.Name = "Detalles"
        Me.Detalles.Width = 212
        '
        'Chk
        '
        Me.Chk.HeaderText = ""
        Me.Chk.Name = "Chk"
        Me.Chk.Width = 40
        '
        'PedidosNeumaticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1262, 450)
        Me.Controls.Add(Me.NuevoPedidoBtn)
        Me.Controls.Add(Me.ManualBtn)
        Me.Controls.Add(Me.DGVDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PedidosNeumaticos"
        Me.Text = "PedidosNeumaticos"
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVDetalle As DataGridView
    Friend WithEvents ManualBtn As Button
    Friend WithEvents NuevoPedidoBtn As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Ancho As DataGridViewTextBoxColumn
    Friend WithEvents Perfil As DataGridViewTextBoxColumn
    Friend WithEvents Radio As DataGridViewTextBoxColumn
    Friend WithEvents Carga As DataGridViewTextBoxColumn
    Friend WithEvents Velocidad As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents FechaRecepcion As DataGridViewTextBoxColumn
    Friend WithEvents FechaInstalacion As DataGridViewTextBoxColumn
    Friend WithEvents Detalles As DataGridViewTextBoxColumn
    Friend WithEvents Chk As DataGridViewCheckBoxColumn
End Class
