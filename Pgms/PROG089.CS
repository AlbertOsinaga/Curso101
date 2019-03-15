// prog089.CS
// Programa: Simple Herencia - Múltiples Interfaces
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
   class Cuenta : ArrayList, IManejaSaldo, IDisposable
   {
       // Constructores y Destructores 

       public Cuenta(string numeroCta, string nombreCta)
       {
          Console.WriteLine();
          Console.WriteLine("Construyendo objeto cuenta..."); 

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
          return m_saldo;
       } 

       public virtual decimal Retiro(decimal monto)
       {
          m_saldo -= monto;
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
         Console.WriteLine("Destruido por Dispose..."); 
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
           
       // Campos de instancia

       private string m_numero;
       private decimal m_saldo;
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
            cta.Add(nombre);
      
         // Depósitos y retiros
         cta.Deposito(2350.75M);
         cta.Retiro(545.23M);

         // Despliega dueños de la cuenta
         Console.WriteLine();
         Console.WriteLine(cta);
         Console.WriteLine("----------------------------");
         Console.WriteLine("Saldo: {0}", cta.Saldo);
         Console.WriteLine("Titulares:");
         foreach(string nombre in cta)
            Console.WriteLine(nombre);
         
         cta.Dispose();
      }
   }   
}