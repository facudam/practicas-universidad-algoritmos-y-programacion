/*
 	Escriba una función recursiva que reciba un arreglo de números y devuelva el promedio. 
 */
using System;

namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] arreglo = {1,3,5,4,8};
		
			Console.WriteLine(calcularPromedio(arreglo));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static double calcularPromedio(int[] arreglo, int indice = 0)
		{
		    if (indice == arreglo.Length - 1)
		        return arreglo[indice] / (double)arreglo.Length;
		    
		    return (arreglo[indice] / (double)arreglo.Length) + calcularPromedio(arreglo, indice + 1);
		}
		
	}
}