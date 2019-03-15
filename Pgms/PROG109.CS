// prog109.CS
// Programa: Relanzando una excepción
// LAOS
// Enero 2004

using System;
using System.IO;

namespace CursoNet
{
   // Definición Clase Database
   class Database 
   {
      public bool OpenDb()
      {
         try
         {
            FileStream data = new FileStream("c:\\dbas.dat", FileMode.Open);
         }
         catch(Exception e)
         {
            Console.WriteLine("'Database.OpenDb()' atrapó excepción de tipo: {0}!", e.GetType());
            LogError(e.Message);
            Console.WriteLine("'Database.OpenDb()' Relanzando la excepción ...");
            throw;
         }

         return true;
      }

      public bool LogIn(string userId, string userPwd)
      {
         // Valida id de usuario
         return true;
      }

      protected void LogError(string error)
      {
         Console.WriteLine("Database Logeando error: '{0}'!", error);
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
         try
         {
            Console.WriteLine();
            Console.WriteLine("Instanciando objeto DB...");
            Database db = new Database();

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
      } 
   }   
}