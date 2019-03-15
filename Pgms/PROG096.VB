' prog096.VB
' Programa: Clase Lista de Strings con "Propiedad default"
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición clase StringList
   Public Class StringList
   
      ' Constructores

      Public Sub New(ParamArray strings() As String)
      
         ' Valida capacidad del array
         If m_maxElementos < strings.Length
         
            ' maneja indice malo
            Throw New IndexOutOfRangeException("Strings manejados fuera de rango")

         End If

         ' Copia los strings pasados al constructor
         For Each s As String in strings
         
            m_strings(m_count) = s
            m_count += 1

         Next

      End Sub

		
      ' Métodos públicos
		
      Public Sub Add(newString As String)
      
         If m_count >= m_strings.Length
         
            ' maneja indice malo
            Throw New IndexOutOfRangeException("(Add) Adicionando un elemento fuera de rango")

         Else
         
	    m_strings(m_count) = newString
            m_count += 1 

         End If

      End Sub

		
      ' Propiedades de instancia
		
      ' Propiedad default para acceder a los elementos del string list
      Default Public Property Palabra(indice As Integer) As String 
      
         Get
	 
	    If indice < 0 OrElse indice >= m_strings.Length
            
               ' maneja indice malo
               Throw New IndexOutOfRangeException("(()) Accediendo a elemento fuera de rango")

            End IF

            Return m_strings(indice)

         End Get
	 Set(value As String)
	 
	    ' Adiciona solo a través de Add
	    If indice >= m_count
	    
	       ' maneja índice malo
	       Throw New IndexOutOfRangeException("(()) Asignando a elemento no adicionado. Use Add!")

            Else
            
               m_strings(indice) = value

            End If

	 End Set

      End Property 
   
      ' strings ocupados
      Public ReadOnly Property Count() As Integer
      
         Get
            Return m_count
         End Get

      End Property

		
      ' Campos de instancia
		
      private Const m_maxElementos As Integer = 5
      private Dim m_strings(m_maxElementos) As String 
      private Dim m_count As Integer = 0

   End Class
    
   
   ' Definición Clase Principal
   Class Principal
   
      Shared Sub Main(args() As String)
      
          ' Test de Indexadores
          TestIndexadores(args) 

      End Sub

      Shared Sub TestIndexadores(args() As String)
      
         Try
	 	
	    ' Crea list de strings
	    Dim ls As StringList = New StringList(args)

  	    ' Despliega elementos
            Console.WriteLine()
            Console.WriteLine("Palabras:")
            Console.WriteLine("--------")
            For i As Integer = 0 To ls.Count - 1
               Console.WriteLine(ls(i))

            Next
	 
  	    ' Despliega elementos
            Console.WriteLine()
            Console.WriteLine("Strings:")
            Console.WriteLine("--------")
            For i As Integer = 0 To ls.Count - 1
               Console.WriteLine(ls(i))

            Next

         Catch e As IndexOutOfRangeException
	 
	    Console.WriteLine()
	    Console.WriteLine(e.Message) 

	 End Try

      End Sub

   End Class   

End Namespace
