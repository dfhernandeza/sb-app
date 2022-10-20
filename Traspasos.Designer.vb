<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Traspasos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Traspasos))
        Me.Persona = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Monto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Detalles = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Origen = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.finalizarbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Persona
        '
        Me.Persona.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Persona.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona.FormattingEnabled = True
        Me.Persona.Location = New System.Drawing.Point(32, 47)
        Me.Persona.Name = "Persona"
        Me.Persona.Size = New System.Drawing.Size(503, 39)
        Me.Persona.TabIndex = 0
        Me.Persona.Text = "-Seleccionar-"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Solicitante"
        '
        'Monto
        '
        Me.Monto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Monto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monto.Location = New System.Drawing.Point(32, 128)
        Me.Monto.Name = "Monto"
        Me.Monto.Size = New System.Drawing.Size(505, 49)
        Me.Monto.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Monto"
        '
        'Detalles
        '
        Me.Detalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detalles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Detalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detalles.Location = New System.Drawing.Point(34, 296)
        Me.Detalles.Multiline = True
        Me.Detalles.Name = "Detalles"
        Me.Detalles.Size = New System.Drawing.Size(501, 96)
        Me.Detalles.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Detalles"
        '
        'Origen
        '
        Me.Origen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Origen.FormattingEnabled = True
        Me.Origen.Items.AddRange(New Object() {"CAJA", "CUENTA CORRIENTE"})
        Me.Origen.Location = New System.Drawing.Point(34, 211)
        Me.Origen.Name = "Origen"
        Me.Origen.Size = New System.Drawing.Size(503, 39)
        Me.Origen.TabIndex = 7
        Me.Origen.Text = "-Seleccionar-"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Origen"
        '
        'finalizarbtn
        '
        Me.finalizarbtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.finalizarbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.finalizarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.finalizarbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalizarbtn.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.finalizarbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.finalizarbtn.Location = New System.Drawing.Point(197, 422)
        Me.finalizarbtn.Name = "finalizarbtn"
        Me.finalizarbtn.Size = New System.Drawing.Size(136, 75)
        Me.finalizarbtn.TabIndex = 59
        Me.finalizarbtn.Text = "Finalizar"
        Me.finalizarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.finalizarbtn.UseVisualStyleBackColor = True
        '
        'Traspasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(570, 509)
        Me.Controls.Add(Me.finalizarbtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Origen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Detalles)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Monto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Persona)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Traspasos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traspasos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Persona As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Monto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Detalles As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Origen As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents finalizarbtn As Button
End Class
