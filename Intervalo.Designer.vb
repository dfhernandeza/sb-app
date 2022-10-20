<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intervalo
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
        Me.fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.aceptarbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'fecha1
        '
        Me.fecha1.Location = New System.Drawing.Point(82, 53)
        Me.fecha1.Name = "fecha1"
        Me.fecha1.Size = New System.Drawing.Size(171, 20)
        Me.fecha1.TabIndex = 0
        '
        'fecha2
        '
        Me.fecha2.Location = New System.Drawing.Point(82, 102)
        Me.fecha2.Name = "fecha2"
        Me.fecha2.Size = New System.Drawing.Size(171, 20)
        Me.fecha2.TabIndex = 1
        '
        'aceptarbtn
        '
        Me.aceptarbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.aceptarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarbtn.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptarbtn.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.aceptarbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.aceptarbtn.Location = New System.Drawing.Point(82, 156)
        Me.aceptarbtn.Name = "aceptarbtn"
        Me.aceptarbtn.Size = New System.Drawing.Size(161, 69)
        Me.aceptarbtn.TabIndex = 66
        Me.aceptarbtn.Text = "Aceptar"
        Me.aceptarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.aceptarbtn.UseVisualStyleBackColor = True
        '
        'Intervalo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(347, 273)
        Me.Controls.Add(Me.aceptarbtn)
        Me.Controls.Add(Me.fecha2)
        Me.Controls.Add(Me.fecha1)
        Me.Name = "Intervalo"
        Me.Text = "Intervalo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fecha1 As DateTimePicker
    Friend WithEvents fecha2 As DateTimePicker
    Friend WithEvents aceptarbtn As Button
End Class
