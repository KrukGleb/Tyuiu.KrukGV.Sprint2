using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KrukGV.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double r = x * x + y * y;
            if (r < 1 || r > 4)
                return false;
            return true;
        }

    }
}