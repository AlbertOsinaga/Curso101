' prog031.VB
' Programa: Manejo de constantes
'           Calcula Superficie y perímetro de un círculo
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Calculo de la supericie y perímetro de un círculo
         CalculaCirculo()

      End Sub

      Shared Sub CalculaCirculo()
      
         ' Declara constante
         Const Pi As Double = 3.14	

         ' Declara variables
         Dim radio, circunferencia, superficie As Double
         Dim veces As System.Int32 = 0 ' equivalente a int                  
         Dim linea As String
         Dim nombre As String ' equivalente a string
         Dim sigue As Boolean
         sigue = true

         ' Invita al usuario a ingresar su nombre
         Console.WriteLine()
         Console.Write("Por favor ingresa tu nombre: ")
         nombre = Console.ReadLine()

         ' Procesa n requerimientos de clculo
         ' mientras usuario introduzca valor > cero
         Do While sigue
         
            ' Pide el radio
            Console.WriteLine()
            Console.Write("Ingrese Radio (0 para terminar): ")
            linea = Console.ReadLine()
            radio = Convert.ToDouble(linea)
         
            ' Si es mayor a cero calcula
            sigue = (radio > 0)
            If sigue
            
               ' Calcula circunferencia y superficie
               circunferencia = 2 * Pi * radio
               superficie = Pi * Math.Pow(radio, 2)
          
               ' Despliega resultados
               Console.WriteLine("Valor de Pi {0}", Pi)
               Console.WriteLine("Circunferencia: " + Convert.ToString(circunferencia))   		   
               Console.WriteLine("Superficie: " + Convert.ToString(superficie))   		   

               ' Incrementa contador de veces
               veces = veces + 1

            End If

         Loop 

         ' Se despide del Usuario
         Console.WriteLine()
         Console.WriteLine("Gracias " + nombre + " por usar este programa")
         Console.WriteLine("Se hicieron " + Convert.ToString(veces) + " consultas")

      End Sub

   End Class

End Namespace
