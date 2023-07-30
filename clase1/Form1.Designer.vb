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
        Me.ButtonAlert = New System.Windows.Forms.Button()
        Me.etiquetaNombre = New System.Windows.Forms.Label()
        Me.textBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textBoxCarnet = New System.Windows.Forms.TextBox()
        Me.listaEstudiantes = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ButtonAlert
        '
        Me.ButtonAlert.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonAlert.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonAlert.Location = New System.Drawing.Point(128, 140)
        Me.ButtonAlert.Name = "ButtonAlert"
        Me.ButtonAlert.Size = New System.Drawing.Size(181, 29)
        Me.ButtonAlert.TabIndex = 0
        Me.ButtonAlert.Text = "Mostrar Alerta"
        Me.ButtonAlert.UseVisualStyleBackColor = False
        '
        'etiquetaNombre
        '
        Me.etiquetaNombre.AutoSize = True
        Me.etiquetaNombre.Location = New System.Drawing.Point(50, 36)
        Me.etiquetaNombre.Name = "etiquetaNombre"
        Me.etiquetaNombre.Size = New System.Drawing.Size(64, 20)
        Me.etiquetaNombre.TabIndex = 6
        Me.etiquetaNombre.Text = "Nombre"
        '
        'textBoxNombre
        '
        Me.textBoxNombre.Location = New System.Drawing.Point(141, 33)
        Me.textBoxNombre.Name = "textBoxNombre"
        Me.textBoxNombre.Size = New System.Drawing.Size(246, 27)
        Me.textBoxNombre.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Carnet"
        '
        'textBoxCarnet
        '
        Me.textBoxCarnet.Location = New System.Drawing.Point(141, 77)
        Me.textBoxCarnet.Name = "textBoxCarnet"
        Me.textBoxCarnet.Size = New System.Drawing.Size(246, 27)
        Me.textBoxCarnet.TabIndex = 9
        '
        'listaEstudiantes
        '
        Me.listaEstudiantes.FormattingEnabled = True
        Me.listaEstudiantes.ItemHeight = 20
        Me.listaEstudiantes.Location = New System.Drawing.Point(28, 189)
        Me.listaEstudiantes.Name = "listaEstudiantes"
        Me.listaEstudiantes.Size = New System.Drawing.Size(746, 224)
        Me.listaEstudiantes.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.listaEstudiantes)
        Me.Controls.Add(Me.textBoxCarnet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textBoxNombre)
        Me.Controls.Add(Me.etiquetaNombre)
        Me.Controls.Add(Me.ButtonAlert)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAlert As Button
    Friend WithEvents etiquetaNombre As Label
    Friend WithEvents textBoxNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents textBoxCarnet As TextBox
    Friend WithEvents listaEstudiantes As ListBox
End Class
