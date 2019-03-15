' prog017.VB
' Programa: Conversión de tipos primitivos
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
         ' Implícitas
         Implicitas()

         ' Explícitas
         Explicitas()
      End Sub 
        
      Shared Sub Implicitas()
         ' Variables locales
         Dim s As Short = 5
         Dim n As Integer = 0
         Dim ln As Long = 0
         Dim db As Double = 0

         ' Conversiones implícitas (promociones)
         n = s
         ln = n
         db = ln 
         
         ' Despliegue de resultados
         Console.WriteLine()
         Console.WriteLine("Implícitas")
         Console.WriteLine("----------")
         Console.WriteLine("short: {0}", s)
         Console.WriteLine("int = short: {0}", n)
         Console.WriteLine("long = int: {0}", ln)
         Console.WriteLine("double = long: {0}", db)
      End Sub

      Shared Sub Explicitas()
         ' Variables locales
         Dim s As Short = 0
         Dim n AS Integer = 0
         Dim ln As Long = 0
         Dim db As Double = double.MaxValue

         ' Conversiones explícitas
         ln = Convert.ToInt64(db) 
         n = Convert.ToInt32(ln)
         s = Convert.ToInt16(n) 

         ' Despliegue de resultados
         Console.WriteLine()
         Console.WriteLine("Explícitas usando Convert")
         Console.WriteLine("-------------------------")
         Console.WriteLine("double: {0}", db)
         Console.WriteLine("long = Convert.ToInt64(db): {0}", ln)
         Console.WriteLine("int = Convert.ToInt32(ln): {0}", n)
         Console.WriteLine("short = Convert.ToInt16(n): {0}", s)
       End Sub
 
   End Class

End Namespace