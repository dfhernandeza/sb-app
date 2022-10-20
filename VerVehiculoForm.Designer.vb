<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerVehiculoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerVehiculoForm))
        Me.marcamodelobox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.patentebox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kilometrajebox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.anobox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.motorbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'marcamodelobox
        '
        Me.marcamodelobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marcamodelobox.Location = New System.Drawing.Point(184, 39)
        Me.marcamodelobox.Name = "marcamodelobox"
        Me.marcamodelobox.Size = New System.Drawing.Size(375, 29)
        Me.marcamodelobox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Marca/Modelo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Patente"
        '
        'patentebox
        '
        Me.patentebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patentebox.Location = New System.Drawing.Point(29, 39)
        Me.patentebox.Name = "patentebox"
        Me.patentebox.Size = New System.Drawing.Size(149, 29)
        Me.patentebox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kilometraje"
        '
        'kilometrajebox
        '
        Me.kilometrajebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilometrajebox.Location = New System.Drawing.Point(29, 91)
        Me.kilometrajebox.Name = "kilometrajebox"
        Me.kilometrajebox.Size = New System.Drawing.Size(168, 29)
        Me.kilometrajebox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Año"
        '
        'anobox
        '
        Me.anobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anobox.Location = New System.Drawing.Point(203, 91)
        Me.anobox.Name = "anobox"
        Me.anobox.Size = New System.Drawing.Size(171, 29)
        Me.anobox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(377, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Motor"
        '
        'motorbox
        '
        Me.motorbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motorbox.Location = New System.Drawing.Point(380, 91)
        Me.motorbox.Name = "motorbox"
        Me.motorbox.Size = New System.Drawing.Size(179, 29)
        Me.motorbox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WindowsApp3.My.Resources.Resources.transportation
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(230, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 39)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Aceptar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VerVehiculoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(589, 221)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.motorbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.anobox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.kilometrajebox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.patentebox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.marcamodelobox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VerVehiculoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver Vehiculo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents marcamodelobox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents patentebox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents kilometrajebox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents anobox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents motorbox As TextBox
    Friend WithEvents Button1 As Button
End Class
