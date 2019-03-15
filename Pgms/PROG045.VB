' prog045.VB
' Programa: Sentencia de control While
' LAOS
' Enero 2004

Imports System
Imports System.Threading

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Cuenta segundos del 1 al 30
         CuentaSegundos()

      End Sub

      Shared Sub CuentaSegundos()
      
         ' variables locales
         const DigitosUnidad As String = "1234567890"
         const DigitosDecena As String = "123"
         Dim sSegundos As String
         Dim nSegundos As Integer
       
         ' pide el número de segundos a contar al usuario
         Console.WriteLine()
         Console.Write("Introduzca el número de segundos a contar (1 a 30): ")
         sSegundos = Console.ReadLine()
         Console.WriteLine()

         ' Si número es inválido, termina 
         If sSegundos.Length < 1
       
            Console.WriteLine("Número no fué introducido!")
            Return 

         End If
         If sSegundos.Length > 2
       
            Console.WriteLine("Lo lamentamos! Solo se aceptan números entre 1 y 30")
            Return 

         End If 
         If sSegundos.Length = 1  AndAlso  DigitosUnidad.IndexOf(sSegundos.Chars(0)) < 0
       
            Console.WriteLine("Lo lamentamos! Solo se aceptan números")
            Return 

         End If 
         If sSegundos.Length = 2  AndAlso  (DigitosDecena.IndexOf(sSegundos.Chars(0)) < 0  OrElse DigitosUnidad.IndexOf(sSegundos.Chars(1)) < 0)
       
            Console.WriteLine("Lo lamentamos! Solo se aceptan números entre 1 y 30")
            Return 

         End If 

         ' Convierte segundos a numero, si no valida rango termina
         nSegundos = Int32.Parse(sSegundos)
         If nSegundos < 1  OrElse nSegundos > 30
       
            Console.WriteLine("Lo lamentamos! Solo se aceptan números entre 1 y 30")
            return 
       
         End If 


         ' Cuenta y despliega los segundos
         Dim n As Integer = 1
         Console.WriteLine()
         While n <= nSegundos 
        
            Thread.Sleep(1000)          
            Console.WriteLine("{0}", n)
            n += 1 

         End While                  	

      End Sub

   End Class

End Namespace
