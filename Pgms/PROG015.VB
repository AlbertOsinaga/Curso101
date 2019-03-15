' prog015.VB
' Programa: Literales de tipos primitivos
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal

      Shared Sub Main()
    
         ' Despliega nombre del tipo de literal

         Console.WriteLine()
         Console.WriteLine("(100): {0}", (100).GetType().ToString())
         Console.WriteLine("(100L): {0}", (100L).GetType().ToString())
         Console.WriteLine("(1500.35F): {0}", (1500.35F).GetType().ToString())
         Console.WriteLine("(1500.35): {0}", (1500.35).GetType().ToString())
         Console.WriteLine("(1500.35D): {0}", (1500.35D).GetType().ToString())
         Console.WriteLine("('A'c): {0}", ("A"c).GetType().ToString())
         Console.WriteLine("(True): {0}", (True).GetType().ToString())
         Console.WriteLine("('Hello World'): {0}", ("Hello World").GetType().ToString())
 
      End Sub

   End Class

End Namespace