
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

            // Тест для символа '1'
            char symbol1 = '1';
            var res1 = ds.GetCharCode(symbol1);
            Assert.AreEqual("Символ: 1 Код: 49", res1);

            // Тест для символа 'A'
            char symbol2 = 'A';
            var res2 = ds.GetCharCode(symbol2);
            Assert.AreEqual("Символ: A Код: 65", res2);

            // Тест для точки (сигнал завершения)
            char symbol3 = '.';
            var res3 = ds.GetCharCode(symbol3);
            Assert.AreEqual("exit", res3);
        }
    }
}


