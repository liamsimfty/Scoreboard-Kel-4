Imports System.Reflection.Emit

Public Class lblFoulsTeamB
    ' Deklarasi variabel untuk menyimpan skor dan waktu
    Dim ScoreB, ScoreA, FoulsA, FoulsB, Babak, Waktu, Waktu2 As Integer

    ' Fungsi untuk mengatur nilai waktu
    Public Sub SetTimerValue(value1 As Integer, value2 As Integer)
        ' value1 adalah detik, value2 adalah menit
        Waktu = value1
        Waktu2 = value2
        lblWaktu.Text = Waktu.ToString()  ' Tampilkan detik
        lblWaktu2.Text = Waktu2.ToString() ' Tampilkan menit
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblScoreTeamA.Click
        ScoreA = 0  ' Set skor tim A ke 0 ketika label diklik
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        FoulsA = 0  ' Set fouls tim A ke 0 ketika label diklik
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles lblFoulsTeamA.Click
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnResetTimer.Click
        ' Mengatur ulang timer
        Timer1.Stop()  ' Hentikan timer
        Waktu = 0      ' Set detik ke 0
        Waktu2 = 0     ' Set menit ke 0
        lblWaktu.Text = "0"    ' Tampilkan 0 untuk detik
        lblWaktu2.Text = "0"   ' Tampilkan 0 untuk menit
    End Sub

    Private Sub btnAddScoreTeamA_Click(sender As Object, e As EventArgs) Handles btnAddScoreTeamA.Click
        ScoreA = ScoreA + 1  ' Tambah skor tim A
        lblScoreTeamA.Text = ScoreA  ' Tampilkan skor tim A
    End Sub

    Private Sub btnAddScoreTeamB_Click(sender As Object, e As EventArgs) Handles btnAddScoreTeamB.Click
        ScoreB = ScoreB + 1  ' Tambah skor tim B
        lblScoreTeamB.Text = ScoreB  ' Tampilkan skor tim B
    End Sub

    Private Sub lblScoreTeamB_Click(sender As Object, e As EventArgs) Handles lblScoreTeamB.Click
        ScoreB = 0  ' Set skor tim B ke 0 ketika label diklik
    End Sub

    Private Sub btnSubtractScoreTeamA_Click(sender As Object, e As EventArgs) Handles btnSubtractScoreTeamA.Click
        ' Mengurangi skor tim A jika lebih dari 0
        If ScoreA > 0 Then
            ScoreA -= 1
        End If
        lblScoreTeamA.Text = ScoreA  ' Tampilkan skor tim A
    End Sub

    Private Sub btnSubtractScoreTeamB_Click(sender As Object, e As EventArgs) Handles btnSubtractScoreTeamB.Click
        ' Mengurangi skor tim B jika lebih dari 0
        If ScoreB > 0 Then
            ScoreB -= 1
        End If
        lblScoreTeamB.Text = ScoreB  ' Tampilkan skor tim B
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
    End Sub

    Private Sub btnNextPeriod_Click(sender As Object, e As EventArgs) Handles btnNextPeriod.Click
        Babak = Babak + 1  ' Tambah babak
        lblPeriod.Text = Babak  ' Tampilkan babak
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Tambah fouls untuk tim A
        FoulsA = FoulsA + 1
        Label4.Text = FoulsA  ' Tampilkan fouls tim A
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        FoulsB = 0  ' Set fouls tim B ke 0 ketika label diklik
    End Sub

    Private Sub btnAddFoulTeamB_Click(sender As Object, e As EventArgs) Handles btnAddFoulTeamB.Click
        ' Tambah fouls untuk tim B
        FoulsB = FoulsB + 1
        Label5.Text = FoulsB  ' Tampilkan fouls tim B
    End Sub

    Private Sub btnResetAll_Click(sender As Object, e As EventArgs) Handles btnResetAll.Click
        ' Menghentikan timer jika sedang berjalan
        Timer1.Stop()

        ' Mengatur semua nilai variabel kembali ke 0
        ScoreA = 0
        ScoreB = 0
        FoulsA = 0
        FoulsB = 0
        Babak = 0
        Waktu = 0
        Waktu2 = 0

        ' Mengatur label kembali ke nilai awal
        lblScoreTeamA.Text = ScoreA.ToString()
        lblScoreTeamB.Text = ScoreB.ToString()
        Label4.Text = FoulsA.ToString() ' Label untuk FoulsA
        Label5.Text = FoulsB.ToString() ' Label untuk FoulsB
        lblPeriod.Text = Babak.ToString()
        lblWaktu.Text = "0"  ' Reset timer detik
        lblWaktu2.Text = "0"  ' Reset timer menit

        ' Opsional: Tampilkan pesan bahwa semua telah di-reset
        MessageBox.Show("Semua nilai telah di-reset!")
    End Sub

    Private Sub lblTimer_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub RichTextBox3_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Logika untuk mengatur timer setiap detik
        If Waktu > 0 Then
            Waktu -= 1  ' Kurangi detik
            lblWaktu.Text = Waktu.ToString()  ' Tampilkan detik
        ElseIf Waktu2 > 0 Then
            ' Jika detik habis dan masih ada menit
            Waktu2 -= 1  ' Kurangi menit
            Waktu = 59   ' Reset detik ke 59
            lblWaktu2.Text = Waktu2.ToString()  ' Tampilkan menit
            lblWaktu.Text = Waktu.ToString()  ' Tampilkan detik
        Else
            Timer1.Stop()  ' Hentikan timer jika kedua waktu habis
            MessageBox.Show("Waktu Habis!")  ' Tampilkan pesan waktu habis
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub lblTimer_Click_2(sender As Object, e As EventArgs) Handles lblWaktu2.Click
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles lblWaktu.Click
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newForm As New Form2() ' Buat instance baru dari Form2
        newForm.Show()  ' Tampilkan Form2
    End Sub

    Private Sub lblPeriod_Click(sender As Object, e As EventArgs) Handles lblPeriod.Click
        Babak = 0  ' Set babak ke 0 ketika label diklik
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnStopTimer.Click
        Timer1.Stop()  ' Hentikan timer
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStartTimer.Click
        ' Memulai timer jika ada waktu yang tersisa
        If Waktu > 0 OrElse Waktu2 > 0 Then
            lblWaktu.Text = Waktu.ToString()  ' Tampilkan detik
            lblWaktu2.Text = Waktu2.ToString()  ' Tampilkan menit
            Timer1.Start()  ' Mulai timer
        Else
            MessageBox.Show("Mohon set waktu terlebih dahulu!")  ' Tampilkan pesan jika tidak ada waktu
        End If
    End Sub

    Private Sub lblFoulsTeamB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Function FormatTime(minutes As Integer, seconds As Integer) As String
        ' Format waktu menjadi string dengan format mm:ss
        Return $"{minutes:00}:{seconds:00}"
    End Function

End Class
