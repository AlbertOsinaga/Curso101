Class Principal

   Public Shared Function Main(args As String()) As Integer
      CambiarMayusculas(args)
      return 0
   End Function
   
   Shared Sub CambiarMayusculas(args As String())
      System.Console.WriteLine()      
      For Each word As String in args
         System.Console.Write(word.ToUpper())      
         System.Console.Write(" ")      
      Next 
      System.Console.WriteLine()      
   End Sub 

End Class
