' prog115.VB
' Programa: Múltiples Catchs
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición clase derivada de Excepción - DBException
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



   ' Definición clase derivada de Excepción - TablaException
   Public class TablaException 
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
      
         Console.WriteLine("TablaException.LogException() - Loggeando '{0}'", Me.Message)
      
      End Sub
   
   End Class



   ' Definición Clase Database
   Class Database 
   
      Public Function OpenDb(dbName As String) As Boolean
      
         ' Intenta conectarse y abrir el archivo de DB
         Dim noAbre As Boolean = True 

         ' Apertura con error: throw exception!
         If noAbre

            Select dbName.ToUpper()
               Case "DB"      
                  Throw New DBException("No hay conexión a DB!")
               Case "TABLA"      
                  Throw New TablaException("Tabla no existe!")
               Case Else
                  Throw New Exception("Error en DB!")
            End Select

         End If
         
         Return True

      End Function

      Public Function LogIn(userId As String, userPwd As String) As String
      
         ' Valida id de usuario
         return True

      End Function

      Public Sub CloseDb()
      
         ' Cerrando la DB
         Console.WriteLine()
         Console.WriteLine("Cerrando la base de datos...")
      
      End Sub 

   End Class


   ' Definición Clase Principal
   Class Principal
   
      Shared Sub Main(args() As String)
      
         ' Prueba base de datos
         TestDB(args)

      End Sub

      Shared Sub TestDB(args() As String)
      
         Console.WriteLine()
         Console.WriteLine("Instanciando objeto DB...")
         Dim db As Database = new Database()
         Dim dbName As String
         If args.Length > 0 Then dbName = args(0) Else dbName = "" 

         Try
         
            Console.WriteLine("Abriendo DB...")
            If db.OpenDb(dbName)
         
               Console.WriteLine("Apertura DB exitosa!")

               Console.WriteLine("Identificandose en DB...")
               If db.LogIn("Pedro", "miclavesecreta")
                  Console.WriteLine("Identificacin en DB exitosa!")
               End If 

            End If

         Catch e As DBException
         
            Console.WriteLine("Exception capturada: '{0}'", e.Message)
            Console.WriteLine("Exception de tipo: '{0}'", e.GetType())
            Console.WriteLine("Stack de llamadas: '{0}'", e.StackTrace)
         
         Catch e As TablaException
         
            Console.WriteLine("Exception capturada: '{0}'", e.Message)
            Console.WriteLine("Exception de tipo: '{0}'", e.GetType())
            Console.WriteLine("Stack de llamadas: '{0}'", e.StackTrace)
         
         Catch e As Exception
         
            Console.WriteLine("Exception capturada: '{0}'", e.Message)
            Console.WriteLine("Exception de tipo: '{0}'", e.GetType())
            Console.WriteLine("Stack de llamadas: '{0}'", e.StackTrace)
         
         Finally

            db.CloseDb()

         End Try
         

      End Sub 

   End Class   

End Namespace
