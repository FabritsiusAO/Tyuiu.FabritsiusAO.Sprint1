using Tyuiu.FabritsiusAO.Sprint1.Task4.V1.Lib;

namespace Tyuiu.FabritsiusAO.Sprint1.Task4.V1.Test
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
            double x = 2;
            double wait = 0.0625;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}