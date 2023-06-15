<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEnkripsi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEnkripsi))
        Me.tbHasilEnkripsi = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnEnkripsi = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbKunciEnkripsi = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbHasilEnkripsi
        '
        Me.tbHasilEnkripsi.Enabled = False
        Me.tbHasilEnkripsi.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHasilEnkripsi.Location = New System.Drawing.Point(301, 181)
        Me.tbHasilEnkripsi.Name = "tbHasilEnkripsi"
        Me.tbHasilEnkripsi.Size = New System.Drawing.Size(280, 35)
        Me.tbHasilEnkripsi.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.Location = New System.Drawing.Point(12, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(283, 350)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(301, 381)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(143, 41)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse Gambar"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnEnkripsi
        '
        Me.btnEnkripsi.Enabled = False
        Me.btnEnkripsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnkripsi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnkripsi.Location = New System.Drawing.Point(301, 334)
        Me.btnEnkripsi.Name = "btnEnkripsi"
        Me.btnEnkripsi.Size = New System.Drawing.Size(143, 41)
        Me.btnEnkripsi.TabIndex = 4
        Me.btnEnkripsi.Text = "Enkripsi"
        Me.btnEnkripsi.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Hexadesimal Enkripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(297, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kode Hexadesimal"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(301, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 35)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "#0123456789ABCDEF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Key Enkripsi"
        '
        'tbKunciEnkripsi
        '
        Me.tbKunciEnkripsi.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKunciEnkripsi.Location = New System.Drawing.Point(301, 267)
        Me.tbKunciEnkripsi.Name = "tbKunciEnkripsi"
        Me.tbKunciEnkripsi.Size = New System.Drawing.Size(208, 35)
        Me.tbKunciEnkripsi.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(450, 381)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(143, 41)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save Gambar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Enabled = False
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(450, 334)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(143, 41)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Enkripsi Gambar"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormEnkripsi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(601, 482)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbKunciEnkripsi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEnkripsi)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbHasilEnkripsi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEnkripsi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enkripsi Gambar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbHasilEnkripsi As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnEnkripsi As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbKunciEnkripsi As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
