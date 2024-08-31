/*
 Escriba un programa de aplicación que solicite al usuario ingresar su nombre y apellido, su edad y su dni e imprima en la consola los datos formateados: 
 Nombre y Apellido: nomyape (edad), DNI: nro de dni 
 */
using System;

namespace ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre, apellido;
			int edad, dni;
			Console.WriteLine("Ingrese su nombre por favor");
			nombre = Console.ReadLine();
			Console.WriteLine("Ahora ingrese su apellido");
			apellido = Console.ReadLine();
			Console.WriteLine("Ingrese su edad");
			edad = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese su dni");
			dni = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Nombre y apellido: {0} {1} ({2}), DNI: {3}", nombre, apellido, edad, dni);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}