' prog067.VB
' Programa: boxing y unboxing
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición de la clase Principal
   Class Principal
   
      Shared Sub Main()
      
         ' Boxing y unboxing de variables
         BoxingYUnboxing()

      End Sub

      Shared Sub BoxingYUnboxing()
      
         ' Variable local    
         Dim monto As Decimal = 10D/3D
         
         ' boxing
         Dim obj As Object = monto
         Console.WriteLine()
         Console.WriteLine("Objeto boxing de un decimal - Tipo: {0}", obj.GetType())
         Console.WriteLine("Objeto boxing de un decimal - Valor: {0}", obj)

         ' unboxing
         Dim dMonto As Decimal = CType(obj, Decimal)
         Console.WriteLine()
         Console.WriteLine("Valor unboxing de un decimal - Tipo: {0}", dMonto.GetType())
         Console.WriteLine("Valor unboxing de un decimal - Valor: {0}", dMonto)
         Console.WriteLine("Valor unboxing de un decimal - decimal.Round(): {0}", decimal.Round(dMonto,2))

      End Sub

   End Class

End Namespace
