Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub From2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles From2ToolStripMenuItem.Click
        Dim F2 As New Form2
        F2.ShowDialog()
    End Sub

    Private Sub From3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles From3ToolStripMenuItem.Click
        Dim F3 As New Form3
        F3.ShowDialog()
    End Sub
End Class
