using Tyuiu.FabritsiusAO.Sprint1.Task7.V11.Lib;

namespace Tyuiu.FabritsiusAO.Sprint1.Task7.V11.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double wait = 1.751;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}