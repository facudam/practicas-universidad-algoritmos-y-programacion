/*
 Escriba un programa de aplicación que lea por teclado una secuencia de números y que imprima el valor máximo, el  valor mínimo de dicho conjunto y el valor promedio.
 */
using System;

namespace ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			double sumaTotal = 0, numeroIngresado, mayorNumero = double.MinValue, menorNumero = double.MaxValue;
			int cantidadDeNumerosIngresados = 0;
			string caracterCentinela = " ";
			
			while (caracterCentinela != "F" && caracterCentinela != "f") {
				Console.WriteLine("Ingrese un numero");
				numeroIngresado = double.Parse(Console.ReadLine());
				
				sumaTotal = sumaTotal + numeroIngresado;
				
				if(numeroIngresado > mayorNumero) {
					mayorNumero = numeroIngresado;
				}
				if(numeroIngresado < menorNumero) {
					menorNumero = numeroIngresado;
				}
				cantidadDeNumerosIngresados++;
				
				Console.WriteLine("¿Desea seguir ingresando más números? Para hacerlo oprima 'S'y para terminar oprima 'F'");
				caracterCentinela = Console.ReadLine();
			}
			
			double promedioTotal = sumaTotal / cantidadDeNumerosIngresados;
			
			Console.WriteLine("El numero más grande fue {0}, el más chico fue: {1} y el promedio de todos los numeros ingresados es {2}", mayorNumero, menorNumero, promedioTotal);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}