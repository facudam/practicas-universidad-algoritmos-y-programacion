/*
 Implemente la clase Avión suponiendo que se conoce el nro de vuelo, la empresa aérea, la cantidad de asientos, el origen y destino del vuelo, la hora de salida, cantidad de escalas y la duración del vuelo.   
Defina la clase Aeropuerto que tiene nombre, localidad y la lista de aviones que salen de dicho aeropuerto. En una aplicación (Main) crear el aeropuerto “Chapelco” y cargarle varios aviones.  
Luego simular la venta de pasajes controlando que haya asientos disponibles. De cada venta se ingresa nro de vuelo y cantidad de asientos solicitados. Al final del proceso imprimir la cantidad de pasajes vendidos,  
qué porcentaje de ellos corresponde a vuelos nocturnos (horario de salida posterior a las 20h   y anterior a las 6AM) y cuál es la duración promedio de los vuelos con escalas cuyo destino es Río de Janeiro. 
Observación: la simulación de venta solo controla que haya asientos disponibles, no asigna nro de asiento ni los ocupa.
 */
using System;
using System.Collections;

namespace Ejercicio3.clases
{
	public class Aeropuerto
	{
		public Aeropuerto(string nombre, string localidad)
		{
			this.nombre = nombre;
			this.localidad = localidad;
			this.listaDeAviones = new ArrayList();
		}
		
		private string nombre, localidad;
		private ArrayList listaDeAviones;
		
		
		public void añadirAvion(Avion nuevoAvion) {
			listaDeAviones.Add(nuevoAvion);
		}
	}
}
