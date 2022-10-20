<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Precios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Precios))
        Me.DGVPrecios = New System.Windows.Forms.DataGridView()
        Me.buscarbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buscarpobox = New System.Windows.Forms.ComboBox()
        CType(Me.DGVPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVPrecios
        '
        Me.DGVPrecios.AllowUserToAddRows = False
        Me.DGVPrecios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPrecios.Location = New System.Drawing.Point(87, 100)
        Me.DGVPrecios.Name = "DGVPrecios"
        Me.DGVPrecios.RowHeadersVisible = False
        Me.DGVPrecios.Size = New System.Drawing.Size(619, 350)
        Me.DGVPrecios.TabIndex = 0
        '
        'buscarbox
        '
        Me.buscarbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.buscarbox.Location = New System.Drawing.Point(579, 59)
        Me.buscarbox.Name = "buscarbox"
        Me.buscarbox.Size = New System.Drawing.Size(127, 20)
        Me.buscarbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(362, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar por:"
        '
        'buscarpobox
        '
        Me.buscarpobox.FormattingEnabled = True
        Me.buscarpobox.Items.AddRange(New Object() {"ITEM", "AUTOMÓVIL"})
        Me.buscarpobox.Location = New System.Drawing.Point(429, 59)
        Me.buscarpobox.Name = "buscarpobox"
        Me.buscarpobox.Size = New System.Drawing.Size(144, 21)
        Me.buscarpobox.TabIndex = 3
        '
        'Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 497)
        Me.Controls.Add(Me.buscarpobox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buscarbox)
        Me.Controls.Add(Me.DGVPrecios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Precios"
        Me.Text = "Precios"
        CType(Me.DGVPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVPrecios As DataGridView
    Friend WithEvents buscarbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents buscarpobox As ComboBox
End Class
