using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.RedSocial
{
    class RedSoocial
    {
        private List<Publicacion> publicaciones;

        public RedSoocial()
        {
            publicaciones = new List<Publicacion>();
        }

        public void AgregarPublicacion(Publicacion publicacion)
        {
            publicaciones.Add(publicacion);
        }

        public void MostrarPublicaciones()
        {
            Console.WriteLine("Publicaciones en la Red Social:");
            foreach (var publicacion in publicaciones)
            {
                publicacion.Mostrar();
            }
        }
    }

}

