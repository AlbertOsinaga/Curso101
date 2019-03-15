// prog018.CS
// Programa: Conversión a/de Strings
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Conversion
         Conversion();
      } 
        
      static void Conversion()
      {
         // Declaración de variables locales numéricas	
         int cantidad = 12;
         long maxEntero = long.MaxValue;
         decimal monto = 25000000M;

         // Conversión de números a string
         string sCantidad = cantidad.ToString();  	
         string sMaxEntero = maxEntero.ToString();
         string sMonto = Convert.ToString(monto);

         // Despliegue de strings
         Console.WriteLine();
         Console.WriteLine("sCantidad : " + sCantidad);
         Console.WriteLine("sMaxEntero : " + sMaxEntero);
         Console.WriteLine("sMonto : " + sMonto);

         // Ingreso de numero en string
         Console.WriteLine();
         Console.Write("Ingrese un número entero: ");
         string sNumero = Console.ReadLine();
	
         // Conversión de string a numeros
         cantidad = Convert.ToInt32(sNumero);
         maxEntero = Convert.ToInt64(sNumero);
         monto = decimal.Parse(sNumero);            	

         // Despliegue de numeros
         Console.WriteLine();
         Console.WriteLine("cantidad - Convert.ToInt32(sNumero): {0}",cantidad);
         Console.WriteLine("maxEntero - Convert.ToInt64(sNumero): {0}", maxEntero);
         Console.WriteLine("monto - decimal.Parse(sNumero): {0}", monto);
      }
   }
}