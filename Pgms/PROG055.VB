' prog055.VB
' Programa: Modificadores de acceso aplicados a campos
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
         Console.WriteLine("------------------------------------")  
         Console.WriteLine("Nombre: {0}", clienteAhorro.nombre)  
         ' Console.WriteLine("Edad: {0}", clienteAhorro.edad)
         If clienteAhorro.sexo = "M"c    
            Console.WriteLine("Sexo: {0}", "Masculino")
         Else
            Console.WriteLine("Sexo: {0}", "Femenino")
         End If   
         ' Console.WriteLine("Activo: {0}", clienteAhorro.activo)
         Console.WriteLine("Email: {0}", clienteAhorro.email)

      End Sub

   End Class



   ' Definición de la clase Cliente
   Class Cliente
   
      Dim Public nombre As String 
      Dim Protected edad As Integer
      Dim Friend sexo As Char
      Dim Private activo As Boolean
      Dim Protected Friend email As String

   End Class 

End Namespace
