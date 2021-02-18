Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine

Public Class Pinjam

    Sub NoPinjam()
        cmd = New OdbcCommand("SELECT id_pinjam FROM pinjam ORDER BY id_pinjam DESC", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            txtIDPJ.Text = "#PJ001"
        Else
            txtIDPJ.Text = "#PJ" + Format(Microsoft.VisualBasic.Right(dr.Item("id_pinjam"), 3) + 1, "000")
        End If
    End Sub

    Sub clear()
        cmbJudul.Text = ""
        cmbNamaA.Text = ""
        txtJumlah.Clear()
        DateTimePicker1.Text = ""
    End Sub

    Sub Awal()
        clear()
        btnTambah.Enabled = True
        txtBatal.Enabled = False
        lblDate.Text = FormatDateTime(Today, DateFormat.LongDate)
        cmbNamaA.Enabled = False
        cmbJudul.Enabled = False
        txtJumlah.Enabled = False
        DateTimePicker1.Enabled = False
        btnTambah.Text = "&TAMBAH"
        TampilGrid()
    End Sub

    Sub Aktif()
        txtBatal.Enabled = True
        lblDate.Text = FormatDateTime(Today, DateFormat.LongDate)
        cmbNamaA.Enabled = True
        cmbJudul.Enabled = True
        txtJumlah.Enabled = True
        DateTimePicker1.Enabled = True
        btnTambah.Enabled = True
        btnTambah.Text = "&SIMPAN"
        NamaAnggota()
        JudulBuku()
    End Sub

    Sub NamaAnggota()
        cmd = New OdbcCommand("SELECT DISTINCT nama_anggota FROM anggota", conn)
        dr = cmd.ExecuteReader
        cmbNamaA.Items.Clear()
        While dr.Read
            cmbNamaA.Items.Add(dr.Item("nama_anggota"))
        End While
    End Sub

    Sub InsertIDAIDP()
        dr = New OdbcCommand("SELECT id_anggota FROM anggota WHERE nama_anggota = '" & cmbNamaA.Text & "'", conn).ExecuteReader
        dr.Read()
        txtIDA.Text = dr.Item("id_anggota")

        dr = New OdbcCommand("SELECT id_petugas FROM petugas WHERE nama_petugas = '" & txtPetugas.Text & "'", conn).ExecuteReader
        dr.Read()
        txtIDP.Text = dr.Item("id_petugas")

        dr = New OdbcCommand("SELECT id_buku FROM buku WHERE judul = '" & cmbJudul.Text & "'", conn).ExecuteReader
        dr.Read()
        txtIDB.Text = dr.Item("id_buku")
    End Sub

    Sub JudulBuku()
        cmd = New OdbcCommand("SELECT DISTINCT judul FROM buku", conn)
        dr = cmd.ExecuteReader
        cmbJudul.Items.Clear()
        While dr.Read
            cmbJudul.Items.Add(dr.Item("judul"))
        End While
    End Sub

    Sub TampilGrid()
        da = New OdbcDataAdapter("SELECT id_pinjam, nama_petugas, tgl_pinjam, nama_anggota, judul, jml_buku, tgl_kembali FROM pinjam, buku, petugas, anggota where pinjam.id_anggota=anggota.id_anggota and buku.id_buku=pinjam.id_buku and petugas.id_petugas=pinjam.id_petugas", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Anggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Awal()
    End Sub

    Private Sub txtBatal_Click(sender As Object, e As EventArgs) Handles txtBatal.Click
        Awal()
        clear()
        btnTambah.Text = "&TAMBAH"
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "&TAMBAH" Then
            btnTambah.Text = "&SIMPAN"
            btnTambah.Enabled = False
            Aktif()
            clear()
            NoPinjam()
            cmbNamaA.Focus()
        ElseIf btnTambah.Text = "&SIMPAN" Then
            Dim dateval As DateTime
            dateval = Format(FormatDateTime(Today, DateFormat.LongDate))

            If btnTambah.Text = "&SIMPAN" Then
                If txtJumlah.Text = "" Then
                    txtJumlah.Text = "1"
                End If
                InsertIDAIDP()
                cmd = New OdbcCommand("INSERT INTO pinjam VALUES('" & Microsoft.VisualBasic.Right(txtIDPJ.Text, 5) & "','" & dateval.ToString("yyyy-MM-dd") & "', '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', '" & txtIDB.Text & "', '" & txtJumlah.Text & "', '" & txtIDA.Text & "', '" & txtIDP.Text & "', 'pinjam')", conn)
                cmd.ExecuteNonQuery()
            End If
            Awal()
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        With Dashboard
            .MainPanel.Controls.Clear()
            CetakPmj.TopLevel = False
            .MainPanel.Controls.Add(CetakPmj)
            CetakPmj.Show()
        End With

        Dim lap As New ReportDocument
        lap.Load(Application.StartupPath + "\" + "CetakPeminjaman.rpt")
        CetakPmj.crv.ReportSource = lap
        'CetakPmj.crv.SelectionFormula = "{mahasiswa1.jurusan}= '" & ComboBox1.Text & "'"
        CetakPmj.crv.RefreshReport()
        MyBase.OnLoad(e)
    End Sub
End Class