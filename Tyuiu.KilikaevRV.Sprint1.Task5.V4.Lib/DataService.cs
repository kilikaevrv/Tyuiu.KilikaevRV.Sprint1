using tyuiu.cources.programming.interfaces.Sprint1;


 

namespace Tyuiu.KilkaevRV.Sprint1.Task5.V4.Lib
    {
        public class DataService : ISprint1Task5V4
        {
            public int Calculate(double k)
            {
                // Целочисленное деление для получения полных часов
                int hours = (int)(k / 3600);
                return hours;
            }

        public int SecondsToHours(int time)
        {
            throw new NotImplementedException();
        }
    }
    }
