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

			' Creacion de semaforos color y dia e inicializacion
			Dim smfColor As Semaforo = New Semaforo 
			Dim smfDias As Semaforo = New SemaforoN 
			smfColor.SetSegundos(segsSemaforo)
			smfDias.SetSegundos(segsSemaforo)
			smfColor.SetEstados(3)
			smfDias.SetEstados(5)
			
			' Suscripcion al evento cambio estado
			AddHandler smfColor.CambioEstado, AddressOf DespliegaColor
			AddHandler smfDias.CambioEstado, AddressOf DespliegaDia

			' Pone en funcionamiento los semaforos
			smfColor.Run(segsFuncionando)
			smfDias.Run(segsFuncionando)
		
		End Sub

		Public Shared Sub DespliegaColor(ByVal semaforo As Object, ByVal estadoInfo As EstadoEventArgs)

			' Traduce estado a color
			Dim color As String = EstadoAColor(estadoInfo.Estado)
			
			' Despliega color
			Console.WriteLine(color)
		
		End Sub

		Public Shared Sub DespliegaDia(ByVal semaforo As Object, ByVal estadoInfo As EstadoEventArgs)

			' Traduce estado a dia
			Dim dia As String = EstadoADia(estadoInfo.Estado)
			
			' Despliega dia
			Console.WriteLine(dia)
		
		End Sub

		Shared Function EstadoAColor(ByVal estado As Integer) As String
			
			Dim color As String = ""
			
			Select estado
			Case 0
				color = "Rojo"
				' break
			Case 1
				color = "Amarillo"
				' break
			Case Else
				color = "Verde"
				' break
			End Select 

			Return color

		End Function

		Shared Function EstadoADia(ByVal estado As Integer) As String

			Dim dia As String = ""

			Select estado
			Case 0
				dia = "Lunes"
				' break
			Case 1
				dia = "Martes"
				' break
			Case 2
				dia = "Miercoles"
				' break
			Case 3
				dia = "Jueves"
				' break
			Case Else
				dia = "Viernes"
				' break
			End Select 

			Return dia

		End Function

	End Class 

End Namespace
