' prog101.VB
' Programa: Stack
' LAOS
' Enero 2004

Option Strict On

Imports System
Imports System.Collections

Namespace CursoNet

   Class Principal
   
      Shared Sub Main(args As String())
      
         ' Despliega las palabras de la línea de comandos
         Dim stkPalabras As Stack = New Stack()
         CopiaAStack(args, stkPalabras)
         DespliegaPalabras(stkPalabras)

      End Sub

      Shared Sub CopiaAStack(args As String(), stkPalabras As Stack)
      
         ' Copia datos de una array a un Queue
         For Each arg As String in args
            stkPalabras.Push(arg)
         Next 

      End Sub

      Shared Sub DespliegaPalabras(stkPalabras As Stack)
      
         ' Verifica existencia de por lo menos dos argumentos
         If stkPalabras.Count < 2
         
             Console.WriteLine("Forma de Uso: prog101 palabra1 palabra2 ...")  
             Return

         End If

         ' Despliega array original
         Console.WriteLine()
         Console.WriteLine()
         Console.WriteLine("Original")
         Console.WriteLine("--------")
         For Each s As String in stkPalabras
         
            Console.Write(s)
            Console.Write(" ")

         Next   

         Console.WriteLine()
         Console.WriteLine()

      End Sub

   End Class

End Namespace
