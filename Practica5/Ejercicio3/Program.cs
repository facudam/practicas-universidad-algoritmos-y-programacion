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
			Aeropuerto chapelco = new Aeropuerto("Chapelco", "San Martín de los Andes");
			
			Avion nuevoAvion = new Avion("23-A", "Avianca", 33, "Buenos Aires", "Rio de Janeiro", "12hs", 0, "3hs");
			Avion otroAvion = new Avion("14-B", "FlyBondi", 40, "Mendoza", "Buenos Aires", "7hs", 0, "2hs");
			Avion avion = new Avion("54-D", "FlyBondi", 40, "Usuahia", "Rio de Janeiro", "6hs", 1, "5hs");
			
			chapelco.añadirAvion(nuevoAvion);
			chapelco.añadirAvion(otroAvion);
			chapelco.añadirAvion(avion);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}