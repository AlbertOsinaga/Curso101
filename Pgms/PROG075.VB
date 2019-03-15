' prog075.VB
' Programa: Clases públicas (Exe/Dll)
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   Public Class Cliente
   
      Shared Public Sub Dice()
       
         Console.Write("Yo soy un Cliente") 

      End Sub

   End Class

   Friend Class ClienteEspecial
   
      Shared Public Sub Dice()
       
         Console.WriteLine() 
         Console.WriteLine() 
         Console.WriteLine("Yo soy un Cliente Especial") 
         Console.Write("Veo que Cliente dice: ")
         Cliente.Dice()

      End Sub

   End Class

   Class ClienteExclusivo
   
      Shared Public Sub Dice()
       
         Console.WriteLine() 
         Console.WriteLine() 
         Console.WriteLine("Yo soy un Cliente Exclusivo") 
         Console.Write("Veo que Cliente dice: ")
         Cliente.Dice()

      End Sub

   End Class

   Class Principal
   
      Shared Sub Main()
      
         Console.WriteLine() 
         Cliente.Dice()
         ClienteEspecial.Dice() 
         ClienteExclusivo.Dice()
         Console.WriteLine() 

      End Sub

   End Class   

End Namespace
