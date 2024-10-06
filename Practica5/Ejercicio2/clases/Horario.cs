
using System;

namespace Ejercicio2.clases
{
	public class Horario
	{
		private string dia, hora, materia;
		
		public Horario(string dia, string hora, string materia)
		{
			this.dia = dia;
			this.hora = hora;
			this.materia = materia;
		}
		
		public string Dia {
			get { return dia; }
			set { dia = value; }
		}
		
		public string Hora {
			get { return hora; }
			set { hora = value; }
		}
		
		public string Materia {
			get { return materia; }
			set { materia = value; }
		}
	}
}
