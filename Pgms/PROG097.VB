' prog097.VB
' Programa: Clase Cuentas con "Propiedad default" String
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición de la clase Cuenta
   Class Cuenta
   
       ' Constructor

       Public Sub New(numeroCta As String, nombreCta As String)
       
          m_numero = numeroCta
          m_nombre = nombreCta

       End Sub 


       ' Métodos pblicos

       Public Overrides Function ToString() As String
       
           Return "Cuenta: " + m_numero + " de " + m_nombre  

       End Function


       ' Propiedades de instancia

       Public Property Numero() As String
       
          Get
             Return m_numero
          End Get

          Set
             m_numero = value
          End Set

       End Property 
       Public Property Nombre() As String
       
          Get  
             Return m_nombre
          End Get

          Set
             m_nombre = value
          End Set

       End Property 


       ' Campos de instancia

       private Dim m_numero As String
       private Dim m_nombre As String

   End Class


   ' Definición clase Cuentas
   Class Cuentas
   
      ' Constructores

      Public Sub New(ParamArray strs() As String)
      
         ' Copia Cuentas al array interno
         For i As Integer = 0 To strs.Length - 1 Step 2
         
            m_ctas(m_count) = New Cuenta(strs(i), strs(i + 1))
            m_count += 1

         Next

      End Sub

		
      ' Métodos públicos
		
      Public Sub Add(newCta As Cuenta)
      
         If m_count >= m_ctas.Length
         
            ' maneja indice malo
            Throw New IndexOutOfRangeException("(Add) Adicionando un elemento fuera de rango")

         Else
         
            m_ctas(m_count).Numero = newCta.Numero
            m_ctas(m_count).Nombre = newCta.Nombre
            m_count += 1

         End If

      End Sub

		
      ' Propiedades de instancia
		
      Public Property cta(indice As Integer) As Cuenta 
      
         Get
	 
	    If indice < 0 OrElse indice >= m_ctas.Length
            
               ' maneja indice malo
               throw new IndexOutOfRangeException("([]) Accediendo a elemento fuera de rango")

            End If

            Return m_ctas(indice)

         End Get
	 Set( value As Cuenta)
	 
	    ' Adiciona solo a través de Add
	    If indice >= m_count
	    
	       ' maneja ndice malo
	       throw new IndexOutOfRangeException("(()) Asignando a elemento no adicionado. Use Add!")

            Else
            
               m_ctas(indice).Numero = value.Numero
               m_ctas(indice).Nombre = value.Nombre

            End If

	 End Set

      End Property
   
      Default Public Property ctastr(numero As String) As Cuenta 
      
         Get
	 
            Dim indice As Integer = 0
            For Each cta As Cuenta in m_ctas
            
               If cta.Numero = numero
                  Exit For
               End If                

               indice += 1 

            Next           	

            If indice < 0 OrElse indice >= m_ctas.Length
            
               ' maneja indice malo
               throw new IndexOutOfRangeException("(()) Accediendo a elemento fuera de rango")

            End If

            Return m_ctas(indice)

         End Get
	 Set(value As Cuenta)
	 
            Dim indice As Integer = 0
            For Each cta As Cuenta in m_ctas
            
               If cta.Numero = numero
                  Exit For
               End IF

               indice += 1 

            Next           	

	    ' Adiciona solo a travs de Add
	    If indice >= m_count
	    
	       ' maneja ndice malo
	       throw new IndexOutOfRangeException("(()) Asignando a elemento no adicionado. Use Add!")

            Else
            
               m_ctas(indice).Numero = value.Numero
               m_ctas(indice).Nombre = value.Nombre

            End If

	 End Set

      End Property
   
      ' strings ocupados
      Public Readonly Property Count As Integer
      
         Get
            Return m_count
         End Get

      End Property

		
      ' Campos de instancia
		
      Private Const m_maxElementos As Integer = 50
      Private Dim m_ctas(m_maxElementos) As Cuenta 
      Private Dim m_count As Integer = 0

   End Class
    
   
   ' Definición Clase Principal
   Class Principal
   
      Shared Sub Main(args() As String)
      
          ' Test de Indexadores
          TestIndexadores(args) 

      End Sub

      Shared Sub TestIndexadores(args() As String)
      
         Try
	 	
	    ' Crea lista de cuentas
	    DIm ctas As Cuentas = new Cuentas(args)

  	    ' Despliega elementos
            Console.WriteLine()
            Console.WriteLine("Cuentas:")
            Console.WriteLine("-------")

            For i As Integer = 0 To ctas.Count -1
               Console.WriteLine(ctas.cta(i))
            Next

            ' Mientras no sea asterisco busca cuenta y despliega
            Console.WriteLine()
            Console.Write("Nmero de cuenta: ")
            Dim numcta As String = Console.ReadLine()
            Do While numcta <>  "*"
            
               Console.WriteLine(ctas(numcta))              
               Console.WriteLine()
               Console.Write("Número de cuenta: ")
               numcta = Console.ReadLine()

            Loop 

	 Catch e As IndexOutOfRangeException
	 
	    Console.WriteLine()
	    Console.WriteLine(e.Message) 

	 End Try

      End Sub

   End Class   

End Namespace
