using Tyuiu.FabritsiusAO.Sprint1.Task6.V14.Lib;

namespace Tyuiu.FabritsiusAO.Sprint1.Task6.V14.Test
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
            string a = "??";
            bool res = ds.CheckLowerCaseRusLetters(a);
            bool wait = false;
            Assert.AreEqual(res, wait);

        }
    }
}