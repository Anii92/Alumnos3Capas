using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Vueling.Business.Logic.Tests
{
    [TestClass()]
    public class AlumnoBLTests
    {
        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        [DataRow("22-01-1992", 26)]
        [DataRow("22-05-1992", 26)]
        [DataTestMethod]
        public void CalcularEdadTest(string fechaNacimiento, int resultado)
        {
            Log.Debug("Inicia el test calcular edad");
            AlumnoBL alumnoBl = new AlumnoBL();
            int edad = alumnoBl.CalcularEdad(Convert.ToDateTime(fechaNacimiento));
            Assert.IsTrue(resultado == edad);
            Log.Debug("Finaliza el test calcular edad");
        }
    }
}