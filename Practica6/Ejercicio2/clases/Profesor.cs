
using System;
using System.Collections;

namespace Ejercicio2.clases
{
	
	public class Profesor
	{
		protected ArrayList listaAlumnos;
		protected int cupoDisponible;
		protected string materia;
		
		public Profesor(string materia, int cupoDisponible)
		{
			this.listaAlumnos = new ArrayList();
			this.materia = materia;
			this.cupoDisponible = cupoDisponible;
		}
		
		public string Materia {
			get { return materia; }
			set { materia = value; }
		}
		
		public int CupoDisponible {
			get { return cupoDisponible; }
			set { cupoDisponible = value; }
		}
		
		public ArrayList ListaDeAlumnos {
			get { return listaAlumnos; }
		}
		
		public void altaAlumno(Alumno nuevoAlumno) {
			listaAlumnos.Add(nuevoAlumno);
			cupoDisponible -= 1;
		}
		
	}
}
