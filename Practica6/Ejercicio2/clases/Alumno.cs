
using System;

namespace Ejercicio2.clases
{
	
	public class Alumno
	{
		private string nombre, apellido;   
		private int legajo;    
		private double promedio;
		 
		public Alumno(string nombre, string apellido, int legajo, double promedio)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.legajo = legajo;
			this.promedio = promedio;
		}
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
		
		public string Apellido {
			get { return apellido; }
			set { apellido = value; }
		}
		
		public int Legajo {
			get { return legajo; }
			set { legajo = value; }
		}
		
		public double Promedio {
			get { return promedio; }
			set { promedio = value; }
		}
	}
}
