
using System;

namespace Ejercicio3.clases
{
	public class Person
	{
		
		
		public Person(string nombre, DateTime fechaNacimiento, string dni) {
			this.nombre = nombre;
			this.fechaNacimiento = fechaNacimiento;
			this.dni = dni;
			this.edad = obtenerEdad();
		}
		
		private string nombre;
		private DateTime fechaNacimiento;
		private string dni;
		private int edad;
		
		private int obtenerEdad() {
			DateTime fechaActual = DateTime.Now; // No se utiliza el new.
			int edadDePersona = fechaActual.Year - fechaNacimiento.Year;
			if (DateTime.Compare(fechaActual, fechaNacimiento.AddYears(edadDePersona)) < 0) { // DateTime.Compare devuelve un negativo si la primer fecha es anterior a la segunda, un 0 si son iguales y un positivo si es posterior.
				// .AddYears añade años a la fecha que la llame. Para quitar años como argumento le pasamos un numero negativo.
				edadDePersona--;
			    }
			return edadDePersona;
		}
		
		public void ImprimirLaEdad() {
			Console.WriteLine("{0} tiene {1} años", nombre, edad);
		}
		
	}
}
