' prog039.VB
' Programa: Operador cast (CType)
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Operador cast
         Casting()

      End Sub

      Shared Sub Casting()
      
         Dim Qt As Char = Convert.ToChar(34)
         Dim a As Integer = 5
         Dim d As Double = CType(a, Double)
         Console.WriteLine()
         Console.WriteLine("Casting")
         Console.WriteLine("-------")
         Console.WriteLine("a es un int: {0}", a.ToString())
         Console.WriteLine("d es un double asignado con casting" + Qt + "d = CType(a, Double)" + Qt + ": {0}", d.ToString())

      End Sub

   End Class

End Namespace
