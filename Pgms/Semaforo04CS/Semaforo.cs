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
using System.Threading;

namespace CursoApliNet
{
	public class Semaforo
	{
		// Campos privados
		protected int estado;
		protected int estados;
		protected int segundos;
		protected int segsFuncionando;
		protected DateTime tmAntes;
		

		// Metodos publicos

		public virtual void Run(int segsFuncionando)
      	{
        	// Inicializa tiempo de funcionamiento
        	this.segsFuncionando = segsFuncionando;

			// Inicia nuevo Thread
			Thread hilo = new Thread(new ThreadStart(Run));
      		hilo.Start();
      	} 

		public virtual void Run()
      	{
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

		public virtual void SetEstados(int estados)
		{
			this.estados = 3;
		}

		public void SetSegundos(int segundos)
		{
			// Inicializa variables
			this.estado = 0;
			this.segundos = segundos;
			this.tmAntes = DateTime.Now;
		}

		
		// Eventos publicos
      	
      	public event CambioEstadoHandler CambioEstado;
		
      	
      	// Metodos protegidos
      	
      	protected void OnCambioEstado(int estado)
      	{
         	// Prepara información para evento
         	EstadoEventArgs estadoInfo = new EstadoEventArgs(estado);
         
         	// Dispara evento
         	if(CambioEstado != null)
         	{
            	CambioEstado(this, estadoInfo);
         	}	 
      	} 
	}

   	public class EstadoEventArgs : EventArgs
   	{
    	// Constructor
      	public EstadoEventArgs(int estado)
      	{
         	this.estado = estado;
      	}


      	// propiedades de instancia
      	public int Estado
      	{
        	get { return this.estado; }
      	} 

      	// Campos de instancia
      	private int estado;
   }      

	// Definición del delegate para manejar cambio de estado
    public delegate void CambioEstadoHandler(object semaforo, EstadoEventArgs estado);
}
