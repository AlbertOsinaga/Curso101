// prog066.CS
// Programa: Uso de params
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
         nn.SetTipo("nn");
         nn.SetNombre("Juan");
         nn.SetEdad(46);
         nn.SetSexo('M');
         nn.SetEmail("juan@sucorreo.net");

         // Setea algunos datos faltantes comprador
         comprador.SetTipo("comprador");
         comprador.SetActivo(true);
         comprador.SetEmail("pablo@mundo.net");

         // Setea algunos datos faltantes vendedor
         vendedor.SetTipo("vendedor");

         // Despliega objetos
         DespliegaClientes(nn, comprador, vendedor);
      }

      static void DespliegaClientes(params Cliente[] clientes)
      {
         foreach(Cliente cliente in clientes)
         {  
            // Despliega objeto cliente
            Console.WriteLine();
            Console.WriteLine("objeto de la clase: {0}", cliente);  
            Console.WriteLine("---------------------------------------");  
            Console.WriteLine("Tipo: {0}", cliente.GetTipo());  
            Console.WriteLine("Nombre: {0}", cliente.GetNombre());  
            Console.WriteLine("Edad: {0}", cliente.GetEdad());  
            Console.WriteLine("Año Nacimiento: {0}", cliente.YearNacimiento("2004"));  
            Console.WriteLine("Sexo: {0}", (cliente.EsVaron() ? "Masculino" : "Femenino"));  
            Console.WriteLine("Activo: {0}", cliente.GetActivo());  
            Console.WriteLine("Email: {0}", cliente.GetEmail());  
         }
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

      public void SetTipo(string tipo)
      {
         this.tipo = tipo;
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

      public string GetTipo()
      {
         return this.tipo;
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
      private string tipo;
   } 
}