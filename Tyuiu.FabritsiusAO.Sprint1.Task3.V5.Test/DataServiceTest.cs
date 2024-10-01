using Tyuiu.FabritsiusAO.Sprint1.Task3.V5.Lib;

namespace Tyuiu.FabritsiusAO.Sprint1.Task3.V5.Test
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
            double a = 3.5;
            double b = 120;
            double wait = 420;
            var res = ds.DistanceLength(a, b);
            Assert.AreEqual(wait, res);
        }
    }
}