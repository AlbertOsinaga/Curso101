// prog015.CS
// Programa: Literales de tipos primitivos
// LAOS
// Enero 2004

using System;

namespace CursoNet
{

   class Principal
   {
      static void Main()
      {
         // Despliega nombre del tipo de literal

         Console.WriteLine();
         Console.WriteLine("(100): {0}", (100).GetType().ToString());
         Console.WriteLine("(100L): {0}", (100L).GetType().ToString());
         Console.WriteLine("(100U): {0}", (100U).GetType().ToString());
         Console.WriteLine("(100UL): {0}", (100UL).GetType().ToString());
         Console.WriteLine("(1500.35F): {0}", (1500.35F).GetType().ToString());
         Console.WriteLine("(1500.35): {0}", (1500.35).GetType().ToString());
         Console.WriteLine("(1500.35D): {0}", (1500.35D).GetType().ToString());
         Console.WriteLine("(1500.35M): {0}", (1500.35M).GetType().ToString());
         Console.WriteLine("('A'): {0}", ('A').GetType().ToString());
         Console.WriteLine("(true): {0}", (true).GetType().ToString());
         Console.WriteLine("(\"Hello World\"): {0}", ("Hello World").GetType().ToString());
      }
   }
}