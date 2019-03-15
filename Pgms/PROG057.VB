' prog057.VB
' Programa: Overloading de Constructores
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
         Console.WriteLine("Nombre: {0}", nn.m_nombre)  
         Console.WriteLine("Edad: {0}", nn.m_edad)  
         If nn.m_sexo = "M"c    
            Console.WriteLine("Sexo: {0}", "Masculino")
         Else
            Console.WriteLine("Sexo: {0}", "Femenino")
         End If   
         Console.WriteLine("Activo: {0}", nn.m_activo)  
         Console.WriteLine("Email: {0}", nn.m_email)  

         ' Despliega objeto comprador
         Console.WriteLine()
         Console.WriteLine("objeto de la clase: {0}", comprador)  
         Console.WriteLine("------------------------------------")  
         Console.WriteLine("Nombre: {0}", comprador.m_nombre)  
         Console.WriteLine("Edad: {0}", comprador.m_edad)  
         If comprador.m_sexo = "M"c    
            Console.WriteLine("Sexo: {0}", "Masculino")
         Else
            Console.WriteLine("Sexo: {0}", "Femenino")
         End If   
         Console.WriteLine("Activo: {0}", comprador.m_activo)  
         Console.WriteLine("Email: {0}", comprador.m_email)  

         ' Despliega objeto vendedor
         Console.WriteLine()
         Console.WriteLine("objeto de la clase: {0}", vendedor)  
         Console.WriteLine("------------------------------------")  
         Console.WriteLine("Nombre: {0}", vendedor.m_nombre)  
         Console.WriteLine("Edad: {0}", vendedor.m_edad)  
         If vendedor.m_sexo = "M"c    
            Console.WriteLine("Sexo: {0}", "Masculino")
         Else
            Console.WriteLine("Sexo: {0}", "Femenino")
         End If   
         Console.WriteLine("Activo: {0}", vendedor.m_activo)  
         Console.WriteLine("Email: {0}", vendedor.m_email)  

      End Sub

   End Class



   ' Definición de la clase Cliente
   Class Cliente
   

      Public Sub New()
      
         m_nombre = "nn"
         m_edad = 0
         m_sexo = "F"c
         m_activo = False
         m_email = ""

      End Sub

      Public Sub New(nombre As String, edad As Integer, sexo As Char)
      
         m_nombre = nombre
         m_edad = edad
         m_sexo = sexo
         m_activo = False
         m_email = ""

      End Sub

      Public Sub New(nombre As String, edad As Integer, sexo As Char, activo As Boolean, email As String)
      
         m_nombre = nombre
         m_edad = edad
         m_sexo = sexo
         m_activo = activo
         m_email = email

      End Sub

      Dim Public m_nombre As String 
      Dim Public m_edad As Integer
      Dim Public m_sexo As Char
      Dim Public m_activo As Boolean
      Dim Public m_email As String

   End Class 

End Namespace
 