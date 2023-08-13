using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.figurasGeometricas
{

    class FigurasGeometricas
    {
        //        Jerarquía de Formas Geométricas Crea una jerarquía de clases
        //que representen diferentes formas geométricas(por ejemplo, círculos,
        //rectángulos, triángulos). Utiliza polimorfismo para calcular áreas y perímetros de
        //estas formas y muestra los resultados en pantalla.
        //********************* y *************************************
        //Figuras 3D Extiende el ejercicio de las formas geométricas para
        //        incluir formas en 3D (por ejemplo, cubos, esferas, conos). Utiliza polimorfismo
        //para calcular volúmenes y áreas superficiales de estas formas tridimensionales.

        public virtual void Area()
        {
            Console.WriteLine("calculando area");

        }

        public virtual void Perimetro()
        {
            Console.WriteLine("calculando Perimetro");

        }

        public virtual void CalcularVolumen()
        {
            Console.WriteLine("calculando volumen");
        }



    }
}
