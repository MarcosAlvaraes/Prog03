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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrimeiroNumero = New System.Windows.Forms.TextBox()
        Me.txtSegundoNumero = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSomar = New System.Windows.Forms.Button()
        Me.btnSubtrair = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDividir)
        Me.Panel1.Controls.Add(Me.btnMultiplicar)
        Me.Panel1.Controls.Add(Me.btnSubtrair)
        Me.Panel1.Controls.Add(Me.btnSomar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtResultado)
        Me.Panel1.Controls.Add(Me.txtSegundoNumero)
        Me.Panel1.Controls.Add(Me.txtPrimeiroNumero)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(42, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 365)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Introduza o 2º valor numérico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduza o 1º valor numérico"
        '
        'txtPrimeiroNumero
        '
        Me.txtPrimeiroNumero.Location = New System.Drawing.Point(237, 32)
        Me.txtPrimeiroNumero.Name = "txtPrimeiroNumero"
        Me.txtPrimeiroNumero.Size = New System.Drawing.Size(100, 23)
        Me.txtPrimeiroNumero.TabIndex = 2
        '
        'txtSegundoNumero
        '
        Me.txtSegundoNumero.Location = New System.Drawing.Point(237, 83)
        Me.txtSegundoNumero.Name = "txtSegundoNumero"
        Me.txtSegundoNumero.Size = New System.Drawing.Size(100, 23)
        Me.txtSegundoNumero.TabIndex = 3
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(237, 143)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 23)
        Me.txtResultado.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultado ->"
        '
        'btnSomar
        '
        Me.btnSomar.Location = New System.Drawing.Point(67, 218)
        Me.btnSomar.Name = "btnSomar"
        Me.btnSomar.Size = New System.Drawing.Size(75, 23)
        Me.btnSomar.TabIndex = 6
        Me.btnSomar.Text = "Somar"
        Me.btnSomar.UseVisualStyleBackColor = True
        '
        'btnSubtrair
        '
        Me.btnSubtrair.Location = New System.Drawing.Point(237, 218)
        Me.btnSubtrair.Name = "btnSubtrair"
        Me.btnSubtrair.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtrair.TabIndex = 7
        Me.btnSubtrair.Text = "Subtrair"
        Me.btnSubtrair.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Location = New System.Drawing.Point(67, 278)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplicar.TabIndex = 8
        Me.btnMultiplicar.Text = "Multiplicar"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Location = New System.Drawing.Point(237, 278)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(75, 23)
        Me.btnDividir.TabIndex = 9
        Me.btnDividir.Text = "Dividir"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 425)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

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
