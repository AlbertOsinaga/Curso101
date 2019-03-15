'
' SemaforoN.vb
' Clase: SemaforoN 
' Created by SharpDevelop.
' User: LAOS
' Date: 9/14/2004
' Time: 9:34 PM
' 
'

Imports System
Imports System.Threading

Namespace CursoApliNet

	Public Class SemaforoN
		Inherits Semaforo
		
		' Campos privados
		Protected estados As Integer


		' Metodos publicos
		
		Public Sub SetEstados(ByVal estados As Integer)
			Me.estados = estados
		End Sub

		Public Overrides Sub Run(ByVal segsFuncionando As Integer)

        	' Inicializa tiempo de funcionamiento
			Dim segsToStop As Integer = segsFuncionando

			' Dispara evento estado inicial
			OnCambioEstado(Me.estado)

        	' Corre el semaforo
			While segsToStop > 0

             	' Duerme 0.1 segundos
				Thread.Sleep(100)

				' Calcula segundos transcurridos
				Dim ahora As DateTime = DateTime.Now
				Dim lapso As TimeSpan = ahora.Subtract(tmAntes)
				
				' Si segs transcurridos es mayor o igual que segs semaforo
				If lapso.Seconds >= Me.segundos Then

				    ' cambia estado y dispara evento
					Me.estado += 1
					Me.estado = Me.estado Mod Me.estados
					OnCambioEstado(Me.estado)

             		' Actualiza hora
					tmAntes = ahora

          			' Actualiza limite de funcionamiento
					segsToStop -= lapso.Seconds

				End If

			End While

		End Sub

	End Class 

End Namespace
