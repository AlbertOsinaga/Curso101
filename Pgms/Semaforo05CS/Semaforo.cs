using System;
using System.Threading;

namespace CursoApliNet
{
	public class Semaforo
	{
		// Campos privados
		
		private bool _ascendente;
		private bool _circular;
		private int _estado;
		private int _estados;
		private int _incremento;
		private int _segs;
		private int _vueltas;
		protected DateTime _tmAntes;
		

		
		// Constructores
		
		public Semaforo()
		{
			_ascendente = true;
			_circular = false;
			_estado = 0;
			_estados = 3;
			_incremento = 1;
			_segs = 1;
			_vueltas = 10;
		}

		
		
		// Propiedades

		public bool Ascendente
		{
			get { return _ascendente; }
			set 
			{ 
				_ascendente = value; 
				if(_ascendente)
					_incremento = 1;
				else
					_incremento = -1;
			}
		}

		public bool Circular
		{
			get { return _circular; }
			set { _circular = value; }
		}

		public int Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}

		public int Estados
		{
			get { return _estados; }
			set { _estados = value; }
		}

		public int SegundosPorEstado
		{
			get { return _segs; }
			set { _segs = value; }
		}

		public int Vueltas
		{
			get { return _vueltas; }
			set { _vueltas = value; }
		}
			
			
		
		// Metodos publicos

		public virtual void Run()
		{
			Run(_vueltas);
		}

		public virtual void Run(int vueltas)
		{
			// Inicializa vueltas
			_vueltas = vueltas;

			// Inicia nuevo Thread
			Thread hilo = new Thread(new ThreadStart(RunThread));
			hilo.Start();
		} 

		public virtual void RunThread()
		{
			// Inicializa semaforo
			_tmAntes = DateTime.Now;
			
			// Dispara evento estado inicial
			bool cancel = false;
			OnCambioEstado(_estado, out cancel);

			// Verifica cancelacion 
			if(cancel)
				return;

			// Corre el semaforo
			for(int i = 0; i < _vueltas * _estados; )
			{
				// Duerme 10 milisegundos
				Thread.Sleep(10);
           
				// Calcula segundos transcurridos
				DateTime ahora = DateTime.Now;
				TimeSpan lapso = ahora.Subtract(_tmAntes);
				
				// Si segs transcurridos es mayor o igual que segs semaforo
				if(lapso.Seconds >= _segs)
				{
					i++;

					// cambia estado
					CambiaEstado();

					// Dispara evento
					OnCambioEstado(_estado, out cancel);

					// Verifica cancelacion 
					if(cancel)
						return;

					// Actualiza hora
					_tmAntes = ahora;
				}
			}
		} 


		
		// Metodos privados
      	
		protected void CambiaEstado()
		{
			// Cambia estado
			_estado += _incremento;

			// Chequea limite inferior
			if(_estado < 0)
			{
				if(_circular)
					_estado = _estados - 1;
				else
				{
					_estado = 1;
					_incremento *= -1;
				}
			}

			// Chequea limite superior
			if(_estado >  _estados - 1)
			{
				if(_circular)
					_estado = 0;
				else
				{
					_estado = _estados - 2;
					_incremento *= -1;
				}
			}
		}

		protected void OnCambioEstado(int estado, out bool cancel)
		{
			// Dispara evento
			cancel = false;
			if(CambioEstado != null)
			{
				CambioEstado(this, estado, out cancel);
			}	 
		} 

		
		
		// Eventos publicos
      	
		public event CambioEstadoHandler CambioEstado;
	}

	// Definición del delegate para manejar cambio de estado
	public delegate void CambioEstadoHandler(object semaforo, int estado, out bool cancel);
}
