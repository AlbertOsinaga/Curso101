// prog012
// Programa Hola: usando alias

using output = System.Console;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         Saludar();
      }

      static void Saludar()
      {
         output.WriteLine();
         output.Write("Por favor ingrese su nombre: ");
         string nombre = output.ReadLine();
         output.WriteLine("Hola "+ nombre);
         output.WriteLine();
       }
    }
}

