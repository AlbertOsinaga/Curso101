' prog019.VB
' Programa: Manejo de Strings
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
         ' Manejo de Strings
         ManejoStrings()
      End Sub 
        
      Shared Sub ManejoStrings()
         ' Hello World
         Dim saludo As String = "Hello World"
         Console.WriteLine()
         Console.WriteLine(saludo)

         ' Hello friend
         saludo = "Hello "
         Console.WriteLine()
         Console.Write("Por favor ingrese su nombre: ")
         Dim nombre As String = Console.ReadLine()
         Dim bienvenido As String = saludo + nombre       
         Console.WriteLine()
         Console.WriteLine(bienvenido)

         ' Goodbye friend
         Dim despedida As String = bienvenido.Replace("Hello ", "Goodbye ")
         Console.WriteLine("..............................")
         Console.WriteLine(despedida)

         ' Gracias a Dios es viernes
         Dim gadev As String = "Gracias a Dios es viernes!"
         Console.WriteLine()
         Console.WriteLine(gadev)
         Console.WriteLine("longitud de gadev = {0}", gadev.Length)
         Console.WriteLine("Indice de '!' en gadev = {0}", gadev.IndexOf("!"))
         Console.WriteLine("La segunda letra en gadev = {0}", gadev.Substring(1, 1))

         ' Gracias a Dios es lunes
         Dim gadel As String = gadev.Replace("viernes", "lunes")
         Console.WriteLine()
         Console.WriteLine(gadel)
         Console.WriteLine("longitud de gadel = {0}", gadel.Length)
         Console.WriteLine("Indice de '!' en gadel = {0}", gadel.IndexOf("!"))
         Console.WriteLine("La segunda letra en gadel = {0}", gadel.Substring(1, 1))

         ' Por desgracia es lunes	
         Dim pdel As String = gadel.Remove(0, gadel.IndexOf("es"))
         pdel = "Por " + pdel
         pdel = pdel.Insert(4, "desgracia ")
         Console.WriteLine()
         Console.WriteLine(pdel)
         Console.WriteLine("longitud de pdel = {0}", pdel.Length)
         Console.WriteLine("Indice de '!' en pdel = {0}", pdel.IndexOf("!"))
         Console.WriteLine("La segunda letra en pdel = {0}", pdel.Substring(1, 1))
      End Sub

   End Class

End Namespace      
   
