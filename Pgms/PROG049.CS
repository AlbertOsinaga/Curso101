// prog049.CS
// Programa: Sentencia de ruptura break
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
            Console.WriteLine(proceso.ProcessName);
            if (proceso.ProcessName.ToUpper() == "PROG049")
               break;
         } 
      }
   }
}