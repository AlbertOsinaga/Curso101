' prog098.VB
' Programa: ArrayList
' LAOS
' Enero 2004

Option Strict On

Imports System
Imports System.Collections

Namespace CursoNet

   Class Principal
   
      Shared Sub Main(args As String())
      
         ' Ordena las palabras de la línea de comandos
         Dim arrayPalabras As ArrayList = New ArrayList()
         CopiaArray(args, arrayPalabras)
         OrdenaPalabras(arrayPalabras)

      End Sub

      Shared Sub CopiaArray(args As String(), arrayPalabras As ArrayList)
      
         ' Copia datos de una array a un ArrayList
         For Each arg As String in args
            arrayPalabras.Add(arg)
         Next 

      End Sub

      Shared Sub OrdenaPalabras(arrayPalabras As ArrayList)
      
         ' Verifica existencia de por lo menos dos argumentos
         If arrayPalabras.Count < 2
         
             Console.WriteLine("Forma de Uso: prog098 palabra1 palabra2 ...")  
             Return

         End If

         ' Despliega array original
         Console.WriteLine()
         Console.WriteLine()
         Console.WriteLine("Original")
         Console.WriteLine("--------")
         For Each s As String in arrayPalabras
         
            Console.Write(s)
            Console.Write(" ")

         Next   

         ' Ordena array
         arrayPalabras.Sort()

         ' Despliega array ordenado ascendentemente
         Console.WriteLine()
         Console.WriteLine()
         Console.WriteLine("Orden ascendente")
         Console.WriteLine("----------------")
         For Each s As String in arrayPalabras
         
            Console.Write(s)
            Console.Write(" ")

         Next   

         ' Reversa array
         arrayPalabras.Reverse()

         ' Despliega array ordenado descendentemente
         Console.WriteLine()
         Console.WriteLine()
         Console.WriteLine("Orden descendente")
         Console.WriteLine("-----------------")
         For Each s As String in arrayPalabras
         
            Console.Write(s)
            Console.Write(" ")

         Next   

         Console.WriteLine()
         Console.WriteLine()

      End Sub

   End Class

End Namespace
