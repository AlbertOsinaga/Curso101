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
		// Metodos publicos

		public override void SetEstados(int estados)
		{
			this.estados = estados;
		}

		public override void Run()
      	{
        	// Inicializa tiempo de funcionamiento
        	this.segsFuncionando = segsFuncionando;
        	
			// Dispara evento estado inicial
   			OnCambioEstado(this.estado);

        	// Corre el semaforo
          	while(this.segsFuncionando > 0)
          	{
             	// Duerme 10 milisegundos
             	Thread.Sleep(10);
           
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
          			this.segsFuncionando -= lapso.Seconds;
          		}
          	}
      	} 
	}
}
