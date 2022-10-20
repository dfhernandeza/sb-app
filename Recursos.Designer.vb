<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recursos))
        Me.DGVRecursos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoriabox = New System.Windows.Forms.ComboBox()
        Me.añadirbtn = New System.Windows.Forms.Button()
        CType(Me.DGVRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVRecursos
        '
        Me.DGVRecursos.AllowUserToAddRows = False
        Me.DGVRecursos.AllowUserToDeleteRows = False
        Me.DGVRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRecursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Apellido})
        Me.DGVRecursos.GridColor = System.Drawing.Color.White
        Me.DGVRecursos.Location = New System.Drawing.Point(12, 62)
        Me.DGVRecursos.Name = "DGVRecursos"
        Me.DGVRecursos.RowHeadersVisible = False
        Me.DGVRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVRecursos.Size = New System.Drawing.Size(388, 252)
        Me.DGVRecursos.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'categoriabox
        '
        Me.categoriabox.FormattingEnabled = True
        Me.categoriabox.Location = New System.Drawing.Point(12, 347)
        Me.categoriabox.Name = "categoriabox"
        Me.categoriabox.Size = New System.Drawing.Size(141, 21)
        Me.categoriabox.TabIndex = 1
        '
        'añadirbtn
        '
        Me.añadirbtn.Location = New System.Drawing.Point(176, 345)
        Me.añadirbtn.Name = "añadirbtn"
        Me.añadirbtn.Size = New System.Drawing.Size(103, 22)
        Me.añadirbtn.TabIndex = 2
        Me.añadirbtn.Text = "Añadir"
        Me.añadirbtn.UseVisualStyleBackColor = True
        '
        'Recursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(412, 429)
        Me.Controls.Add(Me.añadirbtn)
        Me.Controls.Add(Me.categoriabox)
        Me.Controls.Add(Me.DGVRecursos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Recursos"
        Me.Text = "Recursos"
        CType(Me.DGVRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVRecursos As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents categoriabox As ComboBox
    Friend WithEvents añadirbtn As Button
End Class
