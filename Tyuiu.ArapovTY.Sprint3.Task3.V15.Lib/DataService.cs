﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ArapovTY.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;
            int min = 10;
            foreach (char chr in value)
            {
                count++;
                min = Math.Min(min, count);
            }
            return min;
        }
    }
}
