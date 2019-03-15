// prog072.CS
// Programa: Struct con readonly
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   // Definición de la clase Principal
   class Principal
   {
      static void Main()
      {
         // Obtiene colores
         GetColores();
      }

      static void GetColores()
      {
         Console.WriteLine();
         Console.WriteLine("RED: {0}",  RGB.RED);
         Console.WriteLine("GREEN: {0}", RGB.GREEN);
         Console.WriteLine("BLUE: {0}", RGB.BLUE);
      }
   }


   // Definición de la estructura de Colores
   struct RGB
   {
      public int red;
      public int green;
      public int blue;

      public static readonly RGB RED = new RGB(255, 0, 0);
      public static readonly RGB GREEN = new RGB(0, 255, 0);
      public static readonly RGB BLUE = new RGB(0, 0, 255);

      public RGB(int red, int green, int blue)
      {
         this.red = red;
         this.green = green;
         this.blue = blue;
      }

      public override string ToString()
      {
          return (red.ToString("X2") + green.ToString("X2") + blue.ToString("X2"));
      }
   }
}

