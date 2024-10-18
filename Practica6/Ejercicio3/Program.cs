/*
 Dado el siguiente enunciado: Un espectáculo se realiza en una sala con una capacidad determinada de butacas. Una obra de teatro es un espectáculo que tiene un título descriptivo y un precio. 
 Cada espectador que compra una entrada informa su nombre y apellido, su dni y se le asigna un número de butaca. De cada butaca se conoce su nro y estado (ocupada o libre). 
 A. Diseñar las clases Espectaculo, ObraDeTeatro,  Butaca y Espectador (defina sus variables de instancia)  e implementar de cada una el constructor correspondiente, usando herencia cuando sea necesario.   
 B. Implementar el método venderEntrada(Espectador unEsp) que le asigna una butaca libre al espectador y modifica la información correspondiente a la obra de teatro (cantidad de butacas libres y la ocupación de la butaca). A
 qué clase pertenece este método?
 C. En un programa de aplicación (Main)  cree  la obra de teatro ‘El fantasma de la ópera’, ingresando por teclado el precio de la misma.
 Simule la venta de entradas a varios espectadores, asignándole su butaca siempre y cuando haya entradas disponibles. Al final del proceso informe la cantidad total de entradas solicitadas, la cantidad que fueron 
 vendidas y la recaudación final.
 */
using System;
using Ejercicio3.clases;
namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingrese el precio por entrada");
			double precioEntrada = double.Parse(Console.ReadLine());
			
			ObraDeTeatro nuevaObra = new ObraDeTeatro(2, "El fantasma de la ópera", precioEntrada);
			
			int cantidadEntradasSolicitadas = 0, cantidadEntradasVendidas = 0;
			double recaudacionFinal = 0;
			
			string respuesta = "";
			
			do {
				Console.WriteLine("\nIngrese la opción que desee:\n1- Vender entrada para {0}.\n2- Salir.", nuevaObra.Titulo);
				respuesta = Console.ReadLine();
				
				switch(respuesta) {
					case "1":
						cantidadEntradasSolicitadas += 1;
						venderUnaEntradaSiEsPosible(nuevaObra, ref cantidadEntradasVendidas, ref recaudacionFinal);
						break;
					case "2":
						Console.WriteLine("\nCantidad de entradas solicitadas: {0}.\nCantidad de entradas vendidas: {1}.\nRecaudación final: ${2}.\nMuchas gracias por utilizar nuestro sistema.", cantidadEntradasSolicitadas, cantidadEntradasVendidas, recaudacionFinal);
						break;
					default:
						Console.WriteLine("Por favor, ingrese una opción válida.");
						break;
				}
				
			} while (respuesta != "2");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void venderUnaEntradaSiEsPosible(ObraDeTeatro unaObra, ref int cantidadEntradasVendidas, ref double recaudacion) {
			Console.WriteLine("\nIngrese el nombre del espectador");
			string nombre = Console.ReadLine();
			Console.WriteLine("Ingrese su apellido");
			string apellido = Console.ReadLine();
			Console.WriteLine("Ahora ingrese su dni.");
			string dni = Console.ReadLine();
			
			Espectador nuevoEspectador = new Espectador(nombre, apellido, dni);
			
			if(unaObra.venderEntrada(nuevoEspectador)) {
				cantidadEntradasVendidas += 1;
				recaudacion += unaObra.Precio;
				Console.WriteLine("Venta exitosa! Su número de butaca es: {0}", nuevoEspectador.NroButaca);
			} else {
				Console.WriteLine("Lo sentimos, pero no hay entradas dispobibles para {0}", unaObra.Titulo);
			}
		}
	}
}