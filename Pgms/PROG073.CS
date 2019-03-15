// prog073.CS
// Programa: Propiedades
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
         nn.Tipo = "nn";
         nn.Clase = Cliente.Regular;
         nn.Nombre = "Juan";
         nn.Edad = 46;
         nn.Sexo = 'M';
         nn.Email = "juan@sucorreo.net";

         // Setea algunos datos faltantes comprador
         comprador.Tipo = "comprador";
         comprador.Activo = true;
         comprador.Email = "pablo@mundo.net";
         comprador.Clase = Cliente.Especial;

         // Setea algunos datos faltantes vendedor
         vendedor.Tipo = "vendedor";
         vendedor.Clase = Cliente.Exclusivo;

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
            Console.WriteLine("Tipo: {0}", cliente.Tipo);  
            Console.WriteLine("Clase: {0}", cliente.Clase);  
            Console.WriteLine("Nombre: {0}", cliente.Nombre);  
            Console.WriteLine("Edad: {0}", cliente.Edad);  
            Console.WriteLine("Año Nacimiento: {0}", cliente.YearNacimiento("2004"));  
            Console.WriteLine("Sexo: {0}", (cliente.EsVaron ? "Masculino" : "Femenino"));  
            Console.WriteLine("Activo: {0}", cliente.Activo);  
            Console.WriteLine("Email: {0}", cliente.Email);  
            Console.WriteLine("Cantidad: {0}", Cliente.Cantidad);  
            Console.WriteLine("Conexión: {0}", Cliente.ConexionData);  
         }
      } 
   }



   // Definición de la clase Cliente
   class Cliente
   {
      // Constructores

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


      // Métodos públicos de instancia

      public string YearNacimiento(string YearHoy)
      {
         return (int.Parse(YearHoy) - this.edad).ToString(); 
      } 


      // Métodos públicos de clase

      public static string OpenConexion()
      {
         Console.WriteLine();
         Console.WriteLine("Abriendo Conexion a CentralServices");
         return "CentralServices"; 
      } 

      // Propiedades campos de instancia
      public string Nombre
      {
         get { return nombre; }
         set { nombre = value; }
      } 
      public int Edad
      {
         get { return edad; }
         set { edad = value; }
      } 
      public char Sexo
      {
         get { return sexo; }
         set { sexo = value; }
      }
      public bool EsVaron
      {
         get { return (this.sexo == 'M' ? true : false); }
      } 
      public bool Activo
      {
         get { return activo; }
         set { activo = value; }
      } 
      public string Email
      {
         get { return email; }
         set { email = value; }
      } 
      public string Tipo
      {
         get { return tipo; }
         set { tipo = value; }
      } 
      public char Clase
      {
         get { return clase; }
         set { clase = value; }
      } 

      // Propiedades campos de clase
      public static int Cantidad
      {
         get { return cantidad; }
      } 
      public static string ConexionData
      {
         get { return conexionData; }
      } 

      // campos de instancia
      private string nombre;
      private int edad;
      private char sexo;
      private bool activo;
      private string email;
      private string tipo;
      private char clase;
      
      // campos de clase
      private static int cantidad; 
      private static string conexionData;

      // campos constantes
      public const char Regular = 'A';
      public const char Especial = 'B';
      public const char Exclusivo = 'C';
   } 
}