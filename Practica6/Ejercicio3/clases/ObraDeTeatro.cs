/*
 Dado el siguiente enunciado: Un espectáculo se realiza en una sala con una capacidad determinada de butacas. Una obra de teatro es un espectáculo que tiene un título descriptivo y un precio. 
 Cada espectador que compra una entrada informa su nombre y apellido, su dni y se le asigna un número de butaca. De cada butaca se conoce su nro y estado (ocupada o libre). 
 A. Diseñar las clases Espectaculo, ObraDeTeatro,  Butaca y Espectador (defina sus variables de instancia)  e implementar de cada una el constructor correspondiente, usando herencia cuando sea necesario.   
 B. Implementar el método venderEntrada(Espectador unEsp) que le asigna una butaca libre al espectador y modifica la información correspondiente a la obra de teatro (cantidad de butacas libres y la ocupación de la butaca). 
 A qué clase pertenece este método?  
 C. En un programa de aplicación (Main)  cree  la obra de teatro ‘El fantasma de la ópera’, ingresando por teclado el precio de la misma.
 Simule la venta de entradas a varios espectadores, asignándole su butaca siempre y cuando haya entradas disponibles. Al final del proceso informe la cantidad total de entradas solicitadas, la cantidad que fueron 
 vendidas y la recaudación final.
 */
using System;

namespace Ejercicio3.clases
{
	public class ObraDeTeatro: Espectaculo
	{
		public ObraDeTeatro(int capacidad, string titulo, double precio): base(capacidad)
		{
			this.titulo = titulo;
			this.precio = precio;
		}
		
		private string titulo;
		private double precio;
		
		public string Titulo {
			get { return titulo; }
			set { titulo = value; }
		}
		
		public double Precio {
			get { return precio; }
			set { precio = value; }
		}
		
		public bool venderEntrada(Espectador espectador) {
			bool hayButacaLibre = false;
			
			for (int i = 0; i < butacas.Length; i++) {
				if (butacas[i].Estado == "libre") {
					espectador.NroButaca = i + 1;
					butacas[i].Estado = "ocupada";
					hayButacaLibre = true;
					break;
				}
			}
			return hayButacaLibre;
		}
	}
}
