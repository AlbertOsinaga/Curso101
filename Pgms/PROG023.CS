// prog023.CS
// Programa: Enums en la libreria FCL
// LAOS
// Enero 2004

using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Dias de la semana
         DiasDeSemana();

         // Estados de conexión
         EstadosConexion();

         // Colores conocidos
         ColoresConocidos();  
      } 
        
      static void DiasDeSemana()
      {
         // Enum System.Windows.Forms.Day
         Console.WriteLine();
         Console.WriteLine("Enum System.Windows.Forms.Day (Dias de la semana)");
         Console.WriteLine("-------------------------------------------------");
         Console.WriteLine("{0}: {1}", Day.Monday, (int) Day.Monday); 
         Console.WriteLine("{0}: {1}", Day.Tuesday, (int) Day.Tuesday); 
         Console.WriteLine("{0}: {1}", Day.Wednesday, (int) Day.Wednesday); 
         Console.WriteLine("{0}: {1}", Day.Thursday, (int) Day.Thursday); 
         Console.WriteLine("{0}: {1}", Day.Friday, (int) Day.Friday); 
         Console.WriteLine("{0}: {1}", Day.Saturday, (int) Day.Saturday); 
         Console.WriteLine("{0}: {1}", Day.Sunday, (int) Day.Sunday); 
         Console.WriteLine("{0}: {1}", Day.Default, (int) Day.Default); 
      }

      static void EstadosConexion()
      {
         // Enum System.Data.ConnectionState
         Console.WriteLine();
         Console.WriteLine("Enum System.Data.ConnectionState (Estados de conexión)");
         Console.WriteLine("------------------------------------------------------");
         Console.WriteLine("{0}: {1}", ConnectionState.Closed, (int) ConnectionState.Closed); 
         Console.WriteLine("{0}: {1}", ConnectionState.Open, (int) ConnectionState.Open); 
         Console.WriteLine("{0}: {1}", ConnectionState.Connecting, (int) ConnectionState.Connecting); 
         Console.WriteLine("{0}: {1}", ConnectionState.Executing, (int) ConnectionState.Executing); 
         Console.WriteLine("{0}: {1}", ConnectionState.Fetching, (int) ConnectionState.Fetching); 
         Console.WriteLine("{0}: {1}", ConnectionState.Broken, (int) ConnectionState.Broken); 
      }

      static void ColoresConocidos()
      {
         // Enum System.Drawing.KnownColor
         Console.WriteLine();
         Console.WriteLine("Enum System.Drawing.KnownColor (Colores conocidos)");
         Console.WriteLine("-------------------------------------------------");
         Console.WriteLine("{0}: {1}", KnownColor.AliceBlue, (int) KnownColor.AliceBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.Blue, (int) KnownColor.Blue); 
         Console.WriteLine("{0}: {1}", KnownColor.CadetBlue, (int) KnownColor.CadetBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.CornflowerBlue, (int) KnownColor.CornflowerBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.DarkBlue, (int) KnownColor.DarkBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.DarkSlateBlue, (int) KnownColor.DarkSlateBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.DeepSkyBlue, (int) KnownColor.DeepSkyBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.DodgerBlue, (int) KnownColor.DodgerBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.LightBlue, (int) KnownColor.LightBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.LightSkyBlue, (int) KnownColor.LightSkyBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.LightSteelBlue, (int) KnownColor.LightSteelBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.MediumBlue, (int) KnownColor.MediumBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.MediumSlateBlue, (int) KnownColor.MediumSlateBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.MidnightBlue, (int) KnownColor.MidnightBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.PowderBlue, (int) KnownColor.PowderBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.RoyalBlue, (int) KnownColor.RoyalBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.SkyBlue, (int) KnownColor.SkyBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.SlateBlue, (int) KnownColor.SlateBlue); 
         Console.WriteLine("{0}: {1}", KnownColor.SteelBlue, (int) KnownColor.SteelBlue); 
      }
   }
}