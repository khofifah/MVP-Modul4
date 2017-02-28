Public Class Form1

    Dim Data As New ArrayList
    Dim nama As New ArrayList
    Dim tgl As New ArrayList
    Dim pbo As New ArrayList
    Dim dsk As New ArrayList

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Data.Insert(0, TextBox1.Text)
        Data.Insert(1, TextBox2.Text)
        Data.Insert(2, TextBox3.Text)
        Data.Insert(3, TextBox4.Text)

        DataGridView1.Rows.Add(Data(0), Data(1), Data(2), Data(3))

        nama.Add(TextBox1.Text)
        tgl.Add(TextBox2.Text)
        pbo.Add(TextBox3.Text)
        dsk.Add(TextBox4.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim indexMin, i, j, itemp As Integer
        Dim temp As String

        For i = 0 To pbo.Count - 1
            indexMin = i
            For j = i + 1 To pbo.Count - 1
                If pbo(j) < pbo(indexMin) Then
                    indexMin = j
                End If
            Next

            temp = nama(i)
            nama(i) = nama(indexMin)
            nama(indexMin) = temp

            temp = tgl(i)
            tgl(i) = tgl(indexMin)
            tgl(indexMin) = temp

            itemp = pbo(i)
            pbo(i) = pbo(indexMin)
            pbo(indexMin) = itemp

            itemp = dsk(i)
            dsk(i) = dsk(indexMin)
            dsk(indexMin) = itemp

        Next

        DataGridView1.Rows.Clear()
        For i = 0 To pbo.Count - 1
            DataGridView1.Rows.Add(nama(i), tgl(i), pbo(i), dsk(i))

        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim indexMin, i, j, itemp As Integer
        Dim temp As String

        For i = 0 To dsk.Count - 1
            indexMin = i
            For j = 0 To dsk.Count - 1
                If dsk(j) > dsk(indexMin) Then
                    indexMin = j
                End If
            Next

            temp = nama(i)
            nama(i) = nama(indexMin)
            nama(indexMin) = temp

            temp = tgl(i)
            tgl(i) = tgl(indexMin)
            tgl(indexMin) = temp

            itemp = pbo(i)
            pbo(i) = pbo(indexMin)
            pbo(indexMin) = itemp

            itemp = dsk(i)
            dsk(i) = dsk(indexMin)
            dsk(indexMin) = itemp

        Next

        DataGridView1.Rows.Clear()
        For i = 0 To dsk.Count - 1
            DataGridView1.Rows.Add(nama(i), tgl(i), pbo(i), dsk(i))
        Next
    End Sub
End Class
