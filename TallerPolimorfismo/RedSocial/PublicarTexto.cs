using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.RedSocial
{
     class PublicarTexto: Publicacion
    {
        public string Contenido { get; set; }

        public PublicarTexto(string contenido)
        {
            Contenido = contenido;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"publicaste un texto: {Contenido}");
        }
    }
}
