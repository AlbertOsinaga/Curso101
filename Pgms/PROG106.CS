// prog106.CS
// Programa: Excepciones - Ejemplo de una base de datos
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

         Console.WriteLine("Abriendo DB...");
         if(db.OpenDb())
         {
            Console.WriteLine("Apertura DB exitosa!");

            Console.WriteLine("Identificandose en DB...");
            if(db.LogIn("Pedro", "miclavesecreta"))
               Console.WriteLine("Identificación en DB exitosa!");
         }
         
      } 
   }   
}