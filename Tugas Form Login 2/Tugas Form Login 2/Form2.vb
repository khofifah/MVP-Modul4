Public Class Form2
    Dim mystring As New List(Of String)
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub Halaman1ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Halaman2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mystring.Insert(0, nama.Text)
        mystring.Insert(1, no.Text)
        mystring.Insert(2, alamat.Text)
        mystring.Insert(3, asal.Text)
        mystring.Insert(4, tgl.Text)
        TabControl1.SelectedTab = TabPage2
        na.Text = nama.Text
        noo.Text = no.Text
        ala.Text = alamat.Text
        asa.Text = asal.Text
        tl.Text = tgl.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

End Class