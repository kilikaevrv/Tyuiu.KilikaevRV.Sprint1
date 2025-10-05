using Tyuiu.KilikaevRV.Sprint1.Task5.V4.Lib;


namespace Tyuiu.KilkaevRV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double k = 18000; // 5 часов
            var res = ds.Calculate(k);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void ValidExpression13257()
        {
            DataService ds = new DataService();
            double k = 13257;
            var res = ds.Calculate(k);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void ValidExpression3599()
        {
            DataService ds = new DataService();
            double k = 3599; // Меньше часа
            var res = ds.Calculate(k);
            Assert.AreEqual(0, res