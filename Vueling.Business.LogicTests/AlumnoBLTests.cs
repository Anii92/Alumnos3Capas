using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Business.Logic.Tests
{
    [TestClass()]
    public class AlumnoBLTests
    {
        [DataRow("22-01-1992", 26)]
        [DataRow("22-05-1992", 26)]
        [DataTestMethod]
        public void CalcularEdadTest(string fechaNacimiento, int resultado)
        {
            AlumnoBL alumnoBl = new AlumnoBL();
            int edad = alumnoBl.CalcularEdad(Convert.ToDateTime(fechaNacimiento));
            Assert.IsTrue(resultado == edad);
        }
    }
}