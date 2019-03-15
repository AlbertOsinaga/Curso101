class Principal
{
   public static int Main(string[] args)
   {
      CambiarMayusculas(args);
      return 0;
   }
   
   static void CambiarMayusculas(string[] args)
   {
      System.Console.WriteLine();      
      foreach(string word in args)
      {
         System.Console.Write(word.ToUpper());      
         System.Console.Write(" ");      
      } 
      System.Console.WriteLine();      
   } 
}
