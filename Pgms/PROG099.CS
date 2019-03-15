// prog099.CS
// Programa: Queue
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
         Queue qPalabras = new Queue();
         CopiaAQueue(args, qPalabras);
         DespliegaPalabras(qPalabras);
      }

      static void CopiaAQueue(string[] args, Queue qPalabras)
      {
         // Copia datos de una array a un Queue
         foreach(string arg in args)
            qPalabras.Enqueue(arg); 
      }

      static void DespliegaPalabras(Queue qPalabras)
      {
         // Verifica existencia de por lo menos dos argumentos
         if (qPalabras.Count < 2)
         {
             Console.WriteLine("Forma de Uso: prog099 palabra1 palabra2 ...");  
             return;
         }

         // Despliega array original
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("Original");
         Console.WriteLine("--------");
         foreach(string s in qPalabras)
         {
            Console.Write(s);
            Console.Write(" ");
         }   

         Console.WriteLine();
         Console.WriteLine();
      }
   }
}