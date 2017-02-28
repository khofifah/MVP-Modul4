Public Class Form1

    Dim userArr(2) As String
    Dim bioArr(6) As String
    Dim i As Integer


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

        userArr(0) = 0
        userArr(1) = 0
        bioArr(0) = tb3.Text
        bioArr(1) = tb6.Text
        bioArr(2) = ComboBox1.Text
        bioArr(3) = rtb1.Text
        bioArr(4) = tb7.Text
        bioArr(5) = kalender.Text

        ComboBox1.Items.Add("Squad 22")
        ComboBox1.Items.Add("Mascot 23")
        ComboBox1.Items.Add("24 Hours")
        ComboBox1.Items.Add("System 25")

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tb1.Text = userArr(0) And tb2.Text = userArr(1) Then
            TabControl1.SelectedIndex = 2

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
        userArr(0) = tb4.Text
        userArr(1) = tb5.Text
        bioArr(0) = tb3.Text
        bioArr(1) = tb6.Text
        bioArr(2) = ComboBox1.Text
        bioArr(3) = rtb1.Text
        bioArr(4) = tb7.Text
        bioArr(5) = kalender.Text

        ListBox1.Items.Add(tb3.Text)
        ListBox1.Items.Add(tb6.Text)
        ListBox1.Items.Add(ComboBox1.Text)
        ListBox1.Items.Add(rtb1.Text)
        ListBox1.Items.Add(tb7.Text)
        ListBox1.Items.Add(kalender.Text)
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SplashScreen1.Close()

        Close()

    End Sub

End Class
