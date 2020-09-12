using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person person;

        [SetUp]
        public void Setup()
        {
            person = new Person("Test", "1476358-9");
        }

        [Test]
        public void NombreInvalido()
        {
            const string expected = "Test";
            person.Name= "";
            Assert.AreEqual(expected, person.Name);
        }

        [Test]
        public void NombreNull()
        {
            const string expected = "Test";
            person.Name= null;
            Assert.AreEqual(expected, person.Name);
        }
        
        [Test]
        public void NombreValido()
        {
            const string expected = "Hola";
            person.Name = expected;
            Assert.AreEqual(expected, person.Name);
        }

        [Test]
        public void IdInvalido()
        {
            const string expected = "1476358-9";
            person.ID = "9999999-2";
            Assert.AreEqual(expected, person.ID);
        }

        [Test]
        public void IdInvalidoLetras()
        {
            const string expected = "1476358-9";
            person.ID = "Hola";
            Assert.AreEqual(expected, person.ID);
        }

        [Test]
        public void IdVacio()
        {
            const string expected = "1476358-9";
            person.ID = "";
            Assert.AreEqual(expected, person.ID);
        }

        [Test]
        public void IdValido()
        {
            const string expected = "6020931-5";
            person.ID = expected;
            Assert.AreEqual(expected, person.ID);
        }
    }
}