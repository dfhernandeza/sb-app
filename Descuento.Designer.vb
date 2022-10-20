<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Descuento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Descuento))
        Me.CantidadBtn = New System.Windows.Forms.Button()
        Me.Porcentajebtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CantidadBtn
        '
        Me.CantidadBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CantidadBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CantidadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CantidadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadBtn.Image = Global.WindowsApp3.My.Resources.Resources.dollar__2_
        Me.CantidadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CantidadBtn.Location = New System.Drawing.Point(188, 29)
        Me.CantidadBtn.Name = "CantidadBtn"
        Me.CantidadBtn.Size = New System.Drawing.Size(120, 46)
        Me.CantidadBtn.TabIndex = 58
        Me.CantidadBtn.Text = "Cantidad"
        Me.CantidadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CantidadBtn.UseVisualStyleBackColor = True
        '
        'Porcentajebtn
        '
        Me.Porcentajebtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Porcentajebtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Porcentajebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Porcentajebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Porcentajebtn.Image = Global.WindowsApp3.My.Resources.Resources.commerce_and_shopping__1_
        Me.Porcentajebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Porcentajebtn.Location = New System.Drawing.Point(26, 26)
        Me.Porcentajebtn.Name = "Porcentajebtn"
        Me.Porcentajebtn.Size = New System.Drawing.Size(131, 52)
        Me.Porcentajebtn.TabIndex = 57
        Me.Porcentajebtn.Text = "Porcentaje"
        Me.Porcentajebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Porcentajebtn.UseVisualStyleBackColor = True
        '
        'Descuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 109)
        Me.Controls.Add(Me.CantidadBtn)
        Me.Controls.Add(Me.Porcentajebtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Descuento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descuento"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Porcentajebtn As Button
    Friend WithEvents CantidadBtn As Button
End Class
