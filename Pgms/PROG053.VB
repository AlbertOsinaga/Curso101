' prog053.VB
' Programa: Declaración de clases
'           y definición-creación de objetos 
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición de la clase Principal

   Class Principal
   
      Shared Sub Main()
      
         ' Definición y creación de objetos
         UsaObjetos()

      End Sub

      Shared Sub UsaObjetos()
      
         ' Declaración de variable
         Dim clienteAhorro As Cliente

         ' Creación del objeto clienteAhorro
         clienteAhorro = New Cliente()	

         ' Despliega objeto clienteAhorro	
         Console.WriteLine()
         Console.WriteLine("objeto clienteAhorro de la clase: {0}", clienteAhorro)  

         ' Declaración y creación del objeto clienteCredito
         Dim clienteCredito As CursoNet.Cliente = new CursoNet.Cliente()	

         ' Despliega objeto clienteCredito	
         Console.WriteLine()
         Console.WriteLine("objeto clienteCredito de la clase: {0}", clienteCredito)  

      End Sub

   End Class



   ' Definición de la clase Cliente   

   Class Cliente
   
      ' 
      '   Cuerpo de la clase
      '   ..................
      '   ..................
      '   ..................
      ' 

   End Class 

End Namespace
