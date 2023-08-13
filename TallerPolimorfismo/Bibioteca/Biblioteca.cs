using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Bibioteca
{
    class Biblioteca
    {
//        Biblioteca de Medios Crea una biblioteca de medios que contenga
//clases para diferentes tipos de medios(por ejemplo, libros, películas, canciones).
//Utiliza polimorfismo para mostrar información detallada de cada medio,
//considerando sus propiedades únicas.

        public virtual void MostrarInfo()
        {
            Console.WriteLine("mostrar informacion de las bibliotecas");

        }
    }
}
