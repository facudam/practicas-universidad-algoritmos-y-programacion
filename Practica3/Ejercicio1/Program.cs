/*
 	Escriba un programa de aplicación que ingrese una lista de palabras e informe cuántas de ellas son palíndromos. Utilice una función para verificar si son palíndromos.  
	Ejemplo: [sol, ananá,  carro, perro, sos, ama, cal]   Imprime: ananá, sos, ama
 */
using System;
using System.Collections;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList listaPalabrasIngresadas = new ArrayList();
			ArrayList palabrasIngresadasQueSonPalindromos = new ArrayList();
			string palabraIngresada;
			
			Console.WriteLine("Ingrese palabra a verificar, para finalizar sólo oprima enter");
			palabraIngresada = Console.ReadLine();
			
			while (palabraIngresada.Trim() != "") {
				listaPalabrasIngresadas.Add(palabraIngresada);
				Console.WriteLine("Ingrese palabra a verificar, para finalizar sólo oprima enter");
				palabraIngresada = Console.ReadLine();
			}
			
			palabrasIngresadasQueSonPalindromos = filtrarPalindromos(listaPalabrasIngresadas);
			
			if(palabrasIngresadasQueSonPalindromos.Count > 0) {
				Console.WriteLine("Lista de las palabras que son palíndromos:");
				foreach(string palindromo in palabrasIngresadasQueSonPalindromos) {
					Console.WriteLine(palindromo);
				}
			} else {
				Console.WriteLine("No has ingresado ningún palíndromo");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);			
			
		}
		
		static ArrayList filtrarPalindromos(ArrayList listaPalabras) {
			ArrayList listaDePalindromos = new ArrayList();
			
			foreach(string palabra in listaPalabras) {
				if(verificarPalindromo(palabra)) {
					listaDePalindromos.Add(palabra);
				}
			}
			return listaDePalindromos;
		}
		
		static bool verificarPalindromo(string palabra) {
			bool esPalindromo = true;
			
			int posicion = palabra.Length - 1; 
			
			for (int i = 0; i < palabra.Length; i++) {
				if (palabra[i] != palabra[posicion]) {
					esPalindromo = false;
					break;
				}
				posicion -= 1;
			}
			return esPalindromo;
		}
	}
}