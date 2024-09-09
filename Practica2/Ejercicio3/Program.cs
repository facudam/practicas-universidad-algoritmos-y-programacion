/*
	Escriba un programa de aplicación que lea 2 palabras y determine si son palíndromos entre ellas.  (Ej: “abbccd” y “dccbba” son palíndromos).   
 */
using System;

namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingrese la primera palabra");
			string firstWord = Console.ReadLine();
			Console.WriteLine("Ingrese la segunda palabra");
			string secondWord = Console.ReadLine();
			
			bool isPalindrome = true;
			
			if (firstWord.Length == secondWord.Length) {
				int letterPositionToCompare = firstWord.Length - 1;
				for (int i = 0; i < firstWord.Length; i++) {
					if (firstWord[i] != secondWord[letterPositionToCompare]) {
						isPalindrome = false;
						break;
					} else {
						letterPositionToCompare -= 1;
					}
				}
			} else {
				isPalindrome = false;
			}
			
			Console.WriteLine("¿Las dos palabras son palíndromos?: " + isPalindrome);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}