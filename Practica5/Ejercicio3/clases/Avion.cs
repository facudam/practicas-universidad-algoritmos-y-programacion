/*
 Implemente la clase Avión suponiendo que se conoce el nro de vuelo, la empresa aérea, la cantidad de asientos, el origen y destino del vuelo, la hora de salida, cantidad de escalas y la duración del vuelo.   
Defina la clase Aeropuerto que tiene nombre, localidad y la lista de aviones que salen de dicho aeropuerto. En una aplicación (Main) crear el aeropuerto “Chapelco” y cargarle varios aviones.  
Luego simular la venta de pasajes controlando que haya asientos disponibles. De cada venta se ingresa nro de vuelo y cantidad de asientos solicitados. Al final del proceso imprimir la cantidad de pasajes vendidos,  
qué porcentaje de ellos corresponde a vuelos nocturnos (horario de salida posterior a las 20h   y anterior a las 6AM) y cuál es la duración promedio de los vuelos con escalas cuyo destino es Río de Janeiro. 
Observación: la simulación de venta solo controla que haya asientos disponibles, no asigna nro de asiento ni los ocupa.
 */
using System;

namespace Ejercicio3.clases
{
	public class Avion
	{
		public Avion(string numeroVuelo, string empresa, int cantidadAsientos, string origen, string destino, string horaSalida, int cantidadEscalas, string duracionVuelo)
		{
			this.numeroVuelo = numeroVuelo;
			this.empresa = empresa;
			this.cantidadAsientos = cantidadAsientos;
			this.cantidadAsientosDisponibles = cantidadAsientos;
			this.origen = origen;
			this.destino = destino;
			this.horaSalida = horaSalida;
			this.cantidadEscalas = cantidadEscalas;
			this.duracionVuelo = duracionVuelo;
		}
		
		private string numeroVuelo;
		private string empresa;
		private int cantidadAsientos;
		private int cantidadAsientosDisponibles;
		private string origen;
		private string destino;
		private string horaSalida;
		private int cantidadEscalas;
		private string duracionVuelo;
		
		public string NumeroDeVuelo {
			get { return numeroVuelo; }
			set { numeroVuelo = value; }
		}
		
		public string Empresa {
			get { return empresa; }
			set { empresa = value; }
		}
		
		public int CantidadDeAsientos {
			get { return cantidadAsientos; }
			set { cantidadAsientos = value; }
		}
		
		public int CantidadDeAsientosDisponibles {
			get { return cantidadAsientosDisponibles; }
		}
		
		public string Origen {
			get { return origen; }
			set { origen = value; }
		}
		
		public string Destino {
			get { return destino; }
			set { destino = value; }
		}
		
		public string HoraDeSalida {
			get { return horaSalida; }
			set { horaSalida = value; }
		}
		
		public int CantidadDeEscalas {
			get { return cantidadEscalas; }
			set { cantidadEscalas = value; }
		}
		
		public string DuracionDelVuelo {
			get { return duracionVuelo; }
			set { duracionVuelo = value; }
		}
		
		public void venderPasajes(int cantidad) {
			if((cantidadAsientosDisponibles - cantidad) >= 0) {
				cantidadAsientosDisponibles = cantidadAsientosDisponibles - cantidad;
			} else {
				Console.WriteLine("Lo sentimos, pero no hay suficientes asientos disponibles en el vuelo {0}.", numeroVuelo);
			}
		}
		
	}
}
