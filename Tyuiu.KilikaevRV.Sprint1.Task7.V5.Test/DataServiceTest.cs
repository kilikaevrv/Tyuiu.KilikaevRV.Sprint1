
using Tyuiu.KilkaevRV.Sprint1.Task7.V5.Lib;

namespace Tyuiu.KilkaevRV.Sprint1.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest 
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 1.0;
            double wait = -0.255;
            double res = ds.Calculate(x);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateZero()
        {
            DataService ds = new DataService();

            double x = 0.0;
            double wait = 0.0;
            double res = ds.Calculate(x);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateNegative()
        {
            DataService ds = new DataService();

            double x = -1.5;
            double wait = -0.154;
            double res = ds.Calculate(x);

            Assert.AreEqual(wait, res);
        }
    }
}