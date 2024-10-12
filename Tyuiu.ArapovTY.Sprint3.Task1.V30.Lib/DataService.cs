using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ArapovTY.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            double d;
            while (startValue <= stopValue)
            {
                d = Convert.ToDouble(startValue);
                sumSeries = sumSeries + ((Math.Pow(value, d) + (5 / (d + 4))) * Math.Sin(value));
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
