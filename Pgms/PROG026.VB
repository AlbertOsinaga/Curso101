' prog026.VB
' Programa: EStructureuras
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Structure Persona
   
      Public Dim Nombre As String
      Public Dim Edad As Integer
      Public Dim Sexo As Char
      Public Dim Direccion As String
      Public Dim Telefono As String
      Public Dim Email As String

   End Structure
   
   Class Principal
   
      Shared Sub Main()
      
         ' Ejemplo de eStructureura Persona
         EjemploPersona()

      End Sub 
        
      Shared Sub EjemploPersona()
      
         ' Creacin de la eStructureura
         Dim cliente As new Persona()
         cliente.Nombre = "Maria Vargas"
         cliente.Edad = 24
         cliente.Sexo = "F"c
         cliente.Direccion = "Calle Loayza # 289"
         cliente.Telefono = "2791313"
         cliente.Email = "mvargas@algunhost.com"
 
         ' Despliega miembros
         Console.WriteLine()
         Console.WriteLine("Estructura Persona")
         Console.WriteLine("------------------")
         Console.WriteLine("Nombre: {0}", cliente.Nombre) 
         Console.WriteLine("Edad: {0}", cliente.Edad) 
         Console.WriteLine("Sexo: {0}", cliente.Sexo) 
         Console.WriteLine("Dirección: {0}", cliente.Direccion) 
         Console.WriteLine("Email: {0}", cliente.Email) 

      End Sub

   End Class

End Namespace
