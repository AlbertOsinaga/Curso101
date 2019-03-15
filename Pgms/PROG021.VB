' prog021.VB
' Programa: Strings
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Secuencias de Escape
         UsoDeStrings()
      
      End Sub 
        
      Shared Sub UsoDeStrings()
      
         ' Lee nombre del Usuario
         Dim saludo As String = LeeNombre()

         ' Arma saludo
         ArmaSaludo(saludo)

         ' Despliega Saludo
         DespliegaSaludo(saludo)

      End Sub
 
      Shared Function LeeNombre() As String
      
         System.Console.WriteLine()
         System.Console.Write("Por favor ingrese su nombre: ")
         
         return System.Console.ReadLine()
 
      End Function 

      Shared Sub ArmaSaludo(saludo As String)
      
         saludo = "Hola" + "saludo" + ", cómo te va?"

      End Sub

      Shared Sub DespliegaSaludo(saludo As String)
      
         Console.WriteLine()
         Console.WriteLine(saludo)

      End Sub 
   
   End Class

End Namespace