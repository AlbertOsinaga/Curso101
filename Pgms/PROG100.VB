' prog100.VB
' Programa: Queue 2
' LAOS
' Enero 2004

Imports System
Imports System.Collections

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Maneja una cola de palabras
         Dim cola As New ColaDePalabras()
         cola.Run()

      End Sub

   End Class 

   Class ColaDePalabras
   
      ' Constructores
      Public Sub New()
      
         q = New Queue() 

      End Sub
  
      ' Métodos públicos
      Public Sub Run()
      
         Dim palabra As String = ""
         Console.WriteLine()
         Console.WriteLine("Programa Cola de Palabras")
         Console.WriteLine("-------------------------")
         Do
         
            ' Usuario introduce operación
            Console.WriteLine()
            Console.WriteLine("'+ palabra' Pone la palabra en la cola")
            Console.WriteLine("'-' Saca la primera palabra de la cola")
            Console.WriteLine("'=' Despliega la primera palabra de la cola")
            Console.WriteLine("'*' Termina el programa")
            Console.WriteLine()
            Console.Write("Introduzca su operación: ")
            palabra = Console.ReadLine()
            
            ' Si símbolo es '*' termina
            If palabra.Substring(0,1) = "*"c
            
                Console.WriteLine()
                Console.WriteLine("Fin del programa")
                Exit Do

            End If

	    ' Valida símbolo
            If  "+-=".IndexOf(palabra.Substring(0,1)) < 0 
            
               Console.WriteLine()
               Console.WriteLine("Símbolo equivocado. Los símbolos de inicio válidos son: '+','-','=','*'")
               GoTo Continue

            End If
               		 
            ' Valida palabra
            If palabra.Substring(0,1) = "+"c  AndAlso  palabra.Length < 3
            
               Console.WriteLine()
               Console.WriteLine("Después del símbolo de operación, introduzca una palabra después de un espacio!")
               GoTo Continue

            End If   
 
            Select palabra.Substring(0,1)
            
               Case "+"c
                  q.Enqueue(palabra.Substring(2))
                  Console.WriteLine("Palabra '" + palabra.Substring(2) + "' encolada...")
               
               Case "-"c
                  If q.Count < 1
                  
                     Console.WriteLine("La cola está vacía!")
                     GoTo Continue

                  End If
                  Dim wordDQ As String = CType(q.Dequeue(), String)
                  Console.WriteLine("Palabra '" + wordDQ + "' desencolada...")

               Case "="c   
                  If q.Count < 1
                  
                     Console.WriteLine("La cola está vacía!")
                     GoTo Continue

                  End If     
                  Dim firstWord As String = CType(q.Peek(), String)
                  Console.WriteLine("Primera palabra: '" + firstWord + "'")
               
               Case Else
                  Console.WriteLine("Esto no debera suceder nunca, lo prometo!")

            End Select

            Continue:

         Loop While(palabra.Substring(0,1) <> "*"c)

      End Sub

      ' Campos privados
      Private Dim q As Queue      

   End Class

End Namespace
