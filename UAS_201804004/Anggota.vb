Imports System.Data.Odbc

Public Class Anggota

    Sub NoAnggota()
        cmd = New OdbcCommand("SELECT id_anggota FROM anggota ORDER BY id_anggota DESC", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            txtId.Text = "A001"
        Else
            txtId.Text = "A" + Format(Microsoft.VisualBasic.Right(dr.Item("id_anggota"), 3) + 1, "000")
        End If
    End Sub

    Sub clear()
        txtNama.Clear()
        txtAlamat.Clear()
        txtId.Clear()
        txtTelp.Clear()
        txtEmail.Clear()
    End Sub

    Sub Awal()
        txtNama.Enabled = False
        txtAlamat.Enabled = False
        txtTelp.Enabled = False
        txtEmail.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnTambah.Enabled = True
        clear()
        TampilGrid()
    End Sub

    Sub Aktif()
        txtNama.Enabled = True
        txtAlamat.Enabled = True
        txtEmail.Enabled = True
        txtTelp.Enabled = True
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
    End Sub

    Sub caricell()
        cmd = New OdbcCommand("SELECT * FROM anggota WHERE id_anggota ='" & txtId.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub

    Sub caridata()
        cmd = New OdbcCommand("SELECT * FROM anggota WHERE id_anggota='" & txtCari.Text & "' OR nama_anggota ='" & txtCari.Text & "' OR alamat ='" & txtCari.Text & "' OR telp_anggota ='" & txtCari.Text & "' OR email_anggota ='" & txtCari.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub

    Sub fill()
        txtID.Text = dr.Item(0)
        txtNama.Text = dr.Item(1)
        txtAlamat.Text = dr.Item(2)
        txtTelp.Text = dr.Item(3)
        txtEmail.Text = dr.Item(4)
    End Sub

    Sub TampilGrid()
        da = New OdbcDataAdapter("SELECT * FROM anggota", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Anggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Awal()
        TampilGrid()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        btnSimpan.Text = "&SIMPAN"
        btnTambah.Enabled = False
        NoAnggota()
        Aktif()
        txtNama.Focus()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Awal()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "&SIMPAN" Then
            cmd = New OdbcCommand("INSERT INTO anggota VALUES('" & txtId.Text & "','" & txtNama.Text & "', '" & txtAlamat.Text & "', '" & txtTelp.Text & "', '" & txtEmail.Text & "')", conn)
            cmd.ExecuteNonQuery()
            Awal()
        ElseIf btnSimpan.Text = "&UBAH" Then
            cmd = New OdbcCommand("UPDATE anggota SET nama_anggota= '" & txtNama.Text & "', alamat='" & txtAlamat.Text & "', telp_anggota='" & txtTelp.Text & "', email_anggota='" & txtEmail.Text & "' WHERE id_anggota='" & txtId.Text & "'", conn)
            cmd.ExecuteNonQuery()
            Awal()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            If MsgBox("Anda yakin akan menghapus?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
                query = "DELETE FROM anggota WHERE id_anggota='" & txtId.Text & "'"
                cmd = New OdbcCommand(query, conn)
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Awal()
    End Sub

    Private Sub txtCari_Click(sender As Object, e As EventArgs) Handles txtCari.Click
        txtCari.Clear()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try
            If txtCari.Text = "" Then
                MsgBox("Parameter tidak boleh kosong", MsgBoxStyle.Critical, "Info")
                txtCari.Focus()
            Else
                caridata()
                If dr.HasRows Then
                    fill()
                Else
                    MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Critical, "Info")
                End If
                btnTambah.Enabled = False
                btnSimpan.Text = "&UBAH"
                Aktif()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        btnTambah.Enabled = False
        btnSimpan.Text = "&UBAH"
        txtId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        caricell()
        fill()
        Aktif()
    End Sub
End Class