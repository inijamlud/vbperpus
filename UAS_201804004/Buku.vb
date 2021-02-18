Imports System.Data.Odbc

Public Class Buku

    Sub NoBuku()
        cmd = New OdbcCommand("SELECT id_buku FROM buku ORDER BY id_buku DESC", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            txtIDBuku.Text = "B001"
        Else
            txtIDBuku.Text = "B" + Format(Microsoft.VisualBasic.Right(dr.Item("id_buku"), 3) + 1, "000")
        End If
    End Sub

    Sub clear()
        txtJudul.Clear()
        txtPengarang.Clear()
        txtIDBuku.Clear()
        txtPenerbit.Clear()
        txtTahun.Clear()
        txtJml.Clear()
    End Sub

    Sub Awal()
        txtJudul.Enabled = False
        txtPengarang.Enabled = False
        txtPenerbit.Enabled = False
        txtTahun.Enabled = False
        txtJml.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnTambah.Enabled = True
        clear()
        TampilGrid()
    End Sub

    Sub Aktif()
        txtJudul.Enabled = True
        txtPengarang.Enabled = True
        txtTahun.Enabled = True
        txtPenerbit.Enabled = True
        txtJml.Enabled = True
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
    End Sub

    Sub caricell()
        cmd = New OdbcCommand("SELECT * FROM buku WHERE id_buku ='" & txtIDBuku.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub

    Sub caridata()
        cmd = New OdbcCommand("SELECT * FROM buku WHERE id_buku='" & txtCari.Text & "' OR judul='" & txtCari.Text & "' OR penerbit='" & txtCari.Text & "' OR pengarang='" & txtCari.Text & "' OR tahun='" & txtCari.Text & "' OR jml_hal='" & txtCari.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub

    Sub fill()
        txtIDBuku.Text = dr.Item(0)
        txtJudul.Text = dr.Item(1)
        txtPengarang.Text = dr.Item(2)
        txtPenerbit.Text = dr.Item(3)
        txtTahun.Text = dr.Item(4)
        txtJml.Text = dr.Item(5)
    End Sub

    Sub TampilGrid()
        da = New OdbcDataAdapter("SELECT * FROM buku", conn)
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
        NoBuku()
        Aktif()
        txtJudul.Focus()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Awal()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "&SIMPAN" Then
            cmd = New OdbcCommand("INSERT INTO buku VALUES('" & txtIDBuku.Text & "','" & txtJudul.Text & "', '" & txtPengarang.Text & "', '" & txtPenerbit.Text & "', '" & txtTahun.Text & "', '" & txtJml.Text & "')", conn)
            cmd.ExecuteNonQuery()
            Awal()
        ElseIf btnSimpan.Text = "&UBAH" Then
            cmd = New OdbcCommand("UPDATE buku SET judul= '" & txtJudul.Text & "', pengarang='" & txtPengarang.Text & "', penerbit='" & txtPenerbit.Text & "', tahun='" & txtTahun.Text & "', jml_hal='" & txtJml.Text & "' WHERE id_buku='" & txtIDBuku.Text & "'", conn)
            cmd.ExecuteNonQuery()
            Awal()
        End If
    End Sub


    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        btnTambah.Enabled = False
        btnSimpan.Text = "&UBAH"
        txtIDBuku.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        caricell()
        fill()
        Aktif()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            If MsgBox("Anda yakin akan menghapus?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
                query = "DELETE FROM buku WHERE id_buku='" & txtIDBuku.Text & "'"
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
End Class