using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLogic
{
    [TestClass]
    public class TestLogic
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
            Marble marble = new Marble(3, 10, 10);
            Assert.AreEqual(marble.Radius,3);
            Assert.AreEqual(marble.Posy,10);
            Assert.AreEqual(marble.Posx,10);
        }
        [TestMethod]
        public void TestApi()
        {
            LogicAbstractApi Api = LogicAbstractApi.createApi();
            Assert.IsNotNull(Api);
            Api.createCanvas(640, 400, 10, 3);
            Api.Move();
            Assert.AreEqual(Api.getCanvas().GetMarbles().Count, 10);
            foreach (Marble marble in Api.getCanvas().GetMarbles())
            {
                Assert.IsNotNull(marble);
                Assert.IsTrue((marble.Posx - marble.Radius) >= 0);
                Assert.IsTrue((marble.Posx + marble.Radius) <= 640);
                Assert.IsTrue((marble.Posy + marble.Radius) <= 400);
                Assert.IsTrue((marble.Posy - marble.Radius) >= 0);
                Assert.AreEqual(marble.Radius,3);
            }
            Api.Stop();




        }
    }
}