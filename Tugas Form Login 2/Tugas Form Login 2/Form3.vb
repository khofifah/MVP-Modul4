Public Class Form3
    Dim DataDiri As New ArrayList()
    Dim user As String
    Dim pass As String
    Dim nm As String
    Dim tl As String
    Dim jk As String
    Dim almt As String
    Dim phn As String
    Dim hby As String
    Dim nmat As String
    Dim nbi As String

    Dim Counterdata As Integer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each tc In {TabControl1}
            With tc
                .SuspendLayout()
                .SizeMode = TabSizeMode.Fixed
                .ItemSize = New Size(0, 1)
                .Appearance = TabAppearance.Buttons
                .ResumeLayout()
            End With
        Next

        ComboBox1.Items.Add("Male")
        ComboBox1.Items.Add("Female")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim hb As String
        Dim cek, i As Integer

        cek = CheckedListBox1.Items.Count - 1

        For i = 0 To cek
            If CheckedListBox1.GetItemChecked(i) Then
                hb = hb &
                    CheckedListBox1.Items(i).ToString & ","
            End If
        Next

        If Not IsNumeric(TextBox5.Text) Then
            MsgBox("No Telp Harus Angka !", vbInformation)
            TextBox5.Text = ""
        Else
            ''Memasukkan Data ke Array
            user = TextBox1.Text
            pass = TextBox2.Text
            nm = TextBox3.Text
            tl = DateTimePicker1.Text
            jk = ComboBox1.Text
            almt = TextBox4.Text
            phn = TextBox5.Text
            hby = hb
            nmat = TextBox6.Text
            nbi = TextBox7.Text
            Counterdata += 1
            DataGridView1.Rows.Add(Counterdata.ToString(),
                                   user,
                                   pass,
                                   nm,
                                   tl,
                                   jk,
                                   almt,
                                   phn,
                                   hby,
                                   nmat,
                                   nbi)
            MsgBox("Data Anda Berhasil Disimpan")
            TabControl1.SelectedTab = TabPage2
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        DateTimePicker1.ResetText()
        ComboBox1.ResetText()
        TextBox4.ResetText()
        TextBox5.ResetText()
        TextBox6.ResetText()
        TextBox7.ResetText()
        CheckedListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage1

        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        TextBox4.ResetText()
        TextBox5.ResetText()
        TextBox6.ResetText()
        TextBox7.ResetText()
        CheckedListBox1.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim n1(nmat) As Integer
        Dim indexMin As Integer
        Dim temp As Integer

        For i = 0 To n1.Length - 1
            indexMin = i
            For j = i To n1.Length - 1
                If n1(j) < n1(indexMin) Then
                    indexMin = j
                End If
            Next

            temp = n1(i)
            n1(i) = n1(indexMin)
            n1(indexMin) = temp
        Next

        For i = 0 To n1.Length - 1
            DataGridView1.Sort(DataGridView1.Columns(9), System.ComponentModel.ListSortDirection.Descending)
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim n2(nbi) As Integer
        Dim indexMin As Integer
        Dim temp As Integer

        For i = 0 To n2.Length - 1
            indexMin = i
            For j = i To n2.Length - 1
                If n2(j) < n2(indexMin) Then
                    indexMin = j
                End If
            Next

            temp = n2(i)
            n2(i) = n2(indexMin)
            n2(indexMin) = temp
        Next

        For i = 0 To n2.Length - 1
            DataGridView1.Sort(DataGridView1.Columns(10), System.ComponentModel.ListSortDirection.Descending)
        Next
    End Sub
End Class