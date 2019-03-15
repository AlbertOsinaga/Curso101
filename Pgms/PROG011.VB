Imports System
Imports System.Reflection

Namespace CursoNet.VBNet
   
      Class Principal
       
         Shared Sub Main()
            Dim assb As [Assembly] = [Assembly].GetExecutingAssembly()
            Console.WriteLine()
	    Console.Write("Tipo de este assembly: ")
	    Console.Write(assb.GetTypes()(0))
            Console.WriteLine()
         End Sub
   
      End Class

End Namespace
