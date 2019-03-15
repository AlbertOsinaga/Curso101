' prog016.VB
' Programa: Uso de variables
'           Calcula el perímetro
'           y la circunferencia de un círculo
' LAOS
' Enero 2004


Imports System

Namespace CursoNet


   Class Principal
   
      Shared Sub Main()
         ' Saluda
         Saludar()
 
         ' Hace cálculos dado el radio de un círculo
         CalcularCirculos()
      End Sub

      Shared Sub Saludar()
         ' Invita al usuario a ingresar su nombre
         Console.WriteLine()
         Console.Write("Por favor ingresa tu nombre: ")
         Dim nombre As String = Console.ReadLine()
         Console.WriteLine()
         Console.WriteLine("Hola " + nombre + ", cómo te va?")
         Console.WriteLine("Este programa te permitirá obtener")
         Console.WriteLine("el perímetro y la superficie de un círculo")
	 Console.WriteLine("dado su radio.")
      End Sub

      Shared Sub CalcularCirculos()
         ' Declara variables
         Dim radio, circunferencia, superficie As Double
         Dim veces As System.Int32 = 0 	' equivalente a Integer                  
         Dim linea As String
         Dim sigue As Boolean
         sigue = True

         ' Procesa n requerimientos de cálculo
         ' mientras usuario introduzca valor mayor a cero
         Do While sigue
         
            ' Pide el radio
            Console.WriteLine()
            Console.Write("Por favor ingresa el radio de un círculo (0 para terminar): ")
            linea = Console.ReadLine()
            radio = Convert.ToDouble(linea)
         
            ' Si es mayor a cero calcula
            sigue = (radio > 0)
            If sigue
            
               ' Calcula circunferencia y superficie
               circunferencia = 2 * 3.14 * radio
               superficie = 3.14 * Math.Pow(radio, 2)
          
               ' Despliega resultados
               Console.WriteLine()
               Console.WriteLine("Círculo de radio: {0}", radio)
               Console.WriteLine("Perímetro: " + Convert.ToString(circunferencia))   		   
               Console.WriteLine("Superficie: " + Convert.ToString(superficie))   		   

               ' Incrementa contador de veces
               veces = veces + 1

            End If

         Loop

         ' Se despide del Usuario
         Console.WriteLine()
         Console.WriteLine("Gracias por usar este programa!")
         Console.WriteLine("Se hicieron " + Convert.ToString(veces) + " consultas!")
      End Sub

   End Class

End Namespace