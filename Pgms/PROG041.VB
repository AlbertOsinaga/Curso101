' prog041.VB
' Programa: Control de desbordamiento
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Control de desbordamiento
         ControlDesborde()

      End Sub

      Shared Sub ControlDesborde()
      
         ' Control de desbordamiento
         Dim a As Integer
         Console.WriteLine()
         Console.WriteLine("Control de desbordamiento")
         Console.WriteLine("-------------------------")
         a = Integer.MaxValue 
         Console.WriteLine("a = {0}", a)
         a += 1 

      End Sub

   End Class

End Namespace
