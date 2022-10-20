<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caja
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caja))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.montotxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.motivotxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.retiro = New System.Windows.Forms.RadioButton()
        Me.deposito = New System.Windows.Forms.RadioButton()
        Me.responsabletxt = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numerotxt = New System.Windows.Forms.TextBox()
        Me.Acumuladobox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Motivo"
        '
        'montotxt
        '
        Me.montotxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.montotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.montotxt.Location = New System.Drawing.Point(35, 186)
        Me.montotxt.Name = "montotxt"
        Me.montotxt.Size = New System.Drawing.Size(262, 29)
        Me.montotxt.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(113, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Responsable"
        '
        'motivotxt
        '
        Me.motivotxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.motivotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motivotxt.Location = New System.Drawing.Point(35, 241)
        Me.motivotxt.Name = "motivotxt"
        Me.motivotxt.Size = New System.Drawing.Size(262, 29)
        Me.motivotxt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(34, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Monto"
        '
        'retiro
        '
        Me.retiro.AutoSize = True
        Me.retiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retiro.Location = New System.Drawing.Point(63, 301)
        Me.retiro.Name = "retiro"
        Me.retiro.Size = New System.Drawing.Size(77, 28)
        Me.retiro.TabIndex = 3
        Me.retiro.TabStop = True
        Me.retiro.Text = "Retiro"
        Me.retiro.UseVisualStyleBackColor = True
        '
        'deposito
        '
        Me.deposito.AutoSize = True
        Me.deposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deposito.Location = New System.Drawing.Point(172, 301)
        Me.deposito.Name = "deposito"
        Me.deposito.Size = New System.Drawing.Size(102, 28)
        Me.deposito.TabIndex = 4
        Me.deposito.TabStop = True
        Me.deposito.Text = "Depósito"
        Me.deposito.UseVisualStyleBackColor = True
        '
        'responsabletxt
        '
        Me.responsabletxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.responsabletxt.FormattingEnabled = True
        Me.responsabletxt.Location = New System.Drawing.Point(114, 131)
        Me.responsabletxt.Name = "responsabletxt"
        Me.responsabletxt.Size = New System.Drawing.Size(189, 32)
        Me.responsabletxt.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(351, 103)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.Size = New System.Drawing.Size(678, 456)
        Me.DataGridView2.TabIndex = 88
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.WindowsApp3.My.Resources.Resources.signs__2_
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(93, 371)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(161, 72)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Finalizar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "N°"
        '
        'numerotxt
        '
        Me.numerotxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.numerotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numerotxt.Location = New System.Drawing.Point(35, 131)
        Me.numerotxt.Name = "numerotxt"
        Me.numerotxt.Size = New System.Drawing.Size(66, 29)
        Me.numerotxt.TabIndex = 90
        '
        'Acumuladobox
        '
        Me.Acumuladobox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Acumuladobox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Acumuladobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Acumuladobox.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Acumuladobox.Location = New System.Drawing.Point(795, 20)
        Me.Acumuladobox.Name = "Acumuladobox"
        Me.Acumuladobox.Size = New System.Drawing.Size(234, 62)
        Me.Acumuladobox.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(672, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 24)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Acumulado"
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1051, 657)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Acumuladobox)
        Me.Controls.Add(Me.numerotxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.responsabletxt)
        Me.Controls.Add(Me.deposito)
        Me.Controls.Add(Me.retiro)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.montotxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.motivotxt)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Caja"
        Me.Text = "Caja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents montotxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents motivotxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents retiro As RadioButton
    Friend WithEvents deposito As RadioButton
    Friend WithEvents responsabletxt As ComboBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents numerotxt As TextBox
    Friend WithEvents Acumuladobox As TextBox
    Friend WithEvents Label2 As Label
End Class
