' prog114.VB
' Programa: Derivando clases de "EXception"
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición clase derivada de Excepción
   Public class DBException 
                inherits Exception
   
      Public Sub New()  
      
         MyBase.New()
         LogException()

      End Sub

      Public Sub New(message As String) 
      
         MyBase.New(message)
         LogException()

      End Sub

      Public Sub New(message As String, innerException As Exception)
      
         MyBase.New(message, innerException)
         LogException()
      
      End Sub

      Protected Sub LogException()
      
         Console.WriteLine("DBException.LogException() - Loggeando '{0}'", Me.Message)
      
      End Sub
   
   End Class



   ' Definición Clase Database
   Class Database 
   
      Public Function OpenDb() As Boolean
      
         ' Intenta conectarse y abrir el archivo de DB
         Dim noAbre As Boolean = True 

         ' Apertura con error: throw exception!
         If noAbre Then throw New DBException("No hay conexión a DB")
         
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
            If db.OpenDb()
         
               Console.WriteLine("Apertura DB exitosa!")

               Console.WriteLine("Identificandose en DB...")
               If db.LogIn("Pedro", "miclavesecreta")
                  Console.WriteLine("Identificacin en DB exitosa!")
               End If 

            End If

         Catch e As Exception
         
            Console.WriteLine("Exception capturada: '{0}'", e.Message)
            Console.WriteLine("Exception de tipo: '{0}'", e.GetType())
            Console.WriteLine("Stack de llamadas: '{0}'", e.StackTrace)
         
         End Try
         

      End Sub 

   End Class   

End Namespace
