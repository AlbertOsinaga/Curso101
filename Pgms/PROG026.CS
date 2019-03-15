// prog026.CS
// Programa: Estructuras
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   struct Persona
   {
      public string Nombre;
      public int Edad;
      public char Sexo;
      public string Direccion; 
      public string Telefono;
      public string Email;
   }
   
   class Principal
   {
      static void Main()
      {
         // Ejemplo de estructura Persona
         EjemploPersona();
      } 
        
      static void EjemploPersona()
      {
         // Creación de la estructura
         Persona cliente = new Persona();
         cliente.Nombre = "Maria Vargas";
         cliente.Edad = 24;
         cliente.Sexo = 'F';
         cliente.Direccion = "Calle Loayza # 289";
         cliente.Telefono = "2791313";
         cliente.Email = "mvargas@algunhost.com";
 
         // Despliega miembros
         Console.WriteLine();
         Console.WriteLine("Estructura Persona");
         Console.WriteLine("------------------");
         Console.WriteLine("Nombre: {0}", cliente.Nombre); 
         Console.WriteLine("Edad: {0}", cliente.Edad); 
         Console.WriteLine("Sexo: {0}", cliente.Sexo); 
         Console.WriteLine("Dirección: {0}", cliente.Direccion); 
         Console.WriteLine("Email: {0}", cliente.Email); 
      }
   }
}