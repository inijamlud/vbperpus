Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine

Public Class Kembali
    Public denda As String

    Sub NoPinjam()
        cmd = New OdbcCommand("SELECT id_kembali FROM kembali ORDER BY id_kembali DESC", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            txtIDPJ.Text = "#K001"
        Else
            txtIDPJ.Text = "#K" + Format(Microsoft.VisualBasic.Right(dr.Item("id_kembali"), 3) + 1, "000")
        End If
    End Sub

    Sub Awal()
        lblDate.Text = FormatDateTime(Today, DateFormat.LongDate)
        cmbPJ.Enabled = False
        btnTambah.Text = "&TAMBAH"
        TampilGrid()
    End Sub

    Sub Aktif()
        txtBatal.Enabled = True
        lblDate.Text = FormatDateTime(Today, DateFormat.LongDate)
        btnTambah.Enabled = True
        btnTambah.Text = "&SIMPAN"
        IDPinjam()
        NoPinjam()
    End Sub

    Sub IDPinjam()
        cmd = New OdbcCommand("SELECT id_pinjam FROM pinjam where status='pinjam' ", conn)
        dr = cmd.ExecuteReader
        cmbPJ.Items.Clear()
        While dr.Read
            cmbPJ.Items.Add(dr.Item("id_pinjam"))
        End While
    End Sub

    Sub getTglpinjam()
        dr = New OdbcCommand("SELECT tgl_pinjam FROM pinjam WHERE id_pinjam = '" & cmbPJ.Text & "'", conn).ExecuteReader
        dr.Read()
        Dim tglpinjam As DateTime = dr.Item("tgl_pinjam")
    End Sub

    Sub InsertIDP()
        cmbPJ.Enabled = True
        dr = New OdbcCommand("SELECT id_petugas FROM petugas WHERE nama_petugas = '" & txtPetugas.Text & "'", conn).ExecuteReader
        dr.Read()
        txtIDP.Text = dr.Item("id_petugas")

        dr = New OdbcCommand("SELECT id_pinjam FROM pinjam WHERE id_pinjam = '" & cmbPJ.Text & "'", conn).ExecuteReader
        dr.Read()
        txtPJ.Text = dr.Item("id_pinjam")
    End Sub

    Sub TampilGrid()
        da = New OdbcDataAdapter("SELECT kembali.id_kembali, pinjam.id_pinjam, pinjam.tgl_pinjam, anggota.nama_anggota, buku.judul, kembali.tgl_kembali, kembali.denda FROM kembali, pinjam, anggota, buku where kembali.id_pinjam = pinjam.id_pinjam and anggota.id_anggota=pinjam.id_anggota and buku.id_buku=pinjam.id_buku", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Anggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Awal()
        cmbPJ.Enabled = False
    End Sub

    Sub hitungDenda()
        Dim tglkembali As DateTime
        Dim tgltoday As DateTime

        dr = New OdbcCommand("SELECT * FROM pinjam WHERE id_pinjam = '" & txtPJ.Text & "'", conn).ExecuteReader
        dr.Read()

        tgltoday = Today.ToShortDateString
        tglkembali = dr.Item("tgl_kembali")

        If tgltoday > tglkembali Then
            denda = DateDiff(DateInterval.Day, tglkembali, tgltoday)
            txtDenda.Text = "Rp. " & denda & ".000"
        Else
            txtDenda.Text = "Rp. 0"
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If btnTambah.Text = "&SIMPAN" Then
            InsertIDP()
            getTglpinjam()
            hitungDenda()
            cmd = New OdbcCommand("INSERT INTO kembali VALUES('" & Microsoft.VisualBasic.Right(txtIDPJ.Text, 4) & "','" & Today.ToString("yyyy-MM-dd") & "', '" & txtPJ.Text & "', '" & denda & "000', '" & txtIDP.Text & "')", conn)
            cmd.ExecuteNonQuery()
            cmd = New OdbcCommand("UPDATE pinjam SET status='kembali' where id_pinjam='" & txtPJ.Text & "'", conn)
            cmd.ExecuteNonQuery()
            Awal()
            cmbPJ.Enabled = False
            btnTambah.Text = "&TAMBAH"

        ElseIf btnTambah.Text = "&TAMBAH" Then
            cmbPJ.Enabled = True
            Aktif()
        End If
    End Sub

    Private Sub txtBatal_Click(sender As Object, e As EventArgs) Handles txtBatal.Click
        Awal()
        cmbPJ.Enabled = False
        btnTambah.Text = "&TAMBAH"
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        With Dashboard
            .MainPanel.Controls.Clear()
            CetakPmb.TopLevel = False
            .MainPanel.Controls.Add(CetakPmb)
            CetakPmb.Show()
        End With

        Dim lap As New ReportDocument
        lap.Load(Application.StartupPath + "\" + "CetakPengembalian.rpt")
        CetakPmb.crv.ReportSource = lap
        'CetakPmj.crv.SelectionFormula = "{mahasiswa1.jurusan}= '" & ComboBox1.Text & "'"
        CetakPmb.crv.RefreshReport()
        MyBase.OnLoad(e)
    End Sub
End Class