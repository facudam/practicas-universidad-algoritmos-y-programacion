/*
 Desarrolle un programa de aplicación que simule la inscripción de participantes de distintas escuelas a una competencia de matemática. De cada alumno se conoce su dni, 
 su nombre y apellido,  y el nombre de la escuela a la que representa. Pueden inscribirse (en forma desordenada y aleatoria) varios alumnos de la misma escuela. 
 Arme un menú que permita: a. Inscribir un alumno (armar una lista de alumnos inscriptos guardando solo el dni) b. Borrar un alumno (eliminarlo de la lista de alumnos inscriptos) 
 c. Indicar total de alumnos inscriptos d. Indicar total de escuelas que al menos tienen un alumno inscripto (armar una lista de escuelas, sin repeticiones) 
 e. Imprimir el listado de las escuelas, ordenado alfabéticamente, sin repeticiones.
 */
using System;
using System.Collections;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{ 
			ArrayList listaDeAlumnosInscriptos = new ArrayList();
			ArrayList listaDeEscuelasParticipantes = new ArrayList();
			
			inscribirAlumno(ref listaDeAlumnosInscriptos);
			inscribirAlumno(ref listaDeAlumnosInscriptos);
			inscribirAlumno(ref listaDeAlumnosInscriptos);
			
			Console.WriteLine("Lista de alumnos inscriptos:");
			foreach(string dni in listaDeAlumnosInscriptos) {
				Console.WriteLine(dni);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void inscribirAlumno(ref ArrayList listaDeAlumnos) {
			string fullname, school, dni;
			Console.WriteLine("Bienvenido, ingrese el nombre completo de la persona a inscribir");
			fullname = Console.ReadLine();
			Console.WriteLine("Ingrese el número de DNI de {0}, sin comas ni puntos", fullname);
			dni = Console.ReadLine().ToLower();
			if (!esAlumnoInscripto(dni, listaDeAlumnos)) {
				listaDeAlumnos.Add(dni);
				Console.WriteLine("Para finalizar ingrese el nombre de la escuela que representa");
				school = Console.ReadLine();
				Console.WriteLine("¡Inscripción realizada con éxito! ¿Desea seguir inscribiendo alumnos? Oprima S para continuar, y N para terminar.");
			} else {
				Console.WriteLine("El alumno ingresado ya se encuentra registrado");
			}
		}
		
		static bool esAlumnoInscripto(string dni, ArrayList listaDeAlumnos) {
			bool estaInscripto = false;
			for (int i=0; i < listaDeAlumnos.Count; i++) {
				if ((listaDeAlumnos[i] as string) == dni) {
					estaInscripto = true;
					break;
				}
			}
			return estaInscripto;
		}
	}
}