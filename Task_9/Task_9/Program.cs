using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PrintNumToOne(9);
            GetSumm(3, 6);

            int m = 7;
            int n = 3;
            int a = AccermanFunc(n,m);
            Console.WriteLine("m={0}; n={1} -> A(m,n) = {2}", m, n, a);

        }

        private static int AccermanFunc(int n, int m)
        {            
                if (n == 0) return m + 1;
                if (n != 0 && m == 0) return AccermanFunc(n - 1, 1);
                if (n > 0 && m > 0) return AccermanFunc(n - 1, AccermanFunc(n, m - 1));
                return AccermanFunc(n, m);            
        }

        private static void GetSumm(int p1, int p2)
        {
            int _result = 0;
            for (int i = p1; i <=p2; i++)
            {
                _result = _result + i;
            }

            Console.WriteLine("M={0}; N={1} -> {2}", p1, p2, _result);
        }

        private static void PrintNumToOne(int p)
        {
            string _result = "";
            for (int i = p; i > 0; i--)
            { 
                _result = _result + i.ToString()+",";
            }

            Console.WriteLine("N={0}->\"{1}\"", p, _result.TrimEnd(','));
        }
    }
}
