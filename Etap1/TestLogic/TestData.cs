using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestData
{
    [TestClass]
    public class TestData
    {
        [TestMethod]
        public void TestCanvas()
        {
            Canvas canvas = new Canvas(10, 10, 3, 2);
            canvas.createMarbles(3, 2);
            Assert.IsNotNull(canvas);
            Assert.AreEqual(canvas.getHeight(), 10);
            Assert.AreEqual(canvas.getWidth(), 10);
            Assert.AreEqual(canvas.GetMarbles().Count, 3);
            Assert.IsTrue(canvas.getOnOff());
            canvas.createMarbles(6, 2);
            Assert.AreEqual(canvas.GetMarbles().Count, 9);

        }
        [TestMethod]
        public void TestMarbles()
        {
            Marble marble = new Marble(3, 10, 10, 0);
            Assert.AreEqual(marble.Radius,3);
            Assert.AreEqual(marble.Posy,10);
            Assert.AreEqual(marble.Posx,10);
        }
    }
}