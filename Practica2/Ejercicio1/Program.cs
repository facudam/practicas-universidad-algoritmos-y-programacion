/*
 ¿Cuál es el problema del código siguiente y cómo se soluciona? Qué valores imprime?
 	int i=0; 
 	for(int i=1; i<=10;)   
		{ Console.WriteLine(i++); } 
	Console.ReadKey();
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//int i = 0; Doble declaración.
			for (int i=1; i<=10;) {
				Console.WriteLine(i++);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}