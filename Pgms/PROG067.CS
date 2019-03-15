// prog067.CS
// Programa: boxing y unboxing
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   // Definición de la clase Principal
   class Principal
   {
      static void Main()
      {
         // Boxing y unboxing de variables
         BoxingYUnboxing();
      }

      static void BoxingYUnboxing()
      {
         // Variable local    
         decimal monto = 10M/3M;
         
         // boxing
         object obj = monto;
         Console.WriteLine();
         Console.WriteLine("Objeto boxing de un decimal - Tipo: {0}", obj.GetType());
         Console.WriteLine("Objeto boxing de un decimal - Valor: {0}", obj);

         // unboxing
         decimal dMonto = (decimal) obj;
         Console.WriteLine();
         Console.WriteLine("Valor unboxing de un decimal - Tipo: {0}", dMonto.GetType());
         Console.WriteLine("Valor unboxing de un decimal - Valor: {0}", dMonto);
         Console.WriteLine("Valor unboxing de un decimal - decimal.Round(): {0}", decimal.Round(dMonto,2));
      }
   }
}