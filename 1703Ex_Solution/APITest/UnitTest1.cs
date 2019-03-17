using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1703HW;

namespace APITest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(StringAlreadyExistException))]
        public void TestMethod1()
        {
            MyProtectedUniqueList myList = new MyProtectedUniqueList("12345");

            myList.Add("Hello");

            Assert.IsTrue(myList.Get("Hello"));

            Assert.IsFalse(myList.Get("GoodBye!"));

            myList.Add("Hello");

            // will not get to here
            //Assert.IsFalse(myList.Get("Hello"));

        }


    }
}
