// prog078.CS
// Programa: Definición de una clase derivada
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   // Definición de la clase Cuenta
   class Cuenta
   {
       // Constructores y Destructores 

       public Cuenta(string numeroCta, string nombreCta) : this(numeroCta, nombreCta, "", "", "", "nn", Cliente.Regular)
       {
       }  

       public Cuenta(string numeroCta, string nombreCta, string codigoCli, string emailCli) 
                      : this(numeroCta, nombreCta, codigoCli, nombreCta, emailCli, "nn", Cliente.Regular)
       {
       }  

       public Cuenta(string numeroCta, string nombreCta, string codigoCli, string nombreCli, 
                     string emailCli, string tipoCli, char claseCli)
       {
          m_numero = numeroCta;
          m_nombre = nombreCta;
          m_titular = new Cliente(codigoCli, nombreCli, emailCli, tipoCli, claseCli);

          m_saldo = 0M;
       } 

       
       // Métodos públicos

       public decimal Deposito(decimal monto)
       {
          m_saldo += monto;
          return m_saldo;
       } 

       public decimal Retiro(decimal monto)
       {
          m_saldo -= monto;
          return m_saldo;
       } 


       // Propiedades de instancia

       public string Numero
       {
          get { return m_numero; }
          set { m_numero = value; }
       } 
       public string Nombre
       {
          get { return m_nombre; }
          set { m_nombre = value; }
       } 
       public decimal Saldo
       {
          get { return m_saldo; }
       } 
       public Cliente Titular
       {
          get { return m_titular; }
          set { m_titular = value; }
       } 
           
       // Campos de instancia

       private string m_numero;
       private string m_nombre;
       private decimal m_saldo;
       private Cliente m_titular; 
   }



   // Definición de la clase CuentaAhorro
   class CuentaAhorro : Cuenta
   {
       // Constructores y Destructores 

       public CuentaAhorro(string numeroCta, string nombreCta) : base(numeroCta, nombreCta, "", "", "", "nn", Cliente.Regular)
       {
       }  

       public CuentaAhorro(string numeroCta, string nombreCta, string codigoCli, string emailCli) 
                      : base(numeroCta, nombreCta, codigoCli, nombreCta, emailCli, "nn", Cliente.Regular)
       {
       }  

       public CuentaAhorro(string numeroCta, string nombreCta, string codigoCli, string nombreCli, 
                     string emailCli, string tipoCli, char claseCli)
                         : base(numeroCta, nombreCta, codigoCli, nombreCli, emailCli, tipoCli, claseCli)
       {
          m_debitos = 0M;
          m_creditos = 0M; 
          m_saldo_antes = 0M; 
       } 


       // Propiedades de instancia

       public decimal Retiros
       {
          get { return m_debitos; }
          set { m_debitos = value; }
       } 
       public decimal Depositos
       {
          get { return m_creditos; }
          set { m_creditos = value; }
       } 
       public decimal SaldoAnterior
       {
          get { return m_saldo_antes; }
          set { m_saldo_antes = value; }
       } 

       // Campos de instancia

       private decimal m_debitos;
       private decimal m_creditos;
       private decimal m_saldo_antes;
   } 


   // Definición de la clase Cliente
   class Cliente
   {
      // Constructores y Finalizadores

      static Cliente()
      {
         Cliente.cantidad = 0;
         Cliente.conexionData = Cliente.OpenConexion();   
      }
 
      public Cliente(string codigo, string nombre, string email) : this(codigo, nombre, email, "nn", Cliente.Regular)
      {
      }

      public Cliente(string codigo, string nombre, string email, string tipo, char clase)
      {
         this.codigo = codigo;
         this.nombre = nombre;
         this.email = email;
         this.tipo = tipo;
         this.clase = clase; 
 
         this.edad = 0;
         this.sexo = ' ';
         this.activo = true;

         Cliente.cantidad++;
      }

      public void Dispose()
      {
         Cliente.cantidad--;
         GC.SuppressFinalize(this);
      } 

      public void Finalize()
      {
         Cliente.cantidad--;
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

      public string Codigo
      {
         get { return codigo; }
         set { codigo = value; }
      } 
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

      private string codigo;
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



   // Definición Clase Principal
   class Principal
   {
      static void Main()
      {
          // Crea una cuenta ahorro
          CuentaAhorro cta = new CuentaAhorro("1005", "Juan Perez", "000201", "jp@box.com");             

          // Completando datos
          cta.Titular.Tipo = "Ahorrista";
          cta.Titular.Edad = 35;
          cta.Titular.Sexo = 'M';    
          cta.SaldoAnterior = 150M;

          // Despliega datos de cuenta y su cliente
          Console.WriteLine();
          Console.WriteLine("Cuenta # " + cta.Numero + " (Saldo Anterior = 150)");
          Console.WriteLine("-------------------------------------------------");
          Console.WriteLine("Nombre de la Cuenta: " + cta.Nombre); 
          Console.WriteLine("Código del Cliente: " + cta.Titular.Codigo); 
          Console.WriteLine("Nombre del Cliente: " + cta.Titular.Nombre); 
          Console.WriteLine("Email del Cliente: " + cta.Titular.Email); 
          Console.WriteLine("Tipo de Cliente: " + cta.Titular.Tipo); 
          Console.WriteLine("Clase de Cliente: " + cta.Titular.Clase.ToString()); 
          Console.WriteLine("Edad del Cliente: " + cta.Titular.Edad.ToString()); 
          Console.WriteLine("Sexo del Cliente: " + cta.Titular.Sexo.ToString()); 
          Console.WriteLine("Cliente activo: " + cta.Titular.Activo.ToString()); 
          Console.WriteLine("Saldo Anterior: {0}", cta.SaldoAnterior); 
          Console.WriteLine("Depositos: {0}", cta.Depositos); 
          Console.WriteLine("Retiros: {0}", cta.Retiros); 
          Console.WriteLine("Saldo Actual: {0}", cta.Saldo); 

          // Realiza deposito
          cta.Deposito(320.60M);
          
          // Despliega datos de cuenta y su cliente
          Console.WriteLine();
          Console.WriteLine("Cuenta # " + cta.Numero + " (Dep 320.60)");
          Console.WriteLine("-----------------------------------------");
          Console.WriteLine("Nombre de la Cuenta: " + cta.Nombre); 
          Console.WriteLine("Saldo Anterior: {0}", cta.SaldoAnterior); 
          Console.WriteLine("Depositos: {0}", cta.Depositos); 
          Console.WriteLine("Retiros: {0}", cta.Retiros); 
          Console.WriteLine("Saldo Actual: {0}", cta.Saldo); 

          // Realiza deposito
          cta.Deposito(124.50M);
          
          // Despliega datos de cuenta y su cliente
          Console.WriteLine();
          Console.WriteLine("Cuenta # " + cta.Numero + " (Dep 124.50)");
          Console.WriteLine("-----------------------------------------");
          Console.WriteLine("Nombre de la Cuenta: " + cta.Nombre); 
          Console.WriteLine("Saldo Anterior: {0}", cta.SaldoAnterior); 
          Console.WriteLine("Depositos: {0}", cta.Depositos); 
          Console.WriteLine("Retiros: {0}", cta.Retiros); 
          Console.WriteLine("Saldo Actual: {0}", cta.Saldo); 

          // Realiza retiro
          cta.Retiro(201.30M);
          
          // Despliega datos de cuenta y su cliente
          Console.WriteLine();
          Console.WriteLine("Cuenta # " + cta.Numero + " (Ret 201.30)");
          Console.WriteLine("------------------------------------------");
          Console.WriteLine("Nombre de la Cuenta: " + cta.Nombre); 
          Console.WriteLine("Saldo Anterior: {0}", cta.SaldoAnterior); 
          Console.WriteLine("Depositos: {0}", cta.Depositos); 
          Console.WriteLine("Retiros: {0}", cta.Retiros); 
          Console.WriteLine("Saldo Actual: {0}", cta.Saldo); 

          // Realiza retiro
          cta.Retiro(112.25M);
          
          // Despliega datos de cuenta y su cliente
          Console.WriteLine();
          Console.WriteLine("Cuenta # " + cta.Numero + " (Ret 112.25)");
          Console.WriteLine("------------------------------------------");
          Console.WriteLine("Nombre de la Cuenta: " + cta.Nombre); 
          Console.WriteLine("Saldo Anterior: {0}", cta.SaldoAnterior); 
          Console.WriteLine("Depositos: {0}", cta.Depositos); 
          Console.WriteLine("Retiros: {0}", cta.Retiros); 
          Console.WriteLine("Saldo Actual: {0}", cta.Saldo); 
      }
   }   
}