' prog044.VB
' Programa: Sentencia de control Select
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
       Console.WriteLine("Introduzca su número preferido (1 a 9): ")
       sNumero = Console.ReadLine()

       ' Si número es válido 
       If sNumero.Length = 1  AndAlso  Digitos.IndexOf(sNumero) >= 0
        
           ' Indica datos de adivinanza
           nNumero = Int32.Parse(sNumero) 
           Select nNumero
            
               case 1  
               
               Console.WriteLine("Su día de suerte es el lunes!")
               Console.WriteLine("El color que le dá suerte es el rojo!")
               Console.WriteLine("Su destino está vinculado al planeta Marte")

               case 2
 
               Console.WriteLine("Su día de suerte es el martes!")
               Console.WriteLine("El color que le dá suerte es el azul!")
               Console.WriteLine("Su destino está vinculado al planeta Venus")
            
               case 3
           
               Console.WriteLine("Su día de suerte es el miércoles!")
               Console.WriteLine("El color que le dá suerte es el amarillo!")
               Console.WriteLine("Su destino está vinculado al planeta Saturno")

               case 4
           
               Console.WriteLine("Su día de suerte es el jueves!")
               Console.WriteLine("El color que le dá suerte es el verde!")
               Console.WriteLine("Su destino está vinculado al planeta Júpiter")
 
               case 5, 6
           
               Console.WriteLine("Su día de suerte es el viernes!")
               Console.WriteLine("El color que le dá suerte es el azul!")
               Console.WriteLine("Su destino está vinculado al planeta Plutón")

               case 7, 8
           
               Console.WriteLine("Su día de suerte es el sábado!")
               Console.WriteLine("El color que le dá suerte es el rosado!")
               Console.WriteLine("Su destino está vinculado al planeta Mercurio")
 
               Case Else	'case 9
           
               Console.WriteLine("Su día de suerte es el domingo!")
               Console.WriteLine("El color que le dá suerte es el naranja!")
               Console.WriteLine("Su destino está vinculado al planeta Neptuno")

           End Select

           ' Despedida
           Console.WriteLine("Buena suerte!")
 
       ' Si número es inválido
       Else 
 
          Console.WriteLine("Lo lamentamos! Solo se aceptan números del 1 al 9")

       End If

      End Sub

   End Class

End Namespace
