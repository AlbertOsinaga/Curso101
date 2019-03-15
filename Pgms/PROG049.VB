' prog049.VB
' Programa: Sentencia de ruptua Exit { Do | For | Function | Property | Select | Sub | Try | While }
' LAOS
' Enero 2004

Imports System
Imports System.Diagnostics

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Despliega los procesos actualmente corriendo
         DespliegaProcesos()

      End Sub

      Shared Sub DespliegaProcesos()
      
         ' Variables locales
         Dim procesos() As Process
         procesos = Process.GetProcesses()

         ' Despliega procesos
         Console.WriteLine()
         Console.WriteLine("PROCESOS CORRIENDO:") 
         Console.WriteLine()
         For Each proceso As Process in procesos    
             Console.WriteLine(proceso.ProcessName)
             If proceso.ProcessName.ToUpper() = "PROG049"
                Exit For
             End If
         Next

      End Sub

   End Class

End Namespace
