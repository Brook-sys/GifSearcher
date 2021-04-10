Imports System.Drawing.Imaging

Public Class SelecionarFrame
    Dim vertical As Integer = -1
    Dim horizontal As Integer
    Public imagem As Image
    Public Sub pegarframes()
        Dim oDimension As New FrameDimension(imagem.FrameDimensionsList(0))
        Dim FrameCount As Integer = imagem.GetFrameCount(oDimension)
        For i As Integer = 0 To FrameCount - 1
            Dim picbox As New PictureBox
            horizontal = horizontal + 1
            Panel1.Controls.Add(picbox)
            imagem.SelectActiveFrame(oDimension, i)
            Dim Frames As New Bitmap(imagem)
            With picbox
                .Size = New Size(140, 140)
                .Location = New Point((5 + 140) * horizontal, (5 + 140) * vertical)
                .Image = Frames
                .Cursor = Cursors.Hand
                .SizeMode = PictureBoxSizeMode.Zoom
                .Name = "Framev" & vertical & "h" & horizontal
            End With
            AddHandler picbox.Click, Sub()
                                         Try
                                             Dim imageupload As imgbb = UploadImagem.upload(picbox.Image)
                                             If imageupload.success = True Then
                                                 Pesquisa.Show()
                                                 Pesquisa.WindowState = FormWindowState.Normal
                                                 Pesquisa.TextBox1.Text = imageupload.data.url
                                                 Pesquisa.url_delet = imageupload.data.delete_url
                                                 Pesquisa.Pesquisar()
                                                 Me.WindowState = FormWindowState.Minimized
                                             ElseIf imageupload.success = False Then
                                                 MsgBox("Houve algum erro no upload da imagem para pesquisa")
                                             End If
                                         Catch ex As Exception
                                             MsgBox("Houve algum erro no upload da imagem para pesquisa")
                                         End Try


                                     End Sub
            If horizontal = 3 Then
                vertical = vertical + 1
                horizontal = -1
            End If
        Next
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Gif.WindowState = FormWindowState.Normal
    End Sub
End Class