' prog050.VB
' Programa: Sentencia de ruptura (equivalente a continue de C#)
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
             If proceso.ProcessName.ToUpper() = "PROG050"
                GoTo Continue      
             End If
             Console.WriteLine(proceso.ProcessName)
             Continue:
         Next

      End Sub

   End Class

End Namespace
