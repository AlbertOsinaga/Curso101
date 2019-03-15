// prog098.CS
// Programa: ArrayList
// LAOS
// Enero 2004

using System;
using System.Collections;

namespace CursoNet
{
   class Principal
   {
      static void Main(string[] args)
      {
         // Ordena las palabras de la línea de comandos
         ArrayList arrayPalabras = new ArrayList();
         CopiaArray(args, arrayPalabras);
         OrdenaPalabras(arrayPalabras);
      }

      static void CopiaArray(string[] args, ArrayList arrayPalabras)
      {
         // Copia datos de una array a un ArrayList
         foreach(string arg in args)
            arrayPalabras.Add(arg); 
      }

      static void OrdenaPalabras(ArrayList arrayPalabras)
      {
         // Verifica existencia de por lo menos dos argumentos
         if (arrayPalabras.Count < 2)
         {
             Console.WriteLine("Forma de Uso: prog098 palabra1 palabra2 ...");  
             return;
         }

         // Despliega array original
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("Original");
         Console.WriteLine("--------");
         foreach(string s in arrayPalabras)
         {
            Console.Write(s);
            Console.Write(" ");
         }   

         // Ordena array
         arrayPalabras.Sort();

         // Despliega array ordenado ascendentemente
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("Orden ascendente");
         Console.WriteLine("----------------");
         foreach(string s in arrayPalabras)
         {
            Console.Write(s);
            Console.Write(" ");
         }   

         // Reversa array
         arrayPalabras.Reverse();

         // Despliega array ordenado descendentemente
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("Orden descendente");
         Console.WriteLine("-----------------");
         foreach(string s in arrayPalabras)
         {
            Console.Write(s);
            Console.Write(" ");
         }   
         Console.WriteLine();
         Console.WriteLine();
      }
   }
}