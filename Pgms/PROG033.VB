' prog033.VB
' Programa: Operadores Lógicos
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Operadores lógicos
         OperadoresLogicos()

      End Sub

      Shared Sub OperadoresLogicos()
      
         ' Operadores Lógicos
         Dim Qt As Char = Convert.ToChar(34)
         Dim a As Integer
         Console.WriteLine()
         Console.WriteLine("Operadores Lógicos")
         Console.WriteLine("------------------")

         a = 5
         Console.WriteLine()
         Console.WriteLine("y (And)")
         Console.WriteLine("---------------")
         Console.WriteLine(Qt + "Asigna(a, 4) = 5  And  Asigna(a, 8) = 8" + Qt + " es {0}", Asigna(a, 4) = 5  And  Asigna(a, 8) = 8)
         Console.WriteLine("a = {0}", a)

         a = 5
         Console.WriteLine()
         Console.WriteLine("ó (Or)")
         Console.WriteLine("---------------")
         Console.WriteLine(Qt + "Asigna(a, 4) = 4  Or  Asigna(a, 8) = 8" + Qt + " es {0}", Asigna(a, 4) = 4  Or  Asigna(a, 8) = 8)
         Console.WriteLine("a = {0}", a)

         a = 5
         Console.WriteLine()
         Console.WriteLine("ó exclusivo (Xor)")
         Console.WriteLine("-----------------")
         Console.WriteLine(Qt + "Asigna(a, 4) = 4   Xor  Asigna(a, 8) = 8" + Qt + " es {0}", Asigna(a, 4) = 4   Xor  Asigna(a, 8) = 8)
         Console.WriteLine("a = {0}", a)

         a = 5
         Console.WriteLine()
         Console.WriteLine("y (AndAlso)")
         Console.WriteLine("---------------")
         Console.WriteLine(Qt + "Asigna(a, 4) = 5  AndAlso  Asigna(a, 8) = 8" + Qt + " es {0}", Asigna(a, 4) = 5  AndAlso  Asigna(a, 8) = 8)
         Console.WriteLine("a = {0}", a)

         a = 5
         Console.WriteLine()
         Console.WriteLine("ó (OrElse)")
         Console.WriteLine("---------------")
         Console.WriteLine(Qt + "Asigna(a, 4) = 4  OrElse  Asigna(a, 8) = 8" + Qt + " es {0}", Asigna(a, 4) = 4  OrElse  Asigna(a, 8) = 8)
         Console.WriteLine("a = {0}", a)

         a = 5
         Console.WriteLine()
         Console.WriteLine("no (Not)")
         Console.WriteLine("---------------")
         Console.WriteLine(Qt + "Not a=4" + Qt + " es {0}", Not a=4)
         Console.WriteLine("a = {0}", a)

      End Sub

      Shared Function Asigna(ByRef a As Integer, valor As Integer) As Integer
      
         a = valor
         Return a
      
      End Function

   End Class

End Namespace
