
using System;

namespace Ejercicio1.clases
{
	
	public class Hora
	{
		public Hora(int hora, int minutos, int segundos)
		{
			this.hora = hora;
			this.minutos = minutos;
			this.segundos = segundos;
		}
		
		private int hora;
		private int minutos;
		private int segundos;
		
		public void imprimir() {
			Console.WriteLine("{0} HORAS, {1} MINUTOS Y {2} SEGUNDOS", hora, minutos, segundos);
		}
	}
}
