Imports System.Data.Odbc
Public Class Petugas

    Sub IDPetugas()
        cmd = New OdbcCommand("SELECT id_petugas FROM petugas ORDER BY id_petugas DESC", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            txtID.Text = "P001"
        Else
            txtID.Text = "P" + Format(Microsoft.VisualBasic.Right(dr.Item("id_petugas"), 3) + 1, "000")
        End If
    End Sub

    Sub clear()
        txtNamaP.Clear()
        txtPassP.Clear()
        cmbAkses.Text = ""
        txtNamaP.Focus()
    End Sub

    Sub HakAkses()
        cmd = New OdbcCommand("SELECT DISTINCT hak_akses FROM Petugas", conn)
        dr = cmd.ExecuteReader
        cmbAkses.Items.Clear()
        While dr.Read
            cmbAkses.Items.Add(dr.Item("hak_akses"))
        End While
    End Sub

    Sub TampilGrid()
        da = New OdbcDataAdapter("SELECT * FROM petugas", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Sub Awal()
        HakAkses()
        txtNamaP.Enabled = False
        txtPassP.Enabled = False
        cmbAkses.Enabled = False
        Button2.Enabled = False
        Button5.Enabled = False
        btnTambah.Enabled = True
        clear()
        TampilGrid()
    End Sub

    Sub aktif()
        txtNamaP.Enabled = True
        txtPassP.Enabled = True
        cmbAkses.Enabled = True
        Button2.Enabled = True
        Button5.Enabled = True
    End Sub

    Sub fill()
        txtID.Text = dr.Item(0)
        txtNamaP.Text = dr.Item(1)
        txtPassP.Text = dr.Item(2)
        cmbAkses.Text = dr.Item(3)
    End Sub

    Sub caricell()
        cmd = New OdbcCommand("SELECT * FROM petugas WHERE id_petugas ='" & txtID.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub

    Sub caridata()
        cmd = New OdbcCommand("SELECT * FROM petugas WHERE id_petugas='" & txtCari.Text & "' OR nama_petugas ='" & txtCari.Text & "' OR password ='" & txtCari.Text & "' OR hak_akses='" & txtCari.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'simpan
        If Button2.Text = "SIMPAN" Then
            query = "INSERT INTO petugas VALUES('" & txtID.Text & "','" & txtNamaP.Text & "','" & txtPassP.Text & "','" & cmbAkses.Text & "')"
            cmd = New OdbcCommand(query, conn)
            cmd.ExecuteNonQuery()
            Awal()
        ElseIf Button2.Text = "&UBAH" Then
            query = "UPDATE petugas SET nama_petugas='" & txtNamaP.Text & "', password='" & txtPassP.Text & "', hak_akses='" & cmbAkses.Text & "' WHERE id_petugas='" & txtID.Text & "'"
            cmd = New OdbcCommand(query, conn)
            cmd.ExecuteNonQuery()
            Awal()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'DELETE 
        Try
            If MsgBox("Anda yakin akan menghapus?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
                query = "DELETE FROM petugas WHERE id_petugas='" & txtID.Text & "'"
                cmd = New OdbcCommand(query, conn)
                cmd.ExecuteNonQuery()
            End If
            Awal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
            
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        btnTambah.Enabled = False
        Button2.Text = "SIMPAN"
        IDPetugas()
        aktif()
        clear()
    End Sub

    Private Sub Petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Awal()
        TampilGrid()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'BATAL
        Awal()
    End Sub

    Private Sub txtCari_Click(sender As Object, e As EventArgs) Handles txtCari.Click
        txtCari.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CARI
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
                Button2.Text = "&UBAH"
                aktif()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        btnTambah.Enabled = False
        Button2.Text = "&UBAH"
        txtID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        caricell()
        fill()
        aktif()
    End Sub

End Class