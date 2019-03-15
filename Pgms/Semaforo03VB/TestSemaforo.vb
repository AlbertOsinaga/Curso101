'
' TestSemaforo.vb
' Created by SharpDevelop.
' User: LAOS
' Date: 9/14/2004
' Time: 10:15 PM
' 
'

Imports System

Namespace CursoApliNet

	Public Class Principal

		Shared Sub Main(ByVal args As String())

			' Comprueba dos argumentos
			If args.Length < 2 Then
				Console.WriteLine
				Console.WriteLine("Forma de uso: test segsSemaforo segsFuncionando")
				Return
			End If

			' Obtiene datos para el programa
			Dim segsSemaforo As Integer = Int32.Parse(args(0))
			Dim segsFuncionando As Integer = Int32.Parse(args(1))

			' Creacion de semaforo e inicializacion
			Dim smf As SemaforoN = New SemaforoN 
			smf.SetSegundos(segsSemaforo)
			smf.SetEstados(5)

			' Suscripcion al evento cambio estado
			AddHandler smf.CambioEstado, AddressOf DespliegaDia

			' Pone en funcionamiento el semaforo
			smf.Run(segsFuncionando)

		End Sub

		Public Shared Sub DespliegaDia(ByVal semaforo As Object, ByVal estadoInfo As EstadoEventArgs)

			' Traduce estado a dia
			Dim dia As String = EstadoADia(estadoInfo.Estado)
			
			' Despliega dia
			Console.WriteLine(dia)

		End Sub

		Shared Function EstadoADia(ByVal estado As Integer) As String

			Dim dia As String = ""
			Select estado
			Case 0
				dia = "Lunes"
			Case 1
				dia = "Martes"
			Case 2
				dia = "Miercoles"
			Case 3
				dia = "Jueves"
			Case Else
				dia = "Viernes"
			End Select 

			Return dia

		End Function

	End Class 

End Namespace
