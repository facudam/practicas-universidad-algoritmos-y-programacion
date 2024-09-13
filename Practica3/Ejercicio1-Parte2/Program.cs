/*
	Dada la interfaz de usuario del TAD fechaNac escriba un programa de aplicación que ingrese los datos de la fecha
	de nacimiento de una persona y luego imprima su edad.
	El TAD fechaNac permite almacenar día, mes y año de nacimiento de una persona.
	Operaciones permitidas:
	crearFecha(dia,mes,año): retorna una fecha de nacimiento cargada con el dia, mes y año pasados como
	argumentos
	verDia(), retorna el día de nacimiento de la fecha
	verMes(), retorna el mes de nacimiento de la fecha
	verAño(), retorna el año de nacimiento de la fecha
	modDia( int nuevoD), que modifica el día de nacimiento de la fecha
	modMes( int nuevoM), que modifica el mes de nacimiento de la fecha
	modAño( int nuevoA), que modifica el año de nacimiento de la fecha
	edad(fechaActual), retorna la diferencia en años, entre la fechaActual y la fecha de nacimiento
	Observación: NO se pueden cambiar los argumentos de las operaciones
 */
using System;
using FechaNac;

namespace Ejercicio1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número del día de nacimiento");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número del mes de naciemiento");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número del año de nacimiento");
            int anio = int.Parse(Console.ReadLine());
            
            FechaNac fechaNacimiento = new FechaNac();
            fechaNacimiento.crearFecha(dia, mes, anio);
            
            FechaNac fechaActual = new FechaNac();
            fechaActual.crearFecha(7, 9, 2024); // O podemos pedirle al usuario la fecha actual o al sistema.
            
            int edad = fechaNacimiento.edad(fechaActual);
            Console.WriteLine("La edad es: ", edad);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}   