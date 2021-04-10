<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gif
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbtnInternet = New System.Windows.Forms.RadioButton()
        Me.rdbtnArquivo = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblCaminho = New System.Windows.Forms.Label()
        Me.txtboxCaminho = New System.Windows.Forms.TextBox()
        Me.btnPegar = New System.Windows.Forms.Button()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.rdbtnYandex = New System.Windows.Forms.RadioButton()
        Me.rdbtnGoogle = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(61, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GIF SEARCHER"
        '
        'rdbtnInternet
        '
        Me.rdbtnInternet.AutoSize = True
        Me.rdbtnInternet.Location = New System.Drawing.Point(22, 16)
        Me.rdbtnInternet.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.rdbtnInternet.Name = "rdbtnInternet"
        Me.rdbtnInternet.Size = New System.Drawing.Size(75, 20)
        Me.rdbtnInternet.TabIndex = 1
        Me.rdbtnInternet.Text = "Intenet"
        Me.rdbtnInternet.UseVisualStyleBackColor = True
        '
        'rdbtnArquivo
        '
        Me.rdbtnArquivo.AutoSize = True
        Me.rdbtnArquivo.Checked = True
        Me.rdbtnArquivo.Location = New System.Drawing.Point(22, 32)
        Me.rdbtnArquivo.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.rdbtnArquivo.Name = "rdbtnArquivo"
        Me.rdbtnArquivo.Size = New System.Drawing.Size(114, 20)
        Me.rdbtnArquivo.TabIndex = 1
        Me.rdbtnArquivo.TabStop = True
        Me.rdbtnArquivo.Text = "Arquivo Local"
        Me.rdbtnArquivo.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(0, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(402, 2)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'lblCaminho
        '
        Me.lblCaminho.AutoSize = True
        Me.lblCaminho.Location = New System.Drawing.Point(6, 151)
        Me.lblCaminho.Name = "lblCaminho"
        Me.lblCaminho.Size = New System.Drawing.Size(100, 25)
        Me.lblCaminho.TabIndex = 3
        Me.lblCaminho.Text = "Arquivo:"
        '
        'txtboxCaminho
        '
        Me.txtboxCaminho.Location = New System.Drawing.Point(112, 147)
        Me.txtboxCaminho.Name = "txtboxCaminho"
        Me.txtboxCaminho.Size = New System.Drawing.Size(226, 33)
        Me.txtboxCaminho.TabIndex = 4
        '
        'btnPegar
        '
        Me.btnPegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPegar.Location = New System.Drawing.Point(152, 193)
        Me.btnPegar.Name = "btnPegar"
        Me.btnPegar.Size = New System.Drawing.Size(98, 37)
        Me.btnPegar.TabIndex = 5
        Me.btnPegar.Text = "Pegar"
        Me.btnPegar.UseVisualStyleBackColor = True
        Me.btnPegar.Visible = False
        '
        'btnOpenFile
        '
        Me.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenFile.Location = New System.Drawing.Point(344, 145)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(46, 37)
        Me.btnOpenFile.TabIndex = 5
        Me.btnOpenFile.Text = "..."
        Me.btnOpenFile.UseVisualStyleBackColor = True
        Me.btnOpenFile.Visible = False
        '
        'rdbtnYandex
        '
        Me.rdbtnYandex.AutoSize = True
        Me.rdbtnYandex.Checked = True
        Me.rdbtnYandex.Location = New System.Drawing.Point(22, 16)
        Me.rdbtnYandex.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.rdbtnYandex.Name = "rdbtnYandex"
        Me.rdbtnYandex.Size = New System.Drawing.Size(74, 20)
        Me.rdbtnYandex.TabIndex = 1
        Me.rdbtnYandex.TabStop = True
        Me.rdbtnYandex.Text = "Yandex"
        Me.rdbtnYandex.UseVisualStyleBackColor = True
        '
        'rdbtnGoogle
        '
        Me.rdbtnGoogle.AutoSize = True
        Me.rdbtnGoogle.Location = New System.Drawing.Point(22, 34)
        Me.rdbtnGoogle.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.rdbtnGoogle.Name = "rdbtnGoogle"
        Me.rdbtnGoogle.Size = New System.Drawing.Size(69, 20)
        Me.rdbtnGoogle.TabIndex = 1
        Me.rdbtnGoogle.Text = "Google"
        Me.rdbtnGoogle.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbtnYandex)
        Me.GroupBox1.Controls.Add(Me.rdbtnGoogle)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(220, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 62)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Site"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbtnInternet)
        Me.GroupBox2.Controls.Add(Me.rdbtnArquivo)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(28, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(150, 60)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Caminho"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(402, 244)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.btnPegar)
        Me.Controls.Add(Me.txtboxCaminho)
        Me.Controls.Add(Me.lblCaminho)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.Text = "Gif Searcher"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rdbtnInternet As RadioButton
    Friend WithEvents rdbtnArquivo As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblCaminho As Label
    Friend WithEvents txtboxCaminho As TextBox
    Friend WithEvents btnPegar As Button
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents rdbtnYandex As RadioButton
    Friend WithEvents rdbtnGoogle As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
