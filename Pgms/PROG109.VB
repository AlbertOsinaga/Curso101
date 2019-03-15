' prog109.VB
' Programa: Relanzando una excepción
' LAOS
' Enero 2004

Imports System
Imports System.IO

Namespace CursoNet

   ' Definición Clase Database
   Class Database 
   
      Public Function OpenDb() As Boolean
      
         Try
         
            Dim data As FileStream = new FileStream("c:\\dbas.dat", FileMode.Open)
         
         Catch e As Exception
         
            Console.WriteLine("'Database.OpenDb()' atrapó excepción de tipo: {0}!", e.GetType())
            LogError(e.Message)
            Console.WriteLine("'Database.OpenDb()' Relanzando la excepción ...")
            Throw
         
         End Try
         
         Return True

      End Function

      Public Function LogIn(userId As String, userPwd As String) As String
      
         ' Valida id de usuario
         Return True

      End Function

      Protected Sub LogError(err As String)
      
         Console.WriteLine("Database Logeando error: '{0}'!", err)

      End Sub

   End Class


   ' Definición Clase Principal
   Class Principal
   
      Shared Sub Main()
      
         ' Prueba base de datos
         TestDB()

      End Sub

      Shared Sub TestDB()
      
         Console.WriteLine()
         Console.WriteLine("Instanciando objeto DB...")
         Dim db As Database = new Database()

         Try
         
            Console.WriteLine("Abriendo DB...")
            If db.OpenDb()
         
               Console.WriteLine("Apertura DB exitosa!")

               Console.WriteLine("Identificandose en DB...")
               If db.LogIn("Pedro", "miclavesecreta")
                  Console.WriteLine("Identificacin en DB exitosa!")
               End If 

            End If

         Catch e As Exception
         
            Console.WriteLine("'Principal.TestDB()' atrapó excepción: '{0}'", e.Message)
         
         End Try
         

      End Sub 

   End Class   

End Namespace
