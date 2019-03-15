// prog041.CS
// Programa: Operadores de control de desbordamiento
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Operadores de control de desbordamiento
         ControlDesborde();
      }

      static void ControlDesborde()
      {
         // Operadores de control de desbordamiento
         int a;
         Console.WriteLine();
         Console.WriteLine("Operadores de control de desbordamiento");
         Console.WriteLine("---------------------------------------");

         // operadores
         Console.WriteLine();
         Console.WriteLine("unchecked");
         Console.WriteLine("---------");
         a = int.MaxValue; 
         Console.WriteLine("a = {0}", a);
         //a++;
         Console.WriteLine("a = {0}", a);
         //a--;
        
         Console.WriteLine();
         Console.WriteLine("checked");
         Console.WriteLine("-------");
         // checked
         // {
            unchecked 
            {
               a++;
               Console.WriteLine("a = {0}", a);
            }
         // }
      }
   }
}