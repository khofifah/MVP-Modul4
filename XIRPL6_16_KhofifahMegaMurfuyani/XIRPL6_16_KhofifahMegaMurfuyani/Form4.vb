Public Class Form4

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub BoldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoldToolStripMenuItem.Click
        Label2.Font = New Font("Microsoft Sans Serif", Label2.Font.Size, Label2.Font.Style Xor FontStyle.Bold)
    End Sub

    Private Sub FontStyleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontStyleToolStripMenuItem.Click

    End Sub

    Private Sub ItalicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItalicToolStripMenuItem.Click
        Label2.Font = New Font("Microsoft Sans Serif", Label2.Font.Size, Label2.Font.Style Xor FontStyle.Italic)
    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnderlineToolStripMenuItem.Click
        Label2.Font = New Font("Microsoft Sans Serif", Label2.Font.Size, Label2.Font.Style Xor FontStyle.Underline)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label2.Text = TextBox1.Text
    End Sub

    Private Sub StrikeoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrikeoutToolStripMenuItem.Click
        Label2.Font = New Font("Microsoft Sans Serif", Label2.Font.Size, Label2.Font.Style Xor FontStyle.Strikeout)
    End Sub

    Private Sub RegulerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegulerToolStripMenuItem.Click
        Label2.Font = New Font("Microsoft Sans Serif", Label2.Font.Size, Label2.Font.Style Xor FontStyle.Regular)
    End Sub

    Private Sub MerahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MerahToolStripMenuItem.Click
        Label2.ForeColor = Color.Red
    End Sub

    Private Sub KuningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KuningToolStripMenuItem.Click
        Label2.ForeColor = Color.Yellow
    End Sub

    Private Sub HijauToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HijauToolStripMenuItem.Click
        Label2.ForeColor = Color.Green
    End Sub

    Private Sub BiruToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiruToolStripMenuItem.Click
        Label2.ForeColor = Color.Blue
    End Sub

    Private Sub KuningToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KuningToolStripMenuItem1.Click
        Label2.ForeColor = Color.Yellow
    End Sub
End Class