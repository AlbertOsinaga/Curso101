/*
 * TestSemaforo.cs
 * Created by SharpDevelop.
 * User: LAOS
 * Date: 9/14/2004
 * Time: 10:15 PM
 * 
 */

using System;

namespace CursoApliNet
{
	public class Principal
	{
		static void Main(string[] args)
		{
			// Comprueba dos argumentos
			if(args.Length < 2)
			{
				Console.WriteLine();
				Console.WriteLine("Forma de uso: test segsSemaforo segsFuncionando");
				return;
			}
		
			// Obtiene datos para el programa
			int segsSemaforo = Int32.Parse(args[0]);
			int segsFuncionando = Int32.Parse(args[1]);
			
			// Creacion de semaforo e inicializacion
			Semaforo smf = new Semaforo();
			smf.SetSegundos(segsSemaforo);
		
			// Suscripcion al evento cambio estado
			smf.CambioEstado += new CambioEstadoHandler(DespliegaColor);
			
			// Pone en funcionamiento el semaforo
			smf.Run(segsFuncionando);
		}
		
       	static public void DespliegaColor(object semaforo, EstadoEventArgs estadoInfo)
       	{
			// Traduce estado a color
			string color = EstadoAColor(estadoInfo.Estado);
       		
			// Despliega color
            Console.WriteLine(color);  
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
