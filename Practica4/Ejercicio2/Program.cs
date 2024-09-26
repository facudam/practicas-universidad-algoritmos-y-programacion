/*
 Defina la clase Persona con 3 campos: Nombre, Edad y DNI. En el constructor utilice parámetros cuyos nombres coincidan con las variables de instancia del objeto (usar this).  
 Definir un método que permita imprimir los datos de la persona con el siguiente formato: Nombre (Edad) <TAB> DNI. Ejemplo:  Juan Perez (40)  2098745
 */
using System;
using Ejercicio2.clases;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Persona persona1 = new Persona("Juan", 23, "39456521");
			
			persona1.showData();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}