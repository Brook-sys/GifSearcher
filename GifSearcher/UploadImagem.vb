Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Public Class UploadImagem
    Shared key As String = "469aa53ecaccfaf8564f06882f647657"
    Shared Function ConvertBase64(ByVal imagem As Image)
        Dim ms As New MemoryStream()
        imagem.Save(ms, Imaging.ImageFormat.Png)
        Dim imagebytes As Byte() = ms.ToArray
        Dim base64String As String = Convert.ToBase64String(imagebytes)
        Return base64String
    End Function
    Shared Function upload(ByVal imagem As Image) As imgbb
        Try
            Dim client = New WebClient()
            client.Headers.Add("User-Agent", "Nobody")
            Dim url As String = "https://api.imgbb.com/1/upload"
            Dim param As New Specialized.NameValueCollection
            param.Add("key", key)
            param.Add("image", ConvertBase64(imagem))
            Dim responsebytes = client.UploadValues(url, "POST", param)
            Dim responsebody = (New Text.UTF8Encoding).GetString(responsebytes)
            Dim certo As imgbb = JsonConvert.DeserializeObject(Of imgbb)(responsebody)
            Return certo
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


End Class

