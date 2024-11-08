/*
 Sea la siguiente colección de elementos:{ 12 3 8 6 2 9 10 -3 0 5 }
 Ordene manualmente la colección utilizando los métodos: a) Por intercambio b) Por selección c) Por burbuja 
 Aclaración: Realice la ordenamiento paso por paso siguiendo como guía los ejemplos proporcionados en el material de teoría. Compruebe el resultado en los 3 casos. 
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] numeros = new int[] {3,1,7,8,6,0, -10};
			int[] listaNum = new int[] {90,34,15,37,82,1,99};
			int[] otraLista = new int[] {45,1,67,38,22,-1,44};
			ordenarPorIntercambio(ref numeros);
			ordenarPorSeleccion(ref listaNum);
			ordenamientoPorBurbuja(ref otraLista);
			foreach(int num in otraLista) {
				Console.WriteLine(num);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void ordenarPorIntercambio(ref int[] datos)
		{ 	
			int n = datos.Length;
			for(int i=0; i<(n-1); i++) {
				for(int j=i+1; j<n; j++) {
					if(datos[i] > datos[j]) { 
						int swap = datos[i];  
						datos[i] = datos[j]; 
						datos[j] = swap; } 
				}
			}		
		}
		
		public static void ordenarPorSeleccion(ref int[] datos)
		{
			int n = datos.Length;
			for(int i = 0; i < (n-1); i++) {
				int menor = i;
				for(int j=i+1; j<n; j++) {
					if(datos[j] < datos[menor]) {
						menor = j;
					}
				}
				if(menor != i) {
					int swap = datos[i];
					datos[i] = datos[menor];
					datos[menor] = swap;
				}
			}
		}
		
		public static void ordenamientoPorBurbuja(ref int[] datos) {
			int n = datos.Length;
			int i = 0;
			bool ordenado = false;
			
			while((i<(n-1)) && !ordenado) {
				ordenado = true;
				for(int j=0; j<(n-1-i); j++) {
					if(datos[j] > datos[j+1]) {
						ordenado = false;
						int swap = datos[j];
						datos[j] = datos[j+1];
						datos[j+1] = swap;
					}
				}
			}
		}
					
	}
}