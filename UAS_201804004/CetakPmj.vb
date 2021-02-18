Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine

Public Class CetakPmj

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
        Pinjam.Show()
    End Sub

    Sub nama()
        Koneksi()
        cmd = New OdbcCommand("SELECT nama_anggota FROM anggota GROUP BY nama_anggota", conn)
        dr = cmd.ExecuteReader
        cmbNama.Items.Clear()
        While dr.Read
            cmbNama.Items.Add(dr(0).ToString)
        End While
    End Sub

    Private Sub CetakPmj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nama()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim lap As New ReportDocument
        lap.Load(Application.StartupPath + "\" + "CetakPeminjaman.rpt")
        crv.ReportSource = lap
        crv.SelectionFormula = "{anggota1.nama_anggota}= '" & cmbNama.Text & "'"
        crv.RefreshReport()
        MyBase.OnLoad(e)
    End Sub
End Class