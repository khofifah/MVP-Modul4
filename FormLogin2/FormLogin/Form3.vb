Public Class Form3
    Dim tabelArr() As String
    Dim table As String
    Dim hobiArr() As String = {"Membaca", "Menggambar", "Menulis", "Menari", "Menyanyi"}
    

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Squad 22")
        ComboBox1.Items.Add("Mascot 23")
        ComboBox1.Items.Add("24 Hours")
        ComboBox1.Items.Add("System 25")

        ComboBox2.Items.Add("Perempuan")
        ComboBox2.Items.Add("Laki-laki")

        For Each Item In hobiArr
            CheckedListBox1.Items.Add(Item.ToString())
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tabelArr(), Data As String
        Dim x, i As Integer
        x = CheckedListBox1.Items.Count - 1
        tabelArr = New String((8) - 1) {}
        tabelArr(0) = tb3.Text
        tabelArr(1) = ComboBox2.Text
        tabelArr(2) = ComboBox1.Text
        tabelArr(3) = tb7.Text
        tabelArr(4) = kalender.Text
        tabelArr(5) = telp.Text
        tabelArr(6) = rtb1.Text

        Data = ""
        For i = 0 To x
            If CheckedListBox1.GetItemChecked(i) Then
                Data = Data & CheckedListBox1.Items(i).ToString & ";"
            End If
        Next

        tabelArr(7) = Data

        table += 1
        DataGridView1.Rows.Add(table.ToString(),
                                tabelArr(0),
                                tabelArr(1),
                                tabelArr(2),
                                tabelArr(3),
                                tabelArr(4),
                                tabelArr(5),
                                tabelArr(6),
                                tabelArr(7))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tb3.ResetText()
        ComboBox2.ResetText()
        ComboBox1.ResetText()
        tb7.ResetText()
        kalender.ResetText()
        telp.ResetText()
        rtb1.ResetText()

        CheckedListBox1.Items.Clear()
        For Each item In hobiArr
            CheckedListBox1.Items.Add(item.ToString())
        Next

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Close()
        Me.Close()
        SplashScreen1.Close()

    End Sub
End Class