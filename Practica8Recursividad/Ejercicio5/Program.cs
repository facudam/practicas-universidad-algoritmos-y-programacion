/*
 Escriba una función recursiva que reciba un arreglo de strings y devuelva la longitud promedio de los mismos.
 */
using System;

namespace Ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			string [] arrStrings = { "programando", "con", "recursividad" };
			
			Console.WriteLine("La longitud promedio del arreglo de strings es: " + calcularLongitudPromedio(arrStrings));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static double calcularLongitudPromedio(string [] arregloStrings, int posActual = 0) {
			if (posActual == arregloStrings.Length - 1) {
				return arregloStrings[posActual].Length / (double)arregloStrings.Length;
			}
			
			return arregloStrings[posActual].Length / (double)arregloStrings.Length + calcularLongitudPromedio(arregloStrings, posActual + 1);
		}
	}
}