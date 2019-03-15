// prog111.CS
// Programa: Recuperándose de una excepción
// LAOS
// Enero 2004

using System;
using System.IO;

namespace CursoNet
{
   // Definición Clase Principal
   class Principal
   {
      static void Main()
      {
         // Prueba creación de archivo
         TestFile();
      }

      static void TestFile()
      {
         // Variables locales
         int intentos = 0;
         int maxIntentos = 3;
         StreamReader sr;

        GetFileName:
           Console.WriteLine();
           Console.Write("Intento # {0} - Ingrese archivo a leer: ", ++intentos);
           string fileName = Console.ReadLine();

        try
        {
            string s;
            sr = new StreamReader(fileName);

            Console.WriteLine();
            while( (s = sr.ReadLine()) != null )
            {
                Console.WriteLine(s);
            }
            sr.Close();
        }
        catch(FileNotFoundException e)
        {
            Console.WriteLine();
            Console.WriteLine(e.Message);
            if (intentos < maxIntentos)
            {
                Console.WriteLine("Archivo no existe!");
                Console.WriteLine("Desea seleccionar otro archivo?");
                string respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper();
                if (respuesta == "S") goto GetFileName;
            }
            else
            {
                Console.WriteLine("Ha excedido el máximo número de intentos ({0})", maxIntentos);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
      } 
   }   
}