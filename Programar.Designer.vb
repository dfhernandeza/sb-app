<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Programar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Programar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Iniciodtp = New System.Windows.Forms.DateTimePicker()
        Me.iniciotiempo = New System.Windows.Forms.DateTimePicker()
        Me.fintiempo = New System.Windows.Forms.DateTimePicker()
        Me.findtp = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.idmecanicobox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tareasbox = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OTbox = New System.Windows.Forms.ComboBox()
        Me.Mecanicobox = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mecánico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "OT"
        '
        'Iniciodtp
        '
        Me.Iniciodtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Iniciodtp.Location = New System.Drawing.Point(96, 124)
        Me.Iniciodtp.Name = "Iniciodtp"
        Me.Iniciodtp.Size = New System.Drawing.Size(158, 20)
        Me.Iniciodtp.TabIndex = 6
        '
        'iniciotiempo
        '
        Me.iniciotiempo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.iniciotiempo.Location = New System.Drawing.Point(272, 124)
        Me.iniciotiempo.Name = "iniciotiempo"
        Me.iniciotiempo.ShowUpDown = True
        Me.iniciotiempo.Size = New System.Drawing.Size(76, 20)
        Me.iniciotiempo.TabIndex = 7
        '
        'fintiempo
        '
        Me.fintiempo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.fintiempo.Location = New System.Drawing.Point(272, 150)
        Me.fintiempo.Name = "fintiempo"
        Me.fintiempo.ShowUpDown = True
        Me.fintiempo.Size = New System.Drawing.Size(76, 20)
        Me.fintiempo.TabIndex = 9
        '
        'findtp
        '
        Me.findtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.findtp.Location = New System.Drawing.Point(96, 150)
        Me.findtp.Name = "findtp"
        Me.findtp.Size = New System.Drawing.Size(158, 20)
        Me.findtp.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Inicio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fin"
        '
        'idmecanicobox
        '
        Me.idmecanicobox.Location = New System.Drawing.Point(96, 72)
        Me.idmecanicobox.Name = "idmecanicobox"
        Me.idmecanicobox.Size = New System.Drawing.Size(251, 20)
        Me.idmecanicobox.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ID Mecánico"
        '
        'tareasbox
        '
        Me.tareasbox.AllowDrop = True
        Me.tareasbox.FormattingEnabled = True
        Me.tareasbox.Location = New System.Drawing.Point(96, 176)
        Me.tareasbox.Name = "tareasbox"
        Me.tareasbox.Size = New System.Drawing.Size(250, 95)
        Me.tareasbox.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Tareas"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 25)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(150, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 43)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Ingresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Elevador"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(97, 98)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 21)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 19
        '
        'OTbox
        '
        Me.OTbox.FormattingEnabled = True
        Me.OTbox.Location = New System.Drawing.Point(96, 19)
        Me.OTbox.Name = "OTbox"
        Me.OTbox.Size = New System.Drawing.Size(252, 21)
        Me.OTbox.Sorted = True
        Me.OTbox.TabIndex = 20
        '
        'Mecanicobox
        '
        Me.Mecanicobox.FormattingEnabled = True
        Me.Mecanicobox.Location = New System.Drawing.Point(97, 46)
        Me.Mecanicobox.Name = "Mecanicobox"
        Me.Mecanicobox.Size = New System.Drawing.Size(251, 21)
        Me.Mecanicobox.Sorted = True
        Me.Mecanicobox.TabIndex = 21
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(363, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 25)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Programar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(408, 383)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Mecanicobox)
        Me.Controls.Add(Me.OTbox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tareasbox)
        Me.Controls.Add(Me.idmecanicobox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fintiempo)
        Me.Controls.Add(Me.findtp)
        Me.Controls.Add(Me.iniciotiempo)
        Me.Controls.Add(Me.Iniciodtp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Programar"
        Me.Text = "Programar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Iniciodtp As DateTimePicker
    Friend WithEvents iniciotiempo As DateTimePicker
    Friend WithEvents fintiempo As DateTimePicker
    Friend WithEvents findtp As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents idmecanicobox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tareasbox As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents OTbox As ComboBox
    Friend WithEvents Mecanicobox As ComboBox
    Friend WithEvents Button3 As Button
End Class
