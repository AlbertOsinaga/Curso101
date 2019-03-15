// prog088.CS
// Programa: Interfaces (IManejaSaldo)
// LAOS
// Enero 2004

using System;
using System.Collections;

namespace CursoNet
{
   // Definición de la interfaz IManejaSaldo
   interface IManejaSaldo
   {
      decimal Deposito(decimal monto);
      decimal Retiro(decimal monto);
      decimal Saldo { get; } 
   }      


   // Definición de la clase Cuenta
   class Cuenta : IEnumerable, IManejaSaldo
   {
       // Constructores y Destructores 

       public Cuenta(string numeroCta, string nombreCta)
       {
          m_nombres = new ArrayList(); 

          m_numero = numeroCta;
          m_nombres.Add(nombreCta);
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
           return "Cuenta: " + m_numero + " de " + (string)m_nombres[0];  
       }


       // Implementando interfaz IEnumerable
       
       public IEnumerator GetEnumerator()
       {
          return (IEnumerator) new NombreEnumerador(this);
       }


       // Propiedades de instancia

       public string Numero
       {
          get { return m_numero; }
          set { m_numero = value; }
       } 
       public ArrayList Nombres
       {
          get { return m_nombres; }
          set { m_nombres = value; }
       } 
       public virtual decimal Saldo
       {
          get { return m_saldo; }
       } 
           
       // Campos de instancia

       private string m_numero;
       private ArrayList m_nombres;
       private decimal m_saldo;
   }


   // Dfinición de la clase NombreEnumerador
   class NombreEnumerador : IEnumerator
   {
      // Constructores
      
      public NombreEnumerador(Cuenta cta)
      {
         this.m_cta = cta;
         this.m_indice = -1;
      }


      // Implementación IEnumerator

      public bool MoveNext(  )
      {
         m_indice++;
         if(m_indice >= this.m_cta.Nombres.Count)
               return false;
         else
            return true;
      }

      public void Reset(  )
      {
         m_indice = -1;
      }

      public object Current
      {
         get
         {
            return(this.m_cta.Nombres[m_indice]);
         }
      }
      
      
      // Campos de instancia
 
      private Cuenta m_cta;
      private int m_indice;         
   } 


   // Definición Clase Principal
   class Principal
   {
      static void Main(string[] args)
      {
          // Test de Interface
          TestInterface(args); 
      }

      static void TestInterface(string[] args)
      {
         // Crea objeto cuenta 
         Cuenta cta = new Cuenta("1001", "Ana");

         // Ingresa dueños adicionales de la cuenta
         foreach(string nombre in args)
            cta.Nombres.Add(nombre);
      
         // Depósitos y retiros
         cta.Deposito(2350.75M);
         cta.Retiro(545.23M);

         // Despliega dueños de la cuenta
         Console.WriteLine();
         Console.WriteLine(cta);
         Console.WriteLine("----------------------------");
         Console.WriteLine("Saldo: {0}", cta.Saldo);
         Console.WriteLine("Titulares:");
         foreach(string nombre in cta.Nombres)
            Console.WriteLine(nombre);
      }
   }   
}