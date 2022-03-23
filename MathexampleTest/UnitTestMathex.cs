using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MathexampleTest
{
    [TestClass]
    public class UnitTestMathex
    {
        
        [TestMethod]
        public void TestElementary()
        {
            System.Random rnd = new System.Random();
            var a = rnd.Next(10, 100);
            var b = rnd.NextDouble()*100.0;
            Assert.AreEqual(Mathexample.Mathex.add(a,b), a+b);
            Assert.AreEqual(Mathexample.Mathex.subtract(a,b), a-b);
            Assert.AreEqual(Mathexample.Mathex.div(a, b), a/b);
            Assert.AreEqual(Mathexample.Mathex.mul(a, b), a*b);
        }
        [TestMethod]
        public void TestMod()
        {
            System.Random rnd = new System.Random();
            var a = rnd.Next(10, 100);
            var b = rnd.Next(10, 100);
            Assert.AreNotEqual(Mathexample.Mathex.mod(a,b), -a);



        }
    }
}