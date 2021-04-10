Imports System.IO
Imports System.Net
Public Class Gif
    Dim vertical As Integer = -1
    Dim horizontal As Integer
    Public Site As String = "Yandex"
    Private Sub rdbtnCaminho_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnInternet.CheckedChanged, rdbtnArquivo.CheckedChanged
        If rdbtnInternet.Checked Then
            lblCaminho.Text = "Link:"
            txtboxCaminho.Location = New Point(75, 147)
            txtboxCaminho.Size = New Size(315, 33)
            btnOpenFile.Visible = False
        ElseIf rdbtnArquivo.Checked Then
            lblCaminho.Text = "Arquivo:"
            txtboxCaminho.Location = New Point(110, 147)
            txtboxCaminho.Size = New Size(226, 33)
            btnOpenFile.Visible = True
        End If
    End Sub

    Private Sub txtboxCaminho_TextChanged(sender As Object, e As EventArgs) Handles txtboxCaminho.TextChanged

        If txtboxCaminho.Text = "" Then
            btnPegar.Visible = False
        ElseIf txtboxCaminho.Text <> "" Then
            btnPegar.Visible = True
        End If
    End Sub

    Private Sub btnPegar_Click(sender As Object, e As EventArgs) Handles btnPegar.Click
        Try
            If rdbtnArquivo.Checked Then
                PegarGif()
            ElseIf rdbtnInternet.Checked Then
                PegarGif(True)
            End If
        Catch ex As Exception
            MsgBox("Erro")
        End Try

    End Sub
    Sub PegarGif(ByVal Optional link As Boolean = False)
        Dim caminhoGif = txtboxCaminho.Text
        Dim img As Image
        If link Then
            Dim wc As New WebClient()
            Dim bytes As Byte() = wc.DownloadData(caminhoGif)
            Dim ms As New MemoryStream(bytes)
            img = Image.FromStream(ms)
        ElseIf Not link Then
            img = Image.FromFile(caminhoGif)
        End If
        SelecionarFrame.Show()
        Me.WindowState = FormWindowState.Minimized
        SelecionarFrame.imagem = img
        SelecionarFrame.pegarframes()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdbtnInternet.Checked = True
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = DialogResult.OK Then
            txtboxCaminho.Text = ofd.FileName
        End If
    End Sub

    Private Sub rdbtnSite_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnYandex.CheckedChanged, rdbtnGoogle.CheckedChanged
        If rdbtnYandex.Checked Then
            Site = "Yandex"
        ElseIf rdbtnGoogle.Checked Then
            Site = "Google"
        End If
    End Sub
End Class
