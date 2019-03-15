' prog025.VB
' Programa: Estructuras en la FCL
' LAOS
' Enero 2004

Imports System
Imports System.Drawing

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Ejemplos de las esructuras existententes en la FCl
         EjemploEstructuras()
      
      End Sub 
        
      Shared Sub EjemploEstructuras()
      
         ' struct System.Drawing.Point
         Dim p As Point = new Point(2, 8)
         Dim q As Point = new Point(3, 7)
         Console.WriteLine()
         Console.WriteLine("struct System.Drawing.Point")
         Console.WriteLine("---------------------------")
         Console.WriteLine("p está vacío?: {0}", p.IsEmpty)
         Console.WriteLine("p.X = {0}", p.X)
         Console.WriteLine("p.Y = {0}", p.Y)
         Console.WriteLine("q está vacío?: {0}", q.IsEmpty)
         Console.WriteLine("q.X = {0}", q.X)
         Console.WriteLine("q.Y = {0}", q.Y)

         ' struct System.Drawing.Size
         Dim t As Size = new Size(2, 8)
         Dim u As Size = new Size(3, 7)
         Console.WriteLine()
         Console.WriteLine("struct System.Drawing.Size")
         Console.WriteLine("---------------------------")
         Console.WriteLine("t está vacío?: {0}", t.IsEmpty)
         Console.WriteLine("t.Height = {0}", t.Height)
         Console.WriteLine("t.Width = {0}", t.Width)
         Console.WriteLine("u está vacío?: {0}", u.IsEmpty)
         Console.WriteLine("u.Height = {0}", u.Height)
         Console.WriteLine("u.Width = {0}", u.Width)
      
      End Sub
   
   End Class

End Namespace