Imports System.Runtime.Intrinsics.X86
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form3
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim aux As String

        If txtAltura.TextLength <> 0 And txtComprimento.TextLength <> 0 And txtLargura.TextLength <> 0 Then
            aux = txtAltura.Text * txtComprimento.Text * txtLargura.Text
            txtVolume.Text = aux
        End If

    End Sub
End Class