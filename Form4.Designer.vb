<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        btnDividir = New Button()
        btnMultiplicar = New Button()
        btnSubtrair = New Button()
        btnSomar = New Button()
        Label3 = New Label()
        txtResultado = New TextBox()
        txtSegundoNumero = New TextBox()
        txtPrimeiroNumero = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnDividir)
        Panel1.Controls.Add(btnMultiplicar)
        Panel1.Controls.Add(btnSubtrair)
        Panel1.Controls.Add(btnSomar)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtResultado)
        Panel1.Controls.Add(txtSegundoNumero)
        Panel1.Controls.Add(txtPrimeiroNumero)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(540, 265)
        Panel1.TabIndex = 0
        ' 
        ' btnDividir
        ' 
        btnDividir.Location = New Point(343, 220)
        btnDividir.Name = "btnDividir"
        btnDividir.Size = New Size(75, 23)
        btnDividir.TabIndex = 9
        btnDividir.Text = "Dividir"
        btnDividir.UseVisualStyleBackColor = True
        ' 
        ' btnMultiplicar
        ' 
        btnMultiplicar.Location = New Point(181, 220)
        btnMultiplicar.Name = "btnMultiplicar"
        btnMultiplicar.Size = New Size(75, 23)
        btnMultiplicar.TabIndex = 8
        btnMultiplicar.Text = "Multiplicar"
        btnMultiplicar.UseVisualStyleBackColor = True
        ' 
        ' btnSubtrair
        ' 
        btnSubtrair.Location = New Point(262, 178)
        btnSubtrair.Name = "btnSubtrair"
        btnSubtrair.Size = New Size(75, 23)
        btnSubtrair.TabIndex = 7
        btnSubtrair.Text = "Subtrair"
        btnSubtrair.UseVisualStyleBackColor = True
        ' 
        ' btnSomar
        ' 
        btnSomar.Location = New Point(100, 178)
        btnSomar.Name = "btnSomar"
        btnSomar.Size = New Size(75, 23)
        btnSomar.TabIndex = 6
        btnSomar.Text = "Somar"
        btnSomar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(209, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 15)
        Label3.TabIndex = 5
        Label3.Text = "Resultado ->"
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(286, 124)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(100, 23)
        txtResultado.TabIndex = 4
        ' 
        ' txtSegundoNumero
        ' 
        txtSegundoNumero.Location = New Point(286, 68)
        txtSegundoNumero.Name = "txtSegundoNumero"
        txtSegundoNumero.Size = New Size(100, 23)
        txtSegundoNumero.TabIndex = 3
        ' 
        ' txtPrimeiroNumero
        ' 
        txtPrimeiroNumero.Location = New Point(286, 17)
        txtPrimeiroNumero.Name = "txtPrimeiroNumero"
        txtPrimeiroNumero.Size = New Size(100, 23)
        txtPrimeiroNumero.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(116, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 15)
        Label2.TabIndex = 1
        Label2.Text = "Introduza o 2º valor numérico"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(116, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 15)
        Label1.TabIndex = 0
        Label1.Text = "Introduza o 1º valor numérico"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 271)
        Controls.Add(Panel1)
        Name = "Form4"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDividir As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnSubtrair As Button
    Friend WithEvents btnSomar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents txtSegundoNumero As TextBox
    Friend WithEvents txtPrimeiroNumero As TextBox
End Class
