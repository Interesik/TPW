using System;
using LogicMarbles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLogic
{
    [TestClass]
    public class TestLogicApi
    {
        [TestMethod]
    public void TestApi()
    {
        LogicAbstractApi Api = LogicAbstractApi.createApi();
        Assert.IsNotNull(Api);
        Api.createCanvas(640, 400, 10, 3);
        Assert.AreEqual(Api.GetMarblesLogic().Count, 10);
        foreach (MarbleLogic marble in Api.GetMarblesLogic())
        {
            Assert.IsNotNull(marble);
            Assert.IsTrue((marble.Posx - marble.Radius) >= 0);
            Assert.IsTrue((marble.Posx + marble.Radius) <= 640);
            Assert.IsTrue((marble.Posy + marble.Radius) <= 400);
            Assert.IsTrue((marble.Posy - marble.Radius) >= 0);
            Assert.AreEqual(marble.Radius, 3);
        }
        Api.Stop();




    }
}
}
