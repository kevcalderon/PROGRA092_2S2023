<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textBoxNumero1 = New System.Windows.Forms.TextBox()
        Me.textBoxNumero2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Operacion = New System.Windows.Forms.Label()
        Me.comboOperacion = New System.Windows.Forms.ComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.listBoxResultado = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(42, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(42, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Número 2"
        '
        'textBoxNumero1
        '
        Me.textBoxNumero1.Location = New System.Drawing.Point(166, 46)
        Me.textBoxNumero1.Name = "textBoxNumero1"
        Me.textBoxNumero1.Size = New System.Drawing.Size(311, 27)
        Me.textBoxNumero1.TabIndex = 2
        '
        'textBoxNumero2
        '
        Me.textBoxNumero2.Location = New System.Drawing.Point(166, 121)
        Me.textBoxNumero2.Name = "textBoxNumero2"
        Me.textBoxNumero2.Size = New System.Drawing.Size(317, 27)
        Me.textBoxNumero2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(255, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CALCULADORA CLASE 3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Operacion)
        Me.GroupBox1.Controls.Add(Me.comboOperacion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.textBoxNumero1)
        Me.GroupBox1.Controls.Add(Me.textBoxNumero2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 261)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Operacion
        '
        Me.Operacion.AutoSize = True
        Me.Operacion.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Operacion.Location = New System.Drawing.Point(42, 187)
        Me.Operacion.Name = "Operacion"
        Me.Operacion.Size = New System.Drawing.Size(94, 25)
        Me.Operacion.TabIndex = 5
        Me.Operacion.Text = "Operación"
        '
        'comboOperacion
        '
        Me.comboOperacion.FormattingEnabled = True
        Me.comboOperacion.Items.AddRange(New Object() {"+", "-", "*", "/", "#", "^"})
        Me.comboOperacion.Location = New System.Drawing.Point(166, 184)
        Me.comboOperacion.Name = "comboOperacion"
        Me.comboOperacion.Size = New System.Drawing.Size(151, 28)
        Me.comboOperacion.TabIndex = 4
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Location = New System.Drawing.Point(296, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 45)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'listBoxResultado
        '
        Me.listBoxResultado.FormattingEnabled = True
        Me.listBoxResultado.ItemHeight = 20
        Me.listBoxResultado.Location = New System.Drawing.Point(42, 406)
        Me.listBoxResultado.Name = "listBoxResultado"
        Me.listBoxResultado.Size = New System.Drawing.Size(706, 204)
        Me.listBoxResultado.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(786, 645)
        Me.Controls.Add(Me.listBoxResultado)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textBoxNumero1 As TextBox
    Friend WithEvents textBoxNumero2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Operacion As Label
    Friend WithEvents comboOperacion As ComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button1 As Button
    Friend WithEvents listBoxResultado As ListBox
End Class
