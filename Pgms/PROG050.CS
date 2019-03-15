// prog050.CS
// Programa: Sentencia de ruptura continue
// LAOS
// Enero 2004

using System;
using System.Diagnostics;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Despliega los procesos actualmente corriendo
         DespliegaProcesos();
      }

      static void DespliegaProcesos()
      {
         // Variables locales
         Process[] procesos = Process.GetProcesses();

         // Despliega procesos
         Console.WriteLine();
         Console.WriteLine("PROCESOS CORRIENDO:"); 
         Console.WriteLine();
         foreach (Process proceso in procesos)
         {      
             if (proceso.ProcessName.ToUpper() == "PROG050")
                continue;
             Console.WriteLine(proceso.ProcessName);
         } 
      }
   }
}