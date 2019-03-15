/*
 * SemaforoN.cs
 * Clase: SemaforoN 
 * Created by SharpDevelop.
 * User: LAOS
 * Date: 9/14/2004
 * Time: 9:34 PM
 * 
 */

using System;
using System.Threading;

namespace CursoApliNet
{
	public class SemaforoN : Semaforo
	{
		// Campos privados
		protected int estados;
		
		// Metodos publicos

		public void SetEstados(int estados)
		{
			this.estados = estados;
		}

		public void Run(int segsFuncionando)
      	{
        	// Inicializa tiempo de funcionamiento
        	int segsToStop = segsFuncionando;
        	

			// Dispara evento estado inicial
   			OnCambioEstado(this.estado);

        	// Corre el semaforo
          	while(segsToStop > 0)
          	{
             	// Duerme 0.1 segundos
             	Thread.Sleep(100);
           
				// Calcula segundos transcurridos
				DateTime ahora = DateTime.Now;
				TimeSpan lapso = ahora.Subtract(tmAntes);
				
				// Si segs transcurridos es mayor o igual que segs semaforo
          		if(lapso.Seconds >= this.segundos)
          		{
				     // cambia estado y dispara evento
          			this.estado++;
          			this.estado = this.estado % this.estados;
          			OnCambioEstado(this.estado);

             		// Actualiza hora
             		tmAntes = ahora;

          			// Actualiza limite de funcionamiento
          			segsToStop -= lapso.Seconds;
          		}
          	}
      	} 
	}
}
