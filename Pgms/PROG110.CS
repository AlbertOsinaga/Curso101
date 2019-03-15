// prog110.CS
// Programa: Excepciones - Cerrando con finally
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   // Definición Clase Database
   class Database 
   {
      // Constructor
    
      public Database()
      {
         m_isDbOpen = false;
      }

      
      // Métodos públicos

      public bool OpenDb()
      {
         // Supone apertura exitosa
         m_isDbOpen = true;
         return true;
      }

      public bool LogIn(string userId, string userPwd)
      {
         try
         {
            // Abre tabla de Usuarios
            if (OpenTable("Usuarios"))
            {
               // Verifica existencia de usuario y clave
            }
         }
         catch(Exception e)
         {
            Console.WriteLine("Database.LogIn() atrapó excepción de tipo: {0}", e.GetType());
            LogError(e.Message);
            Console.WriteLine("Database.Login() Relanzando excepción ...");
            throw;
         }

         return true;
      }

      public void CloseDb()
      {
         // Cierra archivo
         m_isDbOpen = false;
      }

      public bool OpenTable(string table)
      {
         throw new Exception("Tabla no existe!");
      }

      protected void LogError(string error)
      {
         Console.WriteLine("Database Logeando error: '{0}'!", error);
      }


      // Propiedades de instancia

      public bool IsDbOpen
      {
         get { return m_isDbOpen; }
      }


      // Campos de instancia
      
      private bool m_isDbOpen;
   }


   // Definición Clase Principal
   class Principal
   {
      static void Main()
      {
         // Prueba base de datos
         TestDB();
      }

      static void TestDB()
      {
         Console.WriteLine();
         Console.WriteLine("Instanciando objeto DB...");
         Database db = new Database();

         try
         {
            Console.WriteLine("Abriendo DB...");
            if(db.OpenDb())
            {
               Console.WriteLine("Apertura DB exitosa!");
  
               Console.WriteLine("Identificandose en DB...");
               if(db.LogIn("Pedro", "miclavesecreta"))
                  Console.WriteLine("Identificación en DB exitosa!");
            }
         }
         catch(Exception e)
         {
            Console.WriteLine("'Principal.TestDB()' atrapó excepción: '{0}'", e.Message);
         }
         finally
         {
            if (db.IsDbOpen)
            {
               Console.WriteLine("Principal.TestDB() [finally]: Cerrando DB ...");
               db.CloseDb();
            }
         }
      } 
   }   
}