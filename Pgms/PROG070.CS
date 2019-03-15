// prog070.CS
// Programa: Campos constantes
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
         nn.SetClase(Cliente.regular);

         // Setea algunos datos faltantes comprador
         comprador.SetTipo("comprador");
         comprador.SetActivo(true);
         comprador.SetEmail("pablo@mundo.net");
         comprador.SetClase(Cliente.especial);

         // Setea algunos datos faltantes vendedor
         vendedor.SetTipo("vendedor");
         vendedor.SetClase(Cliente.exclusivo);

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
            Console.WriteLine("Clase: {0}", cliente.GetClase());  
            Console.WriteLine("Nombre: {0}", cliente.GetNombre());  
            Console.WriteLine("Edad: {0}", cliente.GetEdad());  
            Console.WriteLine("Año Nacimiento: {0}", cliente.YearNacimiento("2004"));  
            Console.WriteLine("Sexo: {0}", (cliente.EsVaron() ? "Masculino" : "Femenino"));  
            Console.WriteLine("Activo: {0}", cliente.GetActivo());  
            Console.WriteLine("Email: {0}", cliente.GetEmail());  
            Console.WriteLine("Cantidad: {0}", Cliente.cantidad);  
            Console.WriteLine("Conexión: {0}", Cliente.conexionData);  
         }
      } 
   }



   // Definición de la clase Cliente
   class Cliente
   {

      static Cliente()
      {
         Cliente.cantidad = 0;
         Cliente.conexionData = Cliente.OpenConexion();   
      }
 
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

         Cliente.cantidad++;
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

      public void SetClase(char clase)
      {
         this.clase = clase;
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

      public char GetClase()
      {
         return this.clase;
      }

      public bool EsVaron()
      {
         return (this.sexo == 'M' ? true : false); 
      } 

      public string YearNacimiento(string YearHoy)
      {
         return (int.Parse(YearHoy) - this.edad).ToString(); 
      } 

      public static string OpenConexion()
      {
         Console.WriteLine();
         Console.WriteLine("Abriendo Conexion a CentralServices");
         return "CentralServices"; 
      } 

      private string nombre;
      private int edad;
      private char sexo;
      private bool activo;
      private string email;
      private string tipo;
      private char clase;
      
      public static int cantidad; 
      public static string conexionData;

      public const char regular = 'A';
      public const char especial = 'B';
      public const char exclusivo = 'C';
   } 
}