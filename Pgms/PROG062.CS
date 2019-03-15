// prog062.CS
// Programa: Pasaje de parámetros con ref
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
         // Prueba pasaje de parámetros
         PruebaPasaje();
      }

      static void PruebaPasaje()
      {
         // Pasaje de parámetros tipo valor
         int x = 5;
         int y = 9;
         Console.WriteLine();
         Console.WriteLine("Antes del intercambio");
         Console.WriteLine("---------------------");
         Console.WriteLine("x = {0}", x);
         Console.WriteLine("y = {0}", y);
         IntercambiaValor(ref x, ref y);
         Console.WriteLine();
         Console.WriteLine("Después del intercambio");
         Console.WriteLine("-----------------------");
         Console.WriteLine("x = {0}", x);
         Console.WriteLine("y = {0}", y);
 
         // Pasaje de parámetros tipo referencia
         Cliente comprador = new Cliente("Pablo", 10, 'M', true, "pablo@sucorreo.com");
         Cliente vendedor = new Cliente("Ana", 25, 'F', true, "ana@micorreo.net");
         Console.WriteLine();
         Console.WriteLine("Antes del intercambio");
         Console.WriteLine("---------------------");
         Console.WriteLine("comprador = {0}", comprador.GetDatos());
         Console.WriteLine("vendedor = {0}", vendedor.GetDatos());
         IntercambiaRef(ref comprador, ref vendedor);
         Console.WriteLine();
         Console.WriteLine("Después del intercambio");
         Console.WriteLine("-----------------------");
         Console.WriteLine("comprador = {0}", comprador.GetDatos());
         Console.WriteLine("vendedor = {0}", vendedor.GetDatos());
      }

      static void IntercambiaValor(ref int a, ref int b)
      {
         int t = a;
         a = b;
         b = t; 
      }

      static void IntercambiaRef(ref Cliente a, ref Cliente b)
      {
         Cliente t = a;
         a = b;
         b = t; 
      }
   }



   // Definición de la clase Cliente
   class Cliente
   {

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
      }

      public void SetNombre(string nombre)
      {
         this.nombre = nombre;
      }

      public void SetEdad(int edad)
      {
         this.edad = edad;
      }

      public void SetSexo(char sexo)
      {
         this.sexo = sexo;
      }

      public void SetActivo(bool activo)
      {
         this.activo = activo;
      }

      public void SetEmail(string email)
      {
         this.email = email;
      }

      public string GetNombre()
      {
         return this.nombre;
      }

      public int GetEdad()
      {
         return this.edad;
      }

      public char GetSexo()
      {
         return this.sexo;
      }

      public bool GetActivo()
      {
         return this.activo;
      }

      public string GetEmail()
      {
         return this.email;
      }

      public string GetDatos()
      {
         string datos = this.nombre + " - " + 
                        this.edad.ToString() + " - " + 
                        this.sexo.ToString() + " - " +
                        this.activo.ToString() + " - " +
                        this.email;

         return datos;  
      } 

      public bool EsVaron()
      {
         return (this.sexo == 'M' ? true : false); 
      } 

      public string YearNacimiento(string YearHoy)
      {
         return (int.Parse(YearHoy) - this.edad).ToString(); 
      } 

      private string nombre;
      private int edad;
      private char sexo;
      private bool activo;
      private string email;
   } 
}