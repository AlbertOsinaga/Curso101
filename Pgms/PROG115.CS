// prog115.CS
// Programa: Múltiples catchs
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   // Definición clase derivada de Excepción - DBException
   public class DBException : Exception
   {
      public DBException() : base() 
      {
         LogException();
      }

      public DBException(String message) : base(message) 
      {
         LogException();
      }

      public DBException(String message, Exception innerException) : base(message, innerException) 
      {
         LogException();
      }

      protected void LogException()
      {
         Console.WriteLine("DBException.LogException() - Loggeando '{0}'", this.Message);
      }
   }



   // Definición clase derivada de Excepción - TablaException
   public class TablaException : Exception
   {
      public TablaException() : base() 
      {
         LogException();
      }

      public TablaException(String message) : base(message) 
      {
         LogException();
      }

      public TablaException(String message, Exception innerException) : base(message, innerException) 
      {
         LogException();
      }

      protected void LogException()
      {
         Console.WriteLine("TablaException.LogException() - Loggeando '{0}'", this.Message);
      }
   }



   // Definición Clase Database
   class Database 
   {
      public bool OpenDb(string dbName)
      {
         // Intenta conectarse y abrir el archivo de DB
         bool noAbre = true;

         // Apertura con error: throw exception!
         if(noAbre)
         {
            switch(dbName.ToUpper())
            {
               case "DB":
                  throw new DBException("No hay conexión a DB!");
               case "TABLA":
                  throw new TablaException("Tabla no existe!");
               default:
                  throw new Exception("Error en DB!");
            } 
         } 

         return true;
      }

      public bool LogIn(string userId, string userPwd)
      {
         // Valida id de usuario
         return true;
      }

      public void CloseDb()
      {
         // Cerrando la DB
         Console.WriteLine();
         Console.WriteLine("Cerrando la base de datos...");
      } 
   }


   // Definición Clase Principal
   class Principal
   {
      static void Main(string[] args)
      {
         // Prueba base de datos
         TestDB(args);
      }

      static void TestDB(string[] args)
      {
         Console.WriteLine();
         Console.WriteLine("Instanciando objeto DB...");
         Database db = new Database();
         string dbName = args.Length > 0 ? args[0] : "";

         try
         {
            Console.WriteLine("Abriendo DB...");
            if(db.OpenDb(dbName))
            {
               Console.WriteLine("Apertura DB exitosa!");
  
               Console.WriteLine("Identificandose en DB...");
               if(db.LogIn("Pedro", "miclavesecreta"))
                  Console.WriteLine("Identificación en DB exitosa!");
            }
         }
         catch(DBException e)
         {
            Console.WriteLine("Exception capturada: '{0}'", e.Message);
            Console.WriteLine("Exception de tipo: '{0}'", e.GetType());
            Console.WriteLine("Stack de llamadas: '{0}'", e.StackTrace);
         }
         catch(TablaException e)
         {
            Console.WriteLine("Exception capturada: '{0}'", e.Message);
            Console.WriteLine("Exception de tipo: '{0}'", e.GetType());
            Console.WriteLine("Stack de llamadas: '{0}'", e.StackTrace);
         }
         catch(Exception e)
         {
            Console.WriteLine("Exception capturada: '{0}'", e.Message);
            Console.WriteLine("Exception de tipo: '{0}'", e.GetType());
            Console.WriteLine("Stack de llamadas: '{0}'", e.StackTrace);
         }
         finally
         {
            db.CloseDb();
         }
      } 
   }   
}