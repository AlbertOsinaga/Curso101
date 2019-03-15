// prog034.CS
// Programa: Concatenación de Strings
// LAOS
// Enero 2004

using System;
using System.Text;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Concatenación de Strings
         ConcatenaStrings();
      }

      static void ConcatenaStrings()
      {
         // Operador concatenación de strings
         Console.WriteLine();
         Console.WriteLine("Operador Concatenación de strings");
         Console.WriteLine("---------------------------------");

         // varias formas de concatenar strings
         string hola = "Hola ", mundo = "Mundo";
         Console.WriteLine();
         Console.WriteLine("concatenación (+)");
         Console.WriteLine("-----------------");
         Console.WriteLine(hola + " " + mundo + "!");
         Console.WriteLine(string.Concat(hola, " ", mundo, ".Net!"));
         Console.WriteLine("5 * 2 = " + (5 * 2).ToString()); 
         Console.WriteLine("5 * 3 = " + (5 * 3).ToString()); 

         // concatenación con StringBuilder
         StringBuilder bye = new StringBuilder("Bye bye");
         bye.Append(" World!");
         Console.WriteLine();
         Console.WriteLine("StringBuilder Append");
         Console.WriteLine("--------------------");
         Console.WriteLine(bye);
      }
   }
}