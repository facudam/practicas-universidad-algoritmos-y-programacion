
using System;

namespace Ejercicio3.clases
{
	public class Person
	{
		
		
		public Person(string nombre, DateTime fechaNacimiento, string dni) {
			this.nombre = nombre;
			this.fechaNacimiento = fechaNacimiento;
			this.dni = dni;
		}
		
		private string nombre;
		private DateTime fechaNacimiento;
		private string dni;
		
		DateTime fechaActual = DateTime.Now; // No se utiliza el new.
		
		public void ImprimirEdad() {
			int edad = fechaActual.Year - fechaNacimiento.Year;
			if (DateTime.Compare(fechaActual, fechaNacimiento.AddYears(edad)) < 0) { // DateTime.Compare devuelve un negativo si la primer fecha es menor a la segunda, un 0 si son iguales y un positivo si es mayor.
				// .AddYears añade años a la fecha que la llame. Para quitar años como argumento le pasamos un numero negativo.
				edad--;
			    }
			Console.WriteLine("{0} tiene {1} años", nombre, edad);
		}
	}
}
