
using System;

namespace Ejercicio2.clases
{
	public class Coordinador: Profesor
	{
		private string area; 
		
		public Coordinador(string materia, int cupoDisponible, string area): base(materia, cupoDisponible)
		{
			this.area = area;
		}
		
		public string Area {
			get { return area; }
			set { area = value; }
		}
	}
}
