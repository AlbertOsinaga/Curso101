// prog101.CS
// Programa: Stack 
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
         // Despliega las palabras de la línea de comandos
         Stack stkPalabras = new Stack();
         CopiaAStack(args, stkPalabras);
         DespliegaPalabras(stkPalabras);
      }

      static void CopiaAStack(string[] args, Stack stkPalabras)
      {
         // Copia datos de una array a un Queue
         foreach(string arg in args)
            stkPalabras.Push(arg); 
      }

      static void DespliegaPalabras(Stack stkPalabras)
      {
         // Verifica existencia de por lo menos dos argumentos
         if (stkPalabras.Count < 2)
         {
             Console.WriteLine("Forma de Uso: prog101 palabra1 palabra2 ...");  
             return;
         }

         // Despliega array original
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("Original");
         Console.WriteLine("--------");
         foreach(string s in stkPalabras)
         {
            Console.Write(s);
            Console.Write(" ");
         }   

         Console.WriteLine();
         Console.WriteLine();
      }
   }
}