// prog060.CS
// Programa: Métodos
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

         // Setea algunos datos faltantes nn
         nn.SetNombre("Juan");
         nn.SetEdad(46);
         nn.SetSexo('M');
         nn.SetEmail("juan@sucorreo.net");

         // Despliega objeto nn	
         Console.WriteLine();
         Console.WriteLine("objeto de la clase: {0}", nn);  
         Console.WriteLine("------------------------------------");  
         Console.WriteLine("Nombre: {0}", nn.GetNombre());  
         Console.WriteLine("Edad: {0}", nn.GetEdad());  
         Console.WriteLine("Año Nacimiento: {0}", nn.YearNacimiento("2004"));  
         Console.WriteLine("Sexo: {0}", (nn.EsVaron() == true ? "Masculino" : "Femenino"));  
         Console.WriteLine("Activo: {0}", nn.GetActivo());  
         Console.WriteLine("Email: {0}", nn.GetEmail());  

         // Setea algunos datos faltantes comprador
         comprador.SetActivo(true);
         comprador.SetEmail("pablo@mundo.net");

         // Despliega objeto comprador
         Console.WriteLine();
         Console.WriteLine("objeto de la clase: {0}", comprador);  
         Console.WriteLine("------------------------------------");  
         Console.WriteLine("Nombre: {0}", comprador.GetNombre());  
         Console.WriteLine("Edad: {0}", comprador.GetEdad());  
         Console.WriteLine("Año Nacimiento: {0}", comprador.YearNacimiento("2004"));  
         Console.WriteLine("Sexo: {0}", (comprador.EsVaron() ? "Masculino" : "Femenino"));  
         Console.WriteLine("Activo: {0}", comprador.GetActivo());  
         Console.WriteLine("Email: {0}", comprador.GetEmail());  

         // Despliega objeto vendedor
         Console.WriteLine();
         Console.WriteLine("objeto de la clase: {0}", vendedor);  
         Console.WriteLine("------------------------------------");  
         Console.WriteLine("Nombre: {0}", vendedor.GetNombre());  
         Console.WriteLine("Edad: {0}", vendedor.GetEdad());  
         Console.WriteLine("Año Nacimiento: {0}", vendedor.YearNacimiento("2004"));  
         Console.WriteLine("Sexo: {0}", (vendedor.EsVaron() ? "Masculino" : "Femenino"));  
         Console.WriteLine("Activo: {0}", vendedor.GetActivo());  
         Console.WriteLine("Email: {0}", vendedor.GetEmail());  
      }
   }



   // Definición de la clase Cliente
   class Cliente
   {

      public Cliente() : this("nn", 0, 'F', false, "")
      {
      }

      public Cliente(string nombre, int edad, char sexo) : this(nombre, edad, sexo, false, "")
      {
      }

      public Cliente(string nombre, int edad, char sexo, bool activo, string email)
      {
         this.nombre = nombre;
         this.edad = edad;
         this.sexo = sexo;
         this.activo = activo;
         this.email = email;
      }

      public void SetNombre(string nombre)
      {
         this.nombre = nombre;
      }

      public void SetEdad(int edad)
      {
         this.edad = edad;
      }

      public void SetSexo(char sexo)
      {
         this.sexo = sexo;
      }

      public void SetActivo(bool activo)
      {
         this.activo = activo;
      }

      public void SetEmail(string email)
      {
         this.email = email;
      }

      public string GetNombre()
      {
         return this.nombre;
      }

      public int GetEdad()
      {
         return this.edad;
      }

      public char GetSexo()
      {
         return this.sexo;
      }

      public bool GetActivo()
      {
         return this.activo;
      }

      public string GetEmail()
      {
         return this.email;
      }

      public bool EsVaron()
      {
         return (this.sexo == 'M' ? true : false); 
      } 

      public string YearNacimiento(string YearHoy)
      {
         return (int.Parse(YearHoy) - this.edad).ToString(); 
      } 

      private string nombre;
      private int edad;
      private char sexo;
      private bool activo;
      private string email;
   } 
}