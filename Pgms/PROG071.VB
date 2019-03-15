' prog071.VB
' Programa: Campos readonly
' LAOS
' Enero 2004

Imports System
Imports System.Net

Namespace CursoNet

   ' Definición de la clase Principal
   Class Principal
   
      Shared Sub Main()
      
         ' Obtiene IP Address
         GetIPAddress()

      End Sub

      Shared Sub GetIPAddress()
      
         Dim wk As WorkStation = New WorkStation()
         Console.WriteLine()
         Console.WriteLine("Mi dirección IP es " + wk.IpaString)

      End Sub

   End Class


   ' Definición de la clase WorkStation
   Class WorkStation
   
      Public Sub New()
      
         Dim ipa As IPAddress = Dns.Resolve(hostName).AddressList(0)
         IpaString = ipa.ToString()

      End Sub

      Public Const hostName As String = "localhost"
      Public Dim readonly IpaString As String

   End Class

End Namespace

