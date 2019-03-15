// prog017.CS
// Programa: Conversión de tipos primitivos
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Implícitas
         Implicitas();

         // Explícitas
         Explicitas();

	 // Usando Convert
         UsandoConvert();	
      } 
        
      static void Implicitas()
      {  
         // Variables locales
         short s = 5;
         int n = 0;
         long ln = 0;
         double db = 0;

         // Conversiones implícitas (promociones)
         n = s;
         ln = n;
         db = ln; 
         
         // Despliegue de resultados
         Console.WriteLine();
         Console.WriteLine("Implícitas");
         Console.WriteLine("----------");
         Console.WriteLine("short: {0}", s);
         Console.WriteLine("int = short: {0}", n);
         Console.WriteLine("long = int: {0}", ln);
         Console.WriteLine("double = long: {0}", db);
      } 

      static void Explicitas()
      {  
         // Variables locales
         short s = 0;
         int n = 0;
         long ln = 0;
         double db = double.MaxValue;

         // Conversiones explícitas
         ln = (long) db; 
         n = (int) ln;
         s = (short) n; 

         // Despliegue de resultados
         Console.WriteLine();
         Console.WriteLine("Explícitas");
         Console.WriteLine("----------");
         Console.WriteLine("double: {0}", db);
         Console.WriteLine("long = (long) double: {0}", ln);
         Console.WriteLine("int = (int) long: {0}", n);
         Console.WriteLine("short = (short) int: {0}", s);
       }
 
      static void UsandoConvert()
      {  
         // Casting con Convert
         int entero = 20;	// System.Int32
         uint natural = 30;	// System.UInt32  
         entero = Convert.ToInt32(natural);
         natural = Convert.ToUInt32(entero);
         byte valor = Convert.ToByte(255); 
         Console.WriteLine();
         Console.WriteLine("Usando Convert");
         Console.WriteLine("--------------");
         Console.WriteLine("entero = {0}", entero);
         Console.WriteLine("positivo = {0}", natural);
         Console.WriteLine("valor = {0}", valor);
      }
   }
}