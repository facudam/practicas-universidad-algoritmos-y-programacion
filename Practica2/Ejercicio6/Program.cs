/*
 Defina una función que reciba una palabra y retorne en un vector la cantidad de veces que aparece cada vocal en dicha palabra.  
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] cantidadesDeCadaVocal = new int[5] {0, 0, 0, 0, 0}; // Inicializamos un array con la cantidad de cada vocal encontrada en cero.
			string palabra;
			
			Console.WriteLine("Ingrese una palabra");
			palabra = Console.ReadLine().ToLower(); // Pasamos la palabra a minúscula.
			
			for (int i = 0; i < palabra.Length; i++) {
				switch(palabra[i]) {
					case 'a':
						cantidadesDeCadaVocal[0] += 1;
						break;
					case 'e':
						cantidadesDeCadaVocal[1] += 1;
						break;
					case 'i':
						cantidadesDeCadaVocal[2] += 1;
						break;
					case 'o':
						cantidadesDeCadaVocal[3] += 1;
						break;
					case 'u':
						cantidadesDeCadaVocal[4] += 1;
						break;
					default:
						break;
				}
			}
			
			Console.WriteLine("Cantidad de letras 'A' en '{0}': {1}", palabra, cantidadesDeCadaVocal[0]);
			Console.WriteLine("Cantidad de letras 'E' en '{0}': {1}", palabra, cantidadesDeCadaVocal[1]);
			Console.WriteLine("Cantidad de letras 'I' en '{0}': {1}", palabra, cantidadesDeCadaVocal[2]);
			Console.WriteLine("Cantidad de letras 'O' en '{0}': {1}", palabra, cantidadesDeCadaVocal[3]);
			Console.WriteLine("Cantidad de letras 'U' en '{0}': {1}", palabra, cantidadesDeCadaVocal[4]);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}