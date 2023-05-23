<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Panel1 = New Panel()
        txtVolume = New TextBox()
        btn = New Button()
        txtAltura = New TextBox()
        txtLargura = New TextBox()
        txtComprimento = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtVolume)
        Panel1.Controls.Add(btn)
        Panel1.Controls.Add(txtAltura)
        Panel1.Controls.Add(txtLargura)
        Panel1.Controls.Add(txtComprimento)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(16, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(535, 254)
        Panel1.TabIndex = 0
        ' 
        ' txtVolume
        ' 
        txtVolume.Location = New Point(282, 209)
        txtVolume.Name = "txtVolume"
        txtVolume.Size = New Size(168, 23)
        txtVolume.TabIndex = 8
        ' 
        ' btn
        ' 
        btn.Location = New Point(83, 209)
        btn.Name = "btn"
        btn.Size = New Size(143, 23)
        btn.TabIndex = 7
        btn.Text = "Calcular volume"
        btn.UseVisualStyleBackColor = True
        ' 
        ' txtAltura
        ' 
        txtAltura.Location = New Point(208, 150)
        txtAltura.Name = "txtAltura"
        txtAltura.Size = New Size(179, 23)
        txtAltura.TabIndex = 6
        ' 
        ' txtLargura
        ' 
        txtLargura.Location = New Point(208, 101)
        txtLargura.Name = "txtLargura"
        txtLargura.Size = New Size(179, 23)
        txtLargura.TabIndex = 5
        ' 
        ' txtComprimento
        ' 
        txtComprimento.Location = New Point(208, 54)
        txtComprimento.Name = "txtComprimento"
        txtComprimento.Size = New Size(179, 23)
        txtComprimento.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(155, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 3
        Label4.Text = "Altura="
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(144, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 2
        Label3.Text = "Largura= "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(112, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 15)
        Label2.TabIndex = 1
        Label2.Text = "Comprimento="
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 15)
        Label1.TabIndex = 0
        Label1.Text = "Calcular o volume de um tanque"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 271)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents btn As Button
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtLargura As TextBox
    Friend WithEvents txtComprimento As TextBox
End Class
