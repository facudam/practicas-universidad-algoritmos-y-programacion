/*
Derive de la clase Persona definida en la práctica 4 la clase Alumno, agréguele un atributo llamado promedio. Haga accesibles en la clase Alumno los campos definidos en Persona. 
Defina los constructores necesarios. Definir en ambas clases el método polimórfico imprimirDatos() que imprime los datos de una persona o de un alumno según quién sea el objeto receptor.
 */
using System;

namespace Ejercicio1.clases
{
	public class Alumno: Persona
	{
		public Alumno(string nombre, DateTime fechaNacimiento, string dni, double promedio): base(nombre, fechaNacimiento, dni)
		{
			this.promedio = promedio;
		}
		
		private double promedio;
		
		public override void imprimirDatos() {
			base.imprimirDatos();
			Console.WriteLine("Promedio: {0}", promedio);
		}
	}
}
