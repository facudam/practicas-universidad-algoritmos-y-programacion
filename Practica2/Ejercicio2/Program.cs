/*
 Analice la siguiente porción de código para calcular la sumatoria de 1 a 10. ¿Cuál es el error? ¿Qué hace realmente? ¿Cómo se resuelve? 
	int sum=0; int i=1; 
	while (i<=10);
		{ sum += i++; }
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int sum = 0; int i = 1;
			while (i<=10)//; Esta coma no va acá
			{
				sum += i++;
				Console.WriteLine("Valor de sum: " + sum);
				Console.WriteLine("Valor de i: " + i);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}