using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
           double [,] array =  GetNewArray(5, 7);
           double? a = GetItem (array,3,6);
           double [] tmp = GetAvgColumn(array);
        }

        private static double[] GetAvgColumn(double[,] array)
        {
            
            int m = array.GetLength(0);
            int n = array.GetLength(1);
            double[] _result = new double[m];


            for (int i = 0; i < m; i++)
            {
                double Summ = 0;
                for (int j = 0; j < n; j++)
                {
                    Summ = Summ + array[i, j];

                }
                _result[i] = Math.Round(Summ / n,2);
            }

            return _result;            
        }

        private static double? GetItem(double[,] array, int X, int Y)
        {
            int m = array.GetLength(0);
            int n = array.GetLength(1);

            if (m >= X && n >= Y && X >= 0 && Y >= 0)
            {
                return array[X, Y];
            }
            else
            {
                return null;
            }
                       
        }

        public static double[,] GetNewArray(int m, int n,bool isFill = true)
        {
            double[,] _result = new double[m, n];
            if (isFill)
            { return FillArray(_result); }
            else
            { return _result; }
            
        }

        private static double[,] FillArray(double[,] _result)
        {
            Random _rnd = new Random();
            int m = _result.GetLength(0);
            int n = _result.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    _result[i, j] = _rnd.Next(-10, 10) + Math.Round(_rnd.NextDouble(),2);

                }
            }

            return _result;
        }

        

        
    }
}
