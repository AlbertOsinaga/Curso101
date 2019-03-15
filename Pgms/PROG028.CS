// prog028.CS
// Programa: Arrays en la línea de comandos
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Suma dos números de la línea de comandos
         SumaNumeros();
      }

      static void SumaNumeros()
      {
         // Linea en blanco
         Console.WriteLine();
      
         // Obtiene arrays de strings de la linea de comandos
         string[] args = Environment.GetCommandLineArgs();

         // Verifica existencia de dos números
         if (args.Length < 3)
         {
             Console.WriteLine("Forma de Uso: prog028 num1 num2");  
             return;
         }

         // Suma y despliega resultado
         Console.WriteLine("{0}: {1} + {2} = {3}", args[0], args[1], args[2],Int32.Parse(args[1]) + Int32.Parse(args[2]));
      }

   }
}