' prog052.VB
' Programa: Sentencia de ruptura GoTo
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
       Dim procesos() As Process = Process.GetProcesses()

       ' Despliega procesos
       Console.WriteLine()
       Console.WriteLine("PROCESOS CORRIENDO:") 
       Console.WriteLine()
       For Each proceso As Process in procesos
             
           Dim processName As String = proceso.ProcessName.ToUpper()
           Console.Write(processName)
           If processName <> "PROG033"  AndAlso  processName <> "CMD"  AndAlso _
                    processName <> "NOTEPAD"  AndAlso  processName <> "POWERPNT"
             
              GoTo finDeLinea
           
           End If
           Console.Write("   <---")
           
           finDeLinea:
           Console.Write(Convert.ToChar(10))
       
       Next 

      End Sub

   End Class

End Namespace
