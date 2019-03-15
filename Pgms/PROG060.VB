' prog060.VB
' Programa: Métodos
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
         Dim nn As Cliente = new Cliente()
         Dim comprador As Cliente = New Cliente("Pablo", 10, "M"c)
         Dim vendedor As Cliente = New Cliente("Erika", 28, "F"c, true, "eriBavi@hotmail.com")

         ' Setea algunos datos faltantes nn
         nn.SetNombre("Juan")
         nn.SetEdad(46)
         nn.SetSexo("M"c)
         nn.SetEmail("juan@sucorreo.net")

         ' Despliega objeto nn	
         Console.WriteLine()
         Console.WriteLine("objeto de la clase: {0}", nn)  
         Console.WriteLine("------------------------------------")  
         Console.WriteLine("Nombre: {0}", nn.GetNombre())  
         Console.WriteLine("Edad: {0}", nn.GetEdad())  
         Console.WriteLine("Año Nacimiento: {0}", nn.YearNacimiento("2004"))
         Console.Write("Sexo: ")  
         If nn.EsVaron() = True Then Console.WriteLine("Masculino") Else Console.Write("Femenino")
         Console.WriteLine("Activo: {0}", nn.GetActivo())  
         Console.WriteLine("Email: {0}", nn.GetEmail())  

         ' Setea algunos datos faltantes comprador
         comprador.SetActivo(True)
         comprador.SetEmail("pablo@mundo.net")

         ' Despliega objeto comprador
         Console.WriteLine()
         Console.WriteLine("objeto de la clase: {0}", comprador)  
         Console.WriteLine("------------------------------------")  
         Console.WriteLine("Nombre: {0}", comprador.GetNombre())  
         Console.WriteLine("Edad: {0}", comprador.GetEdad())  
         Console.WriteLine("Año Nacimiento: {0}", comprador.YearNacimiento("2004"))  
         Console.Write("Sexo: ")  
         If comprador.EsVaron() = True Then Console.WriteLine("Masculino") Else Console.Write("Femenino")
         Console.WriteLine("Activo: {0}", comprador.GetActivo())  
         Console.WriteLine("Email: {0}", comprador.GetEmail())  

         ' Despliega objeto vendedor
         Console.WriteLine()
         Console.WriteLine("objeto de la clase: {0}", vendedor)  
         Console.WriteLine("------------------------------------")  
         Console.WriteLine("Nombre: {0}", vendedor.GetNombre())  
         Console.WriteLine("Edad: {0}", vendedor.GetEdad())  
         Console.WriteLine("Año Nacimiento: {0}", vendedor.YearNacimiento("2004"))  
         Console.Write("Sexo: ")  
         If vendedor.EsVaron() = True Then Console.WriteLine("Masculino") Else Console.Write("Femenino")
         Console.WriteLine("Activo: {0}", vendedor.GetActivo())  
         Console.WriteLine("Email: {0}", vendedor.GetEmail())  

      End Sub

   End Class



   ' Definición de la clase Cliente
   Class Cliente
   

      Public Sub New()
  
         Me.New("nn", 0, "F"c, false, "")
      
      End Sub

      Public Sub New(nombre As String, edad As Integer, sexo As Char)
 
         Me.New(nombre, edad, sexo, false, "")
      
      End Sub

      Public Sub New(nombre As String, edad As Integer, sexo As Char, activo As Boolean, email As String)
      
         Me.nombre = nombre
         Me.edad = edad
         Me.sexo = sexo
         Me.activo = activo
         Me.email = email

      End Sub

      Public Sub SetNombre(nombre As String)
      
         Me.nombre = nombre

      End Sub

      Public Sub SetEdad(edad As Integer)
      
         Me.edad = edad

      End Sub

      Public Sub SetSexo(sexo As Char)
      
         Me.sexo = sexo

      End Sub

      Public Sub SetActivo(activo As Boolean)
      
         Me.activo = activo

      End Sub

      Public Sub SetEmail(email As String)
      
         Me.email = email

      End Sub

      Public Function GetNombre() As String 
      
         return Me.nombre

      End Function

      Public Function GetEdad() As Integer
      
         return Me.edad

      End Function

      Public Function GetSexo() As Char
      
         return Me.sexo

      End Function

      Public Function GetActivo() As Boolean
      
         return Me.activo

      End Function

      Public Function GetEmail() As String
      
         return Me.email

      End Function

      Public Function EsVaron() As Boolean
      
        If Me.sexo = "M"c Then Return True Else Return False  

      End Function 

      Public Function YearNacimiento(YearHoy As String) As String
      
         return (Int32.Parse(YearHoy) - Me.edad).ToString() 

      End Function 

      Dim Private nombre As String
      Dim Private edad As Integer
      Dim Private sexo As Char
      Dim private activo As Boolean
      Dim private email As String

   End Class 

End Namespace
