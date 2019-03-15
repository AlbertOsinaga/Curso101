using System;
using System.Reflection;

namespace CursoNet
{
   namespace CSharp
   {
      class Principal
      {    
         static void Main()
         {
            Assembly assb = Assembly.GetExecutingAssembly();
            Console.WriteLine();
	    Console.Write("Tipo de este assembly: ");
	    Console.Write(assb.GetTypes()[0]);
            Console.WriteLine();
         }
      }
   }
}
