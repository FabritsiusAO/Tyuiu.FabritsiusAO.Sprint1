using Tyuiu.FabritsiusAO.Sprint1.Task0.V20.Lib;

namespace Tyuiu.FabritsiusAO.Sprint1.Task0.V20.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(13, res);
        }
    }
}