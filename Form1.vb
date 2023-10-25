Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Hitung.Click
        Dim Label2, Label3, Label4, Label5, Label6, Label7, Label8 As Integer

        Label2 = CInt(TextB.Text)
        Label3 = CInt(Jumlah.Text)
        Label4 = CInt(Diskon.Text)
        Label5 = CInt(Pajak.Text)
        Label7 = CInt(Bayar.Text)


        Dim hargaDiskon = Label2 * Label3 - (Label2 * Label3 * Label4 / 100)


        Label6 = hargaDiskon + (hargaDiskon * Label5 / 100)

        Label8 = Label7 - Label6

        Total.Text = CStr(Label6)
        Kembalian.Text = CStr(Label8)

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        NamaBarang.Text = ""
        TextB.Text = ""
        Jumlah.Text = ""
        Diskon.Text = ""
        Pajak.Text = ""
        Bayar.Text = ""
        Total.Text = ""
        Kembalian.Text = ""
    End Sub
End Class
