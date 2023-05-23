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
        Panel1 = New Panel()
        Button5 = New Button()
        btnCorForm = New Button()
        btnCorLegenda = New Button()
        btnMostrar = New Button()
        btnEsconder = New Button()
        Legenda = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(btnCorForm)
        Panel1.Controls.Add(btnCorLegenda)
        Panel1.Controls.Add(btnMostrar)
        Panel1.Controls.Add(btnEsconder)
        Panel1.Controls.Add(Legenda)
        Panel1.Location = New Point(2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(557, 263)
        Panel1.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(31, 208)
        Button5.Name = "Button5"
        Button5.Size = New Size(493, 38)
        Button5.TabIndex = 5
        Button5.Text = "Escrever na legenda um número aleatório entre 1 e 100"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' btnCorForm
        ' 
        btnCorForm.Location = New Point(305, 136)
        btnCorForm.Name = "btnCorForm"
        btnCorForm.Size = New Size(219, 38)
        btnCorForm.TabIndex = 4
        btnCorForm.Text = "Mudar a cor de fundo do formulário"
        btnCorForm.UseVisualStyleBackColor = True
        ' 
        ' btnCorLegenda
        ' 
        btnCorLegenda.Location = New Point(31, 136)
        btnCorLegenda.Name = "btnCorLegenda"
        btnCorLegenda.Size = New Size(219, 38)
        btnCorLegenda.TabIndex = 3
        btnCorLegenda.Text = "Mudar a cor de fundo da legenda"
        btnCorLegenda.UseVisualStyleBackColor = True
        ' 
        ' btnMostrar
        ' 
        btnMostrar.Location = New Point(305, 62)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(219, 38)
        btnMostrar.TabIndex = 2
        btnMostrar.Text = "Mostrar a legenda"
        btnMostrar.UseVisualStyleBackColor = True
        ' 
        ' btnEsconder
        ' 
        btnEsconder.Location = New Point(31, 62)
        btnEsconder.Name = "btnEsconder"
        btnEsconder.Size = New Size(219, 38)
        btnEsconder.TabIndex = 1
        btnEsconder.Text = "Esconder a legenda"
        btnEsconder.UseVisualStyleBackColor = True
        ' 
        ' Legenda
        ' 
        Legenda.AutoSize = True
        Legenda.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Legenda.Location = New Point(176, 14)
        Legenda.Name = "Legenda"
        Legenda.Size = New Size(219, 32)
        Legenda.TabIndex = 0
        Legenda.Text = "Isto é uma legenda"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 271)
        Controls.Add(Panel1)
        Name = "Form5"
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents btnCorForm As Button
    Friend WithEvents btnCorLegenda As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnEsconder As Button
    Friend WithEvents Legenda As Label
End Class
