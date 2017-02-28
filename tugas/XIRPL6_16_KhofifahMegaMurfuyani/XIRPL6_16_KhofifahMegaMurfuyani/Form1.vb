Public Class Form1



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label4.Text = TextBox2.Text
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Private Sub FontStyleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontStyleToolStripMenuItem.Click

    End Sub

    Private Sub BoldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoldToolStripMenuItem.Click
        Label4.Font = New Font("Microsoft Sans Serif", Label4.Font.Size, Label4.Font.Style Xor FontStyle.Bold)
    End Sub

    Private Sub ItalicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItalicToolStripMenuItem.Click
        Label4.Font = New Font("Microsoft Sans Serif", Label4.Font.Size, Label4.Font.Style Xor FontStyle.Italic)
    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnderlineToolStripMenuItem.Click
        Label4.Font = New Font("Microsoft Sans Serif", Label4.Font.Size, Label4.Font.Style Xor FontStyle.Underline)
    End Sub

    Private Sub StrikeoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrikeoutToolStripMenuItem.Click
        Label4.Font = New Font("Microsoft Sans Serif", Label4.Font.Size, Label4.Font.Style Xor FontStyle.Strikeout)
    End Sub

    Private Sub RegulerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegulerToolStripMenuItem.Click
        Label4.Font = New Font("Microsoft Sans Serif", Label4.Font.Size, Label4.Font.Style Xor FontStyle.Regular)
    End Sub

    Private Sub MerahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MerahToolStripMenuItem.Click
        Label4.ForeColor = Color.Red
    End Sub

    Private Sub KuningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KuningToolStripMenuItem.Click
        Label4.ForeColor = Color.Yellow
    End Sub

    Private Sub HijauToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HijauToolStripMenuItem.Click
        Label4.ForeColor = Color.Green
    End Sub

    Private Sub BiruToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiruToolStripMenuItem.Click
        Label4.ForeColor = Color.Blue
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Anda akan menjalankan Program Sederhana milik Khofifah", "Kotak Pesan Khofifah",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        ComboBox1.Items.Add("Khofifah")
        ComboBox1.Items.Add("Mega")
        ComboBox1.Items.Add("Murfuyani")
        ComboBox1.Items.Add("Weavers")
        ComboBox1.Items.Add("Nemo")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(ComboBox1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub GreeToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
End Class
