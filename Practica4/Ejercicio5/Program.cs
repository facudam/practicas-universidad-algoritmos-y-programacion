/*
 Cree una clase llamada Operación con tres variables de instancia: operando1, operando2 y operador. Definir el constructor, todas las propiedades y el método evaluar() que será encargado de efectuar la operación solicitada 
 según el tipo de operador ( ‘+’: sumar, ‘-‘: restar, ‘*’: multiplicar o ‘/’: dividir, operando 1 y operando 2). El programa de aplicación deberá imprimir todos los resultados solicitados y calculados.  
 Por ejemplo, si se ejecuta: Operación op=new Operación(3,4,”+”);  Console.WriteLine(op.evaluar()); el programa imprime 7.
 */
using System;
using Ejercicio5.clases;

namespace Ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Operacion operation = new Operacion(3.5, 4, '+');
			Console.WriteLine(operation.evaluar());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}