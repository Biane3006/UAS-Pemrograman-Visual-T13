Imports System.IO
Public Class FormEnkripsi

    'ClientAreaMove Handling'----------------------------------------

    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = HTCLIENT Then m.Result = HTCAPTION
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub
    '------------------------------------------------------------------------'

    Dim warna As Color
    Dim img1, img2 As Bitmap
    Dim n, n1 As Int64
    Dim hasil, hasil1, kode, kode1, data, data1, newHasil, newHasil1, textHexa, textHexaHasil As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Focus()
        data1 = TextBox1.Text
        newHasil1 = ""
        Enkripsi1()
        tbHasilEnkripsi.Text = newHasil1
    End Sub

    Private Sub Enkripsi()
        n = Len(data)
        For i = 1 To n
            hasil = Mid(data, i, 1)
            If hasil <> "#" Then
                If hasil = "A" Then
                    hasil = 10
                ElseIf hasil = "B" Then
                    hasil = 11
                ElseIf hasil = "C" Then
                    hasil = 12
                ElseIf hasil = "D" Then
                    hasil = 13
                ElseIf hasil = "E" Then
                    hasil = 14
                ElseIf hasil = "F" Then
                    hasil = 15
                End If

                kode = (Val(hasil) + Val(tbKunciEnkripsi.Text)) Mod 16

                If kode = 10 Then
                    kode = "A"
                ElseIf kode = 11 Then
                    kode = "B"
                ElseIf kode = 12 Then
                    kode = "C"
                ElseIf kode = 13 Then
                    kode = "D"
                ElseIf kode = 14 Then
                    kode = "E"
                ElseIf kode = 15 Then
                    kode = "F"
                End If
            Else
                kode = hasil
            End If
            newHasil = newHasil + kode
        Next
    End Sub

    Private Sub Enkripsi1()
        n1 = Len(data1)
        For l = 1 To n1
            hasil1 = Mid(data1, l, 1)
            If hasil1 <> "#" Then
                If hasil1 = "A" Then
                    hasil1 = 10
                ElseIf hasil1 = "B" Then
                    hasil1 = 11
                ElseIf hasil1 = "C" Then
                    hasil1 = 12
                ElseIf hasil1 = "D" Then
                    hasil1 = 13
                ElseIf hasil1 = "E" Then
                    hasil1 = 14
                ElseIf hasil1 = "F" Then
                    hasil1 = 15
                End If

                kode1 = (Val(hasil1) + Val(tbKunciEnkripsi.Text)) Mod 16

                If kode1 = 10 Then
                    kode1 = "A"
                ElseIf kode1 = 11 Then
                    kode1 = "B"
                ElseIf kode1 = 12 Then
                    kode1 = "C"
                ElseIf kode1 = 13 Then
                    kode1 = "D"
                ElseIf kode1 = 14 Then
                    kode1 = "E"
                ElseIf kode1 = 15 Then
                    kode1 = "F"
                End If
            Else
                kode1 = hasil1
            End If
            newHasil1 = newHasil1 + kode1
        Next
    End Sub

    Private Sub btnEnkripsi_Click(sender As Object, e As EventArgs) Handles btnEnkripsi.Click
        If tbKunciEnkripsi.Text = "" Then
            MessageBox.Show("Kunci Enkripsi Harus Diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            img1 = PictureBox1.Image
            img2 = New Bitmap(img1.Width, img1.Height)

            For y = 0 To (img1.Height - 1)
                For x = 0 To (img2.Width - 1)
                    warna = img1.GetPixel(x, y)

                    textHexa = ColorTranslator.ToHtml(Color.FromArgb(warna.R, warna.G, warna.B))
                    data = textHexa
                    Enkripsi()
                    textHexaHasil = newHasil
                    warna = ColorTranslator.FromHtml(textHexaHasil)

                    img2.SetPixel(x, y, warna)
                    newHasil = ""
                Next
            Next

            PictureBox1.Image = img2

            btnBrowse.Enabled = False
            btnSave.Enabled = True
            btnReset.Enabled = True
            btnEnkripsi.Enabled = True

            newHasil1 = ""
            data1 = tbHasilEnkripsi.Text
            Enkripsi1()
            tbHasilEnkripsi.Text = newHasil1
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Images Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Gambar yang akan di Enkripsi"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim imagePath As String = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(imagePath)
            btnReset.Enabled = True
            btnEnkripsi.Enabled = True
            btnSave.Enabled = False
            btnBrowse.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If PictureBox1.Image IsNot Nothing Then
            SaveFileDialog1.Filter = "PNG Image|*.png"
            SaveFileDialog1.Title = "Simpan Gambar Enkripsi"
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim savePath As String = SaveFileDialog1.FileName
                PictureBox1.Image.Save(savePath)
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        PictureBox1.Image = Nothing
        tbKunciEnkripsi.Text = ""
        tbHasilEnkripsi.Text = ""
        btnSave.Enabled = False
        btnReset.Enabled = False
        btnEnkripsi.Enabled = False
        btnBrowse.Enabled = True
        data1 = TextBox1.Text
        newHasil1 = ""
        Enkripsi1()
        tbHasilEnkripsi.Text = newHasil1
    End Sub

    Private Sub tbKunciEnkripsi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbKunciEnkripsi.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
