Public Class Form1
    Dim userArr(4) As String
    Dim passArr(4) As String
    Dim data As New ArrayList()
    Dim i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Form Login"
        userArr(0) = "admin"
        passArr(0) = "admin"
        i = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = userArr(0) And TextBox2.Text = passArr(0) Then
            Form2.Show()
            Me.Hide()
        Else
            i = i + 1
            MsgBox("Anda salah memasukkan Password " & i & " kali")
            If i = 3 Then
                MsgBox("Anda sudah salah memasukkan Password 3 kali, maka program ini akan ditutup!", vbCritical)
                Close()
                End
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
