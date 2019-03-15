' prog112.VB
' Programa: Excepciones internas
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición Clase Database
   Class Database 
   
      Public Function OpenDb(dbName As String) As Boolean
      
         ' Intenta conectarse y abrir el archivo de DB
         Dim noAbre As Boolean = True 

         ' Apertura con error: throw exception!
         If noAbre Then throw New Exception("", New FormatException("Nombre de DB '" + dbName + "' errado!"))
         
         Return True

      End Function

      Public Function LogIn(userId As String, userPwd As String) As String
      
         ' Valida id de usuario
         return True

      End Function

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
            If db.OpenDb("MiDB")
         
               Console.WriteLine("Apertura DB exitosa!")

               Console.WriteLine("Identificandose en DB...")
               If db.LogIn("Pedro", "miclavesecreta")
                  Console.WriteLine("Identificacin en DB exitosa!")
               End If 

            End If

         Catch e As Exception
         
            Console.WriteLine("Exception capturada [externa]: '{0}'", e.Message)
            Console.WriteLine("Exception capturada [interna]: '{0}'", e.InnerException.Message)
         
         End Try
         

      End Sub 

   End Class   

End Namespace
