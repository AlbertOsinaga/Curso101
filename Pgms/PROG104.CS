// prog104.CS
// Programa: Hashtable con string key
// LAOS
// Enero 2004

using System;
using System.Collections;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Maneja una tabla de clientes
         TablaClientes clientes = new TablaClientes();
         clientes.Run();
      }
   } 

   class TablaClientes
   {
      // Constructores
      public TablaClientes()
      {
         h = new Hashtable(53, 0.5F); 
      }
  
      // Métodos públicos
      public void Run()
      {
         string palabra = "";
         Console.WriteLine();
         Console.WriteLine("Programa Tabla Clientes");
         Console.WriteLine("-----------------------");
         do
         {
            // Usuario introduce operación
            Console.WriteLine();
            Console.WriteLine("\"+\" código-nombre-Teléfono-email  Ingresa entrada en la tabla de clientes");
            Console.WriteLine("\"-\" código  Remueve entrada de la tabla de clientes");
            Console.WriteLine("\"=\" código  Despliega datos del cliente");
            Console.WriteLine("\"*\" Termina el programa");
            Console.WriteLine();
            Console.Write("Introduzca su operación: ");
            palabra = Console.ReadLine();
            
            // Si símbolo es '*' termina
            if(palabra[0] == '*')
            {
                Console.WriteLine();
                Console.WriteLine("Fin del programa");
                break;
            }                

	    // Valida símbolo
            if( "+-=".IndexOf(palabra[0]) < 0 )
            {
               Console.WriteLine();
               Console.WriteLine("Símbolo equivocado. Los símbolos de inicio válidos son: '+','-','=','*'");
               continue;
            }   
               		 
            // Valida palabra (existencia nombre-telefono a ingresar)
            if(palabra[0] == '+'  &&  palabra.Length < 3)
            {
               Console.WriteLine();
               Console.WriteLine("Después del símbolo '+', introduzca codigo-nombre-telefono-email después de un espacio!");
               continue;
            }   
 
            // Valida codigo-nombre (existencia de ambos para el ingreso)  
            if(palabra[0] == '+'  &&  (palabra.IndexOf("-") <= 2  ||  palabra.IndexOf("-") == palabra.Length - 1))
            {
               Console.WriteLine();
               Console.WriteLine("Después del símbolo '+', introduzca codigo-nombre-telefono-email después de un espacio!");
               continue;
            }

            // Valida existencia de codigo para remover   
            if(palabra[0] == '-'  &&  palabra.Length < 3)
            {
               Console.WriteLine();
               Console.WriteLine("Después del símbolo '-', introduzca codigo del cliente a remover!");
               continue;
            }   
 
            // Valida existencia de codigo para despliegue de teléfono   
            if(palabra[0] == '='  &&  palabra.Length < 3)
            {
               Console.WriteLine();
               Console.WriteLine("Después del símbolo '=', introduzca codigo del cliente!");
               continue;
            }   
 
            switch(palabra[0])
            {
               case '+':
                  int indiceGuion1 = palabra.IndexOf("-");
                  int indiceGuion2 = indiceGuion1 + 1 + palabra.Substring(indiceGuion1 + 1).IndexOf("-");
                  int indiceGuion3 = indiceGuion2 + 1 + palabra.Substring(indiceGuion2 + 1).IndexOf("-");  
                  string codigo = palabra.Substring(2, indiceGuion1 - 2);
                  string nombre = palabra.Substring(indiceGuion1 + 1, indiceGuion2 - (indiceGuion1 + 1));
                  string telefono = palabra.Substring(indiceGuion2 + 1, indiceGuion3 - (indiceGuion2 + 1));
                  string email = palabra.Substring(indiceGuion3 + 1, palabra.Length - (indiceGuion3 + 1));
                  Cliente cli = new Cliente(codigo, nombre, telefono, email);
                  h[codigo] = cli;
                  Console.WriteLine(cli.ToString() + " fué ingresado...");
                  break;
 
              case '-':
                  if(h.Count < 1)
                  {
                     Console.WriteLine("La tabla de clientes está vacía!");
                     continue;
                  }
                  codigo = palabra.Substring(2);
                  cli = (Cliente) h[codigo];
                  if(cli == null)
                  {
                     Console.WriteLine("No existe registro para cliente " + codigo + "!");
                     continue;
                  }
                  h.Remove(codigo);      
                  Console.WriteLine(cli.ToString() + " fué removido...");
                  break;

               case '=':   
                  if(h.Count < 1)
                  {
                     Console.WriteLine("La tabla de clientes está vacía!");
                     continue;
                  }
                  codigo = palabra.Substring(2);
                  cli = (Cliente) h[codigo];
                  if(cli == null)
                  {
                     Console.WriteLine("No existe registro para cliente " + codigo + "!");
                     continue;
                  }
                  Console.WriteLine(cli.ToString());
                  break;

               default:
                  Console.WriteLine("Esto no debería suceder nunca, lo prometo!");
                  break;
            }    

         } while(palabra[0] != '*');
      }

      // Campos privados
      private Hashtable h;      
   }

   // Definición de la clase Cliente
   class Cliente
   {
      // Constructores y Finalizadores

      public Cliente(string codigo, string nombre, string telefono, string email)
      {
         this.m_codigo = codigo;
         this.m_nombre = nombre;
         this.m_telefono = telefono;
         this.m_email = email;
      }

      // Métodos públicos de instancia

      public override string ToString()
      {
         return this.m_codigo + "-" + this.m_nombre + "-" + this.m_telefono + "-" + this.m_email;
      }


      // Propiedades campos de instancia

      public string Codigo
      {
         get { return m_codigo; }
         set { m_codigo = value; }
      } 
      public string Nombre
      {
         get { return m_nombre; }
         set { m_nombre = value; }
      } 
      public string Telefono
      {
         get { return m_telefono; }
         set { m_telefono = value; }
      } 
      public string Email
      {
         get { return m_email; }
         set { m_email = value; }
      } 

      // campos de instancia

      private string m_codigo;
      private string m_nombre;
      private string m_telefono;
      private string m_email;
   } 
}