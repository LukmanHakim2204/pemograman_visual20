Public Class Form1

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim diagonal1, diagonal2, sisia, sisib, sisic, sisid, luas, keliling As Integer
        diagonal1 = Val(txtD1.Text)
        diagonal2 = Val(txtD2.Text)
        sisia = Val(txtSisiA.Text)
        sisib = Val(txtSisiB.Text)
        sisic = Val(txtSIsiC.Text)
        sisid = Val(txtSisiD.Text)
        luas = 0.5 * diagonal1 * diagonal2
        keliling = sisia + sisib + sisic + sisid
        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
