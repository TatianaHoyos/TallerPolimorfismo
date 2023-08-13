using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Productos
{
  class Ropa:Producto
    {
        private List<Producto> listaRopa;

        internal List<Producto> ListaRopa { get => listaRopa; set => listaRopa = value; }

        public Ropa(string nombre, int cantidad, double precio, double descuento) : base(nombre, cantidad, precio, descuento)
        {
            ListaRopa = new List<Producto>();
        }


        public Ropa()
        {
            ListaRopa = new List<Producto>();
        }

        public void AgregarProducto(string nombre, int cantidad, double precio, double descuento)
        {
            ListaRopa.Add(new Producto(nombre, cantidad, precio, descuento));
        }
        public void PrecioProductos()
        {
            double precioTotal = 0;
            for (int i = 0; i < ListaRopa.Count; i++)
            {

                Alimentos p = new Alimentos(ListaRopa[i].Nombre,
                    ListaRopa[i].Cantidad,
                    ListaRopa[i].Precio,
                    ListaRopa[i].Descuento);

                double precioT = (p.Cantidad * p.Precio);
                double descuento = precioT * p.Descuento;
                precioTotal += precioT - descuento;
                Console.WriteLine($"{p.Nombre} - {p.Cantidad}*{p.Precio} con descuento de {p.Descuento} = {precioT - descuento}");

            }


            Console.WriteLine($"el precio total con descuento es de: {precioTotal}");
        }
    }
}
