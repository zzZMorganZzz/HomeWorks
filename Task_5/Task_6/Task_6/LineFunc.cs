using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class LineFunc
    {
        public int K { get; set; }
        public int B { get; set; }

        public override string ToString()
        {
            return  String.Format("Y ={0}X+{1}",K,B);
            //return base.ToString();
        }

        public static Point CrossPoint(LineFunc _ln1, LineFunc _ln2)
        {

            Point _p = new Point();
            _p.X = (_ln1.B - _ln2.B) / (_ln1.K - _ln2.K);
            _p.X = _ln1.K * _p.X + _ln1.B;
            return _p;
        }


    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return String.Format("({0};{1})", X, Y);
        }

       

    }
}
