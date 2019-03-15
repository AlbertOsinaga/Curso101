// prog033.CS
// Programa: Operadores Lógicos
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Operadores lógicos
         OperadoresLogicos();
      }

      static void OperadoresLogicos()
      {
         // Operadores Lógicos
         int a;
         Console.WriteLine();
         Console.WriteLine("Operadores Lógicos");
         Console.WriteLine("------------------");

         a = 5;
         Console.WriteLine();
         Console.WriteLine("y (&)");
         Console.WriteLine("---------------");
         Console.WriteLine("\"(a=4) == 5  &  (a=8) == 8\" es {0}", (a=4) == 5  &  (a=8) == 8);
         Console.WriteLine("a = {0}", a);

         a = 5;
         Console.WriteLine();
         Console.WriteLine("ó (|)");
         Console.WriteLine("---------------");
         Console.WriteLine("\"(a=4) == 4  |  (a=8) == 8\" es {0}", (a=4) == 4  |  (a=8) == 8);
         Console.WriteLine("a = {0}", a);

         a = 5;
         Console.WriteLine();
         Console.WriteLine("ó exclusivo (^)");
         Console.WriteLine("---------------");
         Console.WriteLine("\"(a=4) == 4   ^  (a=8) == 8\" es {0}", (a=4) == 4   ^  (a=8) == 8);
         Console.WriteLine("a = {0}", a);

         a = 5;
         Console.WriteLine();
         Console.WriteLine("y (&&)");
         Console.WriteLine("---------------");
         Console.WriteLine("\"(a=4) == 5  &&  (a=8) == 8\" es {0}", (a=4) == 5  &&  (a=8) == 8);
         Console.WriteLine("a = {0}", a);

         a = 5;
         Console.WriteLine();
         Console.WriteLine("ó (||)");
         Console.WriteLine("---------------");
         Console.WriteLine("\"(a=4) == 4  ||  (a=8) == 8\" es {0}", (a=4) == 4  ||  (a=8) == 8);
         Console.WriteLine("a = {0}", a);

         a = 5;
         Console.WriteLine();
         Console.WriteLine("no (!)");
         Console.WriteLine("---------------");
         Console.WriteLine("\"!(a==4)\" es {0}", !(a==4));
         Console.WriteLine("a = {0}", a);
      }
   }
}