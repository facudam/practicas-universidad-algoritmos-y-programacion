/*
 Escriba una función recursiva que reciba un string y retorne la cantidad de letras ‘c’ que contiene.
 */
using System;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(cantidadDeLetrasCEn("Facundo Cáceres"));
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int cantidadDeLetrasCEn(string palabra, int posActual = 0) {
			palabra = palabra.ToLower();
			
			if (posActual == palabra.Length - 1) {
				if (palabra[posActual] == 'c') return 1;
				return 0;
			}
			
			if (palabra[posActual] == 'c') {
				return 1 + cantidadDeLetrasCEn(palabra, posActual + 1);
			} 
			
			return 0 + cantidadDeLetrasCEn(palabra, posActual + 1);
			
		}
	}
}