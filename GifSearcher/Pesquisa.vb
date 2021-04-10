Public Class Pesquisa
    Public url_delet As String
    Public LinkGif As String

    Sub Pesquisar()
        LinkGif = TextBox1.Text
        If Gif.Site = "Yandex" Then
            WebBrowser1.Navigate("https://www.yandex.com/images/search?url=" & LinkGif & "&rpt=imagelike")
        ElseIf Gif.Site = "Google" Then
            WebBrowser1.Navigate("https://www.google.com/searchbyimage?site=search&sa=X&image_url=" & LinkGif)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pesquisar()
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SelecionarFrame.WindowState = FormWindowState.Normal
    End Sub

End Class