' prog051.VB
' Programa: Sentencia de ruptura Throw
'           (excepciones, try/catch)
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Intenta dividir por cero
         DividePorCero()

      End Sub

      Shared Sub DividePorCero()
      
         Dim n As Integer = Int32.MaxValue
         Try
      
           Console.WriteLine("División por cero: {0}", n/0) 
           Console.WriteLine("Overflow: {0}", n + 1) 
      
           catch e As OverflowException
      
           Console.WriteLine("Error! Se sobrepaso el rango de números enteros!")
           Console.WriteLine(e.Message) 
      
         End Try 

      End Sub

   End Class

End Namespace
