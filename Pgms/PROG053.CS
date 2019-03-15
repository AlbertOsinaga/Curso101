// prog053.CS
// Programa: Declaración de clases
//           y definición-creación de objetos 
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
         // Definición y creación de objetos
         UsaObjetos();
      }

      static void UsaObjetos()
      {
         // Declaración de variable
         Cliente clienteAhorro;

         // Creación del objeto clienteAhorro
         clienteAhorro = new Cliente();	

         // Despliega objeto clienteAhorro	
         Console.WriteLine();
         Console.WriteLine("objeto clienteAhorro de la clase: {0}", clienteAhorro);  

         // Declaración y creación del objeto clienteCredito
         CursoNet.Cliente clienteCredito = new CursoNet.Cliente();	

         // Despliega objeto clienteCredito	
         Console.WriteLine();
         Console.WriteLine("objeto clienteCredito de la clase: {0}", clienteCredito);  
      }
   }



   // Definición de la clase Cliente   

   class Cliente
   {
      /* 
         Cuerpo de la clase
         ..................
         ..................
         ..................
      */ 
   } 
}