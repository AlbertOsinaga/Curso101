' prog095.VB
' Programa: Resolviendo métodos iguales en diferentes interfaces
' LAOS
' Enero 2004

Option Strict On

Imports System
Imports System.Collections

Namespace CursoNet

   ' Definición de la interfaz IManejaSaldo
   Interface IManejaSaldo
   
      Function Deposito(monto As Decimal) As Decimal
      Function Retiro(monto As Decimal) As Decimal
      ReadOnly Property Saldo() As Decimal 
   
   End Interface      


   ' Definición de la interfaz IManejaMovis
   Interface IManejaMovis
      Inherits IManejaSaldo    
   
      ReadOnly Property Depositos() As Decimal 
      ReadOnly Property Retiros() As Decimal 
   
   End Interface      


   ' Definición de la interfaz IManejaExtracto
   Interface IManejaExtracto
   
      ReadOnly Property Saldo() As Decimal 
   
   End Interface      


   ' Definición de la clase Cuenta
   Class Cuenta
         Inherits ArrayList 
         Implements IManejaMovis, IManejaExtracto, IDisposable
   
       ' Constructores y Destructores

       Public Sub New(numeroCta As String, nombreCta As String)

          m_numero = numeroCta
          Add(nombreCta)

       End Sub 

       Protected Overrides Sub Finalize()
       
          Console.WriteLine()
          Console.WriteLine("Destruyendo objeto cuenta...")
       
       End Sub
       

       ' Métodos públicos

       Public Overrides Function ToString() As String
       
           Return "Cuenta: " + m_numero + " de " + CType(Me(0), String)  

       End Function


       'Métodos de la Interfaz IManejaMovis

       Public Function Deposito(monto As Decimal) As Decimal Implements IManejaSaldo.Deposito
       
          m_saldo += monto
          m_depositos += monto
          Return m_saldo
       
       End Function 

       Public Function Retiro(monto As Decimal) As Decimal Implements IManejaSaldo.Retiro
       
          m_saldo -= monto
          m_retiros += monto
          Return m_saldo
       
       End Function 


       ' Implementando interfaz IDisposable
       
       Public Sub Dispose() Implements IDisposable.Dispose
      
          Console.WriteLine()
          Console.WriteLine("Destruyendo objeto cuenta...")
          GC.SuppressFinalize(Me)
       
       End Sub 


       ' Propiedades de instancia

       Public Property Numero() As String
       
          Get
             Return m_numero
          End Get

          Set
             m_numero = value
          End Set

       End Property 


       ' Propiedades interfaz IManejaMovis

       Public ReadOnly Property Saldo() As Decimal Implements IManejaSaldo.Saldo
       
          Get
             Return m_saldo
          End Get

       End Property 
       Public ReadOnly Property Depositos() As Decimal Implements IManejaMovis.Depositos
       
          Get
             Return m_depositos
          End Get

       End Property 
       Public ReadOnly Property Retiros() As Decimal Implements IManejaMovis.Retiros
       
          Get
             Return m_retiros
          End Get

       End Property 
           

       ' Propiedades interfaz IManejaExtracto

       Public ReadOnly Property Saldo() As Decimal Implements IManejaExtracto.Saldo
       
           Get
             Return m_saldo
          End Get

        End Property 


       ' Campos de instancia

       private Dim m_numero As String
       private Dim m_saldo As Decimal
       private Dim m_depositos As Decimal
       private Dim m_retiros As Decimal

   End Class


   ' Definición Clase Principal
   Class Principal
   
      Shared Sub Main(args() As String)
      
          ' Test de Interface
          TestInterface(args) 

      End Sub

      Shared Sub TestInterface(args() As String)
      
         ' Interfaz pública (objeto)
         Dim cta As New Cuenta("1001", "Ana")

         ' Depósitos y retiros
         cta.Deposito(1519.70D)
         cta.Retiro(284.92D)

         ' Despliega cuenta
         Console.WriteLine()
         Console.WriteLine("[Acceso mediante una referencia al Objeto cta]")
         Console.WriteLine(cta)
         Console.WriteLine("----------------------------------------------")
         Console.WriteLine("Depósitos: {0}", cta.Depositos)
         Console.WriteLine("Retiros: {0}", cta.Retiros)
         Console.WriteLine("Saldo: {0}", cta.Saldo)

      End Sub

   End Class   

End Namespace
