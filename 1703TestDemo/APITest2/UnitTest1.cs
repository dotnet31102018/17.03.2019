using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1703;

namespace APITest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCaluclatorAdd()
        {
            //Assert.AreEqual(3, 3); -- works
            //Assert.AreEqual(3, 2); -- fails

            Calculator c = new Calculator();

            int result = c.Add(2, 3);
            Assert.AreEqual(5, result);

            Assert.IsTrue(true);


            // left side is the truth!
            //Assert.AreEqual(3, c.Add(0, 3));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestCalculatorDiv()
        {
            Calculator c = new Calculator();

            int result = c.Divide(3, 0);
        }
    }
}
