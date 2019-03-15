// prog051.CS
// Programa: Sentencia de ruptura throw 
//           (excepciones, try/catch)
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Intenta dividir por cero
         DividePorCero();
      }

      static void DividePorCero()
      {
         int n = 0;
         try
         {
            Console.WriteLine("Division por cero: {0}", 5/n); 
         }
         catch (DivideByZeroException e)
         {
            Console.WriteLine("Error! Se intento dividir por cero!");
            Console.WriteLine(e.Message); 
         } 
      }
   }
}