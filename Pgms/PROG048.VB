' prog048.VB
' Programa: Sentencia de control For Each
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
       Next

      End Sub

   End Class

End Namespace
