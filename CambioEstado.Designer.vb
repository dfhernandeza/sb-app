<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioEstado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambioEstado))
        Me.EstadoActualBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NuevoEstadoBox = New System.Windows.Forms.ComboBox()
        Me.IngresarBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Recepcionfecha = New System.Windows.Forms.DateTimePicker()
        Me.recepcionhora = New System.Windows.Forms.DateTimePicker()
        Me.HoraInstalacion = New System.Windows.Forms.DateTimePicker()
        Me.FechaInstalacion = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrecioActualBox = New System.Windows.Forms.TextBox()
        Me.NuevoPrecioBox = New System.Windows.Forms.TextBox()
        Me.ActualizarFechaRecepcion = New System.Windows.Forms.Button()
        Me.ActualizarFechaInstalacion = New System.Windows.Forms.Button()
        Me.ActualizarPrecioBtn = New System.Windows.Forms.Button()
        Me.ActualizarCantidadBtn = New System.Windows.Forms.Button()
        Me.NuevaCantidadBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CantidadActualBox = New System.Windows.Forms.TextBox()
        Me.DetallesBox = New System.Windows.Forms.TextBox()
        Me.ActualizarDetallesBtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'EstadoActualBox
        '
        Me.EstadoActualBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoActualBox.Location = New System.Drawing.Point(22, 46)
        Me.EstadoActualBox.Name = "EstadoActualBox"
        Me.EstadoActualBox.Size = New System.Drawing.Size(167, 29)
        Me.EstadoActualBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Estado Actual"
        '
        'NuevoEstadoBox
        '
        Me.NuevoEstadoBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoEstadoBox.FormattingEnabled = True
        Me.NuevoEstadoBox.Location = New System.Drawing.Point(195, 46)
        Me.NuevoEstadoBox.Name = "NuevoEstadoBox"
        Me.NuevoEstadoBox.Size = New System.Drawing.Size(193, 28)
        Me.NuevoEstadoBox.TabIndex = 2
        '
        'IngresarBtn
        '
        Me.IngresarBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IngresarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.IngresarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IngresarBtn.Image = Global.WindowsApp3.My.Resources.Resources.electronics
        Me.IngresarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngresarBtn.Location = New System.Drawing.Point(407, 44)
        Me.IngresarBtn.Name = "IngresarBtn"
        Me.IngresarBtn.Size = New System.Drawing.Size(101, 30)
        Me.IngresarBtn.TabIndex = 42
        Me.IngresarBtn.Text = "Actualizar"
        Me.IngresarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IngresarBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Nuevo Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Fecha Recepción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Fecha Instalación"
        '
        'Recepcionfecha
        '
        Me.Recepcionfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recepcionfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Recepcionfecha.Location = New System.Drawing.Point(22, 100)
        Me.Recepcionfecha.Name = "Recepcionfecha"
        Me.Recepcionfecha.Size = New System.Drawing.Size(167, 29)
        Me.Recepcionfecha.TabIndex = 46
        '
        'recepcionhora
        '
        Me.recepcionhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recepcionhora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.recepcionhora.Location = New System.Drawing.Point(195, 100)
        Me.recepcionhora.Name = "recepcionhora"
        Me.recepcionhora.ShowUpDown = True
        Me.recepcionhora.Size = New System.Drawing.Size(193, 29)
        Me.recepcionhora.TabIndex = 47
        '
        'HoraInstalacion
        '
        Me.HoraInstalacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraInstalacion.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HoraInstalacion.Location = New System.Drawing.Point(195, 159)
        Me.HoraInstalacion.Name = "HoraInstalacion"
        Me.HoraInstalacion.ShowUpDown = True
        Me.HoraInstalacion.Size = New System.Drawing.Size(193, 29)
        Me.HoraInstalacion.TabIndex = 49
        '
        'FechaInstalacion
        '
        Me.FechaInstalacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaInstalacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInstalacion.Location = New System.Drawing.Point(22, 159)
        Me.FechaInstalacion.Name = "FechaInstalacion"
        Me.FechaInstalacion.Size = New System.Drawing.Size(167, 29)
        Me.FechaInstalacion.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Nuevo Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Precio Actual"
        '
        'PrecioActualBox
        '
        Me.PrecioActualBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioActualBox.Location = New System.Drawing.Point(22, 220)
        Me.PrecioActualBox.Name = "PrecioActualBox"
        Me.PrecioActualBox.Size = New System.Drawing.Size(167, 29)
        Me.PrecioActualBox.TabIndex = 50
        '
        'NuevoPrecioBox
        '
        Me.NuevoPrecioBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoPrecioBox.Location = New System.Drawing.Point(195, 220)
        Me.NuevoPrecioBox.Name = "NuevoPrecioBox"
        Me.NuevoPrecioBox.Size = New System.Drawing.Size(193, 29)
        Me.NuevoPrecioBox.TabIndex = 54
        '
        'ActualizarFechaRecepcion
        '
        Me.ActualizarFechaRecepcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualizarFechaRecepcion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ActualizarFechaRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActualizarFechaRecepcion.Image = Global.WindowsApp3.My.Resources.Resources.electronics
        Me.ActualizarFechaRecepcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActualizarFechaRecepcion.Location = New System.Drawing.Point(407, 99)
        Me.ActualizarFechaRecepcion.Name = "ActualizarFechaRecepcion"
        Me.ActualizarFechaRecepcion.Size = New System.Drawing.Size(101, 30)
        Me.ActualizarFechaRecepcion.TabIndex = 55
        Me.ActualizarFechaRecepcion.Text = "Actualizar"
        Me.ActualizarFechaRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ActualizarFechaRecepcion.UseVisualStyleBackColor = True
        '
        'ActualizarFechaInstalacion
        '
        Me.ActualizarFechaInstalacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualizarFechaInstalacion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ActualizarFechaInstalacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActualizarFechaInstalacion.Image = Global.WindowsApp3.My.Resources.Resources.electronics
        Me.ActualizarFechaInstalacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActualizarFechaInstalacion.Location = New System.Drawing.Point(407, 158)
        Me.ActualizarFechaInstalacion.Name = "ActualizarFechaInstalacion"
        Me.ActualizarFechaInstalacion.Size = New System.Drawing.Size(101, 30)
        Me.ActualizarFechaInstalacion.TabIndex = 56
        Me.ActualizarFechaInstalacion.Text = "Actualizar"
        Me.ActualizarFechaInstalacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ActualizarFechaInstalacion.UseVisualStyleBackColor = True
        '
        'ActualizarPrecioBtn
        '
        Me.ActualizarPrecioBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualizarPrecioBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ActualizarPrecioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActualizarPrecioBtn.Image = Global.WindowsApp3.My.Resources.Resources.electronics
        Me.ActualizarPrecioBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActualizarPrecioBtn.Location = New System.Drawing.Point(407, 219)
        Me.ActualizarPrecioBtn.Name = "ActualizarPrecioBtn"
        Me.ActualizarPrecioBtn.Size = New System.Drawing.Size(101, 30)
        Me.ActualizarPrecioBtn.TabIndex = 57
        Me.ActualizarPrecioBtn.Text = "Actualizar"
        Me.ActualizarPrecioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ActualizarPrecioBtn.UseVisualStyleBackColor = True
        '
        'ActualizarCantidadBtn
        '
        Me.ActualizarCantidadBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualizarCantidadBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ActualizarCantidadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActualizarCantidadBtn.Image = Global.WindowsApp3.My.Resources.Resources.electronics
        Me.ActualizarCantidadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActualizarCantidadBtn.Location = New System.Drawing.Point(407, 271)
        Me.ActualizarCantidadBtn.Name = "ActualizarCantidadBtn"
        Me.ActualizarCantidadBtn.Size = New System.Drawing.Size(101, 30)
        Me.ActualizarCantidadBtn.TabIndex = 63
        Me.ActualizarCantidadBtn.Text = "Actualizar"
        Me.ActualizarCantidadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ActualizarCantidadBtn.UseVisualStyleBackColor = True
        '
        'NuevaCantidadBox
        '
        Me.NuevaCantidadBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevaCantidadBox.Location = New System.Drawing.Point(195, 272)
        Me.NuevaCantidadBox.Name = "NuevaCantidadBox"
        Me.NuevaCantidadBox.Size = New System.Drawing.Size(193, 29)
        Me.NuevaCantidadBox.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Nueva Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Cantidad Actual"
        '
        'CantidadActualBox
        '
        Me.CantidadActualBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadActualBox.Location = New System.Drawing.Point(22, 272)
        Me.CantidadActualBox.Name = "CantidadActualBox"
        Me.CantidadActualBox.Size = New System.Drawing.Size(167, 29)
        Me.CantidadActualBox.TabIndex = 59
        '
        'DetallesBox
        '
        Me.DetallesBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetallesBox.Location = New System.Drawing.Point(22, 331)
        Me.DetallesBox.Multiline = True
        Me.DetallesBox.Name = "DetallesBox"
        Me.DetallesBox.Size = New System.Drawing.Size(366, 63)
        Me.DetallesBox.TabIndex = 64
        '
        'ActualizarDetallesBtn
        '
        Me.ActualizarDetallesBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualizarDetallesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ActualizarDetallesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActualizarDetallesBtn.Image = Global.WindowsApp3.My.Resources.Resources.electronics
        Me.ActualizarDetallesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActualizarDetallesBtn.Location = New System.Drawing.Point(407, 364)
        Me.ActualizarDetallesBtn.Name = "ActualizarDetallesBtn"
        Me.ActualizarDetallesBtn.Size = New System.Drawing.Size(101, 30)
        Me.ActualizarDetallesBtn.TabIndex = 65
        Me.ActualizarDetallesBtn.Text = "Actualizar"
        Me.ActualizarDetallesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ActualizarDetallesBtn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 315)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Detalles"
        '
        'CambioEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(520, 436)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ActualizarDetallesBtn)
        Me.Controls.Add(Me.DetallesBox)
        Me.Controls.Add(Me.ActualizarCantidadBtn)
        Me.Controls.Add(Me.NuevaCantidadBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CantidadActualBox)
        Me.Controls.Add(Me.ActualizarPrecioBtn)
        Me.Controls.Add(Me.ActualizarFechaInstalacion)
        Me.Controls.Add(Me.ActualizarFechaRecepcion)
        Me.Controls.Add(Me.NuevoPrecioBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PrecioActualBox)
        Me.Controls.Add(Me.HoraInstalacion)
        Me.Controls.Add(Me.FechaInstalacion)
        Me.Controls.Add(Me.recepcionhora)
        Me.Controls.Add(Me.Recepcionfecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IngresarBtn)
        Me.Controls.Add(Me.NuevoEstadoBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EstadoActualBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CambioEstado"
        Me.Text = "CambioEstado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EstadoActualBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NuevoEstadoBox As ComboBox
    Friend WithEvents IngresarBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Recepcionfecha As DateTimePicker
    Friend WithEvents recepcionhora As DateTimePicker
    Friend WithEvents HoraInstalacion As DateTimePicker
    Friend WithEvents FechaInstalacion As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PrecioActualBox As TextBox
    Friend WithEvents NuevoPrecioBox As TextBox
    Friend WithEvents ActualizarFechaRecepcion As Button
    Friend WithEvents ActualizarFechaInstalacion As Button
    Friend WithEvents ActualizarPrecioBtn As Button
    Friend WithEvents ActualizarCantidadBtn As Button
    Friend WithEvents NuevaCantidadBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CantidadActualBox As TextBox
    Friend WithEvents DetallesBox As TextBox
    Friend WithEvents ActualizarDetallesBtn As Button
    Friend WithEvents Label9 As Label
End Class
