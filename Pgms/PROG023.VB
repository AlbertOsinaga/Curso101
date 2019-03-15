' prog023.VB
' Programa: Enums de la librería FCL
' LAOS
' Enero 2004

Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Dias de la semana
         DiasDeSemana()
      
         ' Estados de conexión
         EstadosConexion()

         ' ColoresConocidos
         ColoresConocidos()
 
      End Sub 
        
      Shared Sub DiasDeSemana()
   
         ' Enum System.Windows.Forms.Day
         Console.WriteLine()
         Console.WriteLine("Enum System.Windows.Forms.Day (Dias de la semana)")
         Console.WriteLine("-------------------------------------------------")
         Console.WriteLine("{0}: {1}", Day.Monday, Convert.ToInt32(Day.Monday)) 
         Console.WriteLine("{0}: {1}", Day.Tuesday, Convert.ToInt32(Day.Tuesday)) 
         Console.WriteLine("{0}: {1}", Day.Wednesday, Convert.ToInt32(Day.Wednesday)) 
         Console.WriteLine("{0}: {1}", Day.Thursday, Convert.ToInt32(Day.Thursday)) 
         Console.WriteLine("{0}: {1}", Day.Friday, Convert.ToInt32(Day.Friday)) 
         Console.WriteLine("{0}: {1}", Day.Saturday, Convert.ToInt32(Day.Saturday)) 
         Console.WriteLine("{0}: {1}", Day.Sunday, Convert.ToInt32(Day.Sunday)) 
         Console.WriteLine("{0}: {1}", Day.Default, Convert.ToInt32(Day.Default)) 
      
      End Sub

      Shared Sub EstadosConexion()
   
         ' Enum System.Data.ConnectionState
         Console.WriteLine()
         Console.WriteLine("Enum System.Data.ConnectionState (Estados de conexión)")
         Console.WriteLine("------------------------------------------------------")
         Console.WriteLine("{0}: {1}", ConnectionState.Closed, Convert.ToInt32(ConnectionState.Closed)) 
         Console.WriteLine("{0}: {1}", ConnectionState.Open, Convert.ToInt32(ConnectionState.Open)) 
         Console.WriteLine("{0}: {1}", ConnectionState.Connecting, Convert.ToInt32(ConnectionState.Connecting)) 
         Console.WriteLine("{0}: {1}", ConnectionState.Executing, Convert.ToInt32(ConnectionState.Executing)) 
         Console.WriteLine("{0}: {1}", ConnectionState.Fetching, Convert.ToInt32(ConnectionState.Fetching)) 
         Console.WriteLine("{0}: {1}", ConnectionState.Broken, Convert.ToInt32(ConnectionState.Broken)) 

      End Sub

      Shared Sub ColoresConocidos()
   
         ' Enum System.Drawing.KnownColor
         Console.WriteLine()
         Console.WriteLine("Enum System.Drawing.KnownColor (Colores conocidos)")
         Console.WriteLine("-------------------------------------------------")
         Console.WriteLine("{0}: {1}", KnownColor.AliceBlue, Convert.ToInt32(KnownColor.AliceBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.Blue, Convert.ToInt32(KnownColor.Blue)) 
         Console.WriteLine("{0}: {1}", KnownColor.CadetBlue, Convert.ToInt32(KnownColor.CadetBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.CornflowerBlue, Convert.ToInt32(KnownColor.CornflowerBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.DarkBlue, Convert.ToInt32(KnownColor.DarkBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.DarkSlateBlue, Convert.ToInt32(KnownColor.DarkSlateBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.DeepSkyBlue, Convert.ToInt32(KnownColor.DeepSkyBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.DodgerBlue, Convert.ToInt32(KnownColor.DodgerBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.LightBlue, Convert.ToInt32(KnownColor.LightBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.LightSkyBlue, Convert.ToInt32(KnownColor.LightSkyBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.LightSteelBlue, Convert.ToInt32(KnownColor.LightSteelBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.MediumBlue, Convert.ToInt32(KnownColor.MediumBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.MediumSlateBlue, Convert.ToInt32(KnownColor.MediumSlateBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.MidnightBlue, Convert.ToInt32(KnownColor.MidnightBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.PowderBlue, Convert.ToInt32(KnownColor.PowderBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.RoyalBlue, Convert.ToInt32(KnownColor.RoyalBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.SkyBlue, Convert.ToInt32(KnownColor.SkyBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.SlateBlue, Convert.ToInt32(KnownColor.SlateBlue)) 
         Console.WriteLine("{0}: {1}", KnownColor.SteelBlue, Convert.ToInt32(KnownColor.SteelBlue)) 
   
      End Sub
   
   End Class

End Namespace