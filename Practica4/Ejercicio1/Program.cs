/*
 Codifique la clase Hora de tal forma que al ejecutar el siguiente programa de aplicación (Main):  class Program { public static void Main(string[] args) { Hora h=new Hora(23,30,15);  
h.imprimir();  Console.ReadKey(true); } } se imprima por consola:     23 HORAS, 30 MINUTOS Y 15 SEGUNDOS
 */
using System;
using Ejercicio1.clases;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Hora hour = new Hora(23, 30, 15);
			hour.imprimir();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}