<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Observaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Observaciones))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.otbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Observacionesbox = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "OT"
        '
        'otbox
        '
        Me.otbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.otbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otbox.Location = New System.Drawing.Point(38, 64)
        Me.otbox.Name = "otbox"
        Me.otbox.Size = New System.Drawing.Size(178, 29)
        Me.otbox.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Observaciones"
        '
        'Observacionesbox
        '
        Me.Observacionesbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Observacionesbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observacionesbox.Location = New System.Drawing.Point(38, 126)
        Me.Observacionesbox.Multiline = True
        Me.Observacionesbox.Name = "Observacionesbox"
        Me.Observacionesbox.Size = New System.Drawing.Size(460, 277)
        Me.Observacionesbox.TabIndex = 109
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(360, 48)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(138, 69)
        Me.Button7.TabIndex = 111
        Me.Button7.Text = "Finalizar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Observaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(550, 433)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Observacionesbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.otbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Observaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Observaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents otbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Observacionesbox As TextBox
    Friend WithEvents Button7 As Button
End Class
