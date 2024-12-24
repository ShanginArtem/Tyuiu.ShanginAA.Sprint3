using Tyuiu.ShanginAA.Sprint3.Task1.V20.Lib;

namespace Tyuiu.ShanginAA.Sprint3.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 16;
            var res = ds.GetSumSeries(startValue, stopValue);
            Assert.AreEqual(0, res);
        }
    }
}