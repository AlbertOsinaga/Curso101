// prog027.CS
// Programa: Estructura con el m�todo "Main"
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   struct Persona
   {
      string Nombre;
      int Edad;
      char Sexo;
      string Direccion; 
      string Telefono;
      string Email;

      static void Main()
      {
         // Creaci�n de la estructura
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
         Console.WriteLine("Direcci�n: {0}", cliente.Direccion); 
         Console.WriteLine("Tel�fono: {0}", cliente.Telefono); 
         Console.WriteLine("Email: {0}", cliente.Email); 
      }
   }
}