// prog094.CS
// Programa: Escondiendo los métodos de una interfaz
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

       public override string ToString()
       {
           return "Cuenta: " + m_numero + " de " + (string)this[0];  
       }


       // Métodos Interfaz IManejamovis       

       decimal IManejaSaldo.Deposito(decimal monto)
       {
          m_saldo += monto;
          m_depositos += monto;
          return m_saldo;
       } 

       decimal IManejaSaldo.Retiro(decimal monto)
       {
          m_saldo -= monto;
          m_retiros += monto;
          return m_saldo;
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


       // Propiedades Interfaz IManejaMovis

       decimal IManejaSaldo.Saldo
       {
          get { return m_saldo; }
       } 
       decimal IManejaMovis.Depositos
       {
          get { return m_depositos; }
       } 
       decimal IManejaMovis.Retiros
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
         // Interfaz pública (objeto)
         Cuenta cta = new Cuenta("1001", "Ana");   

         // Acceso mediante una referencia a la interfaz (operador as)
         IManejaMovis iMovis = cta as IManejaMovis;

         // Verificación de compatibilidad de tipo
         if( iMovis == null )
         {  
            // Error la interfaz no es implementada
            Console.WriteLine();
            Console.WriteLine("Cuenta no implementa interfaz 'IManejaMovis'");
            return;
         }

         // Depósitos y retiros
         // No compila
         // cta.Deposito(1519.70M);
         // cta.Retiro(284.92M);
         iMovis.Deposito(1519.70M);
         iMovis.Retiro(284.92M);

         // Despliega dueños de la cuenta 
         Console.WriteLine();
         Console.WriteLine("[Acceso mediante una referencia a la interfaz (operador as)]");
         // No compila
         // Console.WriteLine(cta);
         Console.WriteLine(iMovis);
         Console.WriteLine("------------------------------------------------------------");
         // No compila
         // Console.WriteLine("Depósitos: {0}", cta.Depositos);
         // Console.WriteLine("Retiros: {0}", cta.Retiros);
         // Console.WriteLine("Saldo: {0}", cta.Saldo);
         Console.WriteLine("Depósitos: {0}", iMovis.Depositos);
         Console.WriteLine("Retiros: {0}", iMovis.Retiros);
         Console.WriteLine("Saldo: {0}", iMovis.Saldo);
      }
   }   
}