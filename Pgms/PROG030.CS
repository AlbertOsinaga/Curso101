// prog030.CS
// Programa: Manejo de memoria
// LAOS
// Enero 2004

using System;
using System.Text;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Ejercicios de manejo de memoria
         ManejoMemoria();
      }

      static void ManejoMemoria()
      {
         // Asignacion de variables tipo valor
         short h;
         int x = 15;
         long y = x;

         // Despliega variables tipo valor (asignacion)
         Console.WriteLine();
         Console.WriteLine("Variables Tipo Valor: (asignacion)");
         Console.WriteLine("h = no inicializada"); 
         Console.WriteLine("x = {0}", x);
         Console.WriteLine("y = {0}", y);

         // Cambio del valor de una variable tipo valor
         x = 23;

         // Despliega variables tipo valor (cambio valor)
         Console.WriteLine();
         Console.WriteLine("Variables Tipo Valor: (cambio valor)");
         Console.WriteLine("h = no inicializada"); 
         Console.WriteLine("x = {0}", x);
         Console.WriteLine("y = {0}", y);

         // Inicializacin despus de su creación
         h = 17;
 
         // Despliega variables tipo valor (inicializacion)
         Console.WriteLine();
         Console.WriteLine("Variables Tipo Valor (inicializacion):");
         Console.WriteLine("h = {0}", h);
         Console.WriteLine("x = {0}", x);
         Console.WriteLine("y = {0}", y);

         // Pase de variables tipo valor
         Intercambia(x, h);

         // Despliega variables tipo valor (pase)
         Console.WriteLine();
         Console.WriteLine("Variables Tipo Valor (pase):");
         Console.WriteLine("h = {0}", h);
         Console.WriteLine("x = {0}", x);
         Console.WriteLine("y = {0}", y);

         // Asignacion de variables tipo referencia
         StringBuilder sh; 
         StringBuilder sx = new StringBuilder("15");
         StringBuilder sy = sx;
     
         // Despliega variables tipo referencia (asignacion)
         Console.WriteLine();
         Console.WriteLine("Variables Tipo Referencia (asignacion):");
         Console.WriteLine("sh = null");
         Console.WriteLine("sx = {0}", sx);
         Console.WriteLine("sy = {0}", sy);

         // Cambio del valor de una variable tipo referencia
         sx.Replace("15", "23");

         // Despliega variables tipo referencia (cambio valor)
         Console.WriteLine();
         Console.WriteLine("Variables Tipo Referencia (cambio valor):");
         Console.WriteLine("sh = null");
         Console.WriteLine("sx = {0}", sx);
         Console.WriteLine("sy = {0}", sy);

         // Inicializacin despus de su creacin
         sh = new StringBuilder("17");

         // Despliega variables tipo referencia (inicializacion)
         Console.WriteLine();
         Console.WriteLine("Variables Tipo Referencia (inicializacion):");
         Console.WriteLine("sh = {0}", sh);
         Console.WriteLine("sx = {0}", sx);
         Console.WriteLine("sy = {0}", sy);

         // Pase de variables tipo referencia
         Intercambia(sx, sh);

         // Despliega variables tipo referencia (pase)
         Console.WriteLine();
         Console.WriteLine("Variables Tipo Referencia (pase):");
         Console.WriteLine("sh = {0}", sh);
         Console.WriteLine("sx = {0}", sx);
         Console.WriteLine("sy = {0}", sy);

      }

      static void Intercambia(double x, double y)
      {
         double temp = x;
         x = y;
         y = temp;
      }

      static void Intercambia(StringBuilder x, StringBuilder y)
      {
         StringBuilder temp = new StringBuilder(x.ToString());
         x.Replace(x.ToString(), y.ToString());
         y.Replace(y.ToString(), temp.ToString());
      }	
   }
}
