<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarItem
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EliminarItem))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IDT = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(28, 51)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(27, 24)
        IDLabel.TabIndex = 38
        IDLabel.Text = "ID"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(273, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 77)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Aceptar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IDT
        '
        Me.IDT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDT.Location = New System.Drawing.Point(78, 48)
        Me.IDT.Name = "IDT"
        Me.IDT.Size = New System.Drawing.Size(171, 29)
        Me.IDT.TabIndex = 39
        '
        'EliminarItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(427, 136)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EliminarItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents IDT As TextBox
End Class
