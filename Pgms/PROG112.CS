// prog112.CS
// Programa: Excepciones Internas
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   // Definición Clase Database
   class Database 
   {
      public bool OpenDb(string dbName)
      {
         // Intenta conectarse y abrir el archivo de DB
         bool noAbre = true;

         // Apertura con error: throw exception!
         if(noAbre)
            throw new Exception("", new FormatException("Nombre de DB '" + dbName + "' errado!"));

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
            if(db.OpenDb("MiDB"))
            {
               Console.WriteLine("Apertura DB exitosa!");
  
               Console.WriteLine("Identificandose en DB...");
               if(db.LogIn("Pedro", "miclavesecreta"))
                  Console.WriteLine("Identificación en DB exitosa!");
            }
         }
         catch(Exception e)
         {
            Console.WriteLine("Exception capturada [externa]: '{0}'", e.Message);
            Console.WriteLine("Exception capturada [interna]: '{0}'", e.InnerException.Message);
         }
      } 
   }   
}