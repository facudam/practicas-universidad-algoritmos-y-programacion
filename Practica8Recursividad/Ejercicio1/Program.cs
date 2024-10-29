/*
 Implemente una función recursiva que calcule el factorial de un número n, el cual es pasado por parámetro. 
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine(factorial(5));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int factorial(int n) {
			if (n == 1) {
				return 1;
			} 
			return n * factorial(n - 1);
			
		}
	}
}