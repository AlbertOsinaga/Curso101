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

		' Metodos publicos
		
		Public Overloads Overrides Sub SetEstados(ByVal estados As Integer)
			Me.estados = estados
		End Sub

		Public Overloads Overrides Sub Run()

        	' Inicializa tiempo de funcionamiento
			Me.segsFuncionando = segsFuncionando
			
			' Dispara evento estado inicial
			OnCambioEstado(Me.estado)
			
        	' Corre el semaforo
			While Me.segsFuncionando > 0
				
             	' Duerme 10 milisegundos
				Thread.Sleep(10)
				
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
					Me.segsFuncionando -= lapso.Seconds
				
				End If
			
			End While

		End Sub

	End Class 

End Namespace
