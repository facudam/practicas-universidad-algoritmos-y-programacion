/*
  Escriba una función recursiva que reciba un string como parámetro y devuelva si es o no palíndromo. 
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(esPalindromo("anita lava la tina"));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static bool esPalindromo(string texto)
		{
		    // Eliminamos espacios y convertimos a minúsculas todas las letras.
		    texto = texto.Replace(" ", "").ToLower();
		
		    // Caso base: si el string tiene menos de dos caracteres, es palíndromo
		    if (texto.Length < 2)
		    {
		        return true;
		    }
		
		    // Verificamos si el primer y último carácter son iguales
		    if (texto[0] != texto[texto.Length - 1])
		    {
		        return false;
		    }
		
		    // Llamamos a la función recursivamente con el string sin el primer y último carácter
		    return esPalindromo(texto.Substring(1, texto.Length - 2));
		}
	}
}