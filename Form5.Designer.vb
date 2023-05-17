<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnCorForm = New System.Windows.Forms.Button()
        Me.btnCorLegenda = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnEsconder = New System.Windows.Forms.Button()
        Me.Legenda = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.btnCorForm)
        Me.Panel1.Controls.Add(Me.btnCorLegenda)
        Me.Panel1.Controls.Add(Me.btnMostrar)
        Me.Panel1.Controls.Add(Me.btnEsconder)
        Me.Panel1.Controls.Add(Me.Legenda)
        Me.Panel1.Location = New System.Drawing.Point(27, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 359)
        Me.Panel1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(158, 244)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(253, 42)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Escrever na legenda um número aleatório entre 1 e 100"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnCorForm
        '
        Me.btnCorForm.Location = New System.Drawing.Point(311, 164)
        Me.btnCorForm.Name = "btnCorForm"
        Me.btnCorForm.Size = New System.Drawing.Size(159, 38)
        Me.btnCorForm.TabIndex = 4
        Me.btnCorForm.Text = "Mudar a cor de fundo do formulário"
        Me.btnCorForm.UseVisualStyleBackColor = True
        '
        'btnCorLegenda
        '
        Me.btnCorLegenda.Location = New System.Drawing.Point(65, 164)
        Me.btnCorLegenda.Name = "btnCorLegenda"
        Me.btnCorLegenda.Size = New System.Drawing.Size(159, 38)
        Me.btnCorLegenda.TabIndex = 3
        Me.btnCorLegenda.Text = "Mudar a cor de fundo da legenda"
        Me.btnCorLegenda.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(311, 102)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(127, 23)
        Me.btnMostrar.TabIndex = 2
        Me.btnMostrar.Text = "Mostrar a legenda"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnEsconder
        '
        Me.btnEsconder.Location = New System.Drawing.Point(107, 102)
        Me.btnEsconder.Name = "btnEsconder"
        Me.btnEsconder.Size = New System.Drawing.Size(117, 23)
        Me.btnEsconder.TabIndex = 1
        Me.btnEsconder.Text = "Esconder a legenda"
        Me.btnEsconder.UseVisualStyleBackColor = True
        '
        'Legenda
        '
        Me.Legenda.AutoSize = True
        Me.Legenda.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Legenda.Location = New System.Drawing.Point(158, 40)
        Me.Legenda.Name = "Legenda"
        Me.Legenda.Size = New System.Drawing.Size(243, 37)
        Me.Legenda.TabIndex = 0
        Me.Legenda.Text = "Isto é uma legenda"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 409)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents btnCorForm As Button
    Friend WithEvents btnCorLegenda As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnEsconder As Button
    Friend WithEvents Legenda As Label
End Class
