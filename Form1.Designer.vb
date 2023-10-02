<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        NamaBarang = New TextBox()
        TextB = New TextBox()
        Jumlah = New TextBox()
        Diskon = New TextBox()
        Label5 = New Label()
        Pajak = New TextBox()
        Hitung = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Total = New TextBox()
        Bayar = New TextBox()
        Kembalian = New TextBox()
        Clear = New Button()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 1
        Label2.Text = "Harga"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 2
        Label3.Text = "Jumlah"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 15)
        Label4.TabIndex = 3
        Label4.Text = "Diskon(%)"
        ' 
        ' NamaBarang
        ' 
        NamaBarang.Location = New Point(147, 33)
        NamaBarang.Name = "NamaBarang"
        NamaBarang.Size = New Size(207, 23)
        NamaBarang.TabIndex = 4
        ' 
        ' TextB
        ' 
        TextB.Location = New Point(147, 67)
        TextB.Name = "TextB"
        TextB.Size = New Size(207, 23)
        TextB.TabIndex = 5
        ' 
        ' Jumlah
        ' 
        Jumlah.Location = New Point(147, 103)
        Jumlah.Name = "Jumlah"
        Jumlah.Size = New Size(207, 23)
        Jumlah.TabIndex = 6
        ' 
        ' Diskon
        ' 
        Diskon.Location = New Point(147, 143)
        Diskon.Name = "Diskon"
        Diskon.Size = New Size(207, 23)
        Diskon.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 15)
        Label5.TabIndex = 8
        Label5.Text = "Pajak(2%)"
        ' 
        ' Pajak
        ' 
        Pajak.Location = New Point(147, 182)
        Pajak.Name = "Pajak"
        Pajak.Size = New Size(207, 23)
        Pajak.TabIndex = 9
        ' 
        ' Hitung
        ' 
        Hitung.Location = New Point(279, 221)
        Hitung.Name = "Hitung"
        Hitung.Size = New Size(75, 23)
        Hitung.TabIndex = 10
        Hitung.Text = "Hitung"
        Hitung.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 263)
        Label6.Name = "Label6"
        Label6.Size = New Size(32, 15)
        Label6.TabIndex = 11
        Label6.Text = "Total"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 304)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 15)
        Label7.TabIndex = 12
        Label7.Text = "Bayar"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 345)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 15)
        Label8.TabIndex = 13
        Label8.Text = "Kembalian"
        ' 
        ' Total
        ' 
        Total.Location = New Point(147, 260)
        Total.Name = "Total"
        Total.Size = New Size(207, 23)
        Total.TabIndex = 14
        ' 
        ' Bayar
        ' 
        Bayar.Location = New Point(147, 296)
        Bayar.Name = "Bayar"
        Bayar.Size = New Size(207, 23)
        Bayar.TabIndex = 15
        ' 
        ' Kembalian
        ' 
        Kembalian.Location = New Point(147, 337)
        Kembalian.Name = "Kembalian"
        Kembalian.Size = New Size(207, 23)
        Kembalian.TabIndex = 16
        ' 
        ' Clear
        ' 
        Clear.Location = New Point(286, 387)
        Clear.Name = "Clear"
        Clear.Size = New Size(68, 22)
        Clear.TabIndex = 17
        Clear.Text = "Clear"
        Clear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(417, 481)
        Controls.Add(Clear)
        Controls.Add(Kembalian)
        Controls.Add(Bayar)
        Controls.Add(Total)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Hitung)
        Controls.Add(Pajak)
        Controls.Add(Label5)
        Controls.Add(Diskon)
        Controls.Add(Jumlah)
        Controls.Add(TextB)
        Controls.Add(NamaBarang)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "latihan2"
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label1 As Label
    Friend WithEvents Diskon As TextBox
    Friend WithEvents Jumlah As TextBox
    Friend WithEvents TextB As TextBox
    Friend WithEvents NamaBarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Pajak As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Kembalian As TextBox
    Friend WithEvents Bayar As TextBox
    Friend WithEvents Total As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Hitung As Button
    Friend WithEvents Clear As Button
End Class
