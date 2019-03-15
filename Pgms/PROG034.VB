' prog034.VB
' Programa: Concatenación de Strings
' LAOS
' Enero 2004

Imports System
Imports System.Text

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Concatenación de Strings
         ConcatenaStrings()

      End Sub

      Shared Sub ConcatenaStrings()
      
         ' Operador concatenación de strings
         Console.WriteLine()
         Console.WriteLine("Operador Concatenación de strings")
         Console.WriteLine("---------------------------------")

         ' varias formas de concatenar strings
         Dim hola As String = "Hola ", mundo = "Mundo"
         Console.WriteLine()
         Console.WriteLine("concatenación (+)")
         Console.WriteLine("-----------------")
         Console.WriteLine(hola + " " + mundo + "!")
         Console.WriteLine(string.Concat(hola, " ", mundo, ".Net!"))
         Console.WriteLine("5 * 2 = " + (5 * 2).ToString()) 
         Console.WriteLine("5 * 3 = " + (5 * 3).ToString()) 

         Console.WriteLine()
         Console.WriteLine("concatenación (&)")
         Console.WriteLine("-----------------")
         Console.WriteLine(hola & " " & mundo & "!")
         Console.WriteLine(string.Concat(hola, " ", mundo, ".Net!"))
         Console.WriteLine("5 * 2 = " & (5 * 2).ToString()) 
         Console.WriteLine("5 * 3 = " & (5 * 3).ToString()) 

         ' concatenación con StringBuilder
         Dim bye As StringBuilder = new StringBuilder("Bye bye")
         bye.Append(" World!")
         Console.WriteLine()
         Console.WriteLine("StringBuilder Append")
         Console.WriteLine("--------------------")
         Console.WriteLine(bye)

      End Sub

   End Class

End Namespace
