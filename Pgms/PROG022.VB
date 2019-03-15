' prog022.VB
' Programa: StringBuilder
' LAOS
' Enero 2004

Imports System
Imports System.Text

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Secuencias de Escape
         UsoDeStrings()
      
      End Sub 
        
      Shared Sub UsoDeStrings()
      
         ' Lee nombre del Usuario
         Dim saludo As StringBuilder = LeeNombre()

         ' Arma saludo
         ArmaSaludo(saludo)

         ' Despliega Saludo
         DespliegaSaludo(saludo)

      End Sub
 
      Shared Function LeeNombre() As StringBuilder
      
         Console.WriteLine()
         Console.Write("Por favor ingrese su nombre: ")
         Dim nombre As String = Console.ReadLine()
         
         return new StringBuilder(nombre)
 
      End Function 

      Shared Sub ArmaSaludo(saludo As StringBuilder)
      
         saludo.Insert(0, "Hola ")
         saludo.Append(", cómo te va?")

      End Sub

      Shared Sub DespliegaSaludo(saludo As StringBuilder)
      
         Console.WriteLine()
         Console.WriteLine(saludo)

      End Sub 
   
   End Class

End Namespace