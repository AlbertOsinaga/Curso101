' prog028.VB
' Programa: Arrays en la lnea de comandos
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Suma dos nmeros de la lnea de comandos
         SumaNumeros()

      End Sub

      Shared Sub SumaNumeros()
      
         ' Linea en blanco
         Console.WriteLine()
      
         ' Obtiene arrays de strings de la linea de comandos
         Dim args As String() = Environment.GetCommandLineArgs()

         ' Verifica existencia de dos nmeros
         If args.Length < 3
         
             Console.WriteLine("Forma de Uso: prog028 num1 num2")  
             return

         End If

         ' Suma y despliega resultado
         Console.WriteLine("{0}: {1} + {2} = {3}", args(0), args(1), args(2), Int32.Parse(args(1)) + Int32.Parse(args(2)))

      End Sub

   End Class

End Namespace
