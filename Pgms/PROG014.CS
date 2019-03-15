// prog014.CS
// Programa: Tipos y variables
// LAOS
// Enero 2004

using System;
using System.Runtime.InteropServices;

namespace CursoNet
{

class Principal
{
   static void Main()
   { 
      // integers
      byte by= 0;			// 8 bit - signed
      sbyte sb = 0;			// 8 bit - unsigned
      short sh = 0;			// 16 bit - signed
      ushort us = 0;			// 16 bit - un signed
      int i = 0;			// 32 bit - signed
      uint ui = 0;			// 32 bit - unsigned
      long ln = 0L;			// 64 bit - signed
      ulong ul = 0L;			// 64 bit - unsigned

      // floating point numbers (and decimal)
      float fl = 0.00F;
      double db = 0.00;
      decimal dm = 0.00M;

      // boolean, char 
      bool bl = false;
      char ch = 'C';

      // Strings y DateTime
      string s = "abcdefghijklmnopqrstuvwxyz";
      DateTime h = DateTime.Now;

      // Objects
      object o = new object();


      // Despliega tipos, nombres, tamaños, mínimos y máximos
 

      // Enteros 

      Console.WriteLine();
      Console.WriteLine("Tipos enteros:");
      Console.WriteLine("-------------");
      Console.WriteLine();

      Console.WriteLine("byte - {0}", by.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(by));
      Console.WriteLine("Mínimo: {0}", byte.MinValue);
      Console.WriteLine("Máximo: {0}", byte.MaxValue);
      Console.WriteLine();

      Console.WriteLine("sbyte - {0}", sb.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(sb));
      Console.WriteLine("Mínimo: {0}", sbyte.MinValue);
      Console.WriteLine("Máximo: {0}", sbyte.MaxValue);
      Console.WriteLine();

      Console.WriteLine("short - {0}", sh.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(sh));
      Console.WriteLine("Mínimo: {0}", short.MinValue);
      Console.WriteLine("Máximo: {0}", short.MaxValue);
      Console.WriteLine();

      Console.WriteLine("ushort - {0}", us.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(us));
      Console.WriteLine("Mínimo: {0}", ushort.MinValue);
      Console.WriteLine("Máximo: {0}", ushort.MaxValue);
      Console.WriteLine();

      Console.WriteLine("int - {0}", i.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(i));
      Console.WriteLine("Mínimo: {0}", int.MinValue);
      Console.WriteLine("Máximo: {0}", int.MaxValue);
      Console.WriteLine();

      Console.WriteLine("uint - {0}", ui.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(ui));
      Console.WriteLine("Mínimo: {0}", uint.MinValue);
      Console.WriteLine("Máximo: {0}", uint.MaxValue);
      Console.WriteLine();

      Console.WriteLine("long - {0}", ln.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(ln));
      Console.WriteLine("Mínimo: {0}", long.MinValue);
      Console.WriteLine("Máximo: {0}", long.MaxValue);
      Console.WriteLine();

      Console.WriteLine("ulong - {0}", ul.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(ul));
      Console.WriteLine("Mínimo: {0}", ulong.MinValue);
      Console.WriteLine("Máximo: {0}", ulong.MaxValue);
      Console.WriteLine();


      // Punto flotante

      Console.WriteLine();
      Console.WriteLine("Tipos de punto flotante:");
      Console.WriteLine("-----------------------");
      Console.WriteLine();

      Console.WriteLine("float - {0}", fl.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(fl));
      Console.WriteLine("Mínimo: {0}", float.MinValue);
      Console.WriteLine("Máximo: {0}", float.MaxValue);
      Console.WriteLine();

      Console.WriteLine("double - {0}", db.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(db));
      Console.WriteLine("Mínimo: {0}", double.MinValue);
      Console.WriteLine("Máximo: {0}", double.MaxValue);			
      Console.WriteLine();

      Console.WriteLine("decimal - {0}", dm.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(dm));
      Console.WriteLine("Mínimo: {0}", decimal.MinValue);
      Console.WriteLine("Máximo: {0}", decimal.MaxValue);
      Console.WriteLine();


      // Boolean y Char

      Console.WriteLine();
      Console.WriteLine("Tipos booleano y carácter:");
      Console.WriteLine("-------------------------");
      Console.WriteLine();

      Console.WriteLine("bool - {0}", bl.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(bl));
      unsafe { Console.WriteLine("Tamaño con sizeof(): {0}", sizeof(bool)); }
      Console.WriteLine();

      Console.WriteLine("char - {0}", ch.GetType().ToString());
      Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(ch));
      unsafe { Console.WriteLine("Tamaño con sizeof(): {0}", sizeof(char)); }
      Console.WriteLine("Mínimo: {0}", char.MinValue);
      Console.WriteLine("Máximo: {0}", char.MaxValue);			
      Console.WriteLine();


      // Strings and DateTime

      Console.WriteLine();
      Console.WriteLine("Tipos string y datetime:");
      Console.WriteLine("-----------------------");
      Console.WriteLine();

      Console.WriteLine("string - {0}", s.GetType().ToString());
      Console.WriteLine();

      Console.WriteLine("DateTime - {0}", h.GetType().ToString());
      Console.WriteLine("Hoy es: {0}", h.ToString());
      Console.WriteLine();

      // Objects
      Console.WriteLine();
      Console.WriteLine("Tipo object:");
      Console.WriteLine("-----------");
      Console.WriteLine();

      Console.WriteLine("object\t{0}", o.GetType().ToString());
      Console.WriteLine();
   }

}  // end class

}   // end namespace