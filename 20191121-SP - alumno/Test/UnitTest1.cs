using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SerializarPlaneta()
        {
            Planeta planeta = new Planeta(1,1,1,null);
            Xml<Planeta> xml = new Xml<Planeta>();
            xml.Guardar("Planetas.xml",planeta);
            Planeta planetaDes;
            xml.Leer("Planeta.xml",out planetaDes);

            Assert.IsTrue(planeta.VelocidadTraslacion==planetaDes.VelocidadTraslacion);
        }

        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosException))]
        public void ErrorDeArchivos()
        {
            Planeta planeta;
            Xml<Planeta> xml = new Xml<Planeta>();
            xml.Leer("C:\\Planetas.xml",out planeta);
        }
    }
}
