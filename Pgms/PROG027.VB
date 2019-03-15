' prog027.VB
' Programa: EStructureura con el mtodo "Main"
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Structure Persona
   
      Dim Nombre As String
      Dim Edad As Integer
      Dim Sexo As Char
      Dim Direccion As String 
      Dim Telefono As String
      Dim Email As String

      Shared Sub Main()
      
         ' Creación de la estructura
         Dim cliente As Persona = new Persona()
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
         Console.WriteLine("Teléfono: {0}", cliente.Telefono) 
         Console.WriteLine("Email: {0}", cliente.Email) 

      End Sub

   End Structure

End Namespace
