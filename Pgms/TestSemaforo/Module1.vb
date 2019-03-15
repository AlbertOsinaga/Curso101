Imports Semaforo06VB
Imports System.Threading

Module Module1

    Sub Main()

        Dim semafito As Semaforo = New Semaforo
        semafito.SetSegundos(1)
        Dim i As Integer
        For i = 1 To 10
            Console.WriteLine(EstadoAColor(semafito.GetEstado()))
            Thread.Sleep(1000)
        Next


    End Sub

    Private Function EstadoAColor(ByVal estado As Integer) As String
        Select Case estado
            Case 0
                Return "Rojo"
            Case 1
                Return "Amarillo"
            Case Else
                Return "Verde"
        End Select
    End Function

End Module
