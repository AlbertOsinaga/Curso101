' prog058.VB
' Programa: Usando "Me"
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición de la clase Principal
   Class Principal
   
      Shared Sub Main()
      
         ' Crea y despliega un clientes
         CreaClientes()

      End Sub

      Shared Sub CreaClientes()
      
         ' Declaración y creación de objetos
         Dim nn As Cliente = New Cliente()
         Dim comprador As Cliente = New Cliente("Pablo", 10, "M"c)
         Dim vendedor As Cliente = New Cliente("Ana", 25, "F"c, True, "ana@servimail.com")

         ' Despliega objeto nn	
         Console.WriteLine()
         Console.WriteLine("objeto de la clase: {0}", nn)  
         Console.WriteLine("------------------------------------")  
         Console.WriteLine("Nombre: {0}", nn.nombre)  
         Console.WriteLine("Edad: {0}", nn.edad)  
         If nn.sexo = "M"c    
            Console.WriteLine("Sexo: {0}", "Masculino")
         Else
            Console.WriteLine("Sexo: {0}", "Femenino")
         End If   
         Console.WriteLine("Activo: {0}", nn.activo)  
         Console.WriteLine("Email: {0}", nn.email)  

         ' Despliega objeto comprador
         Console.WriteLine()
         Console.WriteLine("objeto de la clase: {0}", comprador)  
         Console.WriteLine("------------------------------------")  
         Console.WriteLine("Nombre: {0}", comprador.nombre)  
         Console.WriteLine("Edad: {0}", comprador.edad)  
         If comprador.sexo = "M"c    
            Console.WriteLine("Sexo: {0}", "Masculino")
         Else
            Console.WriteLine("Sexo: {0}", "Femenino")
         End If   
         Console.WriteLine("Activo: {0}", comprador.activo)  
         Console.WriteLine("Email: {0}", comprador.email)  

         ' Despliega objeto vendedor
         Console.WriteLine()
         Console.WriteLine("objeto de la clase: {0}", vendedor)  
         Console.WriteLine("------------------------------------")  
         Console.WriteLine("Nombre: {0}", vendedor.nombre)  
         Console.WriteLine("Edad: {0}", vendedor.edad)  
         If vendedor.sexo = "M"c    
            Console.WriteLine("Sexo: {0}", "Masculino")
         Else
            Console.WriteLine("Sexo: {0}", "Femenino")
         End If   
         Console.WriteLine("Activo: {0}", vendedor.activo)  
         Console.WriteLine("Email: {0}", vendedor.email)  

      End Sub

   End Class



   ' Definición de la clase Cliente
   Class Cliente
   

      Public Sub New()
      
         Me.nombre = "nn"
         Me.edad = 0
         Me.sexo = "F"c
         Me.activo = False
         Me.email = ""

      End Sub

      Public Sub New(nombre As String, edad As Integer, sexo As Char)
      
         Me.nombre = nombre
         Me.edad = edad
         Me.sexo = sexo
         Me.activo = False
         Me.email = ""

      End Sub

      Public Sub New(nombre As String, edad As Integer, sexo As Char, activo As Boolean, email As String)
      
         Me.nombre = nombre
         Me.edad = edad
         Me.sexo = sexo
         Me.activo = activo
         Me.email = email

      End Sub

      Dim Public nombre As String 
      Dim Public edad As Integer
      Dim Public sexo As Char
      Dim Public activo As Boolean
      Dim Public email As String

   End Class 

End Namespace
 