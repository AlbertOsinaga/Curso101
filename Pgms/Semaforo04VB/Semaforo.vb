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
Imports System.Threading

Namespace CursoApliNet

	Public Class Semaforo

		' Campos privados
		Protected estado As Integer
		Protected estados As Integer
		Protected segundos As Integer
		Protected segsFuncionando As Integer
		Protected tmAntes As DateTime


		' Metodos publicos

		Public Overridable Sub Run(ByVal segsFuncionando As Integer)

        	' Inicializa tiempo de funcionamiento
			Me.segsFuncionando = segsFuncionando

			' Inicia nuevo Thread
			Dim hilo As Thread = New Thread (AddressOf Run)
			hilo.Start

		End Sub

		Public Overridable Sub Run()

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

		Public Overridable Sub SetEstados(ByVal estados As Integer)
			Me.estados = 3
		End Sub

		Public Sub SetSegundos(ByVal segundos As Integer)

			' Inicializa variables
			Me.estado = 0
			Me.segundos = segundos
			Me.tmAntes = DateTime.Now
		
		End Sub


		' Eventos publicos

		Public Event CambioEstado As CambioEstadoHandler


      	' Metodos protegidos
      	
		Protected Sub OnCambioEstado(ByVal estado As Integer)

         	' Prepara información para evento
			Dim estadoInfo As EstadoEventArgs = New EstadoEventArgs (estado)
			
         	' Dispara evento
			RaiseEvent CambioEstado(Me, estadoInfo)
		
		End Sub

	End Class 

	Public Class EstadoEventArgs
		Inherits EventArgs

    	' Constructor
		Public Sub New(ByVal estado As Integer)
			Me.m_estado = estado
		End Sub

      	' propiedades de instancia
		Public ReadOnly Property Estado() As Integer
			Get
				Return Me.m_estado
			End Get
		End Property

      	' Campos de instancia
		Private m_estado As Integer

	End Class 

	' Definición del delegate para manejar cambio de estado
	Public Delegate Sub CambioEstadoHandler(ByVal semaforo As Object, ByVal estado As EstadoEventArgs)

End Namespace
