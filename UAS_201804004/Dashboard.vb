Public Class Dashboard

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Petugas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainPanel.Controls.Clear()
        Petugas.TopLevel = False
        MainPanel.Controls.Add(Petugas)
        Petugas.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MainPanel.Controls.Clear()
        Anggota.TopLevel = False
        MainPanel.Controls.Add(Anggota)
        Anggota.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MainPanel.Controls.Clear()
        Buku.TopLevel = False
        MainPanel.Controls.Add(Buku)
        Buku.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MainPanel.Controls.Clear()
        Pinjam.TopLevel = False
        MainPanel.Controls.Add(Pinjam)
        Pinjam.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            If MsgBox("Anda yakin akan keluar?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
                End
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        End
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MainPanel.Controls.Clear()
        About.TopLevel = False
        MainPanel.Controls.Add(About)
        About.Show()
    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        MainPanel.Controls.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MainPanel.Controls.Clear()
        Kembali.TopLevel = False
        MainPanel.Controls.Add(Kembali)
        Kembali.Show()
    End Sub

End Class