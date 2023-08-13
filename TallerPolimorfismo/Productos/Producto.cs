using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Productos
{
     class Producto
    {
        //        Tienda de Productos Diseña una clase base Producto y clases
        //derivadas que representen diferentes tipos de productos(por ejemplo, alimentos,
        //electrónicos, ropa). Implementa polimorfismo para calcular el precio total de una
        //lista de productos, aplicando descuentos específicos para cada tipo de producto.

        private string nombre;
        private int cantidad;
        private double precio;
        private double descuento;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Descuento { get => descuento; set => descuento = value; }

        public Producto()
        {
        }

        public Producto(string nombre, int cantidad, double precio, double descuento)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
            Descuento = descuento;
        }

        public virtual void AgregarProducto(string nombre, int cantidad, double precio,double descuento)
        {
            Console.WriteLine("agregando nuevo producto");
        }

        public virtual void PrecioTotal()
        {
            Console.WriteLine("calculando precio total");

        }

       
    }
}
