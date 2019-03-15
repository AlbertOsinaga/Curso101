// prog052.CS
// Programa: Sentencia de ruptura goto 
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
             Console.Write(proceso.ProcessName);
             string processName = proceso.ProcessName.ToUpper();
             if (processName != "PROG052"  &&  processName != "CMD"  &&
                      processName != "NOTEPAD"  &&  processName != "POWERPNT")
                goto finDeLinea;
             Console.Write("   <---");
           
             finDeLinea:
             Console.Write("\n");
         } 
      }
   }
}