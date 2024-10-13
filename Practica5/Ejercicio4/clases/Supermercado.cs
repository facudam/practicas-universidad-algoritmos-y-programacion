/*
 En un supermercado se venden distintos productos. De cada producto se conoce el código, nombre, marca, stock, nombre del proveedor y precio.  Definir las clases Supermercado y Producto completas (variables de instancia,
 constructores, propiedades).  En una aplicación crear el supermercado “Sol de Oro” y cargarle varios productos con un bucle.  Luego simular la atención a clientes. Cada cliente puede comprar uno o varios productos. 
 De cada producto se ingresa por teclado el código y la cantidad de unidades compradas.  Se debe imprimir el ticket de compra y el monto final a abonar por cada cliente.  
 Debe decrementarse el stock de cada producto comprado y en caso de que quede nulo, se debe imprimir el nombre del proveedor junto con el código del producto a reponer. 
 Al finalizar la simulación imprimir el monto total recaudado por el supermercado.  Observación: en la simulación de atención de clientes no se hace control de stock ya que se supone que cuando el cliente llega a la caja,
 tiene los productos en su carro.
 */
using System;
using System.Collections;

namespace Ejercicio4.clases
{
	
	public class Supermercado
	{
		private string nombre;
		private ArrayList listaDeProductos;
		
		public Supermercado(string nombre)
		{
			this.nombre = nombre;
			this.listaDeProductos = new ArrayList();
		}
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
		
		public ArrayList ListaDeProductos {
			get { return listaDeProductos; }
		}
		
		public void agregarProducto(Producto producto) {
			listaDeProductos.Add(producto);
		}
	}
}
