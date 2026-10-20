using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KrukGV.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

            int i = (k-1) % 7;
            d = (i - 1 + d) % 7;
            string s = "";
            switch (d)
            {
                case 0:
                    s = days[0];
                    break;
                case 1:
                    s = days[1];
                    break;
                case 2:
                    s = days[2];
                    break;
                case 3:
                    s = days[3];
                    break;
                case 4:
                    s = days[4];
                    break;
                case 5:
                    s = days[5];
                    break;
                case 6:
                    s = days[6];
                    break;

            }
            return s;
        }
    }
}