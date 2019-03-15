// prog032.CS
// Programa: Operadores Aritméticos
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Operadores aritméticos
         OperadoresAritmeticos();
      }

      static void OperadoresAritmeticos()
      {
         // Operadores Aritméticos
         int a = 5;
         Console.WriteLine();
         Console.WriteLine("Operadores Aritméticos");
         Console.WriteLine("----------------------");

         Console.WriteLine();
         Console.WriteLine("suma (+)");
         Console.WriteLine("----------");
         Console.WriteLine("(más unario) +a = {0}", +a); // más unario 
         Console.WriteLine("a + 1 = {0}",a + 1); 
         Console.WriteLine("a + .5 = {0}",a + .5);

         Console.WriteLine();
         Console.WriteLine("resta (-)");
         Console.WriteLine("----------");
         Console.WriteLine("(menos unario) -a = {0}", -a); // menos unario 
         Console.WriteLine("a - 1 = {0}",a - 1); 
         Console.WriteLine("a - .5 = {0}",a - .5);

         Console.WriteLine();
         Console.WriteLine("multiplicación (*)");
         Console.WriteLine("------------------");
         Console.WriteLine("5 * 2 = {0}",5 * 2);
         Console.WriteLine("-.5 * .2 = {0}",-.5 * .2);
         Console.WriteLine("-.5m * .2m = {0}",-.5m * .2m);

         Console.WriteLine();
         Console.WriteLine("división (/)");
         Console.WriteLine("------------");
         Console.WriteLine("5 / 2 = {0}",5 / 2);
         Console.WriteLine("-.5 / .2 = {0}",-.5 / .2);
         Console.WriteLine("-.5m / .2m = {0}",-.5m / .2m);

         Console.WriteLine();
         Console.WriteLine("resto (%)");
         Console.WriteLine("----------");
         Console.WriteLine("5 % 2 = {0}",5 % 2);
         Console.WriteLine("-5 % 2 {0}",-5 % 2);
         Console.WriteLine("5.0 % 2.2 = {0}",5.0 % 2.2);
         Console.WriteLine("5.0m % 2.2m = {0}",5.0m % 2.2m);
         Console.WriteLine("-5.2 % 2.0 = {0}",-5.2 % 2.0);
      }
   }
}