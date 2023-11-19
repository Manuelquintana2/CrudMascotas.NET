using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    [TestClass]
    public class SerializarTest
    {
        [TestMethod]
        public void Serializar_DeberiaRetornarTrue()
        {
            //Arrange
            Serializadora<Perro> serilizadora = new Serializadora<Perro>();
            Perro perro = new Perro();
            //Act
            bool resultado = serilizadora.Serializar(perro, "path");

            //Assert
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Deserializar_CuandoElPathNoExiste_DeberiaRetornarNull()
        {
            //Arrange
            Serializadora<Perro> serilizadora = new Serializadora<Perro>();
            FileNotFoundException excepcion = new FileNotFoundException();
            //Act
            Perro resultado = serilizadora.Deserializar("dasdsa");

            //Assert
            Assert.AreEqual(excepcion, resultado);
        }
    }
}
