using Tyuiu.FabritsiusAO.Sprint1.Task5.V5.Lib;

namespace Tyuiu.FabritsiusAO.Sprint1.Task5.V5.Test
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
            double x = 32.597;
            int d = 5;
            double res = ds.Calculate(x);
            int result = Convert.ToInt32(res);
            Assert.AreEqual(d, res);
        }
    }
}