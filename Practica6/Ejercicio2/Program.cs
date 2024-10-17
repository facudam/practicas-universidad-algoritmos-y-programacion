/*
 Dadas las siguientes clases  
	public class Profesor {      
	protected ArrayList alumnos; protected int cupoDisponible;   protected string materia; }  
	public Profesor(string m, int num) {    
	alumnos = new ArrayList();                                                                                                                   
	materia = m;                                                                                                                      
	cupoDisponible = num
	} 
	public void altaAlumno(Alumno e){      
		alumnos.Add(e);      
		cupoDiponible - =1;    }
    }           ……… 
	}  
	public class Coordinador: Profesor {      
		private string area;        
		public Coordinador (int c, Materia m, string a): base (m, c){
           area  = a;  
		}       
	}                  ………  
	}              
	public class Alumno {   
		private string nombre, apellido;   private int legajo; private double promedio;    
		public Alumno(int l, string n, string a, double pr){    
			nombre = n;    apellido = a;    legajo = l;    promedio= pr } 
		public int Promedio() { 
			set{    promedio=value;} get{   return promedio; 
		} } ……… } 
	a. Agregue a la clase Alumno el método mejorPromedioQue(Alumno otroA) que retorne verdadero si el alumno que recibe el mensaje tiene promedio más alto que el otro alumno que se pasa como parámetro. 
	b. En un programa de aplicación (Main)  crear un coordinador y simular la inscripción de varios alumnos (con un while). Al final el proceso imprimir cuántos alumnos no pudieron inscribirse por falta de 
	cupo y el porcentaje de alumnos de ese coordinador con promedio mayor a 8.
 */
using System;
using Ejercicio2.clases;
using System.Collections;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Coordinador nuevoCoordinador = new Coordinador("Base de datos", 5, "Informática");
			ArrayList listaDeAlumnosSinCupo = new ArrayList();
			
			string respuesta = "";
			do {
				Console.WriteLine("Ingrese la opción que desee: \n1- Inscribir alumno.\n2- Imprimir datos de inscripciones");
				respuesta = Console.ReadLine();
				
				switch(respuesta) {
					case "1":
						intentarInscribirAlumno(nuevoCoordinador, ref listaDeAlumnosSinCupo);
						break;
					case "2":
						imprimirDatos(nuevoCoordinador, listaDeAlumnosSinCupo);
						break;
					default:
						Console.WriteLine("Por favor, ingrese una opción correcta.");
						break;
				} 
			} while (respuesta != "2");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void intentarInscribirAlumno(Coordinador coodinador,ref ArrayList listaDeAlumnosSinCupo) {
			Console.WriteLine("Por favor, ingrese el nombre del alumno");
			string nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el apellido");
			string apellido = Console.ReadLine();
			Console.WriteLine("Por favor, ingrese el número de su legajo");
			int legajo = int.Parse(Console.ReadLine());
			Console.WriteLine("Y finalmente su promedio");
			double promedio = double.Parse(Console.ReadLine());
			
			Alumno nuevoAlumno = new Alumno(nombre, apellido, legajo, promedio);
			
			if(coodinador.CupoDisponible > 0) {
				coodinador.altaAlumno(nuevoAlumno);
			} else {
				listaDeAlumnosSinCupo.Add(nuevoAlumno);
			}
		}
		
		public static void imprimirDatos(Coordinador coordinador, ArrayList listaDeAlumnosSinCupo) {
			int cantidadDeAlumnosConNotaMayorA8 = 0;
			
			foreach(Alumno alumno in coordinador.ListaDeAlumnos) {
				if (alumno.Promedio >= 8) {
					cantidadDeAlumnosConNotaMayorA8 += 1;
				}
			}
			
			double porcentajeAlumnosConNotaMayorAOcho = ((double)cantidadDeAlumnosConNotaMayorA8 / coordinador.ListaDeAlumnos.Count) * 100;
			
			Console.WriteLine("La cantidad de alumnos que se quedaron sin cupo es: {0}", listaDeAlumnosSinCupo.Count);
			Console.WriteLine("El porcentaje de alumnos del coordinador con nota mayor o igual a 8 es del: {0}%", porcentajeAlumnosConNotaMayorAOcho);
		}
	}
}