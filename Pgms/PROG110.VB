' prog110.VB
' Programa: Excepciones - Cerrando con Finally
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición Clase Database
   Class Database 
   
      ' Constructor
    
      Public Sub New()
      
         m_isDbOpen = False

      End Sub

      
      ' Métodos públicos

      Public Function OpenDb() As Boolean
      
         ' Supone apertura exitosa
         m_isDbOpen = True
         Return True

      End Function

      Public Function LogIn(userId As String, userPwd As String) As Boolean
      
         Try
         
            ' Abre tabla de Usuarios
            If OpenTable("Usuarios")
            
               ' Verifica existencia de usuario y clave

            End If

         catch e As Exception
         
            Console.WriteLine("Database.LogIn() atrapó excepción de tipo: {0}", e.GetType())
            LogError(e.Message)
            Console.WriteLine("Database.Login() Relanzando excepción ...")
            Throw

         End Try

         Return True

      End Function

      Public Sub CloseDb()
      
         ' Cierra archivo
         m_isDbOpen = False

      End Sub

      Public Function OpenTable(table As String) As Boolean
      
         Throw New Exception("Tabla no existe!")

      End Function

      Protected Sub LogError(err As String)
      
         Console.WriteLine("Database Logeando error: '{0}'!", err)

      End Sub


      ' Propiedades de instancia

      Public ReadOnly Property IsDbOpen() As Boolean

         Get
            Return m_isDbOpen
         End Get

      End Property


      ' Campos de instancia
      
      Private Dim m_isDbOpen As Boolean

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

         try
         
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

         Finally
         
            If db.IsDbOpen
            
               Console.WriteLine("Principal.TestDB() [finally]: Cerrando DB ...")
               db.CloseDb()

            End If

         End Try

      End Sub 

   End Class   

End Namespace
