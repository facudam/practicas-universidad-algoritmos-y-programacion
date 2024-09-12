/*
 Implemente un programa de aplicación que simule el funcionamiento de una calculadora que permita al usuario realizar las cuatro operaciones elementales e imprimir el resultado 
de la operación. Para ello el programa principal (MAIN) debe mostrar un menú de opciones con cada una de las operaciones, luego de seleccionar la operación el programa pide 
ingresar dos números y para realizar la operación solicitada invoca a la función correspondiente.  Luego de obtenido el resultado, el programa principal lo imprime.  
 El usuario debe poder realizar tantas operaciones como desee hasta seleccionar una opción de salida.  Observación: el MAIN es quien pide los datos e informa los resultados. 
Cada operación se resuelve con una función que es invocada desde el MAIN.  Los datos deben pasarse como parámetros. En el caso de la operación de división el MAIN debe verificar 
que pueda llevarse a cabo (que el denominador sea no nulo) antes de invocar a la función.
 */
using System;

namespace Ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			int choice, firstNumber, secondNumber;
			
			Console.WriteLine("Elija el tipo de operación a realizar");
			Console.WriteLine("1- Suma. \n2- Resta. \n3- Multiplicación. \n4- División. \n5- Terminar");
			choice = int.Parse(Console.ReadLine());
			
			
			
			while(choice >= 0 && choice <= 4) {
				Console.WriteLine("Ingrese el primer número");
				firstNumber = int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese el segundo número");
				secondNumber = int.Parse(Console.ReadLine());
				
				switch(choice) {
					case 1:
						Console.WriteLine("El resultado es: " +  sumar(firstNumber, secondNumber));
						break;
					case 2:
						Console.WriteLine("El resultado es: " +  restar(firstNumber, secondNumber));
						break;
					case 3:
						Console.WriteLine("El resultado es: " +  multiplicar(firstNumber, secondNumber));
						break;
					case 4:
						if (secondNumber != 0) {
							Console.WriteLine("El resultado es: " +  dividir(firstNumber, secondNumber));
						} else {
							Console.WriteLine("No se puede realizar una división por cero");
						}
						break;
					default:
						Console.WriteLine("Gracias");
						break;
				}
				Console.WriteLine("¿Quiere seguir realizando operaciones? Elija el tipo de operación a realizar o finalice.");
				Console.WriteLine("1- Suma. \n2- Resta. \n3- Multiplicación. \n4- División. \n5- Terminar");
				choice = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine("Muchas gracias por utilizar este programa");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static double sumar(double number1, double number2) {
			return number1 + number2;
		}
		static double restar(double number1, double number2) {
			return number1 + number2;
		}
		static double multiplicar(double number1, double number2) {
			return number1 * number2;
		}
		static double dividir(double number1, double number2) {
			return number1 / number2;
		}
		
	}
}