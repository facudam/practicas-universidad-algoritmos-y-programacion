
using System;
using System.Collections;

namespace Ejercicio2.clases
{
	/*
		Implemente la clase Alumno para modelar alumnos en una Universidad. Agréguele como estado lo que considere necesario para el problema. Piense ¿cómo implementaría los horarios de cursada de un alumno? 
		(debe usar la clase del ejercicio anterior).
		Como comportamiento implemente el método agregarMateria(string dia, string hora, string materia) que agrega a los horarios del alumno la materia en ese día y hora, si es que tiene libre el horario.
		Piense qué otros métodos podría definir.
		En una aplicación arme una lista de alumnos con sus horarios de cursada. Defina un menú que permita inscribir alumnos en una materia, imprimir los alumnos inscriptos en una materia dada, 
		informar cuántas materias cursa un alumno e imprimir la lista de todos los alumnos.
		Observación: la lista de alumnos puede ser un Array o un ArrayList (no hay que definir otra clase nueva)
 	*/
	public class Alumno
	{
		private string nombre, apellido, dni;
		private ArrayList listaDeHorarios;
		
		public Alumno(string nombre, string apellido, string dni)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			listaDeHorarios = new ArrayList();
		}
		
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
		
		public ArrayList ListaDeHorarios {
			get { return listaDeHorarios; }
		}
		
		public void agregarMateria(Horario nuevaMateria) {
			bool estaDisponibleElHorario = true;
			
			foreach(Horario elemento in listaDeHorarios) {
				if (elemento.Dia == nuevaMateria.Dia && elemento.Hora == nuevaMateria.Hora) {
					estaDisponibleElHorario = false;
					break;
				}	
			}
			if (estaDisponibleElHorario) {
				listaDeHorarios.Add(nuevaMateria);
				Console.WriteLine("\nLa inscripción se ha completado con éxito\n");
			} else {
				Console.WriteLine("\nLo sentimos pero el horario elegido no está disponible.\n");
			}
		}
		
		public void eliminarMateria(Horario materia) {
			bool esMateriaInscripta = false;
			foreach(Horario elemento in listaDeHorarios) {
				if (elemento.Dia == materia.Dia && elemento.Hora == materia.Hora && elemento.Materia == materia.Materia) {
					listaDeHorarios.Remove(elemento);
					Console.WriteLine("\nLa materia {0} se ha eliminado de la lista correctamente.", materia.Materia);
					esMateriaInscripta = true;
					break;
				}
				
				if (!esMateriaInscripta) 
					Console.WriteLine("\nNo se ha encontrado la materia {0}, en el dia y hora indicado.", materia.Materia);
			}
		}
		
		
	}
}
