Imports System.Data.Odbc

Module ModulKoneksi
    Public strcon As String
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public dr As OdbcDataReader
    Public query As String

    Public Sub Koneksi()
        strcon = "Driver={MySql ODBC 5.1 Driver};Server=localhost;uid=root;Database=vb_perpustakaan"
        conn = New OdbcConnection(strcon)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            'MsgBox("conn oke")
        End If
    End Sub

End Module
