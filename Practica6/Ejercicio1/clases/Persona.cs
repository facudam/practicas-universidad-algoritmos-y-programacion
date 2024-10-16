/*
Derive de la clase Persona definida en la práctica 4 la clase Alumno, agréguele un atributo llamado promedio. Haga accesibles en la clase Alumno los campos definidos en Persona. 
Defina los constructores necesarios. Definir en ambas clases el método polimórfico imprimirDatos() que imprime los datos de una persona o de un alumno según quién sea el objeto receptor.
 */
using System;

namespace Ejercicio1.clases
{
	public class Persona
	{
		public Persona(string nombre, DateTime fechaNacimiento, string dni) {
			this.nombre = nombre;
			this.fechaNacimiento = fechaNacimiento;
			this.dni = dni;
			this.edad = obtenerEdad();
		}
		
		protected string nombre;
		protected DateTime fechaNacimiento;
		protected string dni;
		protected int edad;
		
		// Definimos las propiedades:
		
		public int Edad {
			get { return obtenerEdad(); } //Así calculamos la edad cada vez que la llamamos.
		}
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
		
		public DateTime FechaNacimiento {
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}
		
		public string Dni {
			get { return dni; }
			set { dni = value; }
		}
		
		protected int obtenerEdad() {
			DateTime fechaActual = DateTime.Now; // No se utiliza el new.
			int edadDePersona = fechaActual.Year - fechaNacimiento.Year;
			if (DateTime.Compare(fechaActual, fechaNacimiento.AddYears(edadDePersona)) < 0) { // DateTime.Compare devuelve un negativo si la primer fecha es anterior a la segunda, un 0 si son iguales y un positivo si es posterior.
				// .AddYears añade años a la fecha que la llame. Para quitar años como argumento le pasamos un numero negativo.
				edadDePersona--;
			    }
			return edadDePersona;
		}
		
		public virtual void imprimirDatos() {
			Console.WriteLine("Nombre: {0}\nEdad: {1}\nFecha de nacimiento: {2}\nDNI: {3}", nombre, edad, fechaNacimiento, dni);
		}
	}
}
