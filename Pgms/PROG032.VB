' prog032.VB
' Programa: Operadores Aritmticos
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Operadores aritmticos
         OperadoresAritmeticos()

      End Sub

      Shared Sub OperadoresAritmeticos()
      
         ' Operadores Aritmticos
         Dim a As Integer = 5
         Console.WriteLine()
         Console.WriteLine("Operadores Aritmticos")
         Console.WriteLine("----------------------")

         Console.WriteLine()
         Console.WriteLine("suma (+)")
         Console.WriteLine("----------")
         Console.WriteLine("(ms unario) +a = {0}", +a) ' ms unario 
         Console.WriteLine("a + 1 = {0}",a + 1) 
         Console.WriteLine("a + .5 = {0}",a + .5)

         Console.WriteLine()
         Console.WriteLine("resta (-)")
         Console.WriteLine("----------")
         Console.WriteLine("(menos unario) -a = {0}", -a) ' menos unario 
         Console.WriteLine("a - 1 = {0}",a - 1) 
         Console.WriteLine("a - .5 = {0}",a - .5)

         Console.WriteLine()
         Console.WriteLine("multiplicacin (*)")
         Console.WriteLine("------------------")
         Console.WriteLine("5 * 2 = {0}",5 * 2)
         Console.WriteLine("-.5 * .2 = {0}",-.5 * .2)
         Console.WriteLine("-.5d * .2d = {0}",-.5d * .2d)

         Console.WriteLine()
         Console.WriteLine("divisin (/)")
         Console.WriteLine("------------")
         Console.WriteLine("5 \ 2 = {0}",5 \ 2)
         Console.WriteLine("-.5 / .2 = {0}",-.5 / .2)
         Console.WriteLine("-.5d / .2d = {0}",-.5d / .2d)

         Console.WriteLine()
         Console.WriteLine("resto (%)")
         Console.WriteLine("----------")
         Console.WriteLine("5 Mod 2 = {0}",5 MOd 2)
         Console.WriteLine("-5 Mod 2 {0}",-5 Mod 2)
         Console.WriteLine("5.0 Mod 2.2 = {0}",5.0 Mod 2.2)
         Console.WriteLine("5.0d Mod 2.2d = {0}",5.0d Mod 2.2d)
         Console.WriteLine("-5.2 Mod 2.0 = {0}",-5.2 Mod 2.0)

      End Sub

   End Class

End Namespace
