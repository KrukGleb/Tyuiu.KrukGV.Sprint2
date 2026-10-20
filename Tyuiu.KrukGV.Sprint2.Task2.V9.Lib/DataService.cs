using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KrukGV.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x < 3 || x > 13 || y < 3 || y > 12)
                return false;

            if (y == 3 && ((x > 5 && x < 9) || x == 13))
                return false;
            if (y == 4 && ((x > 5 && x < 9) || x == 13))
                return false;
            if (y == 5 && ((x > 4 && x < 8) || x == 13 || x == 3))
                return false;
            if (y == 6 && ((x > 4 && x < 7) || x == 3))
                return false;
            if ((y == 7 || y == 8) && ((x > 4 && x < 8) || x == 3))
                return false;
            if ((y == 9 || y == 10) && (x == 3 || x == 5 || x == 13))
                return false;
            if (y == 11 && x == 13)
                return false;
            if (y == 12 && (x < 7 || x > 10))
                return false;
            return true;
        }

       
    }
}