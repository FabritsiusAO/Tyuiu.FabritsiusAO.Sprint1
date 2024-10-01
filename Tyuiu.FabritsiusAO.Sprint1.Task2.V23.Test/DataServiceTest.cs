using Tyuiu.FabritsiusAO.Sprint1.Task2.V23.Lib;

namespace Tyuiu.FabritsiusAO.Sprint1.Task2.V23.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConvertMinutesToSecondsValid()
        {
            DataService ds = new DataService();
            int minutes = 10;
            int res = ds.ConvertMinutesToSeconds(minutes);
            Assert.AreEqual(600, res);
        }
    }
}