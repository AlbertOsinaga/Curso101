// prog092.CS
// Programa: El operador 'is'
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


   // Definición de la interfaz IManejaMovis
   interface IManejaMovis : IManejaSaldo
   {
      decimal Depositos { get; } 
      decimal Retiros { get; } 
   }      


   // Definición de la interfaz IManejaDescuento
   interface IManejaDescuento : IManejaMovis
   {
      decimal Descuento { get; } 
   }      


   // Definición de la clase Cuenta
   class Cuenta : ArrayList, IManejaMovis, IDisposable
   {
       // Constructores y Destructores 

       public Cuenta(string numeroCta, string nombreCta)
       {
          m_numero = numeroCta;
          Add(nombreCta);
       } 

       ~Cuenta()
       {
          Console.WriteLine();
          Console.WriteLine("Destruyendo objeto cuenta..."); 
       }
       

       // Métodos públicos

       public virtual decimal Deposito(decimal monto)
       {
          m_saldo += monto;
          m_depositos += monto;
          return m_saldo;
       } 

       public virtual decimal Retiro(decimal monto)
       {
          m_saldo -= monto;
          m_retiros += monto;
          return m_saldo;
       } 

       public override string ToString()
       {
           return "Cuenta: " + m_numero + " de " + (string)this[0];  
       }


       // Implementando interfaz IDisposable
       
       public void Dispose()
       {
          Console.WriteLine();
          Console.WriteLine("Destruyendo objeto cuenta..."); 
          GC.SuppressFinalize(this);
       } 

 
       // Propiedades de instancia

       public string Numero
       {
          get { return m_numero; }
          set { m_numero = value; }
       } 
       public virtual decimal Saldo
       {
          get { return m_saldo; }
       } 
       public virtual decimal Depositos
       {
          get { return m_depositos; }
       } 
       public virtual decimal Retiros
       {
          get { return m_retiros; }
       } 
           
       // Campos de instancia

       private string m_numero;
       private decimal m_saldo;
       private decimal m_depositos;
       private decimal m_retiros;
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
         // Acceso mediante una referencia a la cuenta 
         Cuenta cta = new Cuenta("1001", "Ana");

         // Verificación de compatibilidad de tipo
         if( !(cta is IManejaDescuento) )
         {  
            // Error en runtime (la interfaz no es implementada)
            Console.WriteLine();
            Console.WriteLine("Cuenta no implementa interfaz 'IManejaDescuento'");
            return;
         }

         // Acceso mediante una referencia a la interfaz (casting)
         IManejaDescuento iSaldo = (IManejaDescuento) cta;

         // Depósitos y retiros
         iSaldo.Deposito(1519.70M);
         iSaldo.Retiro(284.92M);

         // Despliega dueños de la cuenta 
         Console.WriteLine();
         Console.WriteLine("[Acceso mediante una referencia a la interfaz (casting)]");
         Console.WriteLine(iSaldo);
         Console.WriteLine("--------------------------------------------------------");
         Console.WriteLine("Depósitos: {0}", iSaldo.Depositos);
         Console.WriteLine("Retiros: {0}", iSaldo.Retiros);
         Console.WriteLine("Saldo: {0}", iSaldo.Saldo);
      }
   }   
}