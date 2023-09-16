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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.buttonRegistrar = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog4 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog5 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog6 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog7 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog8 = New System.Windows.Forms.OpenFileDialog()
        Me.buttonConexion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.textBoxUsuario = New System.Windows.Forms.TextBox()
        Me.textBoxContra = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'buttonRegistrar
        '
        Me.buttonRegistrar.Location = New System.Drawing.Point(299, 295)
        Me.buttonRegistrar.Name = "buttonRegistrar"
        Me.buttonRegistrar.Size = New System.Drawing.Size(181, 50)
        Me.buttonRegistrar.TabIndex = 0
        Me.buttonRegistrar.Text = "Registrar"
        Me.buttonRegistrar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.FileName = "OpenFileDialog3"
        '
        'OpenFileDialog4
        '
        Me.OpenFileDialog4.FileName = "OpenFileDialog4"
        '
        'OpenFileDialog5
        '
        Me.OpenFileDialog5.FileName = "OpenFileDialog5"
        '
        'OpenFileDialog6
        '
        Me.OpenFileDialog6.FileName = "OpenFileDialog6"
        '
        'OpenFileDialog7
        '
        Me.OpenFileDialog7.FileName = "OpenFileDialog7"
        '
        'OpenFileDialog8
        '
        Me.OpenFileDialog8.FileName = "OpenFileDialog8"
        '
        'buttonConexion
        '
        Me.buttonConexion.Location = New System.Drawing.Point(12, 400)
        Me.buttonConexion.Name = "buttonConexion"
        Me.buttonConexion.Size = New System.Drawing.Size(148, 38)
        Me.buttonConexion.TabIndex = 1
        Me.buttonConexion.Text = "Conectar BD"
        Me.buttonConexion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(268, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Registro de usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Contraseña"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(255, 153)
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(323, 27)
        Me.textboxNombre.TabIndex = 6
        '
        'textBoxUsuario
        '
        Me.textBoxUsuario.Location = New System.Drawing.Point(255, 192)
        Me.textBoxUsuario.Name = "textBoxUsuario"
        Me.textBoxUsuario.Size = New System.Drawing.Size(323, 27)
        Me.textBoxUsuario.TabIndex = 7
        '
        'textBoxContra
        '
        Me.textBoxContra.Location = New System.Drawing.Point(255, 237)
        Me.textBoxContra.Name = "textBoxContra"
        Me.textBoxContra.Size = New System.Drawing.Size(323, 27)
        Me.textBoxContra.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.textBoxContra)
        Me.Controls.Add(Me.textBoxUsuario)
        Me.Controls.Add(Me.textboxNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonConexion)
        Me.Controls.Add(Me.buttonRegistrar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents buttonRegistrar As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents OpenFileDialog3 As OpenFileDialog
    Friend WithEvents OpenFileDialog4 As OpenFileDialog
    Friend WithEvents OpenFileDialog5 As OpenFileDialog
    Friend WithEvents OpenFileDialog6 As OpenFileDialog
    Friend WithEvents OpenFileDialog7 As OpenFileDialog
    Friend WithEvents OpenFileDialog8 As OpenFileDialog
    Friend WithEvents buttonConexion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents textboxNombre As TextBox
    Friend WithEvents textBoxUsuario As TextBox
    Friend WithEvents textBoxContra As TextBox
End Class
