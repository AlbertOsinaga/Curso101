' prog018.CS
' Programa: Conversión a/de Strings
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
         ' Conversion
         Conversion()
      End Sub 
        
      Shared Sub Conversion()
         ' Declaración de variables locales numéricas	
         Dim cantidad As Integer = 12
         Dim maxEntero As Long = long.MaxValue
         Dim monto As Decimal = 25000000D

         ' Conversión de números a string
         Dim sCantidad As String = cantidad.ToString()  	
         Dim sMaxEntero As String = maxEntero.ToString()
         Dim sMonto As String = Convert.ToString(monto)

         ' Despliegue de strings
         Console.WriteLine()
         Console.WriteLine("sCantidad : " + sCantidad)
         Console.WriteLine("sMaxEntero : " + sMaxEntero)
         Console.WriteLine("sMonto : " + sMonto)

         ' Ingreso de numero en string
         Console.WriteLine()
         Console.Write("Ingrese un número entero: ")
         Dim sNumero As String = Console.ReadLine()
	
         ' Conversión de string a numeros
         cantidad = Convert.ToInt32(sNumero)
         maxEntero = Convert.ToInt64(sNumero)
         monto = decimal.Parse(sNumero)            	

         ' Despliegue de numeros
         Console.WriteLine()
         Console.WriteLine("cantidad - Convert.ToInt32(sNumero): {0}",cantidad)
         Console.WriteLine("maxEntero - Convert.ToInt64(sNumero): {0}", maxEntero)
         Console.WriteLine("monto - decimal.Parse(sNumero): {0}", monto)
      End Sub
   
   End Class

End Namespace