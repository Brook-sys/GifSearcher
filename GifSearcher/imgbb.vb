Public Class imgbb
    Public Property data As Data
    Public Property success As Boolean
    Public Property status As Integer
End Class
Public Class Imagem
    Public Property filename As String
    Public Property name As String
    Public Property mime As String
    Public Property extension As String
    Public Property url As String
    Public Property size As Integer
End Class

Public Class Thumb
    Public Property filename As String
    Public Property name As String
    Public Property mime As String
    Public Property extension As String
    Public Property url As String
    Public Property size As String
End Class

Public Class Medium
    Public Property filename As String
    Public Property name As String
    Public Property mime As String
    Public Property extension As String
    Public Property url As String
    Public Property size As String
End Class

Public Class Data
    Public Property id As String
    Public Property url_viewer As String
    Public Property url As String
    Public Property display_url As String
    Public Property title As String
    Public Property time As String
    Public Property image As Imagem
    Public Property thumb As Thumb
    Public Property medium As Medium
    Public Property delete_url As String
End Class
