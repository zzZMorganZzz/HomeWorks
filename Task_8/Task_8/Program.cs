using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = GetArrayDuo(3, 2);
            SortedArray(a);
            var num = GetNumMinSummRow(a);
            int[, ,] b = GetArrayTrio(2, 2, 2);
            printArray(b);




            var x = GetArrayDuo(2, 2);
            var y = GetArrayDuo(2, 2);
            var z = Multiplication(x, y);


            var m = FillAsSpiral();

        }

        private static void printArray(int[, ,] b)
        {
            int x = b.GetLength(0);
            int y = b.GetLength(1);
            int z = b.GetLength(2);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("{0} ({1},{2},{3}) ", b[i, j, k], i, j, k);
                    }
                    Console.WriteLine();
                }
            }
        }

        private static int[, ,] GetArrayTrio(int x, int y, int z)
        {
            int[,,] _result = new int[x, y,z];
            Random _rnd = new Random();

            for (int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        _result[i, j, k] = _rnd.Next(-10, 10);
                    }
                }
            }
            return _result;           
        }

        private static int [,] GetArrayDuo(int m, int n, bool isFilling=true)
        {
            int[,] _result = new int[m, n];
            Random _rnd = new Random();
            if (isFilling)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        _result[i, j] = _rnd.Next(0, 20);
                    }
                }
            }
            return _result;
        }

        public static void SortedArray(int[,] array)
        {
            bool isSorted = false;
            int m = array.GetLength(0);
            int n = array.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j + 1 < n)
                    {
                        if (array[i, j] < array[i, j + 1])
                        {
                            int tmp = array[i, j];
                            array[i, j] = array[i, j + 1];
                            array[i, j + 1] = tmp;
                            isSorted = true;

                        }
                    }
                }
            }
            if (isSorted)
            {
                SortedArray(array);
            }
        }

        public static int GetNumMinSummRow(int[,] array)
        {
            int m = array.GetLength(0);
            int n = array.GetLength(1);
            int numRow = 0;
            int minSumm = 0;            

            for (int i = 0; i < m; i++)
            {
                int tmp = 0;
                for (int j = 0; j < n; j++)
                {
                    tmp = tmp + array[i, j];
                }
                if (minSumm == 0)
                {
                    minSumm = tmp;
                    numRow = i;
                }
                else
                {
                    if(tmp < minSumm)
                    {
                        minSumm=tmp;
                        numRow = i;
                    }             
                }                
            }
            return numRow;
        }


        static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }



        static int[,] FillAsSpiral()
        {
            int[,] _result = new int[4, 4];
            int width = _result.GetLength(1);
            int height = _result.GetLength(0);
            var array = new int[width * height];
            int index = 0;
            int minX = 0;
            int maxX = width - 1;
            int minY = 0;
            int maxY = height - 1;
            while (true)
            {
                if (maxX - minX < 0)
                    break;
                for (int i = minX; i <= maxX; i++)
                    _result[minY, i] = index++;                    
                minY++;

                if (maxY - minY < 0)
                    break;
                for (int i = minY; i <= maxY; i++)
                    _result[i, maxX] = index++;
                maxX--;

                if (maxX - minX < 0)
                    break;
                for (int i = maxX; i >= minX; i--)
                    _result[maxY, i] = index++;
                maxY--;

                if (maxY - minY < 0)
                    break;
                for (int i = maxY; i >= minY; i--)
                    _result[i, minX] = index++;
                minX++;
            }
            return _result;
        }
    }
}
