using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Productos
{
    class Electronico:Producto
    {
        private List<Producto> listaElectronicos;

        internal List<Producto> ListaElectronicos { get => listaElectronicos; set => listaElectronicos = value; }

        public Electronico(string nombre, int cantidad, double precio, double descuento) : base(nombre, cantidad, precio, descuento)
        {
            ListaElectronicos = new List<Producto>();
        }


        public Electronico()
        {
            ListaElectronicos = new List<Producto>();
        }

        public void AgregarProducto(string nombre, int cantidad, double precio, double descuento)
        {
            ListaElectronicos.Add(new Producto(nombre, cantidad, precio, descuento));
        }
        public void PrecioProductos()
        {
            double precioTotal = 0;
            for (int i = 0; i < ListaElectronicos.Count; i++)
            {

                Alimentos p = new Alimentos(ListaElectronicos[i].Nombre,
                    ListaElectronicos[i].Cantidad,
                    ListaElectronicos[i].Precio,
                    ListaElectronicos[i].Descuento);

                double precioT = (p.Cantidad * p.Precio);
                double descuento = precioT * p.Descuento;
                precioTotal += precioT - descuento;
                Console.WriteLine($"{p.Nombre} - {p.Cantidad}*{p.Precio} con descuento de {p.Descuento} = {precioT - descuento}");

            }


            Console.WriteLine($"el precio total con descuento es de: {precioTotal}");
        }
    }
}
