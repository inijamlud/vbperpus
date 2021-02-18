<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pinjam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtIDPJ = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtIDA = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.cmbNamaA = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cmbJudul = New System.Windows.Forms.ComboBox()
        Me.txtBatal = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIDP = New System.Windows.Forms.TextBox()
        Me.txtPetugas = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtIDB = New System.Windows.Forms.TextBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIDPJ
        '
        Me.txtIDPJ.AutoSize = True
        Me.txtIDPJ.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDPJ.Location = New System.Drawing.Point(605, 43)
        Me.txtIDPJ.Name = "txtIDPJ"
        Me.txtIDPJ.Size = New System.Drawing.Size(48, 16)
        Me.txtIDPJ.TabIndex = 0
        Me.txtIDPJ.Text = "#PJ000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(175, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Anggota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Judul Buku"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 236)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(623, 187)
        Me.DataGridView1.TabIndex = 12
        '
        'txtIDA
        '
        Me.txtIDA.Location = New System.Drawing.Point(175, 157)
        Me.txtIDA.Name = "txtIDA"
        Me.txtIDA.Size = New System.Drawing.Size(110, 22)
        Me.txtIDA.TabIndex = 28
        Me.txtIDA.Visible = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(454, 185)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(95, 34)
        Me.btnTambah.TabIndex = 31
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'cmbNamaA
        '
        Me.cmbNamaA.FormattingEnabled = True
        Me.cmbNamaA.Location = New System.Drawing.Point(175, 129)
        Me.cmbNamaA.Name = "cmbNamaA"
        Me.cmbNamaA.Size = New System.Drawing.Size(341, 22)
        Me.cmbNamaA.TabIndex = 38
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(451, 59)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(202, 16)
        Me.lblDate.TabIndex = 39
        Me.lblDate.Text = "DATETIMENOW"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbJudul
        '
        Me.cmbJudul.FormattingEnabled = True
        Me.cmbJudul.Location = New System.Drawing.Point(34, 192)
        Me.cmbJudul.Name = "cmbJudul"
        Me.cmbJudul.Size = New System.Drawing.Size(236, 22)
        Me.cmbJudul.TabIndex = 40
        '
        'txtBatal
        '
        Me.txtBatal.BackColor = System.Drawing.Color.White
        Me.txtBatal.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed
        Me.txtBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtBatal.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatal.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.txtBatal.Location = New System.Drawing.Point(555, 185)
        Me.txtBatal.Name = "txtBatal"
        Me.txtBatal.Size = New System.Drawing.Size(95, 34)
        Me.txtBatal.TabIndex = 41
        Me.txtBatal.Text = "BATAL"
        Me.txtBatal.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.Label4.Location = New System.Drawing.Point(25, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 26)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "PEMINJAMAN"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(686, 485)
        Me.ShapeContainer1.TabIndex = 42
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 32
        Me.LineShape1.X2 = 650
        Me.LineShape1.Y1 = 81
        Me.LineShape1.Y2 = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(527, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 14)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Tanggal Kembali"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 14)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Jumlah Buku"
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(298, 192)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(46, 22)
        Me.txtJumlah.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(31, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 14)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Petugas"
        '
        'txtIDP
        '
        Me.txtIDP.Location = New System.Drawing.Point(34, 157)
        Me.txtIDP.Name = "txtIDP"
        Me.txtIDP.Size = New System.Drawing.Size(95, 22)
        Me.txtIDP.TabIndex = 49
        Me.txtIDP.Visible = False
        '
        'txtPetugas
        '
        Me.txtPetugas.Enabled = False
        Me.txtPetugas.Location = New System.Drawing.Point(34, 129)
        Me.txtPetugas.Name = "txtPetugas"
        Me.txtPetugas.Size = New System.Drawing.Size(122, 22)
        Me.txtPetugas.TabIndex = 50
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(530, 129)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 22)
        Me.DateTimePicker1.TabIndex = 51
        '
        'txtIDB
        '
        Me.txtIDB.Location = New System.Drawing.Point(34, 220)
        Me.txtIDB.Name = "txtIDB"
        Me.txtIDB.Size = New System.Drawing.Size(95, 22)
        Me.txtIDB.TabIndex = 52
        Me.txtIDB.Visible = False
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.Location = New System.Drawing.Point(30, 433)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(95, 34)
        Me.btnCetak.TabIndex = 54
        Me.btnCetak.Text = "CETAK"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'Pinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(686, 485)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.txtIDB)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtPetugas)
        Me.Controls.Add(Me.txtIDP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNamaA)
        Me.Controls.Add(Me.txtBatal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cmbJudul)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtIDPJ)
        Me.Controls.Add(Me.txtIDA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pinjam"
        Me.Text = "Petugas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIDPJ As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtIDA As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents cmbNamaA As System.Windows.Forms.ComboBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents cmbJudul As System.Windows.Forms.ComboBox
    Friend WithEvents txtBatal As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIDP As System.Windows.Forms.TextBox
    Friend WithEvents txtPetugas As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtIDB As System.Windows.Forms.TextBox
    Friend WithEvents btnCetak As System.Windows.Forms.Button
End Class
