using Tyuiu.ShanginAA.Sprint3.Task4.V30.Lib;

namespace Tyuiu.ShanginAA.Sprint3.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            double wait = 1.924;

            var res = ds.Calculate(start, stop);

            Assert.AreEqual(wait, res);
        }
    }
}