using Tyuiu.FabritsiusAO.Sprint1.Task1.V1.Lib;
namespace Tyuiu.FabritsiusAO.Sprint1.Task1.V1.Test
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
            double x = 3.0;
            double y = 2.0;
            double a = 4.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(24.5, res);
        }
    }
}