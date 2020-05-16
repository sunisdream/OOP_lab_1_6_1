using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(282.74, OOP_lab_1_6_1.Program.Volume(3, 10));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(188.5, OOP_lab_1_6_1.Program.Square(3, 10));
        }
    }
}
