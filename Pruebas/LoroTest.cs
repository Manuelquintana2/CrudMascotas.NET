using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Pruebas
{
    [TestClass]
    public class LoroTest
    {
        [TestMethod]
        public void TipoDeMascota_CuandoElParametroEsMayorA30_DeberiaRetornarEmpty()
        {
            //Arrange
            int edad = 31;
            Loro loro = new Loro();
            string resultadoEsperado = string.Empty;

            //Act
            string resultado = loro.TipoDeMascota(edad);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        public void TipoDeMascota_CuandoElParametroEsMenorA0_DeberiaRetornarNull()
        {
            //Arrange
            int edad = -1;
            Loro loro = new Loro();
            string resultadoEsperado = "Error";
            //Act
            string resultado = loro.TipoDeMascota(edad);

            //Assert
            Assert.IsNull(resultado);
        }
        [TestMethod]
        public void TipoDeMascota_CuandoElParametroEsValido_DeberiaRetornarCadena()
        {
            //Arrange
            int edad = 21;
            Loro loro = new Loro();
            //Act
            string resultado = loro.TipoDeMascota(edad);

            //Assert
            Assert.IsNotNull(resultado);
        }
    }
}
