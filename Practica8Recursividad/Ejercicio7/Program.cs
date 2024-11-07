/*
 Escriba una función recursiva que reciba un ArrayList de apellidos y retorne si existe o no un apellido dado en la lista.
 */
using System;
using System.Collections;

namespace Ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList apellidos = new ArrayList();
			apellidos.Add("Cáceres");
			apellidos.Add("Gonzalez");
			apellidos.Add("Perez");
			apellidos.Add("Martinez");
			
			Console.WriteLine(estaApellidoEnLista(apellidos, "Martinez"));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static bool estaApellidoEnLista(ArrayList listaDeApellidos, string apellido, int posActual = 0)
		{
			if (posActual == (listaDeApellidos.Count - 1)) { // Caso base. 
				return listaDeApellidos[posActual].ToString() == apellido;
			}
			
			if (listaDeApellidos[posActual].ToString() == apellido) {
				return true;
			}
			
			return estaApellidoEnLista(listaDeApellidos, apellido, posActual + 1);
		}
	}
}