' prog014.VB
' Programa: Tipos y variables
' LAOS
' Enero 2004

Imports System
Imports System.Runtime.InteropServices

Namespace CursoNet

   Class Principal

      Shared Sub Main()
 
         ' integers
         Dim by As Byte = Convert.ToByte(0)	' 8 bit - unsigned
         Dim sh As Short = 0S			' 16 bit - signed
         Dim i As Integer = 0			' 32 bit - signed
         Dim ln As Long = 0L			' 64 bit - signed

         ' floating point numbers (and decimal)
         Dim fl As Single = 0.00F
         Dim db As Double = 0.00
         Dim dm As Decimal = 0.00

         ' boolean, char 
         Dim bl As Boolean = False
         Dim ch As char = "C"c

         ' Strings y DateTime
         Dim s As String = "abcdefghijklmnopqrstuvwxyz"
         Dim h As DateTime = DateTime.Now

         ' Objects
         Dim o As Object = new object()



         ' Despliega tipos, nombres, tamaños, mínimos y máximos
 

         ' Enteros 

         Console.WriteLine()
         Console.WriteLine("Tipos enteros:")
         Console.WriteLine("-------------")
         Console.WriteLine()

         Console.WriteLine("Byte - {0}", by.GetType().ToString())
         Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(by))
         Console.WriteLine("Mínimo: {0}", Byte.MinValue)
         Console.WriteLine("Máximo: {0}", Byte.MaxValue)
         Console.WriteLine()

         Console.WriteLine("Short - {0}", sh.GetType().ToString())
         Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(sh))
         Console.WriteLine("Mínimo: {0}", Short.MinValue)
         Console.WriteLine("Máximo: {0}", Short.MaxValue)
         Console.WriteLine()

         Console.WriteLine("Integer - {0}", i.GetType().ToString())
         Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(i))
         Console.WriteLine("Mínimo: {0}", Integer.MinValue)
         Console.WriteLine("Máximo: {0}", Integer.MaxValue)
         Console.WriteLine()

         Console.WriteLine("Long - {0}", ln.GetType().ToString())
         Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(ln))
         Console.WriteLine("Mínimo: {0}", Long.MinValue)
         Console.WriteLine("Máximo: {0}", Long.MaxValue)
         Console.WriteLine()


         ' Punto flotante
  
         Console.WriteLine()
         Console.WriteLine("Tipos de punto flotante:")
         Console.WriteLine("-----------------------")
         Console.WriteLine()

         Console.WriteLine("Single - {0}", fl.GetType().ToString())
         Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(fl))
         Console.WriteLine("Mínimo: {0}", Single.MinValue)
         Console.WriteLine("Máximo: {0}", Single.MaxValue)
         Console.WriteLine()

         Console.WriteLine("Double - {0}", db.GetType().ToString())
         Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(db))
         Console.WriteLine("Mínimo: {0}", Double.MinValue)
         Console.WriteLine("Máximo: {0}", Double.MaxValue)			
         Console.WriteLine()

         Console.WriteLine("Decimal - {0}", dm.GetType().ToString())
         Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(dm))
         Console.WriteLine("Mínimo: {0}", Decimal.MinValue)
         Console.WriteLine("Máximo: {0}", Decimal.MaxValue)
         Console.WriteLine()


         ' Boolean y Char

         Console.WriteLine()
         Console.WriteLine("Tipos booleano y carácter:")
         Console.WriteLine("-------------------------")
         Console.WriteLine()

         Console.WriteLine("Char - {0}", ch.GetType().ToString())
         Console.WriteLine("Tamaño: {0}", Marshal.SizeOf(ch))
         Console.WriteLine("Mínimo: {0}", char.MinValue)
         Console.WriteLine("Máximo: {0}", char.MaxValue)			
         Console.WriteLine()


         ' Strings and DateTime

         Console.WriteLine()
         Console.WriteLine("Tipos string y datetime:")
         Console.WriteLine("-----------------------")
         Console.WriteLine()

         Console.WriteLine("String - {0}", s.GetType().ToString())
         Console.WriteLine()

         Console.WriteLine("DateTime - {0}", h.GetType().ToString())
         Console.WriteLine("Hoy es: {0}", h.ToString())
         Console.WriteLine()

         ' Objects
         Console.WriteLine()
         Console.WriteLine("Tipo object:")
         Console.WriteLine("-----------")
         Console.WriteLine()

         Console.WriteLine("Object\t{0}", o.GetType().ToString())
         Console.WriteLine()


      End Sub

   End Class

End Namespace