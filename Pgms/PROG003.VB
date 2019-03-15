Class Principal

   Shared Sub Main()
      Saludar()
   End Sub
   
   Shared Sub Saludar()
      System.Console.WriteLine()
      System.Console.Write("Por favor ingrese su nombre: ")
      Dim nombre As String = System.Console.ReadLine()
      System.Console.WriteLine("Hola " & nombre)   
   End Sub

End Class
