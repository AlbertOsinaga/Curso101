// prog116.CS
// Programa: Controlando excepciones
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   // Definición Clase Tabla
   class Tabla
   {
      public void AddRecord(String record)
      {
         try
         {
            // Comienza la transacción
            BeginTran(); 

            // Adiciona un registro en blanco en la tabla
            AddRow();

            // Actualiza registro
            UpdateRow();

            // Finaliza la transacción
            Commit();
         }
         catch(Exception e)
         {
            // Aborta la transacción          
            Rollback();
            // Rethrow exception
            throw e; 
         }
     }

     public void BeginTran()
     {
        Console.WriteLine("Tabla.BeginTran - Comenzando la transacción ...");
     }

     public void Commit()
     {
        Console.WriteLine("Tabla.Commit - Finalizando la transacción ...");
     }

     public void Rollback()
     {
        Console.WriteLine("Tabla.Rollback - Abortando la transacción ...");
     }

     protected void AddRow()
     {
        Console.WriteLine("Tabla.AddRow Adicionando registro ...");
     }

     protected void UpdateRow()
     {
        Console.WriteLine("Tabla.UpdateRow - Registro actualizado ...");
        Console.WriteLine("Tabla.UpdateRow - Error encontrado. Lanzando excepción ...");
        throw new Exception("Error en Update - No se pudo escribir en archivo!");
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
            Tabla tabla = new Tabla();

            Console.WriteLine("Intentando adicionar registro ...");
            tabla.AddRecord("Registro de datos");
         }
         catch(Exception e)
         {
            Console.WriteLine("Principal.TestDB() - Excepción capturada '{0}'", e.Message);
         }
      } 
   }   
}