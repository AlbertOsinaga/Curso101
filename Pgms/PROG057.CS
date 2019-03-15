// prog057.CS
// Programa: Overloading de constructores
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
         Console.WriteLine("Nombre: {0}", nn.m_nombre);  
         Console.WriteLine("Edad: {0}", nn.m_edad);  
         Console.WriteLine("Sexo: {0}", (nn.m_sexo == 'M' ? "Masculino" : "Femenino"));  
         Console.WriteLine("Activo: {0}", nn.m_activo);  
         Console.WriteLine("Email: {0}", nn.m_email);  

         // Despliega objeto comprador
         Console.WriteLine();
         Console.WriteLine("objeto de la clase: {0}", comprador);  
         Console.WriteLine("------------------------------------");  
         Console.WriteLine("Nombre: {0}", comprador.m_nombre);  
         Console.WriteLine("Edad: {0}", comprador.m_edad);  
         Console.WriteLine("Sexo: {0}", (comprador.m_sexo == 'M' ? "Masculino" : "Femenino"));  
         Console.WriteLine("Activo: {0}", comprador.m_activo);  
         Console.WriteLine("Email: {0}", comprador.m_email);  

         // Despliega objeto vendedor
         Console.WriteLine();
         Console.WriteLine("objeto de la clase: {0}", vendedor);  
         Console.WriteLine("------------------------------------");  
         Console.WriteLine("Nombre: {0}", vendedor.m_nombre);  
         Console.WriteLine("Edad: {0}", vendedor.m_edad);  
         Console.WriteLine("Sexo: {0}", (vendedor.m_sexo == 'M' ? "Masculino" : "Femenino"));  
         Console.WriteLine("Activo: {0}", vendedor.m_activo);  
         Console.WriteLine("Email: {0}", vendedor.m_email);  
      }
   }



   // Definición de la clase Cliente
   class Cliente
   {

      public Cliente()
      {
         m_nombre = "nn";
         m_edad = 0;
         m_sexo = 'F';
         m_activo = false;
         m_email = "";
      }

      public Cliente(string nombre, int edad, char sexo)
      {
         m_nombre = nombre;
         m_edad = edad;
         m_sexo = sexo;
         m_activo = false;
         m_email = "";
      }

      public Cliente(string nombre, int edad, char sexo, bool activo, string email)
      {
         m_nombre = nombre;
         m_edad = edad;
         m_sexo = sexo;
         m_activo = activo;
         m_email = email;
      }

      public string m_nombre;
      public int m_edad;
      public char m_sexo;
      public bool m_activo;
      public string m_email;
   } 
}