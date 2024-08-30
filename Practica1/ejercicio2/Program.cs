/*
 Escriba un programa de aplicación que ingrese el nombre y la edad de dos personas y determine quién es mayor. 
 */
using System;

namespace ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombrePersona1, nombrePersona2;
			int edad1, edad2;
			
			Console.WriteLine("Ingrese el nombre de la primer persona");
			nombrePersona1 = Console.ReadLine();
			Console.WriteLine("Ingrese su edad");
			edad1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el nombre de la segunda persona");
			nombrePersona2 = Console.ReadLine();
			Console.WriteLine("Ingrese su edad");
			edad2 = int.Parse(Console.ReadLine());
			
			if (edad1 > edad2) {
				Console.WriteLine("{0} es mayor que {1}", nombrePersona1, nombrePersona2);
			} else if (edad2 > edad1) {
				Console.WriteLine("{0} es mayor que {1}", nombrePersona2, nombrePersona1);
			} else {
				Console.WriteLine("{0} y {1} tienen la misma edad", nombrePersona1, nombrePersona2);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}