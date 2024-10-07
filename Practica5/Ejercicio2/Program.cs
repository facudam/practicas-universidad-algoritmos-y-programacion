/*
 Implemente la clase Alumno para modelar alumnos en una Universidad. Agréguele como estado lo que considere necesario para el problema. Piense ¿cómo implementaría los horarios de cursada de un alumno? 
(debe usar la clase del ejercicio anterior).
Como comportamiento implemente el método agregarMateria(string dia, string hora, string materia) que agrega a los horarios del alumno la materia en ese día y hora, si es que tiene libre el horario.
Piense qué otros métodos podría definir.
En una aplicación arme una lista de alumnos con sus horarios de cursada. Defina un menú que permita inscribir alumnos en una materia, imprimir los alumnos inscriptos en una materia dada, 
informar cuántas materias cursa un alumno e imprimir la lista de todos los alumnos.
Observación: la lista de alumnos puede ser un Array o un ArrayList (no hay que definir otra clase nueva)
 */
using System;
using System.Collections;
using Ejercicio2.clases;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			string answer = "s";
			ArrayList listaDeAlumnos = new ArrayList();
			
			do {
				Console.WriteLine("\nElija la opción que quiera realizar: \n1- Ingresar un nuevo alumno. \n2- Inscribir a un alumno en una materia. \n3- Mostrar alumnos inscritos en una materia. \n4- Mostrar cantidad de materias que cursa un alumno. \n5- Imprimir listado total de alumnos. \n6- Desanotar a un alumno de una materia. \n7- Salir\n");
				answer = Console.ReadLine();
				switch(answer) {
					case "1":
						addNewStudent(ref listaDeAlumnos);
						break;
					case "2":
						enrollStudent(ref listaDeAlumnos);
						break;
					case "3":
						showStudentsEnrolledInSubjet(listaDeAlumnos);
						break;
					case "4":
						showSubjectsListByStudent(listaDeAlumnos);
						break;
					case "5":
						showTotalListOfStudents(listaDeAlumnos);
						break;
					case "6":
						unEnrollStudentBySubjectInList(ref listaDeAlumnos);
						break;
					case "7":
						answer = "7";
						break;
					default:
						Console.WriteLine("\nLa opción ingresada es incorrecta.\n");
						break;	
				}
			} while (answer != "7");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void addNewStudent(ref ArrayList listaDeAlumnos) {
			string nombre, apellido, dni;
			Console.WriteLine("\nPor favor, ingrese el nombre");
			nombre = Console.ReadLine();
			Console.WriteLine("\nAhora ingrese el apellido");
			apellido = Console.ReadLine();
			Console.WriteLine("\nIngrese el DNI");
			dni = Console.ReadLine();
			
			if (!estaAlumnoEnLista(listaDeAlumnos, dni)) {
				Alumno nuevoAlumno = new Alumno(nombre, apellido, dni);
				listaDeAlumnos.Add(nuevoAlumno);
				Console.WriteLine("\nEl Alumno {0} {1} se ha registrado correctamente!\n", nombre, apellido);
			} else {
				Console.WriteLine("\nYa se encuentra anotado un alumno con el DNI: {0}\n", dni);
			}	
		}
		
		public static bool estaAlumnoEnLista(ArrayList listaDeAlumnos, string dni) {
			bool estaYaAnotado = false;
			foreach(Alumno alumno in listaDeAlumnos) {
				if(alumno.Dni == dni) {
					estaYaAnotado = true;
					break;
				}
			}
			return estaYaAnotado;
		}
		
		public static void enrollStudent(ref ArrayList listaDeAlumnos) {
			string dni, materia, dia, hora;
			Console.WriteLine("\nIngrese el DNI del alumno que desea anotar en una materia");
			dni = Console.ReadLine();
			bool esAlumno = false;
			foreach(Alumno alumno in listaDeAlumnos) {
				if(alumno.Dni == dni) {
					Console.WriteLine("Ingrese el nombre de la materia.");
					materia = Console.ReadLine();
					Console.WriteLine("Ingrese el dia a cursar");
					dia = Console.ReadLine();
					Console.WriteLine("Ingrese la hora a cursar");
					hora = Console.ReadLine();
					Horario nuevaMateria = new Horario(dia, hora, materia);
					alumno.agregarMateria(nuevaMateria);
					esAlumno = true;
				}
			}
			if (!esAlumno) Console.WriteLine("\nNo existe ningún alumno con el DNI: {0}\n", dni);
		}
		
		public static void showStudentsEnrolledInSubjet(ArrayList listaDeAlumnos) {
			ArrayList listaAlumnosEnMateria = new ArrayList();
			string materia;
			Console.WriteLine("Ingrese el nombre de la materia");
			materia = Console.ReadLine();
			
			foreach(Alumno alumno in listaDeAlumnos) {
				if(estaAlumnoAnotadoEnMateria(alumno, materia)) {
					listaAlumnosEnMateria.Add(alumno);
				}
			}
			
			if(listaAlumnosEnMateria.Count != 0) {
				Console.WriteLine("\nListado de alumnos anotados en la materia {0}:", materia);
				foreach(Alumno alumno in listaAlumnosEnMateria) {
					Console.WriteLine("{0}, {1}", alumno.Apellido, alumno.Nombre);
				}
			} else {
				Console.WriteLine("\nNo hay alumnos anotados en la materia {0}\n", materia);
			}
		}
		
		public static bool estaAlumnoAnotadoEnMateria(Alumno alumno, string materia) {
			bool estaAnotado = false;
			foreach(Horario materiaAnotada in alumno.ListaDeHorarios) {
				if (materiaAnotada.Materia == materia) {
					estaAnotado = true;
					break;
				}
			}
			return estaAnotado;
		}
		
		public static void showSubjectsListByStudent(ArrayList listaDeAlumnos) {
			bool existeAlumnoEnLista = false;
			Console.WriteLine("Ingrese el DNI del alumno");
			string dni = Console.ReadLine();
			
			foreach(Alumno alumno in listaDeAlumnos) {
				if (alumno.Dni == dni) {
					mostrarListadoDeMateriasAnotadas(alumno);
					existeAlumnoEnLista = true;
					break;
				}
			}
			if (!existeAlumnoEnLista) Console.WriteLine("No existe un alumno con el DNI {0}", dni);
		}
		
		public static void mostrarListadoDeMateriasAnotadas(Alumno alumno) {
			if (alumno.ListaDeHorarios.Count != 0) {
				Console.WriteLine("\nLista de materias que cursa {0}, {1}:", alumno.Apellido, alumno.Nombre);
				foreach(Horario materia in alumno.ListaDeHorarios) {
					Console.WriteLine(materia.Materia);
				}
			} else {
				Console.WriteLine("\nEl alumno {0}, {1} no está inscripto en ninguna materia.", alumno.Apellido, alumno.Nombre);
			}
		}
		
		public static void showTotalListOfStudents(ArrayList listaDeAlumnos) {
			if (listaDeAlumnos.Count != 0) {
				Console.WriteLine("\nLista de alumnos:");
				foreach(Alumno alumno in listaDeAlumnos) {
					Console.WriteLine("{0}, {1}", alumno.Apellido, alumno.Nombre);
				}
			} else {
				Console.WriteLine("\nAún no hay alumnos ingresados al sistema");
			}
		}
		
		public static void unEnrollStudentBySubjectInList(ref ArrayList listaDeAlumnos) {
			string dni, materia, dia, hora;
			bool esAlumnoEnLista = false;
			
			Console.WriteLine("\nIngrese el DNI del alumno");
			dni = Console.ReadLine();
			
			foreach(Alumno alumno in listaDeAlumnos) {
				if(alumno.Dni == dni) {
					Console.WriteLine("\nIngrese el nombre de la materia");
					materia = Console.ReadLine();
					Console.WriteLine("\nIngrese el dia de la cursada");
					dia = Console.ReadLine();
					Console.WriteLine("\nIngrese la hora de la cursada");
					hora = Console.ReadLine();
					Horario materiaAEliminar = new Horario(dia, hora, materia);
					
					alumno.eliminarMateria(materiaAEliminar);
					esAlumnoEnLista = true;
					break;
				}
			}
			if(!esAlumnoEnLista) Console.WriteLine("\nNo hay un alumno anotado con el DNI {0}", dni);
		}
	}
}