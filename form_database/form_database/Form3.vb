Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class Form3

    Dim conn As New MySqlConnection
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Buat Tab Control
        For Each tc In {TabControl1}
            With tc
                .SuspendLayout()
                .SizeMode = TabSizeMode.Fixed
                .ItemSize = New Size(0, 1)
                .Appearance = TabAppearance.Buttons
                .ResumeLayout()
            End With
        Next

        'buat konek ke database
        dbconn = New MySqlConnection("Data Source=localhost;user id=root;database=data_siswa;password= ")
        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Error in connection, please check Database and connection server.")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click
        'buat nambah data ke data base
        sql = "INSERT INTO biodata_siswa VALUES ('" & nis.Text & "', '" & nama.Text & "', '" & kelas.Text & "', '" & tempat.Text & "', '" & tanggal.Text & "', '" & alamat.Text & "', '" & asal.Text & "')"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in saving to Database, Error is :" & ex.Message)
            Exit Sub
        End Try
        MsgBox("Data telah tesrimpan")

        'buat reset textbox
        nis.ResetText()
        nama.ResetText()
        kelas.ResetText()
        tempat.ResetText()
        tanggal.ResetText()
        alamat.ResetText()
        asal.ResetText()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "SELECT * FROM biodata_siswa"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()

            While dbread.Read
                DataGridView1.Rows.Add(dbread("nis"), dbread("nama"), dbread("kelas"),
                                   dbread("tempat_lahir"), dbread("tanggal_lahir"),
                                   dbread("alamat"), dbread("alamat_asal"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Eror in collecting data from Database. Eror is:" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try

        TabControl1.SelectedIndex = 1
    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        sql = "SELECT * FROM biodata_siswa WHERE nama like '%" & cari.Text & "%'"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()

            While dbread.Read
                ListBox1.Items.Add(dbread("nis") & " " & dbread("nama") & " " & dbread("kelas") & " " & dbread("tempat_lahir") & " " & dbread("tanggal_lahir") & " " & dbread("alamat") & " " & dbread("alamat_asal"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Eror is :" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try

        cari.ResetText()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        sql = "DELETE FROM biodata_siswa WHERE nis='" & hapus.Text & "'"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()

            While dbread.Read
                ListBox1.Items.Add(dbread("nis") & " " & dbread("nama") & " " & dbread("kelas") & " " & dbread("tempat") & " " & dbread("tanggal") & " " & dbread("alamat") & " " & dbread("asal"))
            End While
            MsgBox("Data berhasil dihapus")
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Eror is :" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try

        hapus.ResetText()
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        sql = "SELECT * FROM biodata_siswa"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()

            While dbread.Read
                DataGridView1.Rows.Add(dbread("nis"), dbread("nama"), dbread("kelas"),
                                   dbread("tempat_lahir"), dbread("tanggal_lahir"),
                                   dbread("alamat"), dbread("alamat_asal"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Eror in collecting data from Database. Eror is:" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Bikin tabel iTextSharp
        Dim pdfTable As New PdfPTable(DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 30
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1

        'nambah  Header
        For Each column As DataGridViewColumn In DataGridView1.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
            pdfTable.AddCell(cell)
        Next

        'nambah data
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                'pdfTable.AddCell(cell.Value)
                If cell.Value <> "" Then
                    pdfTable.AddCell(cell.Value)
                End If
            Next
        Next

        'Export ke PDF
        Dim folderPath As String = "E:\PDFs\"
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Using Stream As New FileStream(folderPath & "DataGridViewExport.pdf", FileMode.Create)
            Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            PdfWriter.GetInstance(pdfDoc, Stream)
            pdfDoc.Open()
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()
            Stream.Close()
        End Using

        MsgBox("File PDF terdapat di direktori E")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        sql = "SELECT FROM biodata_siswa WHERE nis='" & TextBox1.Text & " '"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()

            While dbread.Read
                nis2.Text = dbread("nis")
                nama2.Text = dbread("nama")
                kelas2.Text = dbread("kelas")
                tanggal2.Text = dbread("tanggal_lahir")
                tempat2.Text = dbread("tempat_lahir")
                alamat2.Text = dbread("alamat")
                asal2.Text = dbread("alamat_asal")
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Eror in collecting data from Database. Eror is:" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try

        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        sql = "UPDATE INTO biodata_siswa set VALUES ('" & nis.Text & "', '" & nama.Text & "', '" & kelas.Text & "', '" & tempat.Text & "', '" & tanggal.Text & "', '" & alamat.Text & "', '" & asal.Text & "') WHERE nis='" & TextBox1.Text & "'"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in saving to Database, Error is :" & ex.Message)
            Exit Sub
        End Try
        MsgBox("Data telah terubah")
        TabControl1.SelectedIndex = 1
    End Sub
End Class