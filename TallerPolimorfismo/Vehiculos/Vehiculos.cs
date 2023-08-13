using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Vehiculos
{
    internal class Vehiculos
    {

//        Vehículos y Desplazamiento Crea una jerarquía de clases para
//diferentes tipos de vehículos(por ejemplo, automóviles, bicicletas, aviones). Utiliza
//polimorfismo para simular el desplazamiento de cada tipo de vehículo, teniendo en
//cuenta sus características de movimiento
    public virtual void Avanzar()
        {
            Console.WriteLine("el vehiculo esta avanzando");
        }
    }
}
