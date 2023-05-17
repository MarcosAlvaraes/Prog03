Imports System.ComponentModel

Public Class Form5
    Private Sub btnEsconder_Click(sender As Object, e As EventArgs) Handles btnEsconder.Click
        Legenda.Hide()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Legenda.Show()
    End Sub

    Private Sub btnCorLegenda_Click(sender As Object, e As EventArgs) Handles btnCorLegenda.Click
        Legenda.BackColor = Color.FromArgb(0, 125, 0)
    End Sub

    Private Sub btnCorForm_Click(sender As Object, e As EventArgs) Handles btnCorForm.Click
        Me.BackColor = Color.FromArgb(125, 0, 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim aux As Integer = CInt(Int((100 * Rnd()) + 1))
        Legenda.Text = aux

    End Sub
End Class