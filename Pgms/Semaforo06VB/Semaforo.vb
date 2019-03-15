Public Class Semaforo

    ' Campos 
    Private segundos As Integer
    Private estado As Integer
    Private tmInicial As DateTime

    ' Metodos
    Public Sub SetSegundos(ByVal segundos As Integer)
        Me.segundos = segundos
        estado = 0
        tmInicial = DateTime.Now
    End Sub

    Public Function GetEstado() As Integer
        Dim ahora As DateTime = DateTime.Now
        Dim lapso As TimeSpan = ahora.Subtract(tmInicial)
        estado = (lapso.Seconds / segundos) Mod 3
        Return estado
    End Function

End Class
