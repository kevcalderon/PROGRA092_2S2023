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
        Me.buttonConexion = New System.Windows.Forms.Button()
        Me.buttonEliminar = New System.Windows.Forms.Button()
        Me.listArtistas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonConexion
        '
        Me.buttonConexion.Location = New System.Drawing.Point(26, 398)
        Me.buttonConexion.Name = "buttonConexion"
        Me.buttonConexion.Size = New System.Drawing.Size(107, 40)
        Me.buttonConexion.TabIndex = 0
        Me.buttonConexion.Text = "Conexion"
        Me.buttonConexion.UseVisualStyleBackColor = True
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Location = New System.Drawing.Point(327, 331)
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(163, 39)
        Me.buttonEliminar.TabIndex = 1
        Me.buttonEliminar.Text = "Eliminar Artista"
        Me.buttonEliminar.UseVisualStyleBackColor = True
        '
        'listArtistas
        '
        Me.listArtistas.FormattingEnabled = True
        Me.listArtistas.ItemHeight = 20
        Me.listArtistas.Location = New System.Drawing.Point(168, 125)
        Me.listArtistas.Name = "listArtistas"
        Me.listArtistas.Size = New System.Drawing.Size(474, 184)
        Me.listArtistas.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(168, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 47)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ELIMINAR ARTISTAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listArtistas)
        Me.Controls.Add(Me.buttonEliminar)
        Me.Controls.Add(Me.buttonConexion)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonConexion As Button
    Friend WithEvents buttonEliminar As Button
    Friend WithEvents listArtistas As ListBox
    Friend WithEvents Label1 As Label
End Class
