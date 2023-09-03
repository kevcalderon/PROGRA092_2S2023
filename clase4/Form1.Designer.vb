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
        Me.cicloButton = New System.Windows.Forms.Button()
        Me.listBoxCiclos = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cicloButton
        '
        Me.cicloButton.Location = New System.Drawing.Point(226, 100)
        Me.cicloButton.Name = "cicloButton"
        Me.cicloButton.Size = New System.Drawing.Size(175, 65)
        Me.cicloButton.TabIndex = 0
        Me.cicloButton.Text = "Hacer ciclo"
        Me.cicloButton.UseVisualStyleBackColor = True
        '
        'listBoxCiclos
        '
        Me.listBoxCiclos.FormattingEnabled = True
        Me.listBoxCiclos.ItemHeight = 20
        Me.listBoxCiclos.Location = New System.Drawing.Point(55, 227)
        Me.listBoxCiclos.Name = "listBoxCiclos"
        Me.listBoxCiclos.Size = New System.Drawing.Size(711, 164)
        Me.listBoxCiclos.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.listBoxCiclos)
        Me.Controls.Add(Me.cicloButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cicloButton As Button
    Friend WithEvents listBoxCiclos As ListBox
End Class
