' prog076.VB
' Programa: Clases públicas (Exe)
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Class Servicio
   
      Shared Public Sub Dice()
       
         Console.WriteLine() 
         Console.WriteLine() 
         Console.WriteLine("Este es un servicio") 
         Console.Write("Veo que Cliente dice: ")
         Cliente.Dice()

      End Sub

   End Class

   Class Operacion
   
      Shared Public Sub Dice()
       
         Console.WriteLine() 
         Console.WriteLine() 
         Console.WriteLine("Esta es una operación") 
         Console.Write("Veo que Cliente dice: ")
         Cliente.Dice()

      End Sub

   End Class

   Class Central
   
      Shared Sub Main()
      
         Console.WriteLine() 
         Cliente.Dice()
         ' ClienteEspecial.Dice()   ' no compila
         ' ClienteExclusivo.Dice()  ' no compila
         Servicio.Dice() 
         Operacion.Dice()
         Console.WriteLine() 

      End Sub

   End Class   

End Namespace
