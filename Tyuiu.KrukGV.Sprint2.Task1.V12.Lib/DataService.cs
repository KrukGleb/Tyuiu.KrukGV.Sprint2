using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KrukGV.Sprint2.Task1.V12.Lib
{
    public class DataService : ISprint2Task1V12
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            /*152;
            int b = 116;
            int c = 887;
            int d = 556;*/

            res[0] = (a > b) | (b < c); // true
            res[1] = (b < c) & (d < c); // true
            res[2] = (a < b) || (b < c); // true
            res[3] = (b > c) && (d < c); // false
            res[4] = !(b == c); // true
            res[5] = (a < d) ^ (d < c); // false

            
            return res;
        }
    }
}