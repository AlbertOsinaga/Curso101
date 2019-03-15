' prog066.VB
' Programa: Uso de ParamArray
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

         ' Setea algunos datos faltantes nn
         nn.SetTipo("nn")
         nn.SetNombre("Juan")
         nn.SetEdad(46)
         nn.SetSexo("M"c)
         nn.SetEmail("juan@sucorreo.net")

         ' Setea algunos datos faltantes comprador
         comprador.SetTipo("comprador")
         comprador.SetActivo(True)
         comprador.SetEmail("pablo@mundo.net")

         ' Setea algunos datos faltantes vendedor
         vendedor.SetTipo("vendedor")

         ' Despliega objetos
         DespliegaClientes(nn, comprador, vendedor)

      End Sub

      Shared Sub DespliegaClientes(ParamArray clientes() As Cliente)
      
         For Each cliente As Cliente in clientes
           
            ' Despliega objeto cliente
            Console.WriteLine()
            Console.WriteLine("objeto de la clase: {0}", cliente)  
            Console.WriteLine("---------------------------------------")  
            Console.WriteLine("Tipo: {0}", cliente.GetTipo())  
            Console.WriteLine("Nombre: {0}", cliente.GetNombre())  
            Console.WriteLine("Edad: {0}", cliente.GetEdad())  
            Console.WriteLine("Ao Nacimiento: {0}", cliente.YearNacimiento("2004"))  
            If cliente.EsVaron() Then Console.WriteLine("Sexo: {0}", "Masculino") Else Console.WriteLine("Sexo: {0}", "Femenino")  
            Console.WriteLine("Activo: {0}", cliente.GetActivo())  
            Console.WriteLine("Email: {0}", cliente.GetEmail())  

         Next

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

      Public Sub SetTipo(tipo As String)
      
         Me.tipo = tipo

      End Sub

      Public Function GetNombre() As String
      
         Return Me.nombre

      End Function

      Public Function GetEdad() As Integer
      
         Return Me.edad

      End Function

      Public Function GetSexo() As Char
      
         Return Me.sexo

      End Function

      Public Function GetActivo() As Boolean
      
         Return Me.activo

      End Function

      Public Function GetEmail() As String
      
         Return Me.email

      End Function

      Public Function GetTipo() As String
      
         Return Me.tipo

      End Function

      Public Function EsVaron() As Boolean
      
         If Me.sexo = "M"c Then Return True Else Return False

      End Function 

      Public Function YearNacimiento(YearHoy As String) As String
      
         Return (Int32.Parse(YearHoy) - Me.edad).ToString() 

      End Function  

      private nombre As String
      private edad As Integer
      private sexo As Char
      private activo As Boolean
      private email As String
      private tipo As String

   End Class 

End Namespace
