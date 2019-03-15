' prog099.VB
' Programa: Queue
' LAOS
' Enero 2004

Option Strict On

Imports System
Imports System.Collections

Namespace CursoNet

   Class Principal
   
      Shared Sub Main(args As String())
      
         ' Despliega las palabras de la línea de comandos
         Dim qPalabras As Queue = New Queue()
         CopiaAQueue(args, qPalabras)
         DespliegaPalabras(qPalabras)

      End Sub

      Shared Sub CopiaAQueue(args As String(), qPalabras As Queue)
      
         ' Copia datos de una array a un Queue
         For Each arg As String in args
            qPalabras.Enqueue(arg)
         Next 

      End Sub

      Shared Sub DespliegaPalabras(qPalabras As Queue)
      
         ' Verifica existencia de por lo menos dos argumentos
         If qPalabras.Count < 2
         
             Console.WriteLine("Forma de Uso: prog099 palabra1 palabra2 ...")  
             Return

         End If

         ' Despliega array original
         Console.WriteLine()
         Console.WriteLine()
         Console.WriteLine("Original")
         Console.WriteLine("--------")
         For Each s As String in qPalabras
         
            Console.Write(s)
            Console.Write(" ")

         Next   

         Console.WriteLine()
         Console.WriteLine()

      End Sub

   End Class

End Namespace
