
using System;

namespace Ejercicio3.clases
{
	
	public class Espectador
	{
		public Espectador(string nombre, string apellido, string dni)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
		}
		
		private string nombre, apellido, dni;
		private int nroButaca;
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
		
		public string Apellido {
			get { return apellido; }
			set { apellido = value; }
		}
		
		public string Dni {
			get { return dni; }
			set { dni = value; }
		}
		
		public int NroButaca {
			get { return nroButaca; }
			set { nroButaca = value; }
		}
	}
}
