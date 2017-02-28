Public Class Form1

    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        Label2.Text = TextBox1.Text

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        End
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label2.ForeColor = Color.Red
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Label2.ForeColor = Color.Yellow
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label2.ForeColor = Color.Green
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label2.ForeColor = Color.Blue
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Label2.Font = New Font("Microsoft Sans Serif", Label2.Font.Size, Label2.Font.Style Xor FontStyle.Bold)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Label2.Font = New Font("Microsoft Sans Serif", Label2.Font.Size, Label2.Font.Style Xor FontStyle.Underline)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Label2.Font = New Font("Microsoft Sans Serif", Label2.Font.Size, Label2.Font.Style Xor FontStyle.Italic)
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Label2.Font = New Font("Microsoft Sans Serif", Label2.Font.Size, Label2.Font.Style Xor FontStyle.Strikeout)
    End Sub
End Class
