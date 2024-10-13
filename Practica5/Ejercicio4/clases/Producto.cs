/*
 En un supermercado se venden distintos productos. De cada producto se conoce el código, nombre, marca, stock, nombre del proveedor y precio.  Definir las clases Supermercado y Producto completas (variables de instancia,
 constructores, propiedades).  En una aplicación crear el supermercado “Sol de Oro” y cargarle varios productos con un bucle.  Luego simular la atención a clientes. Cada cliente puede comprar uno o varios productos. 
 De cada producto se ingresa por teclado el código y la cantidad de unidades compradas.  Se debe imprimir el ticket de compra y el monto final a abonar por cada cliente.  
 Debe decrementarse el stock de cada producto comprado y en caso de que quede nulo, se debe imprimir el nombre del proveedor junto con el código del producto a reponer. 
 Al finalizar la simulación imprimir el monto total recaudado por el supermercado.  Observación: en la simulación de atención de clientes no se hace control de stock ya que se supone que cuando el cliente llega a la caja,
 tiene los productos en su carro.
 */
using System;

namespace Ejercicio4.clases
{
	
	public class Producto
	{
		private int codigo, stock;
		private double precio;
		private string nombre, marca, nombreProveedor;
		
		public Producto(int codigo, int stock, double precio, string nombre, string marca, string nombreProveedor)
		{
			this.codigo = codigo;
			this.stock = stock;
			this.precio = precio;
			this.nombre = nombre;
			this.marca = marca;
			this.nombreProveedor = nombreProveedor;
		}
		
		public int Codigo {
			get { return codigo; }
			set { codigo = value; }
		}
		
		public int Stock {
			get { return stock; }
			set { stock = value; }
		}
		
		public double Precio {
			get { return precio; }
			set { precio = value; }
		}
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
		
		public string Marca {
			get { return marca; }
			set { marca = value; }
		}
		
		public string NombreProveedor {
			get { return nombreProveedor; }
			set { nombreProveedor = value; }
		}
		
		public bool venderProducto(int cantidad) {
			bool esCompraRealizada = false;
			if ((stock - cantidad) >= 0) {
				stock -= cantidad;
				esCompraRealizada = true;
			} else {
				Console.WriteLine("Lo sentimos, no hay stock suficiente para realizar esa compra.");
			}
			return esCompraRealizada;
		}
	}
}
