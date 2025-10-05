

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
            string value = "1";
            var res = ds.SymbolCode(value);
            Assert.AreEqual("49", res);
        }

        [TestMethod]
        public void ExitConditionTest()
        {
            DataService ds = new DataService();

            // Тест для точки
            string value = ".";
            var res = ds.SymbolCode(value);
            Assert.AreEqual("exit", res);
        }

        [TestMethod]
        public void EmptyStringTest()
        {
            DataService ds = new DataService();

            // Тест для пустой строки
            string value = "";
            var res = ds.SymbolCode(value);
            Assert.AreEqual("Ошибка: пустая строка", res);
        }
    }
}
