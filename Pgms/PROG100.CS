// prog100.CS
// Programa: Queue 2
// LAOS
// Enero 2004

using System;
using System.Collections;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Maneja una cola de palabras
         ColaDePalabras cola = new ColaDePalabras();
         cola.Run();
      }
   } 

   class ColaDePalabras
   {
      // Constructores
      public ColaDePalabras()
      {
         q = new Queue(); 
      }
  
      // Métodos públicos
      public void Run()
      {
         string palabra = "";
         Console.WriteLine();
         Console.WriteLine("Programa Cola de Palabras");
         Console.WriteLine("-------------------------");
         do
         {
            // Usuario introduce operación
            Console.WriteLine();
            Console.WriteLine("\"+ palabra\" Pone la palabra en la cola");
            Console.WriteLine("\"-\" Saca la primera palabra de la cola");
            Console.WriteLine("\"=\" Despliega la primera palabra de la cola");
            Console.WriteLine("\"*\" Termina el programa");
            Console.WriteLine();
            Console.Write("Introduzca su operación: ");
            palabra = Console.ReadLine();
            
            // Si símbolo es '*' termina
            if(palabra[0] == '*')
            {
                Console.WriteLine();
                Console.WriteLine("Fin del programa");
                break;
            }                

	    // Valida símbolo
            if( "+-=".IndexOf(palabra[0]) < 0 )
            {
               Console.WriteLine();
               Console.WriteLine("Símbolo equivocado. Los símbolos de inicio válidos son: '+','-','=','*'");
               continue;
            }   
               		 
            // Valida palabra
            if(palabra[0] == '+'  &&  palabra.Length < 3)
            {
               Console.WriteLine();
               Console.WriteLine("Después del símbolo de operación, introduzca una palabra después de un espacio!");
               continue;
            }   
 
            switch(palabra[0])
            {
               case '+':
                  q.Enqueue(palabra.Substring(2));
                  Console.WriteLine("Palabra '" + palabra.Substring(2) + "' encolada...");
                  break;

               case '-':
                  if(q.Count < 1)
                  {
                     Console.WriteLine("La cola está vacía!");
                     continue;
                  }     
                  string wordDQ = (string) q.Dequeue();
                  Console.WriteLine("Palabra '" + wordDQ + "' desencolada...");
                  break;

               case '=':   
                  if(q.Count < 1)
                  {
                     Console.WriteLine("La cola está vacía!");
                     continue;
                  }     
                  string firstWord = (string) q.Peek();
                  Console.WriteLine("Primera palabra: '" + firstWord + "'");
                  break;

               default:
                  Console.WriteLine("Esto no debería suceder nunca, lo prometo!");
                  break;
            }    

         } while(palabra[0] != '*');
      }

      // Campos privados
      private Queue q;      
   }
}