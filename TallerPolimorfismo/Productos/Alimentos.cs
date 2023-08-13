using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Productos
{
     class Alimentos:Producto
    {
        
        private List<Producto> listaAlimentos;

        internal List<Producto> ListaAlimentos { get => listaAlimentos; set => listaAlimentos = value; }

        public Alimentos(string nombre, int cantidad, double precio, double descuento) : base(nombre, cantidad, precio, descuento)
        {
            ListaAlimentos = new List<Producto>();
        }


        public Alimentos()
        {
            ListaAlimentos = new List<Producto>();
        }

        public void AgregarProducto(string nombre, int cantidad, double precio, double descuento)
        {
            ListaAlimentos.Add(new Producto(nombre,cantidad,precio,descuento));
        }
        public void PrecioProductos()
        {
            double precioTotal = 0;
            for (int i = 0; i < ListaAlimentos.Count; i++)
            {
               
                Alimentos p = new Alimentos(ListaAlimentos[i].Nombre, 
                    ListaAlimentos[i].Cantidad, 
                    ListaAlimentos[i].Precio, 
                    ListaAlimentos[i].Descuento);
                
                double precioT = (p.Cantidad * p.Precio);
                double descuento = precioT * p.Descuento;
                 precioTotal += precioT- descuento;
                Console.WriteLine($"{p.Nombre} - {p.Cantidad}*{p.Precio} con descuento de {p.Descuento} = {precioT-descuento}");

            }

            
            Console.WriteLine($"el precio total con descuento es de: {precioTotal}");
        }
    }
}
