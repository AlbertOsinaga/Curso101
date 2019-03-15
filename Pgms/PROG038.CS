// prog038.CS
// Programa: Operadores de Incremento/Decremento
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Operadores de Incemento/Decremento
         IncrmentoDecremento();
      }

      static void IncrmentoDecremento()
      {
         // Operadores incremento y decremento
         int a = 5;
         Console.WriteLine();
         Console.WriteLine("Operadores incremento y decremento");
         Console.WriteLine("----------------------------------");

         // operadores
         Console.WriteLine();
         Console.WriteLine("incremento (++)");
         Console.WriteLine("---------------");
         Console.WriteLine("a = {0}", a);
         Console.WriteLine("(postfijo) a++ = {0}", a++);
         Console.WriteLine("(prefijo)  ++a = {0}", ++a);
         a++;
         Console.WriteLine("a++");
         Console.WriteLine("a = {0}", a);
   
         Console.WriteLine();
         Console.WriteLine("decremento (--)");
         Console.WriteLine("---------------");
         Console.WriteLine("(postfijo) a-- = {0}", a--);
         Console.WriteLine("(prefijo)  --a = {0}", --a);
         --a;
         Console.WriteLine("--a");
         Console.WriteLine("a = {0}", a);
      }
   }
}