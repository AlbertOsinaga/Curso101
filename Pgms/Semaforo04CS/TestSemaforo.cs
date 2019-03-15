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
			
			// Creacion de semaforos color y dia e inicializacion
			Semaforo smfColor = new Semaforo();
			Semaforo smfDias = new SemaforoN();
			smfColor.SetSegundos(segsSemaforo);
			smfDias.SetSegundos(segsSemaforo);
			smfColor.SetEstados(3);
			smfDias.SetEstados(5);
		
			// Suscripcion al evento cambio estado
			smfColor.CambioEstado += new CambioEstadoHandler(DespliegaColor);
			smfDias.CambioEstado += new CambioEstadoHandler(DespliegaDia);
			
			// Pone en funcionamiento los semaforos
			smfColor.Run(segsFuncionando);
			smfDias.Run(segsFuncionando);
		}
		
       	static public void DespliegaColor(object semaforo, EstadoEventArgs estadoInfo)
       	{
			// Traduce estado a color
			string color = EstadoAColor(estadoInfo.Estado);
       		
			// Despliega color
            Console.WriteLine(color);  
       	}     
		
       	static public void DespliegaDia(object semaforo, EstadoEventArgs estadoInfo)
       	{
			// Traduce estado a dia
			string dia = EstadoADia(estadoInfo.Estado);
       		
			// Despliega dia
            Console.WriteLine(dia);  
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

		static string EstadoADia(int estado)
		{
			string dia = "";
			switch(estado)
			{
				case 0:
					dia = "Lunes";
					break;
				case 1:
					dia = "Martes";
					break;
				case 2:
					dia = "Miercoles";
					break;
				case 3:
					dia = "Jueves";
					break;
				default:
					dia = "Viernes";
					break;
			}
			
			return dia;
		}
	}
}
