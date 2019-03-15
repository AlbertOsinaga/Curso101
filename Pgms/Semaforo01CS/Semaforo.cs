/*
 * Semaforo.cs
 * Clase: Semaforo 
 * Created by SharpDevelop.
 * User: LAOS
 * Date: 9/14/2004
 * Time: 9:34 PM
 * 
 */

using System;

namespace CursoApliNet
{
	public class Semaforo
	{
		// Campos privados
		
		private int estado;
		private int segundos;
		private DateTime tmInicio;
		
		
		// Metodos publicos

		public int GetEstado()
		{
			// Calcula tiempo transcurrido
			DateTime ahora = DateTime.Now;
			TimeSpan lapso = ahora.Subtract(tmInicio);

			// Actualiza estado de acuerdo al tiempotranscurrido	
			this.estado = (lapso.Seconds / this.segundos) % 3;

			// Regresa estado			
			return this.estado;
		}
		
		public void SetSegundos(int segundos)
		{
			this.estado = 0;
			this.segundos = segundos;
			this.tmInicio = DateTime.Now;
		}
	}
}
