' prog035.VB
' Programa: Operadores de Comparación
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Operadores de Comparación
         OperadoresComparacion()

      End Sub

      Shared Sub OperadoresComparacion()
      
         ' Operador de comparacion
         Dim Qt As Char = Convert.ToChar(34)
         Dim a As Integer = 5
         Console.WriteLine()
         Console.WriteLine("Operadores de Comparación")
         Console.WriteLine("-------------------------")

         ' operadores
         Console.WriteLine()
         Console.WriteLine("igual (=)")
         Console.WriteLine("----------")
         Console.WriteLine( "a = 5 es {0}", a = 5)
         Console.WriteLine( "a = 4 es {0}", a = 4)

         Console.WriteLine()
         Console.WriteLine("distinto (<>)")
         Console.WriteLine("-------------")
         Console.WriteLine( "a <> 5 es {0}", a <> 5)
         Console.WriteLine( "a <> 4 es {0}", a <> 4)

         Console.WriteLine()
         Console.WriteLine("mayor (>)")
         Console.WriteLine("-------------")
         Console.WriteLine( "a > 5 es {0}", a > 5)
         Console.WriteLine( "a > 4 es {0}", a > 4)

         Console.WriteLine()
         Console.WriteLine("menor (<)")
         Console.WriteLine("-------------")
         Console.WriteLine( "a < 5 es {0}", a < 5)
         Console.WriteLine( "a < 6 es {0}", a < 6)

         Console.WriteLine()
         Console.WriteLine("mayor o igual (>=)")
         Console.WriteLine("------------------")
         Console.WriteLine( "a >= 5 es {0}", a >= 5)
         Console.WriteLine( "a >= 6 es {0}", a >= 6)

         Console.WriteLine()
         Console.WriteLine("menor o igual (<=)")
         Console.WriteLine("------------------")
         Console.WriteLine( "a <= 5 es {0}", a <= 5)
         Console.WriteLine( "a <= 4 es {0}", a <= 4)

         Console.WriteLine()
         Console.WriteLine("parecido (Like)")
         Console.WriteLine("----------------")
         Console.WriteLine( Qt & "aM5b" & Qt & " Like " & Qt & "a[L-P]#[!c-e]" & Qt & " es {0}","aM5b"  Like  "a[L-P]#[!c-e]" )
         Console.WriteLine( Qt & "BAT123khg" & Qt & " Like " & Qt & "B?T*" & Qt & " es {0}","BAT123khg"  Like  "B?T*" )

      End Sub

   End Class

End Namespace
