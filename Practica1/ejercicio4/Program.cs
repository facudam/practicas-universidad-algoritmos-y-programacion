/*
Escriba un programa de aplicación que solicite al usuario que ingrese un número de mes (1 a 12) e imprima el nombre del mes correspondiente. 
Si el valor ingresado no está en ese rango debe imprimir “Mes inválido” . Utilice la sentencia switch.
 */
using System;

namespace ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string numeroMes;
			
			Console.WriteLine("Ingrese el número de mes");
			numeroMes = Console.ReadLine();
			
			switch(numeroMes) {
				case "1": 
					Console.WriteLine("El mes es ENERO");
					break;
				case "2":
					Console.WriteLine("El mes es FEBRERO");
					break;
				case "3":
					Console.WriteLine("El mes es MARZO");
					break;
				case "4":
					Console.WriteLine("El mes es ABRIL");
					break;
				case "5":
					Console.WriteLine("El mes es MAYO");
					break;
				case "6":
					Console.WriteLine("El mes es JUNIO");
					break;
				case "7":
					Console.WriteLine("El mes es JULIO");
					break;
				case "8":
					Console.WriteLine("El mes es AGOSTO");
					break;
				case "9":
					Console.WriteLine("El mes es SEPTIEMBRE");
					break;
				case "10":
					Console.WriteLine("El mes es OCTUBRE");
					break;
				case "11":
					Console.WriteLine("El mes es NOVIEMBRE");
					break;
				case "12":
					Console.WriteLine("El mes es DICIEMBRE");
					break;
				default:
					Console.WriteLine("El mes es inválido");
					break;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}