/*

 */
using System;

namespace Ejercicio3.clases
{
	
	public class Butaca
	{
		public Butaca(int numero, string estado)
		{
			this.numero = numero;
			this.estado = estado;
		}
		
		private int numero;
		private string estado;
		
		public int Numero {
			get { return numero; }
			set { numero = value; }
		}
		
		public string Estado {
			get { return estado; }
			set { estado = value; }
		}
	}
}
