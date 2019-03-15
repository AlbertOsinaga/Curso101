' prog054.VB
' Programa: Campos de una clase
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición de la clase Principal
   Class Principal
   
      Shared Sub Main()
      
         ' Crea y despliega un cliente
         CreaCliente()

      End Sub

      Shared Sub CreaCliente()
      
         ' Declaración de variable
         Dim clienteAhorro As Cliente 

         ' Creación del objeto
         clienteAhorro = new Cliente()	

         ' Despliega objeto	
         Console.WriteLine()
         Console.WriteLine("objeto de la clase: {0}", clienteAhorro)  
         Console.WriteLine("----------------------------")  
         Console.WriteLine("Nombre: {0}", clienteAhorro.nombre)  
         Console.WriteLine("Edad: {0}", clienteAhorro.edad)
         If clienteAhorro.sexo = "M"c    
            Console.WriteLine("Sexo: {0}", "Masculino")
         Else
            Console.WriteLine("Sexo: {0}", "Femenino")
         End If   

      End Sub

   End Class



   ' Definición de la clase Cliente
   Class Cliente
   
      Dim Public nombre As String 
      Dim Public edad As Integer
      Dim Public sexo As Char 

   End Class 

End Namespace
