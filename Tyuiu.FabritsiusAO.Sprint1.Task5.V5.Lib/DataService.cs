using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FabritsiusAO.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double FractionalPart = x - Math.Truncate(x);
            int FirstDigit = (int)(FractionalPart * 10);
            return FirstDigit;
        }
    }
}