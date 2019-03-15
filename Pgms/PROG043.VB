' prog043.VB
' Programa: Sentencia de control If ElseIf
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Arroja suerte de acuerdo a un número del 1 al 9
         SacaSuerte()

      End Sub

      Shared Sub SacaSuerte()
      
          ' variables locales
          const Digitos As String = "123456789"
          Dim sNumero As String
          Dim nNumero As Integer
       
          ' pide un número al usuario
          Console.WriteLine()
          Console.Write("Introduzca su número preferido (1 a 9): ")
          sNumero = Console.ReadLine()

          ' Si número es válido 
          If sNumero.Length = 1  AND  Digitos.IndexOf(sNumero) >= 0
           
              ' Indica datos de adivinanza
              nNumero = Int32.Parse(sNumero) 
              If nNumero = 1
                
                  Console.WriteLine("Su día de suerte es el lunes!")
                  Console.WriteLine("El color que le da suerte es el rojo!")
                  Console.WriteLine("Su destino est vinculado al planeta Marte")

              ElseIf nNumero = 2
               
                  Console.WriteLine("Su día de suerte es el martes!")
                  Console.WriteLine("El color que le da suerte es el azul!")
                  Console.WriteLine("Su destino est vinculado al planeta Venus")

              ElseIf nNumero = 3
              
                  Console.WriteLine("Su día de suerte es el mircoles!")
                  Console.WriteLine("El color que le da suerte es el amarillo!")
                  Console.WriteLine("Su destino est vinculado al planeta Saturno")

              ElseIf nNumero = 4
              
                  Console.WriteLine("Su día de suerte es el jueves!")
                  Console.WriteLine("El color que le da suerte es el verde!")
                  Console.WriteLine("Su destino est vinculado al planeta Júpiter")

              ElseIf nNumero = 5
              
                  Console.WriteLine("Su día de suerte es el viernes!")
                  Console.WriteLine("El color que le da suerte es el azul!")
                  Console.WriteLine("Su destino est vinculado al planeta Plutón")

              ElseIf nNumero = 6
              
                  Console.WriteLine("Su día de suerte es el viernes!")
                  Console.WriteLine("El color que le da suerte es el azul!")
                  Console.WriteLine("Su destino est vinculado al planeta Plutón")

              ElseIf nNumero = 7
              
                  Console.WriteLine("Su día de suerte es el sbado!")
                  Console.WriteLine("El color que le da suerte es el rosado!")
                  Console.WriteLine("Su destino est vinculado al planeta Mercurio")

              ElseIf nNumero = 8
              
                  Console.WriteLine("Su día de suerte es el sbado!")
                  Console.WriteLine("El color que le da suerte es el rosado!")
                  Console.WriteLine("Su destino est vinculado al planeta Mercurio")

              Else		'If nNumero = 9
              
                  Console.WriteLine("Su día de suerte es el domingo!")
                  Console.WriteLine("El color que le da suerte es el naranja!")
                  Console.WriteLine("Su destino est vinculado al planeta Neptuno")

              End If

              ' Despedida
              Console.WriteLine("Buena suerte!")

          ' Si nmero es invlido
          Else 
             Console.WriteLine("Lo lamentamos! Solo se aceptan números del 1 al 9")

          End If

      End Sub

   End Class

End Namespace
