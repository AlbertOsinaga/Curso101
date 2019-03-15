// prog113.CS
// Programa: Propiedad StackTrace
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   // Definición Clase Database
   class Database 
   {
      public bool OpenDb()
      {
         // Intenta conectarse y abrir el archivo de DB
         bool noAbre = true;

         // Apertura con error: throw exception!
         if(noAbre)
            throw new Exception("No hay conexión a DB");

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
            Console.WriteLine("Stack de llamadas: '{0}'", e.StackTrace);
         }
      } 
   }   
}