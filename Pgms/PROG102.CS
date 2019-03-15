// prog102.CS
// Programa: Stack 2
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
         // Maneja un stack de palabras
         StackDePalabras pila = new StackDePalabras();
         pila.Run();
      }
   } 

   class StackDePalabras
   {
      // Constructores
      public StackDePalabras()
      {
         s = new Stack(); 
      }
  
      // Métodos públicos
      public void Run()
      {
         string palabra = "";
         Console.WriteLine();
         Console.WriteLine("Programa Pila de Palabras");
         Console.WriteLine("-------------------------");
         do
         {
            // Usuario introduce operación
            Console.WriteLine();
            Console.WriteLine("\"+ palabra\" Pone la palabra en la pila");
            Console.WriteLine("\"-\" Saca la primera palabra de la pila");
            Console.WriteLine("\"=\" Despliega la primera palabra de la pila");
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
                  s.Push(palabra.Substring(2));
                  Console.WriteLine("Palabra '" + palabra.Substring(2) + "' apilada...");
                  break;
 
              case '-':
                  if(s.Count < 1)
                  {
                     Console.WriteLine("La pila está vacía!");
                     continue;
                  }     
                  string wordPop = (string) s.Pop();
                  Console.WriteLine("Palabra '" + wordPop + "' desapilada...");
                  break;

               case '=':   
                  if(s.Count < 1)
                  {
                     Console.WriteLine("La pila está vacía!");
                     continue;
                  }     
                  string firstWord = (string) s.Peek();
                  Console.WriteLine("Primera palabra: '" + firstWord + "'");
                  break;

               default:
                  Console.WriteLine("Esto no debería suceder nunca, lo prometo!");
                  break;
            }    

         } while(palabra[0] != '*');
      }

      // Campos privados
      private Stack s;      
   }
}