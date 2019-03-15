' prog088.VB
' Programa: Interfaces (IManejaSaldo)
' LAOS
' Enero 2004

Imports System
Imports System.Collections

Namespace CursoNet

   ' Definición de la interfaz IManejaSaldo
   Interface IManejaSaldo
   
      Function Deposito(monto As Decimal) As Decimal
      Function Retiro(monto As Decimal) As Decimal
      ReadOnly Property Saldo() As Decimal 
   
   End Interface      


   ' Definición de la clase Cuenta
   Class Cuenta 
         Implements IEnumerable, IManejaSaldo
   
       ' Constructores

       Public Sub New(numeroCta As String, nombreCta As String)
       
          m_nombres = new ArrayList() 

          m_numero = numeroCta
          m_nombres.Add(nombreCta)

       End Sub 

       
       ' Métodos públicos

       Public Overrides Function ToString() As String
       
           Return "Cuenta: " + m_numero + " de " + CType(m_nombres(0), String)  

       End Function

       Public Overridable Function Deposito(monto As Decimal) As Decimal Implements IManejaSaldo.Deposito
       
          m_saldo += monto
          Return m_saldo
       
       End Function 

       Public Overridable Function Retiro(monto As Decimal) As Decimal Implements IManejaSaldo.Retiro
       
          m_saldo -= monto
          Return m_saldo
       
       End Function 


       ' Implementando interfaz IEnumerable
       
       Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
       
          Return CType( new NombreEnumerador(Me), IEnumerator)

       End Function


       ' Propiedades de instancia

       Public Property Numero() As String
       
          Get
             Return m_numero
          End Get

          Set
             m_numero = value
          End Set

       End Property 
       Public Property Nombres() As ArrayList 
       
          Get
             Return m_nombres
          End Get

          Set
             m_nombres = value
          End Set

       End Property 
       Public ReadOnly Property Saldo() As Decimal Implements IManejaSaldo.Saldo
       
          Get
             Return m_saldo
          End Get

       End Property 
           

       ' Campos de instancia

       private Dim m_numero As String
       private Dim m_nombres As ArrayList 
       private Dim m_saldo As Decimal

   End Class


   ' Dfinición de la clase NombreEnumerador
   Class NombreEnumerador 
         Implements IEnumerator
   
      ' Constructores
      
      Public Sub New(cta As Cuenta)
      
         Me.m_cta = cta
         Me.m_indice = -1

      End Sub


      ' Implementación IEnumerator

      Public Overridable Function MoveNext() As Boolean Implements IEnumerator.MoveNext
      
         m_indice += 1 
         If m_indice >= Me.m_cta.Nombres.Count
            Return False
         Else
            Return True
         End If

      End Function

      Public Overridable Sub Reset()  Implements IEnumerator.Reset
      
         m_indice = -1

      End Sub

      Public ReadOnly Property Current() As Object Implements IEnumerator.Current
      
         Get
            Return Me.m_cta.Nombres(m_indice)
         End Get

      End Property
      
      
      ' Campos de instancia
 
      private Dim m_cta As Cuenta
      private Dim m_indice As Integer         

   End Class 


   ' Definición Clase Principal
   Class Principal
   
      Shared Sub Main(args() As String)
      
          ' Test de Interface
          TestInterface(args) 

      End Sub

      Shared Sub TestInterface(args() As String)
      
         ' Crea objeto cuenta 
         Dim cta As Cuenta = new Cuenta("1001", "Ana")

         ' Ingresa dueños adicionales de la cuenta
         For Each nombre As String in args
            cta.Nombres.Add(nombre)
         Next
      
         ' Depósitos y retiros
         cta.Deposito(2350.75D)
         cta.Retiro(545.23D)

         ' Despliega dueños de la cuenta
         Console.WriteLine()
         Console.WriteLine(cta)
         Console.WriteLine("----------------------------")
         Console.WriteLine("Saldo: {0}", cta.Saldo)
         Console.WriteLine("Titulares:")
         For Each nombre As String in cta.Nombres
            Console.WriteLine(nombre)
         Next

      End Sub

   End Class   

End Namespace
