// prog076.CS
// Programa: Clases públicas (Exe)
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Servicio
   {
      static public void Dice()
      { 
         Console.WriteLine(); 
         Console.WriteLine(); 
         Console.WriteLine("Este es un servicio"); 
         Console.Write("Veo que Cliente dice: ");
         Cliente.Dice();
      }
   }

   class Operacion
   {
      static public void Dice()
      { 
         Console.WriteLine(); 
         Console.WriteLine(); 
         Console.WriteLine("Esta es una operación"); 
         Console.Write("Veo que Cliente dice: ");
         Cliente.Dice();
      }
   }

   class Central
   {
      static void Main()
      {
         Console.WriteLine(); 
         Cliente.Dice();
         // ClienteEspecial.Dice();   // no compila
         // ClienteExclusivo.Dice();  // no compila
         Servicio.Dice(); 
         Operacion.Dice();
         Console.WriteLine(); 
      }
   }   
}