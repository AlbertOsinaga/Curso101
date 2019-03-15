// prog042.CS
// Programa: Sentencia de control if
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Valida números del 1 al 9
         ValidaNumero();
      }

      static void ValidaNumero()
      {
          // variables locales
          const string Digitos = "123456789";
          string sNumero;
          int nNumero;
       
          // pide un número al usuario
          Console.WriteLine();
          Console.Write("Introduzca un número del 1 al 9: ");
          sNumero = Console.ReadLine();

          // Si número es válido 
          if (sNumero.Length == 1  &&  Digitos.IndexOf(sNumero) >= 0)
          { 
              // Identifica número como par o impar
              nNumero = Int32.Parse(sNumero);
              if (nNumero % 2 == 0)
              {
                 Console.WriteLine("Su número es par!");
              } 
              else 
              {
                 Console.WriteLine("Su número es impar!");
              } 

              // Despedida
              Console.WriteLine("Buena suerte!");
          }
          // Si número es inválido
          else 
             Console.WriteLine("Lo lamentamos! Solo se aceptan números del 1 al 9");
      }
   }
}