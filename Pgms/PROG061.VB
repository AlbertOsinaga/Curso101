' prog061.VB
' Programa: Pasaje de parámetros entre Métodos
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición de la clase Principal
   Class Principal
   
      Shared Sub Main()
      
         ' Prueba pasaje de parámetros
         PruebaPasaje()

      End Sub

      Shared Sub PruebaPasaje()
      
         ' Pasaje de parámetros tipo valor
         Dim x As Integer = 5
         Dim y As Integer = 9
         Console.WriteLine()
         Console.WriteLine("Antes del intercambio")
         Console.WriteLine("---------------------")
         Console.WriteLine("x = {0}", x)
         Console.WriteLine("y = {0}", y)
         IntercambiaValor(x, y)
         Console.WriteLine()
         Console.WriteLine("Después del intercambio")
         Console.WriteLine("-----------------------")
         Console.WriteLine("x = {0}", x)
         Console.WriteLine("y = {0}", y)
 
         ' Pasaje de parámetros tipo referencia
         Dim comprador As Cliente = new Cliente("Pablo", 10, "M"c, True, "pablo@sucorreo.com")
         Dim vendedor As Cliente = new Cliente("Ana", 25, "F"c, True, "ana@micorreo.net")
         Console.WriteLine()
         Console.WriteLine("Antes del intercambio")
         Console.WriteLine("---------------------")
         Console.WriteLine("comprador = {0}", comprador.GetDatos())
         Console.WriteLine("vendedor = {0}", vendedor.GetDatos())
         IntercambiaRef(comprador, vendedor)
         Console.WriteLine()
         Console.WriteLine("Después del intercambio")
         Console.WriteLine("-----------------------")
         Console.WriteLine("comprador = {0}", comprador.GetDatos())
         Console.WriteLine("vendedor = {0}", vendedor.GetDatos())

      End Sub

      Shared Sub IntercambiaValor(a As Integer, b As Integer)
      
         Dim t As Integer = a
         a = b
         b = t 

      End Sub

      Shared Sub IntercambiaRef(a As Cliente, b As Cliente)
      
         ' t = a
         Dim t As Cliente = new Cliente()
         t.SetNombre(a.GetNombre())
         t.SetEdad(a.GetEdad())
         t.SetSexo(a.GetSexo())
         t.SetActivo(a.GetActivo())
         t.SetEmail(a.GetEmail())

         ' a = b
         a.SetNombre(b.GetNombre())
         a.SetEdad(b.GetEdad())
         a.SetSexo(b.GetSexo())
         a.SetActivo(b.GetActivo())
         a.SetEmail(b.GetEmail())

         ' b = t 
         b.SetNombre(t.GetNombre())
         b.SetEdad(t.GetEdad())
         b.SetSexo(t.GetSexo())
         b.SetActivo(t.GetActivo())
         b.SetEmail(t.GetEmail())

      End Sub

   End Class


   ' Definición de la clase Cliente
   Class Cliente
   

      Public Sub New()
  
         Me.New("nn", 0, "F"c, false, "")
      
      End Sub

      Public Sub New(nombre As String, edad As Integer, sexo As Char)
 
         Me.New(nombre, edad, sexo, false, "")
      
      End Sub

      Public Sub New(nombre As String, edad As Integer, sexo As Char, activo As Boolean, email As String)
      
         Me.nombre = nombre
         Me.edad = edad
         Me.sexo = sexo
         Me.activo = activo
         Me.email = email

      End Sub

      Public Sub SetNombre(nombre As String)
      
         Me.nombre = nombre

      End Sub

      Public Sub SetEdad(edad As Integer)
      
         Me.edad = edad

      End Sub

      Public Sub SetSexo(sexo As Char)
      
         Me.sexo = sexo

      End Sub

      Public Sub SetActivo(activo As Boolean)
      
         Me.activo = activo

      End Sub

      Public Sub SetEmail(email As String)
      
         Me.email = email

      End Sub

      Public Function GetNombre() As String 
      
         return Me.nombre

      End Function

      Public Function GetEdad() As Integer
      
         return Me.edad

      End Function

      Public Function GetSexo() As Char
      
         return Me.sexo

      End Function

      Public Function GetActivo() As Boolean
      
         return Me.activo

      End Function

      Public Function GetEmail() As String
      
         return Me.email

      End Function

      Public Function GetDatos() As String
      
         Dim datos As String = Me.nombre + " - " + _ 
                               Me.edad.ToString() + " - " + _
                               Me.sexo.ToString() + " - " + _
                               Me.activo.ToString() + " - " + _
                               Me.email

         Return datos  

      End Function 

      Public Function EsVaron() As Boolean
      
        If Me.sexo = "M"c Then Return True Else Return False  

      End Function 

      Public Function YearNacimiento(YearHoy As String) As String
      
         return (Int32.Parse(YearHoy) - Me.edad).ToString() 

      End Function 

      Dim Private nombre As String
      Dim Private edad As Integer
      Dim Private sexo As Char
      Dim private activo As Boolean
      Dim private email As String

   End Class 

End Namespace
