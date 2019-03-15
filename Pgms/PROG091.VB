' prog091.VB
' Programa: Acceso a los miembros de las interfaces
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


   ' Definición de la clase Cuenta
   Class Cuenta
         Inherits ArrayList 
         Implements IManejaMovis, IDisposable
   
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

       Public Overridable Function Deposito(monto As Decimal) As Decimal Implements IManejaSaldo.Deposito
       
          m_saldo += monto
          m_depositos += monto
          Return m_saldo
       
       End Function 

       Public Overridable Function Retiro(monto As Decimal) As Decimal Implements IManejaSaldo.Retiro
       
          m_saldo -= monto
          m_retiros += monto
          Return m_saldo
       
       End Function 

       Public Overrides Function ToString() As String
       
           Return "Cuenta: " + m_numero + " de " + CType(Me(0), String)  

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
       Public ReadOnly Property Saldo() As Decimal Implements IManejaMovis.Saldo
       
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
      
         ' Acceso mediante una referencia a la cuenta 
         Dim cta As Cuenta = new Cuenta("1001", "Ana")

         ' Ingresa dueños adicionales de la cuenta
         For Each nombre As String in args
            cta.Add(nombre)
         Next
      
         ' Depósitos y retiros
         cta.Deposito(2350.75D)
         cta.Retiro(545.23D)

         ' Despliega dueños de la cuenta
         Console.WriteLine()
         Console.WriteLine(cta)
         Console.WriteLine("----------------------------")
         Console.WriteLine("Depósitos: {0}", cta.Depositos)
         Console.WriteLine("Retiros: {0}", cta.Retiros)
         Console.WriteLine("Saldo: {0}", cta.Saldo)
         Console.WriteLine("Titulares:")
         For Each nombre As String in cta
            Console.WriteLine(nombre)
         Next



         ' Acceso mediante una referencia a la interfaz (casting) 
         Dim iMovis As ImanejaMovis = CType(cta, IManejaMovis)

         ' Depósitos y retiros
         iMovis.Deposito(1519.70D)
         iMovis.Retiro(284.92D)

         ' Despliega dueños de la cuenta
         Console.WriteLine()
         Console.WriteLine(iMovis)
         Console.WriteLine("----------------------------")
         Console.WriteLine("Depósitos: {0}", iMovis.Depositos)
         Console.WriteLine("Retiros: {0}", iMovis.Retiros)
         Console.WriteLine("Saldo: {0}", iMovis.Saldo)
         Console.WriteLine("Titulares:")
         ' No compila
         ' For Each nombre As String in cta
         '   Console.WriteLine(nombre)
         'Next



         ' Acceso mediante una referencia a la interfaz (operador As) 
         Dim iMovims As IManejaMovis = cta

         ' Depósitos y retiros
         iMovims.Deposito(634.50D)
         iMovims.Retiro(218.90D)

         ' Despliega dueños de la cuenta
         Console.WriteLine()
         Console.WriteLine(iMovims)
         Console.WriteLine("----------------------------")
         Console.WriteLine("Depósitos: {0}", iMovims.Depositos)
         Console.WriteLine("Retiros: {0}", iMovims.Retiros)
         Console.WriteLine("Saldo: {0}", iMovims.Saldo)
         Console.WriteLine("Titulares:")
         ' No compila
         ' For Each nombre As String in cta
         '   Console.WriteLine(nombre)
         'Next

      End Sub

   End Class   

End Namespace
