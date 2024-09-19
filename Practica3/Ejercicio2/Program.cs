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
			
			string opcion = "";
			
			while (opcion != "f") {
				Console.WriteLine("\nEscriba la opción de desee realizar: \na. Inscribir un alumno. \nb. Borrar un alumno.  \nc. Indicar total de alumnos inscriptos. \nd. Indicar total de escuelas participantes. \ne. Imprimir el listado de las escuelas participantes. \nf. Salir");
				opcion = Console.ReadLine().ToLower();
				
				switch(opcion) {
					case "a":
						inscribirAlumno(ref listaDeAlumnosInscriptos, ref listaDeEscuelasParticipantes);
						break;
					case "b":
						eliminarAlumno(ref listaDeAlumnosInscriptos);
						break;
					case "c":
						indicarCantidadDeAlumnosInscriptos(listaDeAlumnosInscriptos);
						break;
					case "d":
						indicarCantidadDeEscuelasParticipantes(listaDeEscuelasParticipantes);
						break;
					case "e":
						listarEscuelasParticipantes(listaDeEscuelasParticipantes);
						break;
					case "f":
						Console.WriteLine("Muchas gracias por utilizar nuestro sistema. Adiós");
						break;
					default:
						Console.WriteLine("La opción elegida es incorrecta.  Elija una opción entre la a y la f");
						break;
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void inscribirAlumno(ref ArrayList listaDeAlumnos,ref ArrayList listaDeEscuelas) {
			string fullname, school, dni;
			Console.WriteLine("Ingrese el nombre completo de la persona a inscribir");
			fullname = Console.ReadLine();
			Console.WriteLine("Ingrese el número de DNI de {0}, sin comas ni puntos", fullname);
			dni = Console.ReadLine().ToLower();
			if (!esAlumnoInscripto(dni, listaDeAlumnos)) {
				listaDeAlumnos.Add(dni);
				Console.WriteLine("Para finalizar ingrese el nombre de la escuela que representa");
				school = Console.ReadLine().ToLower();
				agregarEscuelaSiCorresponde(school, listaDeEscuelas);
				Console.WriteLine("¡Inscripción realizada con éxito!");
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
		static bool esEscuelaYaAgregada(string escuela, ArrayList listaDeEscuelas) {
			bool estaYaAgregada = false;
			for (int i=0; i < listaDeEscuelas.Count; i++) {
				if ((listaDeEscuelas[i] as string) == escuela.ToLower()) {
					estaYaAgregada = true;
					break;
				}
			}
			return estaYaAgregada;
		}
		static void agregarEscuelaSiCorresponde(string escuela, ArrayList listaDeEscuelas) {
			if (!esEscuelaYaAgregada(escuela.ToLower(), listaDeEscuelas)) {
				listaDeEscuelas.Add(escuela);
			}
		}
		
		static void eliminarAlumno(ref ArrayList listaDeAlumnos) {
			Console.WriteLine("Ingrese el dni del alumno que desea eliminar. Sin comas ni puntos");
			string dni = Console.ReadLine().ToLower();
			bool esAlumnoYaInscripto = false;
			
			for (int i = 0; i < listaDeAlumnos.Count; i++) {
				if ((listaDeAlumnos[i] as string) == dni) {
					listaDeAlumnos.Remove(listaDeAlumnos[i]);
					esAlumnoYaInscripto = true;
					break;
				}
			}
			if (esAlumnoYaInscripto) {
				Console.WriteLine("El alumno ingresado ha sido eliminado con éxito");
			} else {
				Console.WriteLine("No se ha encontrado ningun alumno con el dni {0} en el sistema", dni);
			}
		}
		
		static void indicarCantidadDeAlumnosInscriptos(ArrayList listaDeAlumnos) {
			Console.WriteLine("La cantidad de alumnosInscriptos es: {0}", listaDeAlumnos.Count);
		}
		static void indicarCantidadDeEscuelasParticipantes(ArrayList listaDeEscuelas) {
			Console.WriteLine("La cantidad de escuelas participantes es: {0}", listaDeEscuelas.Count);
		}
		static void listarEscuelasParticipantes(ArrayList listaDeEscuelas) {
			listaDeEscuelas.Sort(); // El método sort ordena alfabeticamente la lista de strings.
			Console.WriteLine("Lista de escuelas participantes:");
			foreach(string escuela in listaDeEscuelas) { 
				Console.WriteLine(escuela);
			}
		}
	}
}