' prog042.VB
' Programa: Sentencia de control If
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Valida nmeros del 1 al 9
         ValidaNumero()

      End Sub

      Shared Sub ValidaNumero()
      
          ' variables locales
          const Digitos As String = "123456789"
          Dim sNumero As String
          Dim nNumero As Integer
       
          ' pide un número al usuario
          Console.WriteLine()
          Console.Write("Introduzca un número del 1 al 9: ")
          sNumero = Console.ReadLine()

          ' Si número es válido 
          If sNumero.Length = 1  And  Digitos.IndexOf(sNumero) >= 0
           
              ' Identifica nmero como par o impar
              nNumero = Int32.Parse(sNumero)
              If nNumero Mod 2 = 0
                 Console.WriteLine("Su número es par!")
              Else 
                 Console.WriteLine("Su número es impar!")
              End If

              ' Despedida
              Console.WriteLine("Buena suerte!")

          ' Si número es inválido
          Else 

             Console.WriteLine("Lo lamentamos! Solo se aceptan números del 1 al 9")

          End If

      End Sub

   End Class

End Namespace
