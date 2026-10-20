using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KrukGV.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            string prev_str = (n < 10)
                ? "0" + n
                : Convert.ToString(n);

            if (m > 1)
                return $"{m - 1}.{prev_str}";

            int prev = (n == 1) ? 12 : n - 1;

            int day = prev switch
            {
                1 => 31,  // янва
                2 => 28,  // фев
                3 => 31,  // мар
                4 => 30,  // апр
                5 => 31,  // май
                6 => 30,  // июн
                7 => 31,  // июл
                8 => 31,  // авг
                9 => 30,  // сен
                10 => 31, // окт
                11 => 30, // ноя
                12 => 31 // дек
            };
            prev_str = (prev < 10)
                ? "0" + prev
                : Convert.ToString(prev);


            return $"{day}.{prev_str}";
        }
    
        
    }
}