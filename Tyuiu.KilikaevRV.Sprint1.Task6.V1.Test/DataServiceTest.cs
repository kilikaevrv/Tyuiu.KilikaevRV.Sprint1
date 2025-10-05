
using Tyuiu.KilkaevRV.Sprint1.Task6.V1.Lib;


namespace Tyuiu.KilkaevRV.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            // Тест для символа '1' - ожидается "49"
            char symbol = '1';
            var res = ds.GetCharCode(symbol);
            Assert.AreEqual("49", res);
        }

        [TestMethod]
        public void ExitConditionTest()
        {
            DataService ds = new DataService();

            // Тест для точки
            char symbol = '.';
            var res = ds.GetCharCode(symbol);
            Assert.AreEqual("exit", res);
        }
    }
}
