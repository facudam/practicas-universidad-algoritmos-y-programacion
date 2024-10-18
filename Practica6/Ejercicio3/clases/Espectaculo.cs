
using System;

namespace Ejercicio3.clases
{
	
	public class Espectaculo
	{
		public Espectaculo(int capacidad)
		{
			this.capacidad = capacidad;
            this.butacas = new Butaca[capacidad];
            
            for (int i = 0; i < capacidad; i++) 
            {
            	butacas[i] = new Butaca(i + 1, "libre");
            }
		}
		
		protected int capacidad;
		protected Butaca[] butacas;
	}
}
