<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kembali
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
        Me.txtPJ = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtBatal = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIDP = New System.Windows.Forms.TextBox()
        Me.txtPetugas = New System.Windows.Forms.TextBox()
        Me.txtDenda = New System.Windows.Forms.Label()
        Me.cmbPJ = New System.Windows.Forms.ComboBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIDPJ
        '
        Me.txtIDPJ.AutoSize = True
        Me.txtIDPJ.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDPJ.Location = New System.Drawing.Point(609, 42)
        Me.txtIDPJ.Name = "txtIDPJ"
        Me.txtIDPJ.Size = New System.Drawing.Size(44, 16)
        Me.txtIDPJ.TabIndex = 0
        Me.txtIDPJ.Text = "#K000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(183, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Peminjaman"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(474, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Denda"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 207)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(619, 220)
        Me.DataGridView1.TabIndex = 12
        '
        'txtPJ
        '
        Me.txtPJ.Location = New System.Drawing.Point(186, 142)
        Me.txtPJ.Name = "txtPJ"
        Me.txtPJ.Size = New System.Drawing.Size(110, 22)
        Me.txtPJ.TabIndex = 28
        Me.txtPJ.Visible = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(34, 159)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(95, 34)
        Me.btnTambah.TabIndex = 31
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = False
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
        'txtBatal
        '
        Me.txtBatal.BackColor = System.Drawing.Color.White
        Me.txtBatal.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed
        Me.txtBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtBatal.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatal.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.txtBatal.Location = New System.Drawing.Point(146, 159)
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
        Me.Label4.Text = "PENGEMBALIAN"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(31, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 14)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Petugas"
        '
        'txtIDP
        '
        Me.txtIDP.Location = New System.Drawing.Point(34, 142)
        Me.txtIDP.Name = "txtIDP"
        Me.txtIDP.Size = New System.Drawing.Size(95, 22)
        Me.txtIDP.TabIndex = 49
        Me.txtIDP.Visible = False
        '
        'txtPetugas
        '
        Me.txtPetugas.Enabled = False
        Me.txtPetugas.Location = New System.Drawing.Point(34, 114)
        Me.txtPetugas.Name = "txtPetugas"
        Me.txtPetugas.Size = New System.Drawing.Size(122, 22)
        Me.txtPetugas.TabIndex = 50
        '
        'txtDenda
        '
        Me.txtDenda.Font = New System.Drawing.Font("Gadugi", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDenda.Location = New System.Drawing.Point(471, 114)
        Me.txtDenda.Name = "txtDenda"
        Me.txtDenda.Size = New System.Drawing.Size(180, 45)
        Me.txtDenda.TabIndex = 51
        Me.txtDenda.Text = "Rp. 0"
        Me.txtDenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPJ
        '
        Me.cmbPJ.FormattingEnabled = True
        Me.cmbPJ.Location = New System.Drawing.Point(186, 114)
        Me.cmbPJ.Name = "cmbPJ"
        Me.cmbPJ.Size = New System.Drawing.Size(190, 22)
        Me.cmbPJ.TabIndex = 52
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.Location = New System.Drawing.Point(34, 433)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(95, 34)
        Me.btnCetak.TabIndex = 53
        Me.btnCetak.Text = "CETAK"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'Kembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(686, 485)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.cmbPJ)
        Me.Controls.Add(Me.txtDenda)
        Me.Controls.Add(Me.txtPetugas)
        Me.Controls.Add(Me.txtIDP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBatal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtIDPJ)
        Me.Controls.Add(Me.txtPJ)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Kembali"
        Me.Text = "Petugas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIDPJ As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtPJ As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtBatal As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIDP As System.Windows.Forms.TextBox
    Friend WithEvents txtPetugas As System.Windows.Forms.TextBox
    Friend WithEvents txtDenda As System.Windows.Forms.Label
    Friend WithEvents cmbPJ As System.Windows.Forms.ComboBox
    Friend WithEvents btnCetak As System.Windows.Forms.Button
End Class
