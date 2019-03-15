' prog013.VB
' Programa Hola: Variables y literales
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal 
       
      Shared Sub Main()
         ' Saluda
         Saludar()
      End Sub
    
      Shared Sub Saludar()   
         ' Invita al usuario a ingresar su nombre
         Console.WriteLine()
         Console.Write("Por favor ingresa tu nombre: ")
      
         ' Lee entrada del Usuario
         Dim nombre As String = Console.ReadLine()

         ' Despliega saludo
         Console.WriteLine()
         Console.WriteLine("Hola " + nombre + ", como te va?")
         Console.WriteLine()
      End Sub
   
   End Class

End Namespace
