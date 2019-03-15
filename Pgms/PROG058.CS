// prog058.CS
// Programa: Usando "this"
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
         // Crea y despliega un clientes
         CreaClientes();
      }

      static void CreaClientes()
      {
         // Declaración y creación de objetos
         Cliente nn = new Cliente();
         Cliente comprador = new Cliente("Pablo", 10, 'M');
         Cliente vendedor = new Cliente("Ana", 25, 'F', true, "ana@servimail.com");

         // Despliega objeto nn	
         Console.WriteLine();
         Console.WriteLine("objeto de la clase: {0}", nn);  
         Console.WriteLine("------------------------------------");  
         Console.WriteLine("Nombre: {0}", nn.nombre);  
         Console.WriteLine("Edad: {0}", nn.edad);  
         Console.WriteLine("Sexo: {0}", (nn.sexo == 'M' ? "Masculino" : "Femenino"));  
         Console.WriteLine("Activo: {0}", nn.activo);  
         Console.WriteLine("Email: {0}", nn.email);  

         // Despliega objeto comprador
         Console.WriteLine();
         Console.WriteLine("objeto de la clase: {0}", comprador);  
         Console.WriteLine("------------------------------------");  
         Console.WriteLine("Nombre: {0}", comprador.nombre);  
         Console.WriteLine("Edad: {0}", comprador.edad);  
         Console.WriteLine("Sexo: {0}", (comprador.sexo == 'M' ? "Masculino" : "Femenino"));  
         Console.WriteLine("Activo: {0}", comprador.activo);  
         Console.WriteLine("Email: {0}", comprador.email);  

         // Despliega objeto vendedor
         Console.WriteLine();
         Console.WriteLine("objeto de la clase: {0}", vendedor);  
         Console.WriteLine("------------------------------------");  
         Console.WriteLine("Nombre: {0}", vendedor.nombre);  
         Console.WriteLine("Edad: {0}", vendedor.edad);  
         Console.WriteLine("Sexo: {0}", (vendedor.sexo == 'M' ? "Masculino" : "Femenino"));  
         Console.WriteLine("Activo: {0}", vendedor.activo);  
         Console.WriteLine("Email: {0}", vendedor.email);  
      }
   }



   // Definición de la clase Cliente
   class Cliente
   {

      public Cliente()
      {
         this.nombre = "nn";
         this.edad = 0;
         this.sexo = 'F';
         this.activo = false;
         this.email = "";
      }

      public Cliente(string nombre, int edad, char sexo)
      {
         this.nombre = nombre;
         this.edad = edad;
         this.sexo = sexo;
         this.activo = false;
         this.email = "";
      }

      public Cliente(string nombre, int edad, char sexo, bool activo, string email)
      {
         this.nombre = nombre;
         this.edad = edad;
         this.sexo = sexo;
         this.activo = activo;
         this.email = email;
      }

      public string nombre;
      public int edad;
      public char sexo;
      public bool activo;
      public string email;
   } 
}