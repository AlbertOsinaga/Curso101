'
' TestSemaforo.vb
' Created by SharpDevelop.
' User: LAOS
' Date: 9/14/2004
' Time: 10:15 PM
' 
'

Imports System
Imports System.Threading

Namespace CursoApliNet

	Public Class Principal

		Shared Sub Main(ByVal args As String())

			' Comprueba tres argumentos
			If args.Length < 3 Then
				Console.WriteLine
				Console.WriteLine("Forma de uso: test segsSemaforo segsConsulta segsFuncionando")
				Return
			End If

			' Obtiene datos para el programa
			Dim segsSemaforo As Integer = Int32.Parse(args(0))
			Dim segsConsulta As Integer = Int32.Parse(args(1))
			Dim segsFuncionando As Integer = Int32.Parse(args(2))

			' Creacion de semaforo e inicializacion
			Dim smf As Semaforo = New Semaforo 
			smf.SetSegundos(segsSemaforo)

			' Puesta en funcionamiento
			Console.WriteLine
			Dim segs As Integer = 0
			While segs < segsFuncionando

				' Traduce estado a color
				Dim color As String = EstadoAColor(smf.GetEstado)
				
				' Muestra color
				Console.WriteLine(color)
				
				' Hace parada
				Thread.Sleep(segsConsulta * 1000)
				
				segs += segsConsulta
			
			End While

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
