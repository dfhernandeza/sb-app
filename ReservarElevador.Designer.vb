<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservarElevador
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
        Me.OTbox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tareasbox = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fintiempo = New System.Windows.Forms.DateTimePicker()
        Me.findtp = New System.Windows.Forms.DateTimePicker()
        Me.iniciotiempo = New System.Windows.Forms.DateTimePicker()
        Me.Iniciodtp = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.detallesbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.patentebox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.marcabox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OTbox
        '
        Me.OTbox.FormattingEnabled = True
        Me.OTbox.Location = New System.Drawing.Point(75, 35)
        Me.OTbox.Name = "OTbox"
        Me.OTbox.Size = New System.Drawing.Size(252, 21)
        Me.OTbox.Sorted = True
        Me.OTbox.TabIndex = 37
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(120, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 43)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Tareas"
        '
        'tareasbox
        '
        Me.tareasbox.AllowDrop = True
        Me.tareasbox.FormattingEnabled = True
        Me.tareasbox.Location = New System.Drawing.Point(75, 120)
        Me.tareasbox.Name = "tareasbox"
        Me.tareasbox.Size = New System.Drawing.Size(250, 95)
        Me.tareasbox.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Fin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Inicio"
        '
        'fintiempo
        '
        Me.fintiempo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.fintiempo.Location = New System.Drawing.Point(251, 94)
        Me.fintiempo.Name = "fintiempo"
        Me.fintiempo.ShowUpDown = True
        Me.fintiempo.Size = New System.Drawing.Size(76, 20)
        Me.fintiempo.TabIndex = 27
        '
        'findtp
        '
        Me.findtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.findtp.Location = New System.Drawing.Point(75, 94)
        Me.findtp.Name = "findtp"
        Me.findtp.Size = New System.Drawing.Size(158, 20)
        Me.findtp.TabIndex = 26
        '
        'iniciotiempo
        '
        Me.iniciotiempo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.iniciotiempo.Location = New System.Drawing.Point(251, 68)
        Me.iniciotiempo.Name = "iniciotiempo"
        Me.iniciotiempo.ShowUpDown = True
        Me.iniciotiempo.Size = New System.Drawing.Size(76, 20)
        Me.iniciotiempo.TabIndex = 25
        '
        'Iniciodtp
        '
        Me.Iniciodtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Iniciodtp.Location = New System.Drawing.Point(75, 68)
        Me.Iniciodtp.Name = "Iniciodtp"
        Me.Iniciodtp.Size = New System.Drawing.Size(158, 20)
        Me.Iniciodtp.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "OT"
        '
        'detallesbox
        '
        Me.detallesbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.detallesbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.detallesbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detallesbox.Location = New System.Drawing.Point(436, 112)
        Me.detallesbox.Multiline = True
        Me.detallesbox.Name = "detallesbox"
        Me.detallesbox.Size = New System.Drawing.Size(353, 102)
        Me.detallesbox.TabIndex = 139
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Detalles"
        '
        'patentebox
        '
        Me.patentebox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.patentebox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.patentebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patentebox.Location = New System.Drawing.Point(436, 71)
        Me.patentebox.Name = "patentebox"
        Me.patentebox.Size = New System.Drawing.Size(353, 20)
        Me.patentebox.TabIndex = 137
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(385, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Patente"
        '
        'marcabox
        '
        Me.marcabox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.marcabox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.marcabox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marcabox.Location = New System.Drawing.Point(436, 36)
        Me.marcabox.Name = "marcabox"
        Me.marcabox.Size = New System.Drawing.Size(353, 20)
        Me.marcabox.TabIndex = 135
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(353, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Marca/Modelo"
        '
        'ReservarElevador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 340)
        Me.Controls.Add(Me.detallesbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.patentebox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.marcabox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.OTbox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tareasbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fintiempo)
        Me.Controls.Add(Me.findtp)
        Me.Controls.Add(Me.iniciotiempo)
        Me.Controls.Add(Me.Iniciodtp)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ReservarElevador"
        Me.Text = "Reservar Elevador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OTbox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tareasbox As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fintiempo As DateTimePicker
    Friend WithEvents findtp As DateTimePicker
    Friend WithEvents iniciotiempo As DateTimePicker
    Friend WithEvents Iniciodtp As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents detallesbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents patentebox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents marcabox As TextBox
    Friend WithEvents Label7 As Label
End Class
