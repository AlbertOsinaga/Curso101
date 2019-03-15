// prog013.CS
// Programa Hola: Variables y literales
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal 
   {    
      static void Main()
      {
         // Saluda
         Saludar();
      }
    
      static void Saludar()   
      {
         // Invita al usuario a ingresar su nombre
         Console.WriteLine();
         Console.Write("Por favor ingresa tu nombre: ");
      
         // Lee entrada del Usuario
         string nombre = Console.ReadLine();

         // Despliega saludo
         Console.WriteLine();
         Console.WriteLine("Hola " + nombre + ", como te va?");
         Console.WriteLine();
      }
   }
}
