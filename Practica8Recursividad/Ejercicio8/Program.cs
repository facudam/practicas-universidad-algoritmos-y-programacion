/*
 Escriba una función recursiva que reciba un número y un arreglo de números y retorne la cantidad de veces que dicho número aparece en el arreglo.
 */
using System;
using System.Collections;

namespace Ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList listaNumeros = new ArrayList();
			listaNumeros.Add(1);
			listaNumeros.Add(23);
			listaNumeros.Add(10);
			listaNumeros.Add(5);
			listaNumeros.Add(10);
			
			Console.WriteLine("Veces vistas: " + cantidadDeVecesDeNumero_En_(10, listaNumeros));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static int cantidadDeVecesDeNumero_En_(int numero, ArrayList listaDeNumeros, int posActual = 0, int vecesVisto = 0)
		{
			int numeroASumar;
			
			if ((int)listaDeNumeros[posActual] == numero) {
				numeroASumar = 1;
			} else {
				numeroASumar = 0;
			}
			
			if (posActual == (listaDeNumeros.Count - 1)) {
				return vecesVisto + numeroASumar;
			}
			
			return cantidadDeVecesDeNumero_En_(numero, listaDeNumeros, posActual + 1, vecesVisto + numeroASumar);
		}
	}
}