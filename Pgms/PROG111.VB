' prog111.VB
' Programa: Recuperndose de una excepción
' LAOS
' Enero 2004

Imports System
Imports System.IO

Namespace CursoNet

   ' Definición Clase Principal
   Class Principal
   
      Shared Sub Main()
      
         ' Prueba creación de archivo
         TestFile()

      End Sub

      Shared Sub TestFile()
      
         ' Variables locales
         Dim intentos As Integer = 0
         Dim maxIntentos As Integer = 3
         Dim sr As StreamReader

         GetFileName:
            intentos += 1
            Console.WriteLine()
            Console.Write("Intento # {0} - Ingrese archivo a leer: ", intentos)
            Dim fileName As String = Console.ReadLine()

        Try
        
            Dim s As String
            sr = new StreamReader(fileName)

            s = sr.ReadLine()
            Console.WriteLine()
            Do While s <> Nothing 
               Console.WriteLine(s)
               s = sr.ReadLine()
            Loop
            sr.Close()

        Catch e As FileNotFoundException
        
            Console.WriteLine()
            Console.WriteLine(e.Message)
            If intentos < maxIntentos
            
                Console.WriteLine("Archivo no existe!")
                Console.WriteLine("Desea seleccionar otro archivo?")
                Dim respuesta As String = Console.ReadLine()
                respuesta = respuesta.ToUpper()
                If respuesta = "S" Then GoTo GetFileName

            Else
            
                Console.WriteLine("Ha excedido el máximo número de intentos ({0})", maxIntentos)

            End If

        catch e As Exception 
        
            Console.WriteLine(e.Message)

        End Try

      End Sub 

   End Class   

End Namespace
