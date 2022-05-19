using LogicMarbles;
using MarblesKKModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLogic
{
    [TestClass]
    public class TestModel
    {
        [TestMethod]
        public void ModelTest()
        {
            LogicAbstractApi Api = LogicAbstractApi.createApi();
            ModelAbstractApi model = ModelAbstractApi.createApi(Api);
            model.start(640, 300, 10, 3);
            Assert.AreEqual(model.GetMarbelModels().Count, 10);
            model.stop();
        }
    }
}