// prog036.CS
// Programa: Operadores de Manejo de Bits
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Operadores de Manejo de Bits
         ManejoBits();
      }

      static void ManejoBits()
      {
         // Operadores de manejo de bits
         int a;
         Console.WriteLine();
         Console.WriteLine("Operadores de manejo de bits");
         Console.WriteLine("----------------------------");

         // operadores
         Console.WriteLine();
         Console.WriteLine("and (&)");
         Console.WriteLine("----------");
         a = 0x07;
         Console.WriteLine("a = {0}", a);
         a = a & 0x09;
         Console.WriteLine("a = a & 0x09   (a = {0})", a);

         Console.WriteLine();
         Console.WriteLine("or (|)");
         Console.WriteLine("----------");
         a = a |0x07;
         Console.WriteLine("a = a |0x07   (a = {0})", a);

         Console.WriteLine();
         Console.WriteLine("xor (^)");
         Console.WriteLine("----------");
         a = a ^ 0x08;
         Console.WriteLine("a = a ^ 0x08   (a = {0})", a);

         Console.WriteLine();
         Console.WriteLine("complemento (~)");
         Console.WriteLine("---------------");
         Console.WriteLine("~a = {0:X}", ~a);

         Console.WriteLine();
         Console.WriteLine("desplazamiento derecha (>>)");
         Console.WriteLine("---------------------------");
         a = a >> 1;
         Console.WriteLine("a = a >> 1   (a = {0})", a);

         Console.WriteLine();
         Console.WriteLine("desplazamiento izquierda (<<)");
         Console.WriteLine("-----------------------------");
         a = a << 1;
         Console.WriteLine("a = a << 1   (a = {0})", a);
      }
   }
}