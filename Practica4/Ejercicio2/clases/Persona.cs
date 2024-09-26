
using System;

namespace Ejercicio2.clases
{
	
	public class Persona
	{
		public Persona(string nombre, int edad, string dni)
		{
			this.nombre = nombre;
			this.edad = edad;
			this.dni = dni;
		}
		private string nombre;
		private int edad;
		private string dni;
		
		public void showData() {
			Console.WriteLine("{0} ({1})  {2}", nombre, edad, dni);
		}
		
	}
}
