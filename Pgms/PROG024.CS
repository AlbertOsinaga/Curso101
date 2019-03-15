// prog024.CS
// Programa: Enums
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   public enum Dia
   {
      Lunes,
      Martes,
      Miercoles,
      Jueves,
      Viernes,
      Sabado,
      Domingo
   }

   class Principal
   {
      static void Main()
      {
         // Dias de la semana
         DiasDeSemana();
      } 
        
      static void DiasDeSemana()
      {
         // Enum System.Windows.Forms.Day
         Console.WriteLine();
         Console.WriteLine("Enum Dia (Dias de la semana)");
         Console.WriteLine("----------------------------");
         Console.WriteLine("{0}: {1}", Dia.Lunes, Convert.ToInt32(Dia.Lunes)); 
         Console.WriteLine("{0}: {1}", Dia.Martes, Convert.ToInt32(Dia.Martes)); 
         Console.WriteLine("{0}: {1}", Dia.Miercoles, Convert.ToInt32(Dia.Miercoles)); 
         Console.WriteLine("{0}: {1}", Dia.Jueves, Convert.ToInt32(Dia.Jueves)); 
         Console.WriteLine("{0}: {1}", Dia.Viernes, Convert.ToInt32(Dia.Viernes)); 
         Console.WriteLine("{0}: {1}", Dia.Sabado, Convert.ToInt32(Dia.Sabado)); 
         Console.WriteLine("{0}: {1}", Dia.Domingo, Convert.ToInt32(Dia.Domingo)); 

         // Creando variables (objetos) de tipos enum
         Console.WriteLine();
         Console.Write("Ingrese un número de día de la semana (0-6): ");
         string sDiaElegido = Console.ReadLine();   
         Dia diaElegido = (Dia) Convert.ToInt32(sDiaElegido);
         Dia diaAnterior = (Dia) (diaElegido - 1);
         Dia diaSiguiente = (Dia) (diaElegido + 1);
         if(diaElegido == Dia.Lunes)
             diaAnterior = Dia.Domingo;
         if(diaElegido == Dia.Domingo)
             diaSiguiente = Dia.Lunes;  
         Console.WriteLine();
         Console.WriteLine("Ud. eligió el dia {0} ({1})", diaElegido, Convert.ToInt32(diaElegido)); 
         Console.WriteLine("El dia anterior es {0} ({1})", diaAnterior, Convert.ToInt32(diaAnterior)); 
         Console.WriteLine("El dia siguiente es {0} ({1})", diaSiguiente, Convert.ToInt32(diaSiguiente)); 
      }
   }
}