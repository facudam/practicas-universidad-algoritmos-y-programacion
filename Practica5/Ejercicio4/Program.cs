/*
 En un supermercado se venden distintos productos. De cada producto se conoce el código, nombre, marca, stock, nombre del proveedor y precio.  Definir las clases Supermercado y Producto completas (variables de instancia,
 constructores, propiedades).  En una aplicación crear el supermercado “Sol de Oro” y cargarle varios productos con un bucle.  Luego simular la atención a clientes. Cada cliente puede comprar uno o varios productos. 
 De cada producto se ingresa por teclado el código y la cantidad de unidades compradas.  Se debe imprimir el ticket de compra y el monto final a abonar por cada cliente.  
 Debe decrementarse el stock de cada producto comprado y en caso de que quede nulo, se debe imprimir el nombre del proveedor junto con el código del producto a reponer. 
 Al finalizar la simulación imprimir el monto total recaudado por el supermercado.  Observación: en la simulación de atención de clientes no se hace control de stock ya que se supone que cuando el cliente llega a la caja,
 tiene los productos en su carro.
 */
using System;
using Ejercicio4.clases;
using System.Collections;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			double recaudacionFinal = 0;
			Supermercado supermercado1 = new Supermercado("Sol de Oro");
			
			stockearSupermercado(supermercado1);
			
			string respuesta = "";
			do {
				Console.WriteLine("\nIngrese la opción que desee realizar: \n1- Para atender clientes. \n2- Para culminar día e imprimir recaudación final, u oprima cualquier otra tecla.");
				respuesta = Console.ReadLine();
				
				if (respuesta.ToLower() == "s") {
					atenderClientes(ref recaudacionFinal, supermercado1);
				} else {
					Console.WriteLine("La recaudación final del día es: ${0}.\nMuchas gracias por utilizar nuestro sistema.", recaudacionFinal);
				}
			} while (respuesta.ToLower() == "s");
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void stockearSupermercado(Supermercado supermercado) {
			string respuesta = "";
			do {
				Console.WriteLine("\nIngrese la opción que desee realizar:\n1- Añadir nuevo producto.\n2- Terminar");
				respuesta = Console.ReadLine();
				
				switch(respuesta) {
					case "1":
						cargarProducto(supermercado);
						break;
					case "2":
						Console.WriteLine("Cantidad de productos ingresados: {0}", supermercado.ListaDeProductos.Count);
						break;
					default:
						Console.WriteLine("La opción es incorrecta, por favor vuelva a ingresarla.");
						break;
				}
			} while (respuesta != "2");
		}
		
		public static void cargarProducto(Supermercado supermercado) {
			Console.WriteLine("\nIngrese el nombre del producto");
			string nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el número de código del producto");
			int codigo = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la marca del producto");
			string marca = Console.ReadLine();
			Console.WriteLine("Ingrese el Stock del producto");
			int stock = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el precio del producto");
			double precio = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el nombre del proveedor del producto");
			string proveedor = Console.ReadLine();
			
			supermercado.agregarProducto(new Producto(codigo, stock, precio, nombre, marca, proveedor));
			Console.WriteLine("El producto: {0}, ha sido añadido correctamente.", nombre);
		}
		
		public static void atenderClientes(ref double recaudacion, Supermercado supermercado) {
			
		}
	}
}