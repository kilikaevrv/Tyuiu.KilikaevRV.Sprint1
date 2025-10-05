using tyuiu.cources.programming.interfaces.Sprint1;

using System;

namespace Tyuiu.KilkaevRV.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
{
        public string SymbolCode(string value)
        {
            throw new NotImplementedException();
        }
    }

    public string GetCharCode(char symbol)
        {
            if (symbol == '.')
            {
                return "exit";
            }

            int code = (int)symbol;
            return code.ToString(); // Возвращаем только код как строку
        }
    }
}