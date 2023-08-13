using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TallerPolimorfismo.RedSocial
{
    internal class Publicacion
    {
//        Redes Sociales y Publicaciones Simula una red social donde los
//usuarios pueden hacer diferentes tipos de publicaciones(por ejemplo, texto,
//imágenes, videos). Utiliza polimorfismo para mostrar las publicaciones de manera
//adecuada según su tipo.

        public virtual void Mostrar()
        {
            Console.WriteLine("publicacion");
        }
    }
}
