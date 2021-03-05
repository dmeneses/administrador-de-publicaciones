using System.Linq;
using NUnit.Framework;
using SourceCode;

namespace Tests
{
    public class AdministradorDePublicacionesTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeberiaCrearUnaPublicacion()
        {
            var contenido = "publicacion 1";
            var administrador = new AdministradorDePublicaciones();
            var ciudadano = new Ciudadano();
            var publicacion = new Publicacion(contenido);
            administrador.agregarCiudadano(ciudadano);
            ciudadano.agregarPublicacion(publicacion);

            Assert.AreEqual(ciudadano.ListaDePublicaciones.Count, 1);
            Assert.AreEqual(ciudadano.ListaDePublicaciones.First().Contenido, contenido);
        }
    }
}