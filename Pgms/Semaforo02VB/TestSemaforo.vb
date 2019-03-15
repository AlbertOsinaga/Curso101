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
			Dim smf As Semaforo = New Semaforo 
			smf.SetSegundos(segsSemaforo)

			' Suscripcion al evento cambio estado
			AddHandler smf.CambioEstado, AddressOf DespliegaColor

			' Pone en funcionamiento el semaforo
			smf.Run(segsFuncionando)

		End Sub

		Public Shared Sub DespliegaColor(ByVal semaforo As Object, ByVal estadoInfo As EstadoEventArgs)

			' Traduce estado a color
			Dim color As String = EstadoAColor(estadoInfo.Estado)

			' Despliega color
			Console.WriteLine(color)

		End Sub

		Shared Function EstadoAColor(ByVal estado As Integer) As String

			Dim color As String = ""

			Select estado
			Case 0
				color = "Rojo"
			Case 1
				color = "Amarillo"
			Case Else
				color = "Verde"
			End Select 

			Return color

		End Function

	End Class 

End Namespace
