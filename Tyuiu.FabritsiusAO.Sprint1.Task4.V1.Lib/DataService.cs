﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FabritsiusAO.Sprint1.Task4.V1.Lib
{
    public class DataService : ISprint1Task4V1
    {
        public double Calculate(double x)
        {
            var res = 1 / Math.Pow(x + 2, 2);

            double recu = Math.Round(res, 4);

            return recu;
        }
    }
}