<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevoEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoEmpleado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombrebox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.apellidobox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.especialidadbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.costohhbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.aceptarbtn = New System.Windows.Forms.Button()
        Me.idbox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'nombrebox
        '
        Me.nombrebox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nombrebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombrebox.Location = New System.Drawing.Point(184, 59)
        Me.nombrebox.Name = "nombrebox"
        Me.nombrebox.Size = New System.Drawing.Size(305, 29)
        Me.nombrebox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'apellidobox
        '
        Me.apellidobox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.apellidobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidobox.Location = New System.Drawing.Point(41, 110)
        Me.apellidobox.Name = "apellidobox"
        Me.apellidobox.Size = New System.Drawing.Size(448, 29)
        Me.apellidobox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellidos"
        '
        'especialidadbox
        '
        Me.especialidadbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.especialidadbox.Location = New System.Drawing.Point(41, 163)
        Me.especialidadbox.Name = "especialidadbox"
        Me.especialidadbox.Size = New System.Drawing.Size(278, 29)
        Me.especialidadbox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Especialidad"
        '
        'costohhbox
        '
        Me.costohhbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costohhbox.Location = New System.Drawing.Point(325, 163)
        Me.costohhbox.Name = "costohhbox"
        Me.costohhbox.Size = New System.Drawing.Size(164, 29)
        Me.costohhbox.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(322, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Costo HH"
        '
        'aceptarbtn
        '
        Me.aceptarbtn.BackColor = System.Drawing.Color.Transparent
        Me.aceptarbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.aceptarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptarbtn.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.aceptarbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.aceptarbtn.Location = New System.Drawing.Point(173, 227)
        Me.aceptarbtn.Name = "aceptarbtn"
        Me.aceptarbtn.Size = New System.Drawing.Size(174, 67)
        Me.aceptarbtn.TabIndex = 5
        Me.aceptarbtn.Text = "Ingresar"
        Me.aceptarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.aceptarbtn.UseVisualStyleBackColor = False
        '
        'idbox
        '
        Me.idbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idbox.Location = New System.Drawing.Point(41, 59)
        Me.idbox.Name = "idbox"
        Me.idbox.Size = New System.Drawing.Size(137, 29)
        Me.idbox.TabIndex = 0
        '
        'NuevoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(546, 306)
        Me.Controls.Add(Me.idbox)
        Me.Controls.Add(Me.costohhbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.especialidadbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.apellidobox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nombrebox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.aceptarbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NuevoEmpleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents aceptarbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nombrebox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents apellidobox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents especialidadbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents costohhbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents idbox As MaskedTextBox
End Class
