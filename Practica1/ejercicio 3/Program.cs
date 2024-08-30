/*
Escriba un programa de aplicación que calcule la suma de dos números reales introducidos por teclado y muestre el resultado en la consola.     
Ayuda: utilice double.Parse(st) para obtener el valor real del string st.
 */
using System;

namespace ejercicio_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			double primerNumero, segundoNumero, resultado;
			Console.WriteLine("Ingrese el primer numero. Si el número no es entero ingréselo con un punto en lugar de una coma. Ej: 1.23");
			primerNumero = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el segundo numero. Si el número no es entero ingréselo con un punto en lugar de una coma. Ej: 1.23");
			segundoNumero = double.Parse(Console.ReadLine());
			resultado = primerNumero + segundoNumero;
			Console.WriteLine("La suma es: {0}", resultado);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}