// prog020.CS
// Programa: Strings, secuencias de escape
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
         SecuenciasEscape();
      } 
        
      static void SecuenciasEscape()
      {
         // Hello World	
         Console.WriteLine("\nHello World\n");
         Console.WriteLine("\"Hello World\"");

         // Tabla
         Console.WriteLine("\nNombre\tTele\teMail");
         Console.WriteLine("------\t----\t-----");
         Console.WriteLine("Juan\t2232323\tjuan@correo.net");
         Console.WriteLine("Pedro\t2443355\tpedro@buzon.net"); 

         // directorios
         Console.WriteLine();
         Console.WriteLine("Directorio: " + "c:\\misdocumentos\\misimagenes\\");
         Console.WriteLine("Directorio: " + @"c:\misdocumentos\misimagenes\");

         // Despedida
         Console.WriteLine("\nBye bye Paraguay!\a");
      }
   }
}