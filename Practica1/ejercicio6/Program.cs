/*
 Escriba un programa de aplicación que imprima en la consola todos los números impares del intervalo [40,352] que además sean múltiplos de 3.
 */
using System;

namespace ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int numeros = 40;
			
			while (numeros != 353) {
				if ((numeros % 2) != 0 && (numeros % 3) == 0) {
					Console.WriteLine(numeros);
				}
				numeros++;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}