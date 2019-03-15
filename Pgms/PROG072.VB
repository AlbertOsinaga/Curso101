' prog072.VB
' Programa: Structure con ReadOnly
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición de la clase Principal
   Class Principal
   
      Shared Sub Main()
      
         ' Obtiene colores
         GetColores()

      End Sub

      Shared Sub GetColores()
      
         Console.WriteLine()
         Console.WriteLine("RED: {0}",  RGB.RED)
         Console.WriteLine("GREEN: {0}", RGB.GREEN)
         Console.WriteLine("BLUE: {0}", RGB.BLUE)

      End Sub

   End Class


   ' Definición de la estructura de Colores
   Structure RGB
   
      Public m_red As Integer
      Public m_green As Integer
      Public m_blue As Integer

      Public Shared readonly RED As RGB
      Public Shared readonly GREEN As RGB
      Public Shared readonly BLUE As RGB

      Shared Sub New()

         RED = new RGB(255, 0, 0)
         GREEN = new RGB(0, 255, 0)
         BLUE = new RGB(0, 0, 255)

      End Sub

      Public Sub New(red As Integer, green As Integer, blue As Integer)
      
         Me.m_red = red
         Me.m_green = green
         Me.m_blue = blue

      End Sub

      Public Overrides Function ToString() As String
      
          Return m_red.ToString("X2") + m_green.ToString("X2") + m_blue.ToString("X2")

      End Function

   End Structure

End Namespace

