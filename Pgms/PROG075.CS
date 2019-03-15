// prog075.CS
// Programa: Clases públicas (Exe/Dll)
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   public class Cliente
   {
      static public void Dice()
      { 
         Console.Write("Yo soy un Cliente"); 
      }
   }

   internal class ClienteEspecial
   {
      static public void Dice()
      { 
         Console.WriteLine(); 
         Console.WriteLine(); 
         Console.WriteLine("Yo soy un Cliente Especial"); 
         Console.Write("Veo que Cliente dice: ");
         Cliente.Dice();
      }
   }

   class ClienteExclusivo
   {
      static public void Dice()
      { 
         Console.WriteLine(); 
         Console.WriteLine(); 
         Console.WriteLine("Yo soy un Cliente Exclusivo"); 
         Console.Write("Veo que Cliente dice: ");
         Cliente.Dice();
      }
   }

   class Principal
   {
      static void Main()
      {
         Console.WriteLine(); 
         Cliente.Dice();
         ClienteEspecial.Dice(); 
         ClienteExclusivo.Dice();
         Console.WriteLine(); 
      }
   }   
}