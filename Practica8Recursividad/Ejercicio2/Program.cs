/*
Implemente una función recursiva que imprima por consola la secuencia de Fibonacci hasta un número pasado por parámetro. La secuencia de Fibonacci se genera sumando dos números consecutivos 
para obtener el siguiente. La definición es la siguiente: f1 = 1  f2 = 1 fn = fn-1 + fn–2    para n >= 3 La serie Fibonacci hasta el número 8→  es: 1, 1, 2, 3, 5, 8, 13, 21
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			fibonacci(10);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void fibonacci(int limite, int a = 1, int b = 1, int contador = 1)
	    {
	        if (contador > limite) // Caso base: detener cuando se han impreso 'limite' números
	            return;
	
	        Console.Write(a + " "); // Imprime el número actual de la secuencia
	
	        // Llamada recursiva con los siguientes valores y aumenta el contador
	        fibonacci(limite, b, a + b, contador + 1);
	    }
	}
}