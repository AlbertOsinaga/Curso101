' prog116.VB
' Programa: Controlando excepciones
' LAOS
' Enero 2004

Imports System

Namespace CursoNet

   ' Definición Clase Tabla
   Class Tabla
   
      Public Sub AddRecord(record As String)
      
         Try
         
            ' Comienza la transacción
            BeginTran() 

            ' Adiciona un registro en blanco en la tabla
            AddRow()

            ' Actualiza registro
            UpdateRow()

            ' Finaliza la transaccin
            Commit()

         Catch e As Exception
         
            ' Aborta la transaccin          
            Rollback()
            ' Relanza la excepción
            Throw 

         End Try

     End Sub

     Public Sub BeginTran()
     
        Console.WriteLine("Tabla.BeginTran - Comenzando la transacción ...")

     End Sub

     Public Sub Commit()
     
        Console.WriteLine("Tabla.Commit - Finalizando la transacción ...")

     End Sub

     Public Sub Rollback()
     
        Console.WriteLine("Tabla.Rollback - Abortando la transacción ...")

     End Sub

     Protected Sub AddRow()
     
        Console.WriteLine("Tabla.AddRow Adicionando registro ...")

     End Sub

     Protected Sub UpdateRow()
     
        Console.WriteLine("Tabla.UpdateRow - Registro actualizado ...")
        Console.WriteLine("Tabla.UpdateRow - Error encontrado. Lanzando excepción ...")
        throw new Exception("Error en Update - No se pudo escribir en archivo!")

     End Sub

   End Class


   ' Definición Clase Principal
   Class Principal
   
      Shared Sub Main()
      
         ' Prueba base de datos
         TestDB()

      End Sub

      Shared Sub TestDB()
      
         Try
         
            Dim tabla As Tabla = new Tabla()

            Console.WriteLine("Intentando adicionar registro ...")
            tabla.AddRecord("Registro de datos")

         catch e As Exception
         
            Console.WriteLine("Principal.TestDB() - Excepción capturada '{0}'", e.Message)

         End Try

      End Sub 

   End Class   

End Namespace
