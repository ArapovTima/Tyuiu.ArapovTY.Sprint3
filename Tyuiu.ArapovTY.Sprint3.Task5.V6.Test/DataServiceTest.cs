using Tyuiu.ArapovTY.Sprint3.Task5.V6.Lib;
namespace Tyuiu.ArapovTY.Sprint3.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            double res = ds.GetSumSumSeries(startValue1, stopValue1, startValue2, stopValue2);
            double wait = 10.191;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}