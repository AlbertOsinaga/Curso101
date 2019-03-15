// prog081.CS
// Programa: El método ToString
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

       public virtual decimal Deposito(decimal monto)
       {
          m_saldo += monto;
          return m_saldo;
       } 

       public virtual decimal Retiro(decimal monto)
       {
          m_saldo -= monto;
          return m_saldo;
       } 

       public override string ToString()
       {
           return "Cuenta: " + m_numero + " de " + m_nombre;  
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
       public Cliente Titular
       {
          get { return m_titular; }
          set { m_titular = value; }
       } 
       public virtual decimal Saldo
       {
          get { return m_saldo; }
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
          m_saldoAntes = 0M; 
       } 


       // Métodos públicos

       public override decimal Deposito(decimal monto)
       {
          m_creditos += monto;
          return m_saldoAntes + m_creditos - m_debitos;
       } 

       public override decimal Retiro(decimal monto)
       {
          m_debitos += monto;
          return m_saldoAntes + m_creditos - m_debitos;
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
          get { return m_saldoAntes; }
          set { m_saldoAntes = value; }
       } 
       public override decimal Saldo
       {
          get { return m_saldoAntes + m_creditos - m_debitos; }
       } 

       // Campos de instancia

       private decimal m_debitos;
       private decimal m_creditos;
       private decimal m_saldoAntes;
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


      public override string ToString()
      {
         return this.nombre;
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
          Cuenta cta1 = new Cuenta("1005", "Juan Perez", "000201", "jp@box.com");             

          // Cuenta - Utliza métodos de clase Object
          Console.WriteLine();
          Console.WriteLine("Cuenta cta1");
          Console.WriteLine("-----------");
          Console.WriteLine("cta1.ToString(): {0}", cta1.ToString());
          Console.WriteLine("cta1.GetHashCode(): {0}", cta1.GetHashCode());
          Console.WriteLine("cta1.GetType(): {0}", cta1.GetType());

          // Crea una cuenta ahorro
          Cuenta cta2 = new Cuenta("1006", "Luis Lopez", "000202", "ll@box.com");             

          // Cuenta - Utliza métodos de clase Object
          Console.WriteLine();
          Console.WriteLine("Cuenta cta2");
          Console.WriteLine("-----------");
          Console.WriteLine("cta2.ToString(): {0}", cta2.ToString());
          Console.WriteLine("cta2.GetHashCode(): {0}", cta2.GetHashCode());
          Console.WriteLine("cta2.GetType(): {0}", cta2.GetType());

          // Crea una cuenta ahorro
          CuentaAhorro cta3 = new CuentaAhorro("1007", "Carlos Matas", "000203", "cm@box.com");             

          // Cuenta - Utliza métodos de clase Object
          Console.WriteLine();
          Console.WriteLine("CuentaAhorro cta3");
          Console.WriteLine("-----------------");
          Console.WriteLine("cta3.ToString(): {0}", cta3.ToString());
          Console.WriteLine("cta3.GetHashCode(): {0}", cta3.GetHashCode());
          Console.WriteLine("cta3.GetType(): {0}", cta3.GetType());

          // Crea un cliente
          Cliente cli = new Cliente("000204", "Maria Peredo", "mp@box.com");             

          // Cliente - Utliza métodos de clase Object
          Console.WriteLine();
          Console.WriteLine("Cliente cli");
          Console.WriteLine("-----------");
          Console.WriteLine("cli.ToString(): {0}", cli.ToString());
          Console.WriteLine("cli.GetHashCode(): {0}", cli.GetHashCode());
          Console.WriteLine("cli.GetType(): {0}", cli.GetType());

          // Crea un entero
          int i = 5;             

          // Entero - Utliza métodos de clase Object
          Console.WriteLine();
          Console.WriteLine("int i");
          Console.WriteLine("-----");
          Console.WriteLine("i.ToString(): {0}", i.ToString());
          Console.WriteLine("i.GetHashCode(): {0}", i.GetHashCode());
          Console.WriteLine("i.GetType(): {0}", i.GetType());
      }
   }   
}