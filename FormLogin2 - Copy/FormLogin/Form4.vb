Public Class Form4
    Dim userArr(2) As String
    Dim i As Integer

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each tc In {TabControl1}
            With tc
                .SuspendLayout()
                .SizeMode = TabSizeMode.Fixed
                .ItemSize = New Size(0, 1)
                .Appearance = TabAppearance.Buttons
                .ResumeLayout()
            End With
        Next

        userArr(0) = 0
        userArr(1) = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tb1.Text = userArr(0) And tb2.Text = userArr(1) Then
            Form3.Show()
            Me.Hide()

        Else
            i += 1
            Label13.Text = "Anda gagal " & i & " kali tersisa " & 3 - i & " percobaan"
        End If

        If i = 3 Then
            MsgBox("Username dan Password salah. Program akan otomatis tertutup.", vbOKOnly)
            End
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        userArr(0) = TextBox1.Text
        userArr(1) = TextBox2.Text
        TabControl1.SelectedIndex = 0
    End Sub
End Class