// prog037.CS
// Programa: Operadores de Asignación
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Operadores de asignación
         Asignacion();
      }

      static void Asignacion()
      {
         // Operadores de asignacion
         int a = 5;
         int n;
         Console.WriteLine();
         Console.WriteLine("Operadores de asignación");
         Console.WriteLine("------------------------");

         // operadores
         Console.WriteLine();
         Console.WriteLine("asignación (=)");
         Console.WriteLine("--------------");
         a = 6;
         Console.WriteLine("a = {0} \t\t( a = {0} )", a);
         n = 3;
         Console.WriteLine("n = {0} \t\t( n = {0} )", n);

         Console.WriteLine();
         Console.WriteLine("sume a | concatene a (+=)");
         Console.WriteLine("-------------------------");
         a = a + 5;
         Console.WriteLine("a = a + 5 \t( a = {0} )", a);
         a += 5;
         Console.WriteLine("a += 5 \t\t( a = {0} )", a);
         string s = "Hello";
         s += " World";
         Console.WriteLine("s += \" World\" \t( s = {0} )", s);

         Console.WriteLine();
         Console.WriteLine("reste a (-=)");
         Console.WriteLine("--------------");
         a = a - 5;
         Console.WriteLine("a = a - 5 \t( a = {0} )", a);
         a -= 5;
         Console.WriteLine("a -= 5 \t\t( a = {0} )", a);

         Console.WriteLine();
         Console.WriteLine("multiplique a (*=)");
         Console.WriteLine("------------------");
         a = a * 5;
         Console.WriteLine("a = a * 5 \t( a = {0} )", a);
         a *= 5;
         Console.WriteLine("a *= 5 \t\t( a = {0} )", a);

         Console.WriteLine();
         Console.WriteLine("divida a (/=)");
         Console.WriteLine("-------------");
         a = a / 5;
         Console.WriteLine("a = a / 5 \t( a = {0} )", a);
         a /= 5;
         Console.WriteLine("a /= 5 \t\t( a = {0} )", a);

         Console.WriteLine();
         Console.WriteLine("resto a (%=)");
         Console.WriteLine("------------------");
         a = a % 5;
         Console.WriteLine("a = a % 5 \t( a = {0} )", a);
         a %= 5;
         Console.WriteLine("a %= 5 \t\t( a = {0} )", a);

         Console.WriteLine();
         Console.WriteLine("and a (&=)");
         Console.WriteLine("------------------");
         bool b = true;
         Console.WriteLine("b = {0}", b);
         b = b & true;
         Console.WriteLine("b = b & true \t( b = {0} )", b);
         b &= false;
         Console.WriteLine("b &= false \t( b = {0} )", b);
         a = 0x07;
         Console.WriteLine("a = {0}", a);
         a &= 0x09;
         Console.WriteLine("a &= 0x09 ( a = {0} )", a);

         Console.WriteLine();
         Console.WriteLine("or a (|=)");
         Console.WriteLine("------------------");
         b = b | true;
         Console.WriteLine("b = b | true \t( b = {0} )", b);
         b |= false;
         Console.WriteLine("b |= false \t( b = {0} )", b);
         a |= 0x07;
         Console.WriteLine("a |= 0x07 ( a = {0} )", a);

         Console.WriteLine();
         Console.WriteLine("or exclusivo a (^=)");
         Console.WriteLine("-------------------");
         b = b ^ true;
         Console.WriteLine("b = b ^ true \t( b = {0} )", b);
         b ^= false;
         Console.WriteLine("b ^= false \t( b = {0} )", b);
         a ^= 0x08;
         Console.WriteLine("a ^= 0x08 ( a = {0} )", a);

         Console.WriteLine();
         Console.WriteLine("desplazamiento derecha a (>>=)");
         Console.WriteLine("------------------------------");
         a >>= 1;
         Console.WriteLine("a >>= 1 ( a = {0} )", a);

         Console.WriteLine();
         Console.WriteLine("desplazamiento izquierda a (<<=)");
         Console.WriteLine("--------------------------------");
         a <<= 1;
         Console.WriteLine("a <<= 1 ( a = {0} )", a);
      }
   }
}