using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TallerPolimorfismo.TiendaOnline
{
    internal class Tienda
    {
        //        Formas de Pago en una Tienda Online Implementa un sistema de
        //formas de pago en una tienda online utilizando interfaces.Crea interfaces para
        //diferentes métodos de pago (por ejemplo, tarjeta de crédito, PayPal) y luego
        //permite que un cliente elija una forma de pago y realice una transacción utilizando
        //polimorfismo.

        public void RealizarCompra(double monto, MetodoPago metodoPago)
        {
            Console.WriteLine($"Total a pagar: {monto:C}");
            metodoPago.Pagar(monto);
            Console.WriteLine("¡Compra realizada con éxito!");
        }

    }
}
