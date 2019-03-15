' prog089.VB
' Programa: Simple Herencia - Múltiples Interfaces
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
         Inherits ArrayList 
         Implements IManejaSaldo, IDisposable
   
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
          Return m_saldo
       
       End Function 

       Public Overridable Function Retiro(monto As Decimal) As Decimal Implements IManejaSaldo.Retiro
       
          m_saldo -= monto
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
       Public ReadOnly Property Saldo() As Decimal Implements IManejaSaldo.Saldo
       
          Get
             Return m_saldo
          End Get

       End Property 
           

       ' Campos de instancia

       private Dim m_numero As String
       private Dim m_saldo As Decimal

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
            cta.Add(nombre)
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
         For Each nombre As String in cta
            Console.WriteLine(nombre)
         Next

      End Sub

   End Class   

End Namespace
