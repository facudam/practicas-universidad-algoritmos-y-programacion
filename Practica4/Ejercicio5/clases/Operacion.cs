
using System;

namespace Ejercicio5.clases
{
	public class Operacion
	{
		public Operacion(double operando1,double operando2, char operador)
		{
			this.operando1 = operando1;
			this.operando2 = operando2;
			this.operador = operador;
		}
		
		private double operando1;
		private double operando2;
		private char operador;
			
		public double Operando1 {
			get {
				return operando1;
			}
			set {
				operando1 = value;
			}
		}
		
		public double Operando2 {
			get {
				return operando2;
			}
			set {
				operando2 = value;
			}
		}
		
		public char Operador {
			get {
				return operador;
			}
			set {
				operador = value;
			}
		}
		
		public double evaluar() {
			double resultado = 0.0;
			switch(operador) {
				case '+':
					resultado = operando1 + operando2;
					break;
				case '-':
					resultado = operando1 - operando2;
					break;
				case '*':
					resultado = operando1 * operando2;
					break;
				case '/':
					resultado = operando1 / operando2;
					break;
				default:
					Console.WriteLine("El operador ingresado es incorrecto");
					break;
			}
			return resultado;
		}
	}
}
