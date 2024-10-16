/*
 Derive de la clase Persona definida en la práctica 4 la clase Alumno, agréguele un atributo llamado promedio. Haga accesibles en la clase Alumno los campos definidos en Persona. Defina los constructores necesarios. 
 Definir en ambas clases el método polimórfico imprimirDatos() que imprime los datos de una persona o de un alumno según quién sea el objeto receptor.
 */
using System;
using Ejercicio1.clases;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Persona persona = new Persona("Agustín", new DateTime(1995,12,10), "39125373");
			Alumno alumno = new Alumno("Damián", new DateTime(1990, 3,21), "42158023", 8.3);
			
			persona.imprimirDatos();
			alumno.imprimirDatos();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}