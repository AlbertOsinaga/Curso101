'
' Semaforo.vb
' Clase: Semaforo 
' Created by SharpDevelop.
' User: LAOS
' Date: 9/14/2004
' Time: 9:34 PM
' 
'

Imports System

Namespace CursoApliNet

	Public Class Semaforo

		' Campos privados
		
		Private estado As Integer
		Private segundos As Integer
		Private tmInicio As DateTime


		' Metodos publicos

		Public Function GetEstado() As Integer
			
			' Calcula tiempo transcurrido
			Dim ahora As DateTime = DateTime.Now
			Dim lapso As TimeSpan = ahora.Subtract(tmInicio)

			' Actualiza estado de acuerdo al tiempotranscurrido	
			Me.estado = (lapso.Seconds / Me.segundos) Mod 3
			
			' Regresa estado			
			Return Me.estado
		
		End Function

		Public Sub SetSegundos(ByVal segundos As Integer)
			Me.estado = 0
			Me.segundos = segundos
			Me.tmInicio = DateTime.Now
		End Sub

	End Class 

End Namespace
