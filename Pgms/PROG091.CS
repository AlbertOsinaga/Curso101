// prog091.CS
// Programa: Acceso a los miembros de las interfaces
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

         // Ingresa dueños adicionales de la cuenta
         foreach(string nombre in args)
            cta.Add(nombre);
      
         // Depósitos y retiros
         cta.Deposito(2350.75M);
         cta.Retiro(545.23M);

         // Despliega dueños de la cuenta 
         Console.WriteLine();
         Console.WriteLine("[Acceso mediante una referencia a la cuenta]");
         Console.WriteLine(cta);
         Console.WriteLine("--------------------------------------------");
         Console.WriteLine("Depósitos: {0}", cta.Depositos);
         Console.WriteLine("Retiros: {0}", cta.Retiros);
         Console.WriteLine("Saldo: {0}", cta.Saldo);
         Console.WriteLine("Titulares:");
         foreach(string nombre in cta)
            Console.WriteLine(nombre);



         // Acceso mediante una referencia a la interfaz (casting) 
         IManejaMovis iMovis = (IManejaMovis) cta;

         // Depósitos y retiros
         iMovis.Deposito(1519.70M);
         iMovis.Retiro(284.92M);

         // Despliega dueños de la cuenta 
         Console.WriteLine();
         Console.WriteLine("[Acceso mediante una referencia a la interfaz (casting)]");
         Console.WriteLine(iMovis);
         Console.WriteLine("--------------------------------------------------------");
         Console.WriteLine("Depósitos: {0}", iMovis.Depositos);
         Console.WriteLine("Retiros: {0}", iMovis.Retiros);
         Console.WriteLine("Saldo: {0}", iMovis.Saldo);
         Console.WriteLine("Titulares:");
         // No compila
         // foreach(string nombre in iMovis)
         //     Console.WriteLine(nombre);




         // Acceso mediante una referencia a la interfaz (operador as) 
         IManejaMovis iMovims = cta as IManejaMovis;

         // Depósitos y retiros
         iMovims.Deposito(634.50M);
         iMovims.Retiro(218.90M);

         // Despliega dueños de la cuenta 
         Console.WriteLine();
         Console.WriteLine("[Acceso mediante una referencia a la interfaz (operador as)]");
         Console.WriteLine(iMovims);
         Console.WriteLine("-----------------------------------------------------------");
         Console.WriteLine("Depósitos: {0}", iMovims.Depositos);
         Console.WriteLine("Retiros: {0}", iMovims.Retiros);
         Console.WriteLine("Saldo: {0}", iMovims.Saldo);
         Console.WriteLine("Titulares:");
         // No compila
         // foreach(string nombre in iMovims)
         //     Console.WriteLine(nombre);
      }
   }   
}