using Tyuiu.KrukGV.Sprint2.Task5.V14.Lib;

namespace Tyuiu.KrukGV.Sprint2.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Крук Г. В. | НТм25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Крук Глеб Владиславович | НТм25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая которая использует оператор switch          *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int k = 0;
            Console.WriteLine("Введите k");
            k = Convert.ToInt16(Console.ReadLine());

            int d = 0;
            Console.WriteLine("Введите d");
            d = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindDayName(k, d);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}