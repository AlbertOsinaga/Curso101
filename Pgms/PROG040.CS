// prog040.CS
// Programa: Operador condicional
//           Cálculo de la supericie y perímetro de un círculo
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Operador condicional
         // Calcula la supericie y perímetro de un círculo
         CalculaCirculo();
      }

      static void CalculaCirculo()
      {
         // Declara variables
         const double PI = 3.14;
         double radio, Perímetro, superficie;
         System.Int32 veces = 0; // equivalente a int                  
         string linea;
         System.String nombre; // equivalente a string
         bool sigue;
         sigue = true;

         // Invita al usuario a ingresar su nombre
         Console.WriteLine();
         Console.Write("Por favor ingresa tu nombre: ");
         nombre = Console.ReadLine();

         // Procesa n requerimientos de cálculo
         // mientras usuario introduzca valor > cero
         while(sigue)
         {
            // Pide el radio
            Console.WriteLine();
            Console.Write("Ingrese Radio (0 para terminar): ");
            linea = Console.ReadLine();
            radio = Convert.ToDouble(linea);

            // Si es mayor a cero calcula
            sigue = (radio > 0);
           if(sigue)
           {
               // Calcula Perímetro y superficie
               Perímetro = 2 * PI * radio;
               superficie = PI * Math.Pow(radio, 2);
          
               // Despliega resultados
               Console.WriteLine("PI: " + Convert.ToString(PI));
               Console.WriteLine("Radio: " + Convert.ToString(radio));
               Console.WriteLine("Perímetro (2*PI*Radio): " + Convert.ToString(Perímetro));   		   
               Console.WriteLine("Superficie (PI*Radio*Radio): " + Convert.ToString(superficie));   		   

               // Incrementa contador de veces
               veces = veces + 1;
            }
         }

         // Se despide del Usuario
         Console.WriteLine();
         Console.WriteLine("Gracias " + nombre + " por usar este programa");
         Console.WriteLine("Se " + (veces != 1 ? "hicieron " : "hizo ") + Convert.ToString(veces) + " consulta" + (veces != 1 ? "s" : "") );
      }
   }
}