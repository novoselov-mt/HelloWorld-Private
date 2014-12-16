using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Lib.Tests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void TestGreetings()
        {
            var lib = new Library();

            Assert.AreEqual("Hello", lib.GetGreetings());
        }

        [TestMethod]
        public void TestGetName()
        {
            var lib = new Library();

            Assert.AreEqual("World", lib.GetName());
        }
    }

}
