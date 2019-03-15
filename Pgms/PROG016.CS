// prog016.CS
// Programa: Uso de variables
//           Calcula el perímetro
//           y la circunferencia de un círculo
// LAOS
// Enero 2004


using System;

namespace CursoNet
{

   class Principal
   {
      static void Main()
      {
         // Saluda
         Saludar();
 
         // Hace cálculos dado el radio de un círculo
         CalcularCirculos();
      }

      static void Saludar()
      {
         // Invita al usuario a ingresar su nombre
         Console.WriteLine();
         Console.Write("Por favor ingresa tu nombre: ");
         string nombre = Console.ReadLine();
         Console.WriteLine();
         Console.WriteLine("Hola " + nombre + ", cómo te va?");
         Console.WriteLine("Este programa te permitirá obtener");
         Console.WriteLine("el perímetro y la superficie de un círculo");
	 Console.WriteLine("dado su radio.");
      }

      static void CalcularCirculos()
      { 
         // Declara variables
         double radio, circunferencia, superficie;
         System.Int32 veces = 0; // equivalente a int                  
         string linea;
         bool sigue;
         sigue = true;

         // Procesa n requerimientos de cálculo
         // mientras usuario introduzca valor mayor a cero
         while(sigue)
         {
            // Pide el radio
            Console.WriteLine();
            Console.Write("Por favor ingresa el radio de un círculo (0 para terminar): ");
            linea = Console.ReadLine();
            radio = Convert.ToDouble(linea);
         
            // Si es mayor a cero calcula
            sigue = (radio > 0);
            if(sigue)
            {
               // Calcula circunferencia y superficie
               circunferencia = 2 * 3.14 * radio;
               superficie = 3.14 * Math.Pow(radio, 2);
          
               // Despliega resultados
               Console.WriteLine();
               Console.WriteLine("Círculo de radio: {0}", radio);
               Console.WriteLine("Perímetro: " + Convert.ToString(circunferencia));   		   
               Console.WriteLine("Superficie: " + Convert.ToString(superficie));   		   

               // Incrementa contador de veces
               veces = veces + 1;
            }
         }

         // Se despide del Usuario
         Console.WriteLine();
         Console.WriteLine("Gracias por usar este programa!");
         Console.WriteLine("Se hicieron " + Convert.ToString(veces) + " consultas!");
      }
   }
}