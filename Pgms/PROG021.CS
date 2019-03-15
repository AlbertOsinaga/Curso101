// prog021.CS
// Programa: Strings
// LAOS
// Enero 2004

using System;

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
         string saludo = LeeNombre();

         // Arma saludo
         ArmaSaludo(saludo);

         // Despliega Saludo
         DespliegaSaludo(saludo);
      }
 
      static string LeeNombre()
      {
         System.Console.WriteLine();
         System.Console.Write("Por favor ingrese su nombre: ");
         
         return System.Console.ReadLine();
      }

      static void ArmaSaludo(string saludo)
      {
         saludo = "Hola" + "saludo" + ", cómo te va?";
      }

      static void DespliegaSaludo(string saludo)
      {
         Console.WriteLine();
         Console.WriteLine(saludo);
      } 
   }
}