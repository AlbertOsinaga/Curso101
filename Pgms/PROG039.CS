// prog039.CS
// Programa: Operador cast
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Operador cast
         Casting();
      }

      static void Casting()
      {
         int a = 5;
         double d = (double) a;
         Console.WriteLine();
         Console.WriteLine("Casting");
         Console.WriteLine("-------");
         Console.WriteLine("a es un int: {0}", a.ToString());
         Console.WriteLine("d es un double asignado con casting \"d = (double) a\": {0}", d.ToString());
      }
   }
}