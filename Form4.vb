Public Class Form4
    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        Dim aux As String

        If txtPrimeiroNumero.TextLength <> 0 And txtSegundoNumero.TextLength <> 0 Then
            aux = Val(txtPrimeiroNumero.Text) + Val(txtSegundoNumero.Text)
            txtResultado.Text = aux
        End If
    End Sub

    Private Sub btnSubtrair_Click(sender As Object, e As EventArgs) Handles btnSubtrair.Click
        Dim aux As String

        If txtPrimeiroNumero.TextLength <> 0 And txtSegundoNumero.TextLength <> 0 Then
            aux = Val(txtPrimeiroNumero.Text) - Val(txtSegundoNumero.Text)
            txtResultado.Text = aux
        End If
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        Dim aux As String

        If txtPrimeiroNumero.TextLength <> 0 And txtSegundoNumero.TextLength <> 0 Then
            aux = Val(txtPrimeiroNumero.Text) * Val(txtSegundoNumero.Text)
            txtResultado.Text = aux
        End If
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        Dim aux As String

        If txtPrimeiroNumero.TextLength <> 0 And txtSegundoNumero.TextLength <> 0 Then
            aux = Val(txtPrimeiroNumero.Text) / Val(txtSegundoNumero.Text)
            txtResultado.Text = aux
        End If
    End Sub
End Class