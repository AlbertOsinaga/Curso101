' prog030.VB
' Programa: Manejo de memoria
' LAOS
' Enero 2004

Imports System
Imports System.Text

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Ejercicios de manejo de memora
         ManejoMemoria()

      End Sub

      Shared Sub ManejoMemoria()
      
         ' Asignacion de variables tipo valor
         Dim h As short
         Dim x As Integer = 15     
         Dim y As Long = x

         ' Despliega variables tipo valor (asignacion)
         Console.WriteLine()
         Console.WriteLine("Variables Tipo Valor: (asignacion)")
         Console.WriteLine("h = no inicializada") 
         Console.WriteLine("x = {0}", x)
         Console.WriteLine("y = {0}", y)

         ' Cambio del valor de una variable tipo valor
         x = 23

         ' Despliega variables tipo valor (cambio valor)
         Console.WriteLine()
         Console.WriteLine("Variables Tipo Valor: (cambio valor)")
         Console.WriteLine("h = no inicializada") 
         Console.WriteLine("x = {0}", x)
         Console.WriteLine("y = {0}", y)

         ' Inicializacin despus de su creacin
         h = 17
 
         ' Despliega variables tipo valor (inicializacion)
         Console.WriteLine()
         Console.WriteLine("Variables Tipo Valor (inicializacion):")
         Console.WriteLine("h = {0}", h)
         Console.WriteLine("x = {0}", x)
         Console.WriteLine("y = {0}", y)

         ' Pase de variables tipo valor
         Intercambia(x, h) 	

         ' Despliega variables tipo valor (pase)
         Console.WriteLine()
         Console.WriteLine("Variables Tipo Valor (pase):")
         Console.WriteLine("h = {0}", h)
         Console.WriteLine("x = {0}", x)
         Console.WriteLine("y = {0}", y)

         ' Asignacion de variables tipo referencia
         Dim sh As StringBuilder 
         Dim sx As StringBuilder = new StringBuilder("15")     
         Dim sy As StringBuilder = sx
     
         ' Despliega variables tipo referencia (asignacion)
         Console.WriteLine()
         Console.WriteLine("Variables Tipo Referencia (asignacion):")
         Console.WriteLine("sh = null")
         Console.WriteLine("sx = {0}", sx)
         Console.WriteLine("sy = {0}", sy)

         ' Cambio del valor de una variable tipo referencia
         sx.Replace("15", "23")

         ' Despliega variables tipo referencia (cambio valor)
         Console.WriteLine()
         Console.WriteLine("Variables Tipo Referencia (cambio valor):")
         Console.WriteLine("sh = null")
         Console.WriteLine("sx = {0}", sx)
         Console.WriteLine("sy = {0}", sy)

         ' Inicializacin despus de su creacin
         sh = new StringBuilder("17")

         ' Despliega variables tipo referencia (inicializacion)
         Console.WriteLine()
         Console.WriteLine("Variables Tipo Referencia (inicializacion):")
         Console.WriteLine("sh = {0}", sh)
         Console.WriteLine("sx = {0}", sx)
         Console.WriteLine("sy = {0}", sy)

         ' Pase de variables tipo referencia
         Intercambia(sx, sh) 	

         ' Despliega variables tipo referencia (pase)
         Console.WriteLine()
         Console.WriteLine("Variables Tipo Referencia (pase):")
         Console.WriteLine("sh = {0}", sh)
         Console.WriteLine("sx = {0}", sx)
         Console.WriteLine("sy = {0}", sy)

      End Sub

      Shared Sub Intercambia(x As Double, y As Double)
      
         Dim temp As Double = x
         x = y
         y = temp

      End Sub

      Shared Sub Intercambia(x As StringBuilder, y As StringBuilder)
      
         Dim temp As StringBuilder = new StringBuilder(x.ToString())
         x.Replace(x.ToString(), y.ToString())
         y.Replace(y.ToString(), temp.ToString())

      End Sub

   End Class

End Namespace
