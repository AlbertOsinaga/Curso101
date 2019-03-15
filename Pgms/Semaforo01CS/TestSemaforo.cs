/*
 * TestSemaforo.cs
 * Created by SharpDevelop.
 * User: LAOS
 * Date: 9/14/2004
 * Time: 10:15 PM
 * 
 */

using System;
using System.Threading;

namespace CursoApliNet
{
	public class Principal
	{
		static void Main(string[] args)
		{
			// Comprueba tres argumentos
			if(args.Length < 3)
			{
				Console.WriteLine();
				Console.WriteLine("Forma de uso: test segsSemaforo segsConsulta segsFuncionando");
				return;
			}
		
			// Obtiene datos para el programa
			int segsSemaforo = Int32.Parse(args[0]);
			int segsConsulta = Int32.Parse(args[1]);
			int segsFuncionando = Int32.Parse(args[2]);
			
			// Creacion de semaforo e inicializacion
			Semaforo smf = new Semaforo();
			smf.SetSegundos(segsSemaforo);
			
			// Puesta en funcionamiento
			Console.WriteLine();
			for(int segs = 0; segs < segsFuncionando; segs += segsConsulta)
			{
				// Traduce estado a color
				string color = EstadoAColor(smf.GetEstado());
					
				// Muestra color
				Console.WriteLine(color);
				
				// Hace parada
				Thread.Sleep(segsConsulta * 1000);
			}
		}
		
		static string EstadoAColor(int estado)
		{
			string color = "";
			switch(estado)
			{
				case 0:
					color = "Rojo";
					break;
				case 1:
					color = "Amarillo";
					break;
				default:
					color = "Verde";
					break;
			}
			
			return color;
		}
	}
}
