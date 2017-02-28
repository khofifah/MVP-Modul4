Public Class Form4

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each tc In {TabControl1}
            With tc
                .SuspendLayout()
                .SizeMode = TabSizeMode.Fixed
                .ItemSize = New Size(0, 1)
                .Appearance = TabAppearance.Buttons
                .ResumeLayout()
            End With
        Next
    End Sub

    Private Sub Halaman1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Halaman1ToolStripMenuItem.Click
        TabControl1.SelectedIndex = 0

    End Sub

    Private Sub Halaman2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Halaman2ToolStripMenuItem.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class