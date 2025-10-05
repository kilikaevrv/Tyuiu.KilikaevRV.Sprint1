using Tyuiu.KilikaevRV.Sprint1.Task5.V4.Lib;
namespace Tyuiu.KilikaevRV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double k = 9869;
            var res = ds.Calculate(k);
            Assert.AreEqual(3, res);
        }
    }
}
