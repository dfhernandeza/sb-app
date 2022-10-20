<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.totalTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.netoTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemanalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MensualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntervaloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(56, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(825, 371)
        Me.DataGridView1.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(626, 49)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(255, 22)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Value = New Date(2021, 3, 2, 0, 0, 0, 0)
        '
        'totalTextBox2
        '
        Me.totalTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.totalTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalTextBox2.Location = New System.Drawing.Point(187, 501)
        Me.totalTextBox2.Name = "totalTextBox2"
        Me.totalTextBox2.Size = New System.Drawing.Size(120, 29)
        Me.totalTextBox2.TabIndex = 41
        Me.totalTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(125, 504)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Total"
        '
        'IvaTextBox
        '
        Me.IvaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IvaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IvaTextBox.Location = New System.Drawing.Point(407, 501)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(120, 29)
        Me.IvaTextBox.TabIndex = 43
        Me.IvaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(345, 504)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 24)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "IVA"
        '
        'netoTextBox
        '
        Me.netoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.netoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.netoTextBox.Location = New System.Drawing.Point(695, 499)
        Me.netoTextBox.Name = "netoTextBox"
        Me.netoTextBox.Size = New System.Drawing.Size(120, 29)
        Me.netoTextBox.TabIndex = 45
        Me.netoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(633, 502)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Neto"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.VerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(932, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiarioToolStripMenuItem, Me.SemanalToolStripMenuItem, Me.MensualToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem1.Text = "Informe"
        '
        'DiarioToolStripMenuItem
        '
        Me.DiarioToolStripMenuItem.Name = "DiarioToolStripMenuItem"
        Me.DiarioToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.DiarioToolStripMenuItem.Text = "Diario"
        '
        'SemanalToolStripMenuItem
        '
        Me.SemanalToolStripMenuItem.Name = "SemanalToolStripMenuItem"
        Me.SemanalToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.SemanalToolStripMenuItem.Text = "Semanal"
        '
        'MensualToolStripMenuItem
        '
        Me.MensualToolStripMenuItem.Name = "MensualToolStripMenuItem"
        Me.MensualToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.MensualToolStripMenuItem.Text = "Mensual"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodasToolStripMenuItem, Me.MesToolStripMenuItem, Me.SemanaToolStripMenuItem, Me.IntervaloToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'TodasToolStripMenuItem
        '
        Me.TodasToolStripMenuItem.Name = "TodasToolStripMenuItem"
        Me.TodasToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.TodasToolStripMenuItem.Text = "Todas"
        '
        'MesToolStripMenuItem
        '
        Me.MesToolStripMenuItem.Name = "MesToolStripMenuItem"
        Me.MesToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.MesToolStripMenuItem.Text = "Mes"
        '
        'SemanaToolStripMenuItem
        '
        Me.SemanaToolStripMenuItem.Name = "SemanaToolStripMenuItem"
        Me.SemanaToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.SemanaToolStripMenuItem.Text = "Semana"
        '
        'IntervaloToolStripMenuItem
        '
        Me.IntervaloToolStripMenuItem.Name = "IntervaloToolStripMenuItem"
        Me.IntervaloToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.IntervaloToolStripMenuItem.Text = "Intervalo"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(53, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 29)
        Me.TextBox1.TabIndex = 47
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(295, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 32)
        Me.ComboBox1.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Image = Global.WindowsApp3.My.Resources.Resources.eye
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(190, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 35)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Buscar por:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(932, 552)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.netoTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IvaTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totalTextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents totalTextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IvaTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents netoTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DiarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SemanalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MensualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SemanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntervaloToolStripMenuItem As ToolStripMenuItem
End Class
