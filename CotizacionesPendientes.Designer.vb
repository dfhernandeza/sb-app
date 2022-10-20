<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CotizacionesPendientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVP = New System.Windows.Forms.DataGridView()
        Me.OK = New System.Windows.Forms.Button()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cotizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DGVP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVP
        '
        Me.DGVP.AllowUserToAddRows = False
        Me.DGVP.AllowUserToDeleteRows = False
        Me.DGVP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Cotizacion, Me.Cliente, Me.Item, Me.CodItem, Me.Check})
        Me.DGVP.Location = New System.Drawing.Point(69, 98)
        Me.DGVP.Name = "DGVP"
        Me.DGVP.RowHeadersVisible = False
        Me.DGVP.Size = New System.Drawing.Size(624, 358)
        Me.DGVP.TabIndex = 0
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(69, 46)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(52, 23)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Cotizacion
        '
        Me.Cotizacion.HeaderText = "COT"
        Me.Cotizacion.Name = "Cotizacion"
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        '
        'CodItem
        '
        Me.CodItem.HeaderText = "CodItem"
        Me.CodItem.Name = "CodItem"
        Me.CodItem.Visible = False
        '
        'Check
        '
        Me.Check.HeaderText = ""
        Me.Check.Name = "Check"
        '
        'CotizacionesPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(745, 513)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.DGVP)
        Me.Name = "CotizacionesPendientes"
        Me.Text = "CotizacionesPendientes"
        CType(Me.DGVP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVP As DataGridView
    Friend WithEvents OK As Button
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Cotizacion As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents CodItem As DataGridViewTextBoxColumn
    Friend WithEvents Check As DataGridViewCheckBoxColumn
End Class
