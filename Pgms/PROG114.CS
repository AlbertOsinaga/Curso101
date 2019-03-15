// prog114.CS
// Programa: Derivando clases de "EXception"
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   // Definición clase derivada de Excepción
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



   // Definición Clase Database
   class Database 
   {
      public bool OpenDb()
      {
         // Intenta conectarse y abrir el archivo de DB
         bool noAbre = true;

         // Apertura con error: throw exception!
         if(noAbre)
            throw new DBException("No hay conexión a DB");

         return true;
      }

      public bool LogIn(string userId, string userPwd)
      {
         // Valida id de usuario
         return true;
      }
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
            Console.WriteLine("Exception capturada: '{0}'", e.Message);
            Console.WriteLine("Exception de tipo: '{0}'", e.GetType());
            Console.WriteLine("Stack de llamadas: '{0}'", e.StackTrace);
         }
      } 
   }   
}