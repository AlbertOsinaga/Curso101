' prog029.VB
' Programa: Arrays
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main(args As String())
      
         ' Ordena las palabras de la lnea de comandos
         OrdenaPalabras(args)

      End Sub

      Shared Sub OrdenaPalabras(args As String())
      
         ' Verifica existencia de por lo menos dos argumentos
         If args.Length < 2
         
             Console.WriteLine("Forma de Uso: prog029 palabra1 palabra2 ...")  
             return

         End If

         ' Clona array de argumentos
         Dim argsOrdenados(args.Length - 1) As String
         Array.Copy(args, argsOrdenados, args.Length)
 
         ' Despliega array original
         Console.WriteLine()
         Console.WriteLine()
         Console.WriteLine("Original")
         Console.WriteLine("--------")
         For i As Integer = 0 To args.Length - 1 Step 1
         
            Console.Write(args(i))
            Console.Write(" ")

         Next i   

         ' Ordena array
         Array.Sort(argsOrdenados)

         ' Despliega array ordenado ascendentemente
         Console.WriteLine()
         Console.WriteLine()
         Console.WriteLine("Orden ascendente")
         Console.WriteLine("----------------")
         For i As Integer = 0 To args.Length - 1 Step 1
         
            Console.Write(argsOrdenados(i)) 
            Console.Write(" ")

         Next i          

         ' Reversa array
         Array.Reverse(argsOrdenados)

         ' Despliega array ordenado ascendentemente
         Console.WriteLine()
         Console.WriteLine()
         Console.WriteLine("Orden descendente")
         Console.WriteLine("-----------------")
         For i As Integer = 0 To args.Length - 1 Step 1
         
            Console.Write(argsOrdenados(i)) 
            Console.Write(" ")

         Next i          
         Console.WriteLine()
         Console.WriteLine()

      End Sub

   End Class

End Namespace
