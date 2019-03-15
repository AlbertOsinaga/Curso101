' prog073.VB
' Programa: Propiedades
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
         Dim vendedor As Cliente = New Cliente("Ana", 25, "F"c, True, "ana@servimail.com")

         ' Setea algunos datos faltantes nn
         nn.Tipo = "nn"
         nn.Clase = Cliente.Regular
         nn.Nombre = "Juan"
         nn.Edad = 46
         nn.Sexo = "M"c
         nn.Email = "juan@sucorreo.net"

         ' Setea algunos datos faltantes comprador
         comprador.Tipo = "comprador"
         comprador.Activo = True
         comprador.Email = "pablo@mundo.net"
         comprador.Clase = Cliente.Especial

         ' Setea algunos datos faltantes vendedor
         vendedor.Tipo = "vendedor"
         vendedor.Clase = Cliente.Exclusivo

         ' Despliega objetos
         DespliegaClientes(nn, comprador, vendedor)

      End Sub

      Shared Sub DespliegaClientes(ParamArray clientes() As Cliente)
      
         For Each wCliente As Cliente in clientes
           
            ' Despliega objeto cliente
            Console.WriteLine()
            Console.WriteLine("objeto de la clase: {0}", wCliente)  
            Console.WriteLine("---------------------------------------")  
            Console.WriteLine("Tipo: {0}", wCliente.Tipo)  
            Console.WriteLine("Clase: {0}", wCliente.Clase)  
            Console.WriteLine("Nombre: {0}", wCliente.Nombre)  
            Console.WriteLine("Edad: {0}", wCliente.Edad)  
            Console.WriteLine("Año Nacimiento: {0}", wCliente.YearNacimiento("2004"))  
            If wCliente.EsVaron Then Console.WriteLine("Masculino") Else Console.WriteLine("Femenino") 
            Console.WriteLine("Activo: {0}", wCliente.Activo)  
            Console.WriteLine("Email: {0}", wCliente.Email)  
            Console.WriteLine("Cantidad: {0}", Cliente.Cantidad)  
            Console.WriteLine("Conexión: {0}", Cliente.ConexionData)  

         Next

      End Sub 

   End Class



   ' Definición de la clase Cliente
   Class Cliente
   
      ' ConStructureores

      Shared Sub New()
      
         Cliente.m_cantidad = 0
         Cliente.m_conexionData = Cliente.OpenConexion()   

      End Sub
 
      Public Sub New()

         Me.New("nn", 0, "F"c, false, "")
      
      End Sub

      Public Sub New(nombre As String, edad As Integer, sexo As Char)

         Me.New(nombre, edad, sexo, false, "")
      
      End Sub

      Public Sub New(nombre As String, edad As Integer, sexo As Char, activo As Boolean, email As String)
      
         Me.m_nombre = nombre
         Me.m_edad = edad
         Me.m_sexo = sexo
         Me.m_activo = activo
         Me.m_email = email

         Cliente.m_cantidad += 1

      End Sub


      ' Métodos públicos de instancia

      Public Function YearNacimiento(YearHoy As String) As String
      
         Return (Int32.Parse(YearHoy) - Me.m_edad).ToString() 

      End Function 


      ' Métodos públicos de clase

      Public Shared Function OpenConexion() As String
      
         Console.WriteLine()
         Console.WriteLine("Abriendo Conexion a CentralServices")
         Return "CentralServices" 

      End Function 


      ' Propiedades campos de instancia

      Public Property Nombre() As String
      
         Get
            Return m_nombre
         End Get

         Set(value As String)
            m_nombre = value
         End Set

      End Property 

      Public Property Edad() As Integer

         Get
            Return m_edad
         End Get

         Set(value As Integer)
            m_edad = value
         End Set

      End Property 

      Public Property Sexo() As Char

         Get
            Return m_sexo
         End Get

         Set(value As Char)
            m_sexo = value
         End Set

      End Property 

      Public ReadOnly Property EsVaron() As Boolean

         Get  
            If Me.m_sexo = "M"c Then Return True Else Return False
         End Get

      End Property 

      Public Property Activo() As Boolean

         Get
            Return m_activo
         End Get

         Set(value As Boolean)
            m_activo = value
         End Set

      End Property 

      Public Property Email() As String

         Get
            Return m_email
         End Get

         Set(value As String)
            m_email = value
         End Set

      End Property 

      Public Property Tipo() As String

         Get
            Return m_tipo
         End Get

         Set(value As String)
            m_tipo = value
         End Set

      End Property 

      Public Property Clase() As Char

         Get
            Return m_clase
         End Get

         Set(value As Char)
            m_clase = value
         End Set

      End Property 

      ' Propiedades campos de clase
      Public Shared ReadOnly Property Cantidad() As Integer
      
         Get
            Return cantidad
         End Get

      End Property 
      
      Public Shared ReadOnly Property ConexionData() As String
      
         Get
            Return conexionData
         End Get

      End Property 

      ' campos de instancia
      private m_nombre As String
      private m_edad As Integer
      private m_sexo As Char
      private m_activo As Boolean
      private m_email As String
      private m_tipo As String
      private m_clase As Char
      
      ' campos de clase
      private Shared m_cantidad As Integer 
      private Shared m_conexionData As String

      ' campos constantes
      Public const Regular As Char = "A"c
      Public const Especial As Char = "B"c
      Public const Exclusivo As Char = "C"c

   End Class 

End Namespace
