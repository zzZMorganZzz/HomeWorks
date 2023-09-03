using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            int count = Convert.ToInt32(Console.ReadLine());
            int countItem = 0;
            for (int i = 0; i < count; i++)
            {
                int tmp = Convert.ToInt32(Console.ReadLine());
                int val = tmp > 0 ? 1 : 0;
                countItem = countItem + val;
            }
            Console.WriteLine(countItem);
            Console.ReadKey();
            #endregion


            #region Задание 2
            LineFunc _ln1 = new LineFunc() { K = -2, B = 6 };
            LineFunc _ln2 = new LineFunc() { K = 6, B = 1 };

            Point _p = LineFunc.CrossPoint(_ln1, _ln2);

            Console.WriteLine("Точка пересечения функций {0} и {1}: {2}", _ln1.ToString(), _ln2.ToString(), _p.ToString());
            Console.ReadKey();

            #endregion
        }
    }
}
