// prog029.CS
// Programa: Arrays
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main(string[] args)
      {
         // Ordena las palabras de la línea de comandos
         OrdenaPalabras(args);
      }

      static void OrdenaPalabras(string[] args)
      {
         // Verifica existencia de por lo menos dos argumentos
         if (args.Length < 2)
         {
             Console.WriteLine("Forma de Uso: prog029 palabra1 palabra2 ...");  
             return;
         }

         // Clona array de argumentos
         string[] argsOrdenados = new string[args.Length];
         Array.Copy(args, argsOrdenados, args.Length);
 
         // Despliega array original
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("Original");
         Console.WriteLine("--------");
         for(int i = 0; i < args.Length; i++)
         {
            Console.Write(args[i]);
            Console.Write(" ");
         }   

         // Ordena array
         Array.Sort(argsOrdenados);

         // Despliega array ordenado ascendentemente
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("Orden ascendente");
         Console.WriteLine("----------------");
         for(int i = 0; i < args.Length; i++)
         {
            Console.Write(argsOrdenados[i]); 
            Console.Write(" ");
         }          

         // Reversa array
         Array.Reverse(argsOrdenados);

         // Despliega array ordenado ascendentemente
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("Orden descendente");
         Console.WriteLine("-----------------");
         for(int i = 0; i < args.Length; i++)
         {
            Console.Write(argsOrdenados[i]); 
            Console.Write(" ");
         }          
         Console.WriteLine();
         Console.WriteLine();
      }
   }
}