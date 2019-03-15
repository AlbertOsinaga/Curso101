// prog071.CS
// Programa: Campos readonly
// LAOS
// Enero 2004

using System;
using System.Net;

namespace CursoNet
{
   // Definición de la clase Principal
   class Principal
   {
      static void Main()
      {
         // Obtiene IP Address
         GetIPAddress();
      }

      static void GetIPAddress()
      {
         WorkStation wk = new WorkStation();
         Console.WriteLine();
         Console.WriteLine("Mi dirección IP es " + wk.IpaString);
      }
   }


   // Definición de la clase WorkStation
   class WorkStation
   {
      public WorkStation()
      {
         IPAddress ipa = Dns.Resolve(hostName).AddressList[0];
         IpaString = ipa.ToString();
      }

      public const string hostName = "localhost";
      public readonly string IpaString;
   }
}

