Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtMasaKerja.Text) >= 20) Then
            txtKeterangan.Text = "Anda mendapat bonus mobil suzuki ayla"

        ElseIf (txtMasaKerja.Text >= 15) Then
            txtKeterangan.Text = "Anda mendapat bonus motor"

        ElseIf (txtMasaKerja.Text >= 10) Then
            txtKeterangan.Text = "Anda mendapat bonus uang belanja RP.3.500.000"

        ElseIf (txtMasaKerja.Text >= 5) Then
            txtKeterangan.Text = "Anda mendapat bonus emas 1gram"

        Else
            txtKeterangan.Text = "Maaf anda belum layak dapat bonus"
        End If
    End Sub
End Class