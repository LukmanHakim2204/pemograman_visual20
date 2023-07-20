Public Class Form1
    Private Sub Apoteker2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Apoteker2ToolStripMenuItem.Click
        ApotekerForm.ShowDialog()
    End Sub

    Private Sub Obat2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Obat2ToolStripMenuItem.Click
        ObatForm.ShowDialog()
    End Sub

    Private Sub Costumer1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Costumer1ToolStripMenuItem.Click
        Customer1Form.ShowDialog()
    End Sub

    Private Sub Transaksi2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Transaksi2ToolStripMenuItem.Click
        TransaksiForm.ShowDialog()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MatikanSemuaMenu()

    End Sub

    Private Sub MatikanSemuaMenu()
        MenuAdminBar.Visible = False
        MenuApotekerBar.Visible = False
        MenuCustomerBar.Visible = False
        LoginBar.Visible = True
        LogoutBar.Visible = False
    End Sub

    Private Sub LoginBar_Click(sender As Object, e As EventArgs) Handles LoginBar.Click
        LoginForm.ShowDialog()

    End Sub

    Private Sub LogoutBar_Click(sender As Object, e As EventArgs) Handles LogoutBar.Click
        MatikanSemuaMenu()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Jika user login adalah Admin
        If (admin_role = True) Then
            MenuAdminBar.Visible = True
            MenuApotekerBar.Visible = False
            MenuCustomerBar.Visible = False
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

        'Jika user login adalah Dosen
        If (apoteker_role = True) Then
            MenuAdminBar.Visible = False
            MenuApotekerBar.Visible = True
            MenuCustomerBar.Visible = False
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

        'Jika user login adalah mahasiswa
        If (customer_role = True) Then
            MenuAdminBar.Visible = False
            MenuApotekerBar.Visible = False
            MenuCustomerBar.Visible = True
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If
    End Sub

    Private Sub ExitBar_Click(sender As Object, e As EventArgs) Handles ExitBar.Click
        End
    End Sub

    Private Sub Apoteker1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Apoteker1ToolStripMenuItem.Click
        ApotekerForm.ShowDialog()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObatToolStripMenuItem.Click
        ObatForm.ShowDialog()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        TransaksiForm.ShowDialog()
    End Sub

    Private Sub Costumer2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Costumer2ToolStripMenuItem.Click
        Customer1Form.ShowDialog()
    End Sub

    Private Sub Transaksi1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Transaksi1ToolStripMenuItem1.Click
        TransaksiForm.ShowDialog()
    End Sub

    Private Sub CostumerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CostumerToolStripMenuItem.Click
        Customer2Form.ShowDialog()
    End Sub

    Private Sub Obat3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Obat3ToolStripMenuItem.Click
        Obat2Form.ShowDialog()
    End Sub
End Class
