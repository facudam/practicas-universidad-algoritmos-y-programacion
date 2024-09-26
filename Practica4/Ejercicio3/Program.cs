/*
Modifique la clase anterior agregando un campo privado FechaNacimiento. Defina un nuevo constructor que reciba como parámetro el nombre, la fecha de nacimiento (un DateTime) y el dni. 
En base a la fecha de nacimiento y la fecha actual debe calcular y guardar la edad.
 */
using System;
using Ejercicio3.clases;

namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			DateTime fecha1 = new DateTime(2000, 10, 15);
			Person hombre = new Person("Carlos", fecha1, "45098123");
			
			hombre.ImprimirEdad();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}