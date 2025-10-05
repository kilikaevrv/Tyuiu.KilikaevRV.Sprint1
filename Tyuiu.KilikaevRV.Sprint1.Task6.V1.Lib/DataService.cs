using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KilkaevRV.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string GetCharCode(char symbol)
        {

            if (symbol == '.')
            {
                return "exit";
            }

            int code = (int)symbol;
            return $"Символ: {symbol} Код: {code}";
        }

        public string? GetCharCode(int v)
        {
            throw new NotImplementedException();
        }

        public string SymbolCode(string value)
        {
            throw new NotImplementedException();
        }
    }
}