using Tyuiu.ArapovTY.Sprint3.Task4.V10.Lib;
namespace Tyuiu.ArapovTY.Sprint3.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 0.014;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}