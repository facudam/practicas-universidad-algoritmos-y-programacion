
using System;
using System.Collections;

namespace Ejercicio2.clases
{
	public class Coordinador: Profesor
	{
		private string area; 
		
		public Coordinador(int cupoDisponible, string materia, string area): base(cupoDisponible, materia)
		{
			this.area = area;
		}
		
		public string Area {
			get { return area; }
			set { area = value; }
		}
	}
}
