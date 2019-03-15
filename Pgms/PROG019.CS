// prog019.CS
// Programa: Manejo de Strings
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Manejo de Strings
         ManejoStrings();
      } 
        
      static void ManejoStrings()
      {
         // Hello World
         string saludo = "Hello World";
         Console.WriteLine();
         Console.WriteLine(saludo);

         // Hello friend
         saludo = "Hello ";
         Console.WriteLine();
         Console.Write("Por favor ingrese su nombre: ");
         string nombre = Console.ReadLine();
         string bienvenido = saludo + nombre;       
         Console.WriteLine();
         Console.WriteLine(bienvenido);

         // Goodbye friend
         string despedida = bienvenido.Replace("Hello ", "Goodbye ");
         Console.WriteLine("..............................");
         Console.WriteLine(despedida);

         // Gracias a Dios es viernes
         string gadev = "Gracias a Dios es viernes!";
         Console.WriteLine();
         Console.WriteLine(gadev);
         Console.WriteLine("longitud de gadev = {0}", gadev.Length);
         Console.WriteLine("Indice de '!' en gadev = {0}", gadev.IndexOf("!"));
         Console.WriteLine("La segunda letra en gadev = {0}", gadev[1]);

         // Gracias a Dios es lunes
         string gadel = gadev.Replace("viernes", "lunes");
         Console.WriteLine();
         Console.WriteLine(gadel);
         Console.WriteLine("longitud de gadel = {0}", gadel.Length);
         Console.WriteLine("Indice de '!' en gadel = {0}", gadel.IndexOf("!"));
         Console.WriteLine("La segunda letra en gadel = {0}", gadel[1]);

         // Por desgracia es lunes	
         string pdel = gadel.Remove(0, gadel.IndexOf("es"));
         pdel = "Por " + pdel;
         pdel = pdel.Insert(4, "desgracia ");
         Console.WriteLine();
         Console.WriteLine(pdel);
         Console.WriteLine("longitud de pdel = {0}", pdel.Length);
         Console.WriteLine("Indice de '!' en pdel = {0}", pdel.IndexOf("!"));
         Console.WriteLine("La segunda letra en pdel = {0}", pdel[1]);
      }
   }
}