using Tyuiu.ShanginAA.Sprint3.Task0.V24.Lib;

namespace Tyuiu.ShanginAA.Sprint3.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 10.763;

            Assert.AreEqual(wait, res);
        }
    }
}