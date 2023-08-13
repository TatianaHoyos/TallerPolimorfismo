using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.TiendaOnline
{
    internal class Paypal : MetodoPago
    {
        public void Pagar(double monto)
        {
            Console.WriteLine($"Pago de {monto:C} procesado con paypal.");
        }


    }
    

    
}
