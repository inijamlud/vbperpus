Imports System.Data.Odbc

Public Class Login
    Sub awal()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi()
        If txtUsername.Text = "" Then
            MsgBox("Username tidak boleh kosong!", MsgBoxStyle.Exclamation, "Kosong!")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Kosong!")
            txtPassword.Focus()
        Else
            Dim query As String
            query = "SELECT * FROM petugas WHERE nama_petugas='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "'"
            cmd = New OdbcCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Login")
                awal()
                Hide()
                With Pinjam
                    .txtPetugas.Text = dr.Item("nama_petugas")
                End With

                With Kembali
                    .txtPetugas.Text = dr.Item("nama_petugas")
                End With

                With Dashboard
                    .Show()
                    .txtadminname.Text = "Aplikasi Perpustakaan | " + dr.Item("nama_petugas")
                End With

            Else
                MsgBox("Username atau Password salah!", vbOKOnly, "Warning")
                awal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
