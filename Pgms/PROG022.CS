// prog022.CS
// Programa: SrtingBuilder
// LAOS
// Enero 2004

using System;
using System.Text;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Secuencias de Escape
         UsoDeStrings();
      } 
        
      static void UsoDeStrings()
      {
         // Lee nombre del Usuario
         StringBuilder saludo = LeeNombre();

         // Arma saludo
         ArmaSaludo(saludo);

         // Despliega Saludo
         DespliegaSaludo(saludo);
      }
 
      static StringBuilder LeeNombre()
      {
         System.Console.WriteLine();
         System.Console.Write("Por favor ingrese su nombre: ");
         string nombre = Console.ReadLine();

         return new StringBuilder(nombre);
      }

      static void ArmaSaludo(StringBuilder saludo)
      {
         saludo.Insert(0, "Hola ");
         saludo.Append(", cómo te va?");
      }

      static void DespliegaSaludo(StringBuilder saludo)
      {
         Console.WriteLine();
         Console.WriteLine(saludo);
      } 
   }
}