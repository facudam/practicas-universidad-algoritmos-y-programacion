/*
 Implemente un programa de aplicación que permita al usuario ingresar por consola una sucesión de números que finaliza con un 0. 
 Informar al final del proceso cuál es la cantidad total de números ingresados y el porcentaje de números mayores a 10 de la sucesión.
 */
using System;

namespace ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int numeroIngresado = 1, 
			totalNumerosIngresados = 0, 
			cantidadNumerosMayoresA10 = 0;
			
			while (numeroIngresado != 0) {
				Console.WriteLine("Ingrese un número entero, para finalizar ingrese el número 0");
				numeroIngresado = int.Parse(Console.ReadLine());
				
				if (numeroIngresado > 10) {
					cantidadNumerosMayoresA10++;
				}
				if (numeroIngresado != 0) {
					totalNumerosIngresados++;
				}
				
			}
			
			double porcentajeMayorA10 = (cantidadNumerosMayoresA10 * 100.0) / totalNumerosIngresados; // Colocamos 100.0 para que C# muestre los decimales.
			Console.WriteLine("La cantidad total de números ingresados son: {0}, y el porcentaje de números mayores a 10 es: {1}%", totalNumerosIngresados, porcentajeMayorA10);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}