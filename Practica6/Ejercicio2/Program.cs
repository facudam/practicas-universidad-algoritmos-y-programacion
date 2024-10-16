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

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}