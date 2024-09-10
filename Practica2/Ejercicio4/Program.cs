/*
 Haga un programa de aplicación que lea por consola una sucesión de palabras que termina con la palabra vacía. Imprima el porcentaje de palabras que comienzan con ‘s’, 
la longitud de cada palabra leída y el promedio de caracteres por palabra. Ayuda: si st es una variable de tipo string, st.Length devuelve la cantidad de caracteres del string
 */
using System;
using System.Collections;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			ArrayList wordsList = new ArrayList();
			
			Console.WriteLine("Ingrese una palabra. Para terminar sólo presione enter");
			string palabraIngresada = Console.ReadLine();
			int totalCaracteres = 0;
			int cantidadPalabrasComienzanConS = 0;
			
			while (palabraIngresada != "" && palabraIngresada != " ") {
				wordsList.Add(palabraIngresada);
				totalCaracteres += palabraIngresada.Length;
				
				if(palabraIngresada[0] == 's' || palabraIngresada[0] == 'S') {
					cantidadPalabrasComienzanConS += 1;
				}
				
				Console.WriteLine("Ingrese una palabra. Para terminar sólo presione enter");
				palabraIngresada = Console.ReadLine();
			}
			
			double porcentajePalabrasConS = cantidadPalabrasComienzanConS * 100.0 / wordsList.Count;
			double promedioCaracteresPorPalabra = Convert.ToDouble(totalCaracteres) / wordsList.Count;
			
			Console.WriteLine("total caracteres: " + totalCaracteres);
			Console.WriteLine("El porcentaje de palabras que comienzan con S es: {0}%", porcentajePalabrasConS);
			Console.WriteLine("El promedio de caracteres por palabra es: {0}", promedioCaracteresPorPalabra);
			
			foreach(string word in wordsList) {
				Console.WriteLine("La longitud de la palabra {0} es: {1}", word, word.Length);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}