' prog104.VB
' Programa: Hashtable con string key
' LAOS
' Enero 2004

Imports System
Imports System.Collections

Namespace CursoNet

   Class Principal
   
      Shared Sub Main()
      
         ' Maneja una tabla de clientes
         Dim clientes As TablaClientes = new TablaClientes()
         clientes.Run()

      End Sub

   End Class 

   Class TablaClientes
   
      ' Constructores
      Public Sub New()
      
         h = New Hashtable(53, 0.5F) 

      End Sub
  
      ' Métodos públicos
      Public Sub Run()
      
         Dim palabra As String = ""
         Console.WriteLine()
         Console.WriteLine("Programa Tabla Clientes")
         Console.WriteLine("-----------------------")
         Do
         
            ' Usuario introduce operación
            Console.WriteLine()
            Console.WriteLine("'+' código-nombre-Teléfono-email  Ingresa entrada en la tabla de clientes")
            Console.WriteLine("'-' código  Remueve entrada de la tabla de clientes")
            Console.WriteLine("'=' código  Despliega datos del cliente")
            Console.WriteLine("'*' Termina el programa")
            Console.WriteLine()
            Console.Write("Introduzca su operación: ")
            palabra = Console.ReadLine()
            
            ' Si smbolo es '*' termina
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
               		 
            ' Valida palabra (existencia codigo-nombre a ingresar)
            If palabra.Substring(0,1) = "+"c  AndAlso  palabra.Length < 3
            
               Console.WriteLine()
               Console.WriteLine("Después del símbolo '+', introduzca codigo-nombre-telefono-email después de un espacio!")
               GoTo Continue

            End If
 
            ' Valida codigo-nombre (existencia de ambos para el ingreso)  
            If palabra.Substring(0,1) = "+"c  AndAlso  (palabra.IndexOf("-") <= 2  OrElse  palabra.IndexOf("-") = palabra.Length - 1)
            
               Console.WriteLine()
               Console.WriteLine("Después del símbolo '+', introduzca codigo-nombre-telefono-email después de un espacio!")
               GoTo Continue

            End If

            ' Valida existencia de codigo para remover   
            If palabra.Substring(0,1) = "-"c  AndAlso  palabra.Length < 3
            
               Console.WriteLine()
               Console.WriteLine("Después del símbolo '-', introduzca codigo del cliente a remover!")
               GoTo Continue

            End If
 
            ' Valida existencia de codigo para despliegue de teléfono   
            If palabra.Substring(0,1) = "="c  AndAlso  palabra.Length < 3
            
               Console.WriteLine()
               Console.WriteLine("Después del símbolo '=', introduzca codigo del cliente!")
               GoTo Continue

            End If   
 
            Select palabra.Substring(0,1)
            
               Case "+"c
                  Dim indiceGuion1 As Integer = palabra.IndexOf("-")
                  Dim indiceGuion2 As Integer = indiceGuion1 + 1 + palabra.Substring(indiceGuion1 + 1).IndexOf("-")
                  Dim indiceGuion3 As Integer = indiceGuion2 + 1 + palabra.Substring(indiceGuion2 + 1).IndexOf("-")  
                  Dim codigo As String = palabra.Substring(2, indiceGuion1 - 2)
                  Dim nombre As String = palabra.Substring(indiceGuion1 + 1, indiceGuion2 - (indiceGuion1 + 1))
                  Dim telefono As String = palabra.Substring(indiceGuion2 + 1, indiceGuion3 - (indiceGuion2 + 1))
                  Dim email As String = palabra.Substring(indiceGuion3 + 1, palabra.Length - (indiceGuion3 + 1))
                  Dim cli As Cliente = new Cliente(codigo, nombre, telefono, email)
                  h(codigo) = cli
                  Console.WriteLine(cli.ToString() + " fué ingresado...")
 
              Case "-"c
                  If h.Count < 1
                  
                     Console.WriteLine("La tabla de clientes est vacía!")
                     GoTo Continue

                  End If
                  Dim codigo As String = palabra.Substring(2)
                  Dim cli As Cliente = CType(h(codigo), Cliente)
                  If cli Is Nothing
                  
                     Console.WriteLine("No existe registro para cliente " + codigo + "!")
                     GoTo Continue

                  End If
                  h.Remove(codigo)      
                  Console.WriteLine(cli.ToString() + " fué removido...")

               Case "="c   
                  If h.Count < 1
                  
                     Console.WriteLine("La tabla de clientes est vacía!")
                     GoTo Continue

                  End If
                  Dim codigo As String = palabra.Substring(2)
                  Dim cli As Cliente = CType(h(codigo), Cliente)
                  If cli Is Nothing
                  
                     Console.WriteLine("No existe registro para cliente " + codigo + "!")
                     GoTo Continue

                  End If
                  Console.WriteLine(cli.ToString())

               Case Else
                  Console.WriteLine("Esto no debera suceder nunca, lo prometo!")

            End Select    


            Continue:
         Loop while(palabra.Substring(0,1) <> "*"c)

      End Sub

      ' Campos privados
      Private Dim h As Hashtable      

   End Class

   ' Definición de la clase Cliente
   Class Cliente
   
      ' Constructores y Finalizadores

      Public Sub New(codigo As String, nombre As String, telefono As String, email As String)
      
         Me.m_codigo = codigo
         Me.m_nombre = nombre
         Me.m_telefono = telefono
         Me.m_email = email

      End Sub

      ' Métodos públicos de instancia

      Public overrides Function ToString() As String
      
         return Me.m_codigo + "-" + Me.m_nombre + "-" + Me.m_telefono + "-" + Me.m_email

      End Function


      ' Propiedades campos de instancia

      Public Property Codigo() As String
      

         Get
            return m_codigo
         End Get

         Set(value As String) 
            m_codigo = value
         End Set

      End Property 

      Public Property Nombre() As String
      

         Get
            return m_nombre
         End Get

         Set(value As String) 
            m_nombre = value
         End Set

      End Property
 
      Public Property Telefono() As String
      

         Get
            return m_telefono
         End Get

         Set(value As String) 
            m_telefono = value
         End Set

      End Property

      Public Property Email() As String
      

         Get
            return m_email
         End Get

         Set(value As String) 
            m_email = value
         End Set

      End Property 

      ' campos de instancia

      Private Dim m_codigo As String
      Private Dim m_nombre As String
      Private Dim m_telefono As String
      Private Dim m_email As String

   End Class

End Namespace
