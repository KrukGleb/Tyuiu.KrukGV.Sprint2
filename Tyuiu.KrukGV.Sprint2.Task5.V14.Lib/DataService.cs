using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KrukGV.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            string[] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
            int i = (k-1) % 7;
            d = (i - 1 + d) % 7;
            return days[d];
        }
    }
}