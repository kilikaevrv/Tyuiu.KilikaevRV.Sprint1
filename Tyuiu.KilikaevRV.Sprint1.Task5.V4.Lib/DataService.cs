using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KilikaevRV.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public double Calculate(double k)
        {
            return Math.Round(k / 3600);
        }

        public int SecondsToHours(int time)
        {
            throw new NotImplementedException();
        }
    }
}
