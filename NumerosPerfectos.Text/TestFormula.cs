using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumerosPerfectos.Text
{
    [TestClass]
    public class TestFormula
    {

        [TestMethod]
        public void ReturnTrueIfEsPrimo()
        {
            var prueba = new Formula();

            Assert.IsTrue(prueba.EsPrimo(7));
        }
        [TestMethod]
        public void ReturnFalseIfNoEsPrimo()
        {
            var prueba = new Formula();

            Assert.IsFalse(prueba.EsPrimo(10));
        }

        [TestMethod]
        public void NotReturnValue()
        {
            var prueba = new Formula();
            Assert.AreEqual(0, prueba.ForEuclides(39));
        }

        [TestMethod]
        public void ReturnValue()
        {
            var prueba = new Formula();
            Assert.AreEqual(6, prueba.ForEuclides(3));
        }






    }
}
