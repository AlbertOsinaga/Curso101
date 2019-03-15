// prog083.CS
// Programa: Overloads en una clase derivada
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

       protected decimal m_debitos;
       protected decimal m_creditos;
       protected decimal m_saldoAntes;
   } 


   // Definición de la clase CuentaTran
   class CuentaTran : CuentaAhorro
   {
       // Constructores y Destructores 

       public CuentaTran(string numeroCta, string nombreCta) : base(numeroCta, nombreCta, "", "", "", "nn", Cliente.Regular)
       {
       }  

       public CuentaTran(string numeroCta, string nombreCta, string codigoCli, string emailCli) 
                      : base(numeroCta, nombreCta, codigoCli, nombreCta, emailCli, "nn", Cliente.Regular)
       {
       }  

       public CuentaTran(string numeroCta, string nombreCta, string codigoCli, string nombreCli, 
                     string emailCli, string tipoCli, char claseCli)
                         : base(numeroCta, nombreCta, codigoCli, nombreCli, emailCli, tipoCli, claseCli)
       {
       } 


       // Métodos públicos

       public decimal Deposito(decimal monto, decimal descuento)
       {
          m_creditos += monto * (1 - descuento);
          return m_saldoAntes + m_creditos - m_debitos;
       } 

       public decimal Retiro(decimal monto, decimal descuento)
       {
          m_debitos += monto * (1 + descuento);
          return m_saldoAntes + m_creditos - m_debitos;
       } 
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
          // Crea varias cuentas en un array
          Cuenta[] ctas = new Cuenta[6];
          ctas[0] = new Cuenta("1001", "Juan Perez", "000201", "jp@box.com");
          ctas[1] = new Cuenta("1002", "Carlos Lopez", "000202", "cl@box.com");
          ctas[2] = new CuentaAhorro("2001", "Miguel Angel", "000203", "ma@box.com");
          ctas[3] = new CuentaAhorro("2002", "Ricardo Mendez", "000204", "rm@box.com");
          ctas[4] = new CuentaTran("3001", "Maria Aguilar", "000205", "ma@box.com");
          ctas[5] = new CuentaTran("3002", "Rene Blanco", "000206", "rb@box.com");

          // Depósitos y retiros
          int i = 0;
          foreach(Cuenta cta in ctas)
          {
             i++;
             if(cta is CuentaTran)
             {
                ((CuentaTran)cta).Deposito(1000M * Convert.ToDecimal(i), 0.003M);
                ((CuentaTran)cta).Retiro(100M * Convert.ToDecimal(i), 0.003M);
             }
             else
             {
                cta.Deposito(1000M * Convert.ToDecimal(i));
                cta.Retiro(100M * Convert.ToDecimal(i));
             }
          }

          // Despliega saldos
          foreach(Cuenta cta in ctas)
          {
             Console.WriteLine();
             Console.WriteLine("{0}", cta.ToString());
             Console.WriteLine("Saldo: {0}", cta.Saldo);
          }
      }
   }   
}