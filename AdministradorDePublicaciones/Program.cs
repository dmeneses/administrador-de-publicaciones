using System;
using System.Collections.Generic;

namespace SourceCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class AdministradorDePublicaciones
    {
        public List<Ciudadano> Ciudadanos { get; set; }

        public AdministradorDePublicaciones()
        {
            Ciudadanos = new List<Ciudadano>();
        }


        public void agregarCiudadano(Ciudadano ciudadano)
        {
            Ciudadanos.Add(ciudadano);
        }
    }

    public class Ciudadano
    {
        public List<Publicacion> ListaDePublicaciones { get; set; }

        public Ciudadano()
        {
            ListaDePublicaciones = new List<Publicacion>();
        }

        public void agregarPublicacion(Publicacion publicacion)
        {
            ListaDePublicaciones.Add(publicacion);
        }
    }

    public class Publicacion
    {
        public string Contenido { get; set; }

        public Publicacion(string contenido)
        {
            Contenido = contenido;
        }
    }
}

