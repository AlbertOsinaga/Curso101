class Principal
{
   static void Main()
   {
      Saludar();
   }
   
   static void Saludar()
   {
      System.Console.WriteLine();
      System.Console.Write("Por favor ingrese su nombre: ");
      string nombre = System.Console.ReadLine();
      System.Console.WriteLine("Hola " + nombre);   
   }
}
