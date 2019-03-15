' prog012.VB
' Programa Hola: usando alias

Imports output = System.Console

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
         Saludar()
      End Sub

      Shared Sub Saludar()
         output.WriteLine()
         output.Write("Por favor ingrese su nombre: ")
         Dim nombre As String = output.ReadLine()
         output.WriteLine("Hola " & nombre)
         output.WriteLine()
       End Sub
    
   End Class

End Namespace

