/*
 Implemente la clase Avión suponiendo que se conoce el nro de vuelo, la empresa aérea, la cantidad de asientos, el origen y destino del vuelo, la hora de salida, cantidad de escalas y la duración del vuelo.   
Defina la clase Aeropuerto que tiene nombre, localidad y la lista de aviones que salen de dicho aeropuerto. En una aplicación (Main) crear el aeropuerto “Chapelco” y cargarle varios aviones.  
Luego simular la venta de pasajes controlando que haya asientos disponibles. De cada venta se ingresa nro de vuelo y cantidad de asientos solicitados. Al final del proceso imprimir la cantidad de pasajes vendidos,  
qué porcentaje de ellos corresponde a vuelos nocturnos (horario de salida posterior a las 20h   y anterior a las 6AM) y cuál es la duración promedio de los vuelos con escalas cuyo destino es Río de Janeiro. 
Observación: la simulación de venta solo controla que haya asientos disponibles, no asigna nro de asiento ni los ocupa.
 */
using System;
using Ejercicio3.clases;

namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int cantidadPasajesVendidos = 0, 
				cantidadPasajesNocturnosVendidos = 0,
				totalVuelosARioConEscala = 0;
			double totalHorasDeViajesARio = 0;
			
			
			Aeropuerto chapelco = new Aeropuerto("Chapelco", "San Martín de los Andes");
			
			Avion nuevoAvion = new Avion(1, "Avianca", 33, "Chapelco", "Rio de Janeiro", new TimeSpan(17,30,0), 0, 3);
			Avion otroAvion = new Avion(2, "FlyBondi", 40, "Chapelco", "Buenos Aires", new TimeSpan(21,30,0), 0, 2);
			Avion avion = new Avion(3, "FlyBondi", 40, "Chapelco", "Rio de Janeiro", new TimeSpan(5,30,0), 1, 5);
			
			chapelco.añadirAvion(nuevoAvion);
			chapelco.añadirAvion(otroAvion);
			chapelco.añadirAvion(avion);
			
			string respuesta = "";
			
			do {
				Console.WriteLine("\nIngrese la opción que desee:\n1- Comprar pasajes.\n2- Finalizar y obtener datos de compras realizadas");
				respuesta = Console.ReadLine();
				
				switch(respuesta) {
					case "1":
						comprarPasajesEnAeropuerto(chapelco, ref cantidadPasajesVendidos, ref cantidadPasajesNocturnosVendidos,ref totalVuelosARioConEscala, ref totalHorasDeViajesARio);
						break;
					case "2":
						mostrarInformación(cantidadPasajesVendidos, cantidadPasajesNocturnosVendidos, totalVuelosARioConEscala, totalHorasDeViajesARio);
						break;
					default:
						Console.WriteLine("Opción incorrecta. Por favor, elija la opción 1 o 2.");
						break;
				}
				
			} while (respuesta != "2");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void comprarPasajesEnAeropuerto(Aeropuerto aeropuerto, ref int cantidadPasajesVendidos, ref int cantidadPasajesNocturnosVendidos,ref int totalVuelosARioConEscala, ref double totalHorasDeViajesARio) {
			
			bool existeNumeroVuelo = false;
			
			Console.WriteLine("Ingrese el número de vuelo al que desea comprar pasajes");
			int numVuelo = int.Parse(Console.ReadLine());
			
			foreach(Avion avion in aeropuerto.ListaDeAviones) {
				if(avion.NumeroDeVuelo == numVuelo) {
					existeNumeroVuelo = true;
					venderPasajePorAvion(avion, ref cantidadPasajesVendidos, ref cantidadPasajesNocturnosVendidos,ref totalVuelosARioConEscala, ref totalHorasDeViajesARio);
					break;
				}
			}
			if (!existeNumeroVuelo) Console.WriteLine("El número de vuelo ingresado no pertenece a un vuelo activo");
		}
		
		public static void venderPasajePorAvion(Avion avion, ref int cantidadPasajesVendidos, ref int cantidadPasajesNocturnosVendidos,ref int totalVuelosARioConEscala, ref double totalHorasDeViajesARio) {
			Console.WriteLine("Ingrese la cantidad de pasajes que desea adquirir");
			int cantPasajes = int.Parse(Console.ReadLine());
			
			if (avion.venderPasajes(cantPasajes)) {
				cantidadPasajesVendidos += cantPasajes;
				incrementarCantidadVuelosNocturnosVendidosSiCorresponde(avion, ref cantidadPasajesNocturnosVendidos, cantPasajes);
				incrementarDatosDeVuelosARioSiCorresponde(avion, ref totalVuelosARioConEscala, ref totalHorasDeViajesARio);
				Console.WriteLine("Su compra se ha realizado con éxito!");
			} else {
				Console.WriteLine("Lamentablemente no hay asientos disponibles para la operación");
			}
		}
		
		public  static void incrementarCantidadVuelosNocturnosVendidosSiCorresponde(Avion avion, ref int cantidadPasajesNocturnosVendidos, int cantidadPasajes) {
			TimeSpan horaNocturna = new TimeSpan(20,0,0),
				horaMadrugada = new TimeSpan(6,0,0);
			if (avion.HoraDeSalida >= horaNocturna || avion.HoraDeSalida <= horaMadrugada) {
				cantidadPasajesNocturnosVendidos += cantidadPasajes;
			}
		}
		
		public static void incrementarDatosDeVuelosARioSiCorresponde(Avion avion, ref int totalVuelosARioConEscala, ref double totalHorasDeViajesARio) {
			if (avion.Destino.ToLower() == "rio de janeiro" && avion.CantidadDeEscalas > 0) {
				totalVuelosARioConEscala += 1;
				totalHorasDeViajesARio += avion.DuracionDelVuelo;
			}
		}
		
		public static void mostrarInformación(int cantidadPasajesVendidos,int cantidadPasajesNocturnosVendidos, int totalVuelosARioConEscala, double totalHorasDeViajesARio) {
			Console.WriteLine("La cantidad de vuelos vendidos hasta ahora es: {0}", cantidadPasajesVendidos);
			double porcentajeVuelosNocturnos = ((double)cantidadPasajesNocturnosVendidos / cantidadPasajesVendidos) * 100;
			Console.WriteLine("El porcentaje de vuelos nocturnos vendidos es: {0}%", porcentajeVuelosNocturnos);
			double duracionPromedioDeVueloARioConEscala = totalHorasDeViajesARio / totalVuelosARioConEscala;
			Console.WriteLine("la duración promedio de los vuelos con escalas cuyo destino es Río de Janeiro es: {0}hs", duracionPromedioDeVueloARioConEscala);
		}
		
	}
}