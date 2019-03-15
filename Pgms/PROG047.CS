// prog047.CS
// Programa: Sentencia de control for
// LAOS
// Enero 2004

using System;
using System.Threading;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Cuenta segundos del 1 al 30
         CuentaSegundos();
      }

      static void CuentaSegundos()
      {
         // variables locales
         const string DigitosUnidad = "1234567890";
         const string DigitosDecena = "123";
         string sSegundos;
         int nSegundos;
       
         // pide el número de segundos a contar al usuario
         Console.WriteLine();
         Console.Write("Introduzca el número de segundos a contar (1 a 30): ");
         sSegundos = Console.ReadLine();
         Console.WriteLine();

         // Si número es inválido, termina 
         if (sSegundos.Length < 1)
         {
            Console.WriteLine("Número no fué introducido!");
            return; 
         }
         if (sSegundos.Length > 2)
         {
            Console.WriteLine("Lo lamentamos! Solo se aceptan números entre 1 y 30");
            return; 
         } 
         if (sSegundos.Length == 1  &&  DigitosUnidad.IndexOf(sSegundos[0]) < 0)
         {
            Console.WriteLine("Lo lamentamos! Solo se aceptan números");
            return; 
         } 
         if ( sSegundos.Length == 2  &&  (DigitosDecena.IndexOf(sSegundos[0]) < 0  || DigitosUnidad.IndexOf(sSegundos[1]) < 0) )
         {
            Console.WriteLine("Lo lamentamos! Solo se aceptan números entre 1 y 30");
            return; 
         } 

         // Convierte segundos a numero, si no valida rango termina
         nSegundos = Int32.Parse(sSegundos);
         if (nSegundos < 1  || nSegundos > 30)
         {
            Console.WriteLine("Lo lamentamos! Solo se aceptan números entre 1 y 30");
            return; 
         } 

         // Cuenta y despliega los segundos
         Console.WriteLine();
         for (int n = 1; n <= nSegundos; n++)
         { 
            Thread.Sleep(1000);          
            Console.Write("\b{0}", n);
         }                 	
         Console.WriteLine();
      }
   }
}