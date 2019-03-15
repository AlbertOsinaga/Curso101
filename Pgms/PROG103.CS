// prog103.CS
// Programa: Diccionario
// LAOS
// Enero 2004

using System;
using System.Collections.Specialized;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Maneja un Directorio telefónico
         DirectorioTelefonico telefonos = new DirectorioTelefonico();
         telefonos.Run();
      }
   } 

   class DirectorioTelefonico
   {
      // Constructores
      public DirectorioTelefonico()
      {
         d = new StringDictionary(); 
      }
  
      // Métodos públicos
      public void Run()
      {
         string palabra = "";
         Console.WriteLine();
         Console.WriteLine("Programa Directorio Telefónico");
         Console.WriteLine("------------------------------");
         do
         {
            // Usuario introduce operación
            Console.WriteLine();
            Console.WriteLine("\"+\" nombre-Teléfono  Ingresa entrada en el directorio");
            Console.WriteLine("\"-\" nombre  Remueve entrada del directorio");
            Console.WriteLine("\"=\" nombre  Despliega nombre-telefono del directorio");
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
               		 
            // Valida palabra (existencia nombre-telefono a ingresar)
            if(palabra[0] == '+'  &&  palabra.Length < 3)
            {
               Console.WriteLine();
               Console.WriteLine("Después del símbolo '+', introduzca nombre-telefono después de un espacio!");
               continue;
            }   
 
            // Valida nombre-telefono (existencia de ambos para el ingreso)  
            if(palabra[0] == '+'  &&  (palabra.IndexOf("-") <= 2  ||  palabra.IndexOf("-") == palabra.Length - 1))
            {
               Console.WriteLine();
               Console.WriteLine("Después del símbolo '+', introduzca nombre-telefono después de un espacio!");
               continue;
            }

            // Valida existencia de nombre para remover   
            if(palabra[0] == '-'  &&  palabra.Length < 3)
            {
               Console.WriteLine();
               Console.WriteLine("Después del símbolo '-', introduzca nombre a remover!");
               continue;
            }   
 
            // Valida existencia de nombre para despliegue de teléfono   
            if(palabra[0] == '='  &&  palabra.Length < 3)
            {
               Console.WriteLine();
               Console.WriteLine("Después del símbolo '=', introduzca nombre de la persona!");
               continue;
            }   
 
            switch(palabra[0])
            {
               case '+':
                  int indiceGuion = palabra.IndexOf("-");
                  string nombre = palabra.Substring(2, indiceGuion - 2);
                  string telefono = palabra.Substring(indiceGuion + 1, palabra.Length - 1 - indiceGuion);
                  d[nombre] = telefono;
                  Console.WriteLine(nombre + "-" + telefono + " fué ingresado...");
                  break;
 
              case '-':
                  if(d.Count < 1)
                  {
                     Console.WriteLine("El directorio está vacío!");
                     continue;
                  }
                  nombre = palabra.Substring(2);
                  telefono = d[nombre];
                  if(telefono == null)
                  {
                     Console.WriteLine("No existe teléfono registrado para " + nombre + "!");
                     continue;
                  }
                  d.Remove(nombre);      
                  Console.WriteLine(nombre + "-" + " fué removido...");
                  break;

               case '=':   
                  if(d.Count < 1)
                  {
                     Console.WriteLine("El directorio está vacío!");
                     continue;
                  }
                  nombre = palabra.Substring(2);
                  telefono = d[nombre];
                  if(telefono == null)
                  {
                     Console.WriteLine("No existe teléfono registrado para " + nombre + "!");
                     continue;
                  }
                  Console.WriteLine(nombre + "-" + telefono);
                  break;

               default:
                  Console.WriteLine("Esto no debería suceder nunca, lo prometo!");
                  break;
            }    

         } while(palabra[0] != '*');
      }

      // Campos privados
      private StringDictionary d;      
   }
}