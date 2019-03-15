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
			SemaforoN smf = new SemaforoN();
			smf.SetSegundos(segsSemaforo);
			smf.SetEstados(5);
		
			// Suscripcion al evento cambio estado
			smf.CambioEstado += new CambioEstadoHandler(DespliegaDia);
			
			// Pone en funcionamiento el semaforo
			smf.Run(segsFuncionando);
		}
		
       	static public void DespliegaDia(object semaforo, EstadoEventArgs estadoInfo)
       	{
			// Traduce estado a dia
			string dia = EstadoADia(estadoInfo.Estado);
       		
			// Despliega dia
            Console.WriteLine(dia);  
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
