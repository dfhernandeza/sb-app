<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mes
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.anobox = New System.Windows.Forms.ComboBox()
        Me.mesbox = New System.Windows.Forms.ComboBox()
        Me.aceptarbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(214, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 39)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "/"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Mes/Año"
        '
        'anobox
        '
        Me.anobox.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anobox.FormattingEnabled = True
        Me.anobox.Location = New System.Drawing.Point(255, 53)
        Me.anobox.Name = "anobox"
        Me.anobox.Size = New System.Drawing.Size(101, 31)
        Me.anobox.TabIndex = 64
        '
        'mesbox
        '
        Me.mesbox.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mesbox.FormattingEnabled = True
        Me.mesbox.Location = New System.Drawing.Point(151, 53)
        Me.mesbox.Name = "mesbox"
        Me.mesbox.Size = New System.Drawing.Size(57, 31)
        Me.mesbox.Sorted = True
        Me.mesbox.TabIndex = 63
        '
        'aceptarbtn
        '
        Me.aceptarbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.aceptarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarbtn.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptarbtn.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.aceptarbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.aceptarbtn.Location = New System.Drawing.Point(138, 119)
        Me.aceptarbtn.Name = "aceptarbtn"
        Me.aceptarbtn.Size = New System.Drawing.Size(161, 69)
        Me.aceptarbtn.TabIndex = 65
        Me.aceptarbtn.Text = "Aceptar"
        Me.aceptarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.aceptarbtn.UseVisualStyleBackColor = True
        '
        'Mes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(398, 224)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.aceptarbtn)
        Me.Controls.Add(Me.anobox)
        Me.Controls.Add(Me.mesbox)
        Me.Name = "Mes"
        Me.Text = "Mes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents aceptarbtn As Button
    Friend WithEvents anobox As ComboBox
    Friend WithEvents mesbox As ComboBox
End Class
