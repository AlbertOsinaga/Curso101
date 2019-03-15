' prog020.VB
' Programa: Strings, secuencias de escape
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
         ' Secuencias de Escape
         SecuenciasEscape()
      End Sub 
        
      Shared Sub SecuenciasEscape()
         ' Caracteres especiales
         Dim al As Char = Convert.ToChar(7)
         Dim tb As Char = Convert.ToChar(9)
         Dim nl As Char = Convert.ToChar(10)
         Dim qt As Char = Convert.ToChar(34)

         ' Hello World	
         Console.WriteLine(nl + "Hello World" + nl)
         Console.WriteLine(qt + "Hello World" + qt)

         ' Tabla
         Console.WriteLine(nl + "Nombre" + tb + "Tele" + tb + "eMail")
         Console.WriteLine("------" + tb + "----" + tb + "-----")
         Console.WriteLine("Juan" + tb + "2232323" + tb + "juan@correo.net")
         Console.WriteLine("Pedro" + tb + "2443355" + tb + "pedro@buzon.net") 

         ' directorios
         Console.WriteLine()
         Console.WriteLine("Directorio: " + "c:\misdocumentos\misimagenes\")

         ' Despedida
         Console.WriteLine(nl + "Bye bye Paraguay!" + al)
      End Sub

   End Class

End Namespace