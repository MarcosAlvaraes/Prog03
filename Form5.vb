Imports System.ComponentModel

Public Class Form5
    Private Sub btnEsconder_Click(sender As Object, e As EventArgs) Handles btnEsconder.Click
        Legenda.Hide()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Legenda.Show()
    End Sub

    Private Sub btnCorLegenda_Click(sender As Object, e As EventArgs) Handles btnCorLegenda.Click
        Dim prim As Integer = CInt(Int((250 * Rnd()) + 1))
        Dim seg As Integer = CInt(Int((250 * Rnd()) + 1))
        Dim ter As Integer = CInt(Int((250 * Rnd()) + 1))
        Legenda.BackColor = Color.FromArgb(prim, seg, ter)
    End Sub

    Private Sub btnCorForm_Click(sender As Object, e As EventArgs) Handles btnCorForm.Click
        Dim prim As Integer = CInt(Int((250 * Rnd()) + 1))
        Dim seg As Integer = CInt(Int((250 * Rnd()) + 1))
        Dim ter As Integer = CInt(Int((250 * Rnd()) + 1))
        Me.BackColor = Color.FromArgb(prim, seg, ter)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim aux As Integer = CInt(Int((100 * Rnd()) + 1))
        Legenda.Text = aux

    End Sub
End Class