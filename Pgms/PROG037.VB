' prog037.VB
' Programa: Operadores de Asignación
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Operadores de Asignación
         Asignacion()

      End Sub

      Shared Sub Asignacion()
      
         ' Operadores de asignacion
         Dim Qt As Char = Convert.ToChar(34)
         Dim a As Integer = 5
         Dim n As Integer
         Console.WriteLine()
         Console.WriteLine("Operadores de asignación")
         Console.WriteLine("------------------------")

         ' operadores
         Console.WriteLine()
         Console.WriteLine("asignación (=)")
         Console.WriteLine("--------------")
         a = 6
         Console.WriteLine("a = {0} ( a = {0} )", a)
         n = 3
         Console.WriteLine("n = {0} ( n = {0} )", n)

         Console.WriteLine()
         Console.WriteLine("sume a | concatene a (+=) (&=)")
         Console.WriteLine("------------------------------")
         a = a + 5
         Console.WriteLine("a = a + 5 ( a = {0} )", a)
         a += 5
         Console.WriteLine("a += 5 ( a = {0} )", a)
         Dim s As String = "Hello"
         s += " World"
         Console.WriteLine("s += " + Qt + "World" + Qt + "   ( s = {0} )", s)
         s &= " World"
         Console.WriteLine("s &= " + Qt + "World" + Qt + "   ( s = {0} )", s)

         Console.WriteLine()
         Console.WriteLine("reste a (-=)")
         Console.WriteLine("--------------")
         a = a - 5
         Console.WriteLine("a = a - 5 ( a = {0} )", a)
         a -= 5
         Console.WriteLine("a -= 5 ( a = {0} )", a)

         Console.WriteLine()
         Console.WriteLine("multiplique a (*=)")
         Console.WriteLine("------------------")
         a = a * 5
         Console.WriteLine("a = a * 5 ( a = {0} )", a)
         a *= 5
         Console.WriteLine("a *= 5 ( a = {0} )", a)

         Console.WriteLine()
         Console.WriteLine("divida a (/=)")
         Console.WriteLine("-------------")
         a = a / 5
         Console.WriteLine("a = a / 5 ( a = {0} )", a)
         a /= 5
         Console.WriteLine("a /= 5 ( a = {0} )", a)

         Console.WriteLine()
         Console.WriteLine("divida a (\=)")
         Console.WriteLine("-------------")
         a = a \ 5
         Console.WriteLine("a = a \ 5 ( a = {0} )", a)
         a \= 5
         Console.WriteLine("a \= 5 ( a = {0} )", a)

         Console.WriteLine()
         Console.WriteLine("potencia a (^=)")
         Console.WriteLine("------------------")
         a = 6 
         Console.WriteLine("a = {0}", a)
         a = a ^ 2
         Console.WriteLine("a = a ^ 2 ( a = {0} )", a)
         a ^= 3
         Console.WriteLine("a ^= 3 ( a = {0} )", a)

         Console.WriteLine()
         Console.WriteLine("desplazamiento derecha a (>>=)")
         Console.WriteLine("------------------------------")
         a = 15 
         Console.WriteLine("a = {0}", a)
         a >>= 1
         Console.WriteLine("a >>= 1 ( a = {0} )", a)

         Console.WriteLine()
         Console.WriteLine("desplazamiento izquierda a (<<=)")
         Console.WriteLine("--------------------------------")
         a <<= 1
         Console.WriteLine("a <<= 1 ( a = {0} )", a)

      End Sub

   End Class

End Namespace
