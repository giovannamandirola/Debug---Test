using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
            this.person = new Person()
            Person sofia = new Person("Test", "8.765.432-1");
        }

        [Test]
        public void NombreNoVacio() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de pruebaaquí
            sofia.nombre("");
            Assert.AreEqual(sofia.nombre;"");
        }
        [Test]
        public void IdVálido() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de pruebaaquí
            sofia.id("8123452-4");
            Assert.AreEqual(sofia.id; "");
        }
    }
}