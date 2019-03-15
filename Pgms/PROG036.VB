' prog036.VB
' Programa: Operadores de Manejo de Bits
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Operadores de Manejo de Bits
         ManejoBits()

      End Sub

      Shared Sub ManejoBits()
      
         ' Operadores de manejo de bits
         Dim a As Integer
         Console.WriteLine()
         Console.WriteLine("Operadores de manejo de bits")
         Console.WriteLine("----------------------------")

         ' operadores
         Console.WriteLine()
         Console.WriteLine("and (And)")
         Console.WriteLine("----------")
         a = 7
         Console.WriteLine("a = {0}", a)
         a = a And 9
         Console.WriteLine("a = a And 9   (a = {0})", a)

         Console.WriteLine()
         Console.WriteLine("or (Or)")
         Console.WriteLine("----------")
         a = a Or 7
         Console.WriteLine("a = a Or 7   (a = {0})", a)

         Console.WriteLine()
         Console.WriteLine("xor (Xor)")
         Console.WriteLine("----------")
         a = a Xor 8
         Console.WriteLine("a = a Xor 8   (a = {0})", a)

         Console.WriteLine()
         Console.WriteLine("complemento (Not)")
         Console.WriteLine("-----------------")
         Console.WriteLine("Not a = {0}", Not a)

         Console.WriteLine()
         Console.WriteLine("desplazamiento derecha (>>)")
         Console.WriteLine("---------------------------")
         a = a >> 1
         Console.WriteLine("a = a >> 1   (a = {0})", a)

         Console.WriteLine()
         Console.WriteLine("desplazamiento izquierda (<<)")
         Console.WriteLine("-----------------------------")
         a = a << 1
         Console.WriteLine("a = a << 1   (a = {0})", a)

      End Sub

   End Class

End Namespace
