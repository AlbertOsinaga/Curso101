// prog056.CS
// Programa: Constructor por defecto
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
         // Crea y despliega un cliente
         CreaCliente();
      }

      static void CreaCliente()
      {
         // Declaración de variable
         Cliente clienteAhorro;

         // Creación del objeto
         clienteAhorro = new Cliente();	

         // Despliega objeto	
         Console.WriteLine();
         Console.WriteLine("objeto de la clase: {0}", clienteAhorro);  
         Console.WriteLine("------------------------------------");  
         Console.WriteLine("Nombre: {0}", clienteAhorro.nombre);  
         Console.WriteLine("Edad: {0}", clienteAhorro.edad);  
         Console.WriteLine("Sexo: {0}", (clienteAhorro.sexo == 'M' ? "Masculino" : "Femenino"));  
         Console.WriteLine("Activo: {0}", clienteAhorro.activo);  
         Console.WriteLine("Email: {0}", clienteAhorro.email);  
      }
   }



   // Definición de la clase Cliente
   class Cliente
   {

      public Cliente()
      {
         nombre = null;
         edad = 0;
         sexo = '\0';
         activo = false;
         email = null;
      }

      public string nombre;
      public int edad;
      public char sexo;
      public bool activo;
      public string email;
   } 
}