// prog035.CS
// Programa: Operadores de Comparación
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Operadores de Comparación
         OperadoresComparacion();
      }

      static void OperadoresComparacion()
      {
         // Operador de comparacion
         int a = 5;
         Console.WriteLine();
         Console.WriteLine("Operadores de comparación");
         Console.WriteLine("-------------------------");

         // operadores
         Console.WriteLine();
         Console.WriteLine("igual (==)");
         Console.WriteLine("----------");
         Console.WriteLine( "a == 5 es {0}", a == 5);
         Console.WriteLine( "a == 4 es {0}", a == 4);

         Console.WriteLine();
         Console.WriteLine("distinto (!=)");
         Console.WriteLine("-------------");
         Console.WriteLine( "a != 5 es {0}", a != 5);
         Console.WriteLine( "a != 4 es {0}", a != 4);

         Console.WriteLine();
         Console.WriteLine("mayor (>)");
         Console.WriteLine("-------------");
         Console.WriteLine( "a > 5 es {0}", a > 5);
         Console.WriteLine( "a > 4 es {0}", a > 4);

         Console.WriteLine();
         Console.WriteLine("menor (<)");
         Console.WriteLine("-------------");
         Console.WriteLine( "a < 5 es {0}", a < 5);
         Console.WriteLine( "a < 6 es {0}", a < 6);

         Console.WriteLine();
         Console.WriteLine("mayor o igual (>=)");
         Console.WriteLine("------------------");
         Console.WriteLine( "a >= 5 es {0}", a >= 5);
         Console.WriteLine( "a >= 6 es {0}", a >= 6);

         Console.WriteLine();
         Console.WriteLine("menor o igual (<=)");
         Console.WriteLine("------------------");
         Console.WriteLine( "a <= 5 es {0}", a <= 5);
         Console.WriteLine( "a <= 4 es {0}", a <= 4);
      }
   }
}