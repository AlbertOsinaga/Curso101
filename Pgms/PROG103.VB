' prog103.VB
' Programa: Diccionario
' LAOS
' Enero 2004

Imports System
Imports System.Collections.Specialized

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Maneja un Directorio telefónico
         Dim telefonos As DirectorioTelefonico = new DirectorioTelefonico()
         telefonos.Run()

      End Sub

   End Class 

   Class DirectorioTelefonico
   
      ' Constructores
      Public Sub New()
      
         d = New StringDictionary() 

      End Sub
  
      ' Métodos públicos
      Public Sub Run()
      
         Dim palabra As String = ""
         Console.WriteLine()
         Console.WriteLine("Programa Directorio Telefónico")
         Console.WriteLine("------------------------------")
         Do
         
            ' Usuario introduce operación
            Console.WriteLine()
            Console.WriteLine("'+' nombre-Teléfono  Ingresa entrada en el directorio")
            Console.WriteLine("'-' nombre  Remueve entrada del directorio")
            Console.WriteLine("'=' nombre  Despliega nombre-telefono del directorio")
            Console.WriteLine("'*' Termina el programa")
            Console.WriteLine()
            Console.Write("Introduzca su operación: ")
            palabra = Console.ReadLine()
            
            ' Si símbolo es '*' termina
            If palabra.Substring(0, 1) = "*"c
            
                Console.WriteLine()
                Console.WriteLine("Fin del programa")
                Exit Do

            End If                

	    ' Valida símbolo
            If  "+-=".IndexOf(palabra.Substring(0, 1)) < 0 
            
               Console.WriteLine()
               Console.WriteLine("Símbolo equivocado. Los símbolos de inicio válidos son: '+','-','=','*'")
               GoTo Continue

            End If   
               		 
            ' Valida palabra (existencia nombre-telefono a ingresar)
            If palabra.Substring(0, 1) = "+"c  AndAlso  palabra.Length < 3
            
               Console.WriteLine()
               Console.WriteLine("Después del símbolo '+', introduzca nombre-telefono después de un espacio!")
               GoTo Continue

            End If   
 
            ' Valida nombre-telefono (existencia de ambos para el ingreso)  
            If palabra.Substring(0, 1) = "+"c  AndAlso  (palabra.IndexOf("-") <= 2  OrElse  palabra.IndexOf("-") = palabra.Length - 1)
            
               Console.WriteLine()
               Console.WriteLine("Después del símbolo '+', introduzca nombre-telefono después de un espacio!")
               GoTo Continue

            End If

            ' Valida existencia de nombre para remover   
            If palabra.Substring(0, 1) = "-"c  AndAlso  palabra.Length < 3
            
               Console.WriteLine()
               Console.WriteLine("Después del símbolo '-', introduzca nombre a remover!")
               GoTo Continue

            End If   
 
            ' Valida existencia de nombre para despliegue de teléfono   
            If palabra.Substring(0, 1) = "="c  AndAlso  palabra.Length < 3
            
               Console.WriteLine()
               Console.WriteLine("Después del símbolo '=', introduzca nombre de la persona!")
               GoTo Continue

            End If
 
            Select palabra.Substring(0, 1)
            
               Case "+"c
                  Dim indiceGuion As Integer = palabra.IndexOf("-")
                  Dim nombre As String = palabra.Substring(2, indiceGuion - 2)
                  Dim telefono As String = palabra.Substring(indiceGuion + 1, palabra.Length - 1 - indiceGuion)
                  d(nombre) = telefono
                  Console.WriteLine(nombre + "-" + telefono + " fué ingresado...")
 
              case "-"c
                  If d.Count < 1
                  
                     Console.WriteLine("El directorio est vacío!")
                     GoTo Continue

                  End If
                  Dim nombre As String = palabra.Substring(2)
                  Dim telefono As String = d(nombre)
                  If telefono = Nothing
                  
                     Console.WriteLine("No existe teléfono registrado para " + nombre + "!")
                     GoTo Continue

                  End If
                  d.Remove(nombre)      
                  Console.WriteLine(nombre + "-" + " fué removido...")

               case "="c   
                  If d.Count < 1
                  
                     Console.WriteLine("El directorio est vacío!")
                     GoTo Continue

                  End If
                  Dim nombre As String = palabra.Substring(2)
                  Dim telefono As String = d(nombre)
                  If telefono = Nothing
                  
                     Console.WriteLine("No existe teléfono registrado para " + nombre + "!")
                     GoTo Continue

                  End If
                  Console.WriteLine(nombre + "-" + telefono)

               Case Else
                  Console.WriteLine("Esto no debíera suceder nunca, lo prometo!")

            End Select    


            Continue:
         Loop while(palabra.Substring(0, 1) <> "*"c)

      End Sub

      ' Campos privados
      private Dim d As StringDictionary       

   End Class

End Namespace
