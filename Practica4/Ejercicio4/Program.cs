/*
 Agregue a la clase Persona un método esMayorQue(Persona p) que devuelva verdadero si la persona que recibe el mensaje es más grande que la persona recibida como parámetro. 
 Utilícelo para realizar un programa de aplicación (Main) que al recibir los datos de 2 personas imprima el nombre y el dni del menor.
 */
using System;
using Ejercicio4.clases;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			DateTime fecha1 = new DateTime(2003, 10, 15);
			Person hombre = new Person("Carlos", fecha1, "45098123");
			
			DateTime fecha2 = new DateTime(2001, 04, 26);
			Person mujer = new Person("Monica", fecha2, "46134654");
			
			imprimirNombreYDniEntre_Y_(hombre, mujer);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void imprimirNombreYDniEntre_Y_(Person persona1, Person persona2) {
			if(persona1.esMayorQue(persona2)) {
				Console.WriteLine("El nombre del menor es: {0} y su dni es: {1}", persona2.Nombre, persona2.Dni);
			} else {
				Console.WriteLine("El nombre del menor es: {0} y su dni es: {1}", persona1.Nombre, persona1.Dni);
			}
		}
		
	}
	
}