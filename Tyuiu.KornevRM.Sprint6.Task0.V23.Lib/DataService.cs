﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KornevRM.Sprint6.Task0.V23.Lib
{
    public class DataService : ISprint6Task0V23
    {
        public double Calculate(int x)
        {
            double res = Math.Round(Math.Log(x + 1) - Math.Log(x + 2), 3);
            return res;
        }
    }
}
