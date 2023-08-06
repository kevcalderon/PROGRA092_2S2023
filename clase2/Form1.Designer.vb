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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listBoxResultados = New System.Windows.Forms.ListBox()
        Me.checkBoxIf = New System.Windows.Forms.RadioButton()
        Me.checkBoxCase = New System.Windows.Forms.RadioButton()
        Me.buttonNota = New System.Windows.Forms.Button()
        Me.textBoxNota = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(241, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clase 2 - IF ELSE CASE"
        '
        'listBoxResultados
        '
        Me.listBoxResultados.FormattingEnabled = True
        Me.listBoxResultados.ItemHeight = 20
        Me.listBoxResultados.Location = New System.Drawing.Point(35, 363)
        Me.listBoxResultados.Name = "listBoxResultados"
        Me.listBoxResultados.Size = New System.Drawing.Size(752, 264)
        Me.listBoxResultados.TabIndex = 1
        '
        'checkBoxIf
        '
        Me.checkBoxIf.AutoSize = True
        Me.checkBoxIf.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.checkBoxIf.Location = New System.Drawing.Point(198, 140)
        Me.checkBoxIf.Name = "checkBoxIf"
        Me.checkBoxIf.Size = New System.Drawing.Size(105, 35)
        Me.checkBoxIf.TabIndex = 2
        Me.checkBoxIf.TabStop = True
        Me.checkBoxIf.Text = "IF ELSE"
        Me.checkBoxIf.UseVisualStyleBackColor = True
        '
        'checkBoxCase
        '
        Me.checkBoxCase.AutoSize = True
        Me.checkBoxCase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.checkBoxCase.Location = New System.Drawing.Point(403, 142)
        Me.checkBoxCase.Name = "checkBoxCase"
        Me.checkBoxCase.Size = New System.Drawing.Size(146, 32)
        Me.checkBoxCase.TabIndex = 3
        Me.checkBoxCase.TabStop = True
        Me.checkBoxCase.Text = "SELECT CASE"
        Me.checkBoxCase.UseVisualStyleBackColor = True
        '
        'buttonNota
        '
        Me.buttonNota.AutoSize = True
        Me.buttonNota.BackColor = System.Drawing.SystemColors.MenuText
        Me.buttonNota.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonNota.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonNota.Location = New System.Drawing.Point(419, 216)
        Me.buttonNota.Name = "buttonNota"
        Me.buttonNota.Size = New System.Drawing.Size(216, 49)
        Me.buttonNota.TabIndex = 4
        Me.buttonNota.Text = "Evalua tu nota"
        Me.buttonNota.UseVisualStyleBackColor = False
        '
        'textBoxNota
        '
        Me.textBoxNota.Location = New System.Drawing.Point(374, 88)
        Me.textBoxNota.Name = "textBoxNota"
        Me.textBoxNota.Size = New System.Drawing.Size(378, 27)
        Me.textBoxNota.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(49, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ingrese la nota del estudiante"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 120)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ingresa tu nota: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si es >= 90 Es una nota de A. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si es >=80  Es una nota de B. " &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si es >= 70 Es una nota de C." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Si es >= 60 es una nota de D. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "De lo contraio" &
    " es una nota de F"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(817, 661)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textBoxNota)
        Me.Controls.Add(Me.buttonNota)
        Me.Controls.Add(Me.checkBoxCase)
        Me.Controls.Add(Me.checkBoxIf)
        Me.Controls.Add(Me.listBoxResultados)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents listBoxResultados As ListBox
    Friend WithEvents checkBoxIf As RadioButton
    Friend WithEvents checkBoxCase As RadioButton
    Public WithEvents buttonNota As Button
    Friend WithEvents textBoxNota As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
