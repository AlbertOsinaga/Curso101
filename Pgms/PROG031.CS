// prog031.CS
// Programa: Manejo de constantes
//           Calcula Superficie y perímetro de un círculo
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Calculo de la supericie y perímetro de un círculo
         CalculaCirculo();
      }

      static void CalculaCirculo()
      {
         // Declara constante
         const double Pi = 3.14;	

         // Declara variables
         double radio, circunferencia, superficie;
         System.Int32 veces = 0; // equivalente a int                  
         string linea;
         System.String nombre; // equivalente a string
         bool sigue;
         sigue = true;

         // Invita al usuario a ingresar su nombre
         Console.WriteLine();
         Console.WriteLine("Por favor ingresa tu nombre: ");
         nombre = Console.ReadLine();

         // Procesa n requerimientos de cálculo
         // mientras usuario introduzca valor > cero
         while(sigue)
         {
            // Pide el radio
            Console.WriteLine();
            Console.WriteLine("Ingrese Radio (0 para terminar): ");
            linea = Console.ReadLine();
            radio = Convert.ToDouble(linea);
         
            // Si es mayor a cero calcula
            sigue = (radio > 0);
            if(sigue)
            {
               // Calcula circunferencia y superficie
               circunferencia = 2 * Pi * radio;
               superficie = Pi * Math.Pow(radio, 2);
          
               // Despliega resultados
               Console.WriteLine("Valor de Pi {0}", Pi);
               Console.WriteLine("Circunferencia: " + Convert.ToString(circunferencia));   		   
               Console.WriteLine("Superficie: " + Convert.ToString(superficie));   		   

               // Incrementa contador de veces
               veces = veces + 1;
            }
         }

         // Se despide del Usuario
         Console.WriteLine();
         Console.WriteLine("Gracias " + nombre + " por usar este programa");
         Console.WriteLine("Se hicieron " + Convert.ToString(veces) + " consultas");
      }
   }
}