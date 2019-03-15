' prog079.VB
' Programa: Polimorfismo (Overridable y overrides)
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición de la clase Cuenta
   Class Cuenta
   
       ' Constructores y Destructores 

       Public Sub New(numeroCta As String, nombreCta As String)

          Me.New(numeroCta, nombreCta, "", "", "", "nn", Cliente.Regular)
       
       End Sub 

       Public Sub New(numeroCta As String, nombreCta As String, codigoCli As String, emailCli As String) 

          Me.New(numeroCta, nombreCta, codigoCli, nombreCta, emailCli, "nn", Cliente.Regular)
       
       End Sub 

       Public Sub New(numeroCta As String, nombreCta As String, codigoCli As String, nombreCli As String, _
                      emailCli As String, tipoCli As String, claseCli As Char)
       
          m_numero = numeroCta
          m_nombre = nombreCta
          m_titular = New Cliente(codigoCli, nombreCli, emailCli, tipoCli, claseCli)

          m_saldo = 0D

       End Sub 

       
       ' Métodos públicos
       Public Overridable Function Deposito(monto As Decimal) As Decimal
       
          m_saldo += monto
          Return m_saldo

       End Function 

       ' Métodos públicos
       Public Overridable Function Retiro(monto As Decimal) As Decimal
       
          m_saldo -= monto
          Return m_saldo

       End Function 


       ' Propiedades de instancia
       Public Property Numero() As String
       
          Get
             Return m_numero
          End Get

          Set(value As String)
             m_numero = value
          End Set

       End Property 
       Public Property Nombre() As String

          Get
             Return m_nombre
          End Get

          Set(value As String)
             m_nombre = value
          End Set

       End Property 
       Public Overridable ReadOnly Property Saldo() As Decimal
       
          Get
             Return m_saldo
          End Get

       End Property 
       Public Property Titular() As Cliente
       
          Get
             Return m_titular
          End Get

          Set(value As Cliente)
             m_titular = value
          End Set

       End Property 
           
       ' Campos de instancia
       private Dim m_numero As String
       private Dim m_nombre As string
       private Dim m_saldo As Decimal
       private Dim m_titular As Cliente 

   End Class



   ' Definición de la clase CuentaAhorro
   Class CuentaAhorro
         inherits Cuenta
   
       ' Constructores y Destructores 

       Public Sub New(numeroCta As String, nombreCta As String) 

           MyBase.New(numeroCta, nombreCta, "", "", "", "nn", Cliente.Regular)
       
       End Sub  

       Public Sub New(numeroCta As String, nombreCta As String, codigoCli As String, emailCli As String) 
       
           MyBase.New(numeroCta, nombreCta, codigoCli, nombreCta, emailCli, "nn", Cliente.Regular)
       
       End Sub  

       Public Sub New(numeroCta As String, nombreCta As String, codigoCli As String, nombreCli As String, _
                     emailCli As String, tipoCli As String, claseCli As Char)
       

          MyBase.New(numeroCta, nombreCta, codigoCli, nombreCli, emailCli, tipoCli, claseCli)
          
          m_debitos = 0D
          m_creditos = 0D 
          m_saldoAntes = 0D 
       
       End Sub 


       ' Métodos públicos
       Public Overrides Function Deposito(monto As Decimal) As Decimal
       
          m_creditos += monto
          Return m_saldoAntes + m_creditos - m_debitos

       End Function 

       ' Métodos públicos
       Public Overrides Function Retiro(monto As Decimal) As Decimal
       
          m_debitos += monto
          Return m_saldoAntes + m_creditos - m_debitos

       End Function 


       ' Propiedades de instancia

       Public Property Retiros() As Decimal
       
          Get
             Return m_debitos
          End Get

          Set(value As Decimal)
             m_debitos = value
          End Set
       
       End Property 
       Public Property Depositos() As Decimal
       
          Get
             Return m_creditos
          End Get

          Set(value As Decimal) 
             m_creditos = value
          End Set 
       
       End Property 
       Public Property SaldoAnterior() As Decimal
       
          Get
             Return m_saldoAntes
          End Get
          Set(value As Decimal)
             m_saldoAntes = value
          End Set

       End Property 
       Public Overrides ReadOnly Property Saldo() As Decimal
       
          Get
             Return m_saldoAntes + m_creditos - m_debitos
          End Get

       End Property 

       ' Campos de instancia

       private Dim m_debitos As Decimal
       private Dim m_creditos As Decimal
       private Dim m_saldoAntes As Decimal
   
   End Class 



   ' Definición de la clase Cliente
   Class Cliente
   
      ' Constructores y Finalizadores

      Shared Sub New()
      
         Cliente.m_cantidad = 0
         Cliente.m_conexionData = Cliente.OpenConexion()   

      End Sub
 
      Public Sub New(codigo As String, nombre As String, email As String)

         Me.New(codigo, nombre, email, "nn", Cliente.Regular)

      End Sub

      Public Sub New(codigo As String, nombre As String, email As String, tipo As String, clase As Char)
      
         Me.codigo = codigo
         Me.nombre = nombre
         Me.email = email
         Me.tipo = tipo
         Me.clase = clase 
 
         Me.edad = 0
         Me.sexo = " "c
         Me.activo = True

         Cliente.m_cantidad += 1

      End Sub

      Public Sub Dispose()
      
         Cliente.m_cantidad -= 1
         GC.SuppressFinalize(Me)

      End Sub 

      Protected Overrides Sub Finalize()
      
         Cliente.m_cantidad -= 1

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
      Public Property Codigo() As String
      
         Get
            Return Me.m_codigo
         End Get

         Set(value As String)
            Me.m_codigo = value
         End Set

      End Property 
      Public Property Nombre() As String
      
         Get
            Return Me.m_nombre
         End Get

         Set(value As String)
            Me.m_nombre = value
         End Set

      End Property 
      Public Property Edad() As Integer

         Get
            Return Me.m_edad
         End Get

         Set(value As Integer)
            Me.m_edad = value
         End Set

      End Property 
      Public Property Sexo() As Char

         Get
            return Me.m_sexo
         End Get

         Set(value As Char)
            Me.m_sexo = value
         End Set

      End Property
      Public ReadOnly Property EsVaron() As Boolean

         Get
            If Me.m_sexo = "M"c Then Return True Else Return False
         End Get
      End Property
      Public Property Activo() As Boolean

         Get
            Return Me.m_activo
         End Get

         Set(value As Boolean)
            Me.m_activo = value
         End Set

      End Property 
      Public Property Email() As String 
      
         Get
            Return Me.m_email
         End Get

         Set(value As String)
            Me.m_email = value
         End Set

      End Property 
      Public Property Tipo() As String
      
         Get
            return Me.m_tipo
         End Get

         Set(value As String) 
            Me.m_tipo = value
         End Set

      End Property 
      Public Property Clase() As Char

         Get
            Return Me.m_clase
         End Get

         Set(value As Char)
            Me.m_clase = value
         End Set

      End Property 

      ' Propiedades campos de clase
      Public Shared ReadOnly Property Cantidad() As Integer
      
         Get
            Return Cliente.m_cantidad
         End Get

      End Property 
      Public Shared ReadOnly Property ConexionData() As String
      
         Get
            return Cliente.m_conexionData
         End Get

      End Property 

      ' campos de instancia
      Private Dim m_codigo As String
      Private Dim m_nombre As String
      Private Dim m_edad As Integer
      Private Dim m_sexo As Char
      Private Dim m_activo As Boolean
      Private Dim m_email As String
      Private Dim m_tipo As String
      Private Dim m_clase As Char
      
      ' campos de clase
      Private Shared Dim m_cantidad As Integer 
      Private Shared Dim m_conexionData As String

      ' campos constantes
      Public const Regular As Char = "A"c
      Public const Especial As Char = "B"c
      Public const Exclusivo As Char = "C"c

   End Class 



   ' Definición Clase Principal
   Class Principal
   
      Shared Sub Main()
      
          ' Crea una Cuenta Ahorro
          Dim cta As CuentaAhorro = new CuentaAhorro("1005", "Juan Perez", "000201", "jp@box.com")             

          ' Completando datos
          cta.Titular.Tipo = "Ahorrista"
          cta.Titular.Edad = 35
          cta.Titular.Sexo = "M"c    
          cta.SaldoAnterior = 150D

          ' Despliega datos de cuenta y su cliente
          Console.WriteLine()
          Console.WriteLine("Cuenta # " + cta.Numero + " (Saldo Anterior = 150)")
          Console.WriteLine("-------------------------------------------------")
          Console.WriteLine("Nombre de la Cuenta: " + cta.Nombre) 
          Console.WriteLine("Cdigo del Cliente: " + cta.Titular.Codigo) 
          Console.WriteLine("Nombre del Cliente: " + cta.Titular.Nombre) 
          Console.WriteLine("Email del Cliente: " + cta.Titular.Email) 
          Console.WriteLine("Tipo de Cliente: " + cta.Titular.Tipo) 
          Console.WriteLine("Clase de Cliente: " + cta.Titular.Clase.ToString()) 
          Console.WriteLine("Edad del Cliente: " + cta.Titular.Edad.ToString()) 
          Console.WriteLine("Sexo del Cliente: " + cta.Titular.Sexo.ToString()) 
          Console.WriteLine("Cliente activo: " + cta.Titular.Activo.ToString()) 
          Console.WriteLine("Saldo Anterior: {0}", cta.SaldoAnterior) 
          Console.WriteLine("Depositos: {0}", cta.Depositos) 
          Console.WriteLine("Retiros: {0}", cta.Retiros) 
          Console.WriteLine("Saldo Actual: {0}", cta.Saldo) 

          ' Realiza deposito
          cta.Deposito(320.60D)
          
          ' Despliega datos de cuenta y su cliente
          Console.WriteLine()
          Console.WriteLine("Cuenta # " + cta.Numero + " (Dep 320.60)")
          Console.WriteLine("-----------------------------------------")
          Console.WriteLine("Nombre de la Cuenta: " + cta.Nombre) 
          Console.WriteLine("Saldo Anterior: {0}", cta.SaldoAnterior) 
          Console.WriteLine("Depositos: {0}", cta.Depositos) 
          Console.WriteLine("Retiros: {0}", cta.Retiros) 
          Console.WriteLine("Saldo Actual: {0}", cta.Saldo) 

          ' Realiza deposito
          cta.Deposito(124.50D)
          
          ' Despliega datos de cuenta y su cliente
          Console.WriteLine()
          Console.WriteLine("Cuenta # " + cta.Numero + " (Dep 124.50)")
          Console.WriteLine("-----------------------------------------")
          Console.WriteLine("Nombre de la Cuenta: " + cta.Nombre) 
          Console.WriteLine("Saldo Anterior: {0}", cta.SaldoAnterior) 
          Console.WriteLine("Depositos: {0}", cta.Depositos) 
          Console.WriteLine("Retiros: {0}", cta.Retiros) 
          Console.WriteLine("Saldo Actual: {0}", cta.Saldo) 

          ' Realiza retiro
          cta.Retiro(201.30D)
          
          ' Despliega datos de cuenta y su cliente
          Console.WriteLine()
          Console.WriteLine("Cuenta # " + cta.Numero + " (Ret 201.30)")
          Console.WriteLine("------------------------------------------")
          Console.WriteLine("Nombre de la Cuenta: " + cta.Nombre) 
          Console.WriteLine("Saldo Anterior: {0}", cta.SaldoAnterior) 
          Console.WriteLine("Depositos: {0}", cta.Depositos) 
          Console.WriteLine("Retiros: {0}", cta.Retiros) 
          Console.WriteLine("Saldo Actual: {0}", cta.Saldo) 

          ' Realiza retiro
          cta.Retiro(112.25D)
          
          ' Despliega datos de cuenta y su cliente
          Console.WriteLine()
          Console.WriteLine("Cuenta # " + cta.Numero + " (Ret 112.25)")
          Console.WriteLine("------------------------------------------")
          Console.WriteLine("Nombre de la Cuenta: " + cta.Nombre) 
          Console.WriteLine("Saldo Anterior: {0}", cta.SaldoAnterior) 
          Console.WriteLine("Depositos: {0}", cta.Depositos) 
          Console.WriteLine("Retiros: {0}", cta.Retiros) 
          Console.WriteLine("Saldo Actual: {0}", cta.Saldo) 

      End Sub

   End Class   

End Namespace
 