#region  Task_1 (проверка на полиндром)
// int number  = 1234321;
// Console.WriteLine (IsPalindrome(number));

// bool IsPalindrome (int _number)
// {
//     bool _IsResult = false;
//     if (_number.ToString().Length%2==1)
//     {
        
//         int _sPoint = _number.ToString().Length/2;
//         int offset = 0;
//         while (_sPoint-offset!=-1)
//         {
//             if(_number.ToString()[_sPoint+offset]!=_number.ToString()[_sPoint-offset])
//             {
//                 _IsResult = false;
//                 break;
//             }
//             else 
//             {
//                 _IsResult = true;
//             }
//             offset++;
//         }
//     }
//     return _IsResult;
// }

#endregion

#region Task_2 (расстояние между двумая точками)

// Console.WriteLine (DistanceTwoPoint(new Point (){X=1,Y=4,Z=3}, new Point(){X=-2,Y=8,Z=-1}));

// double DistanceTwoPoint (Point a,Point b)
// {
//    return Math.Sqrt(Math.Pow(a.X-b.X,2)+Math.Pow(a.Y-b.Y,2)+Math.Pow(a.Z-b.Z,2));
// }

// public class Point 
// {
//     public Point ()
//     {
//         this.X =0;
//         this.Y=0;
//         this.Z=0;
//     }
    
//     public int X {get;set;}

//     public int Y {get;set;}

//     public int Z {get;set;}
// }
#endregion

#region Task_3 (возведение в 3 степень)

// foreach (int item in PowToThree(8))
// {
//     Console.WriteLine(item);
// }

// List<int> PowToThree (int N)
// {
//    List<int> _result = new List<int>();
//     for(int i =0; i<=N;i++)
//     {
//         _result.Add(Convert.ToInt32(Math.Pow(i,3)));
//     }
//     return _result;
// }
#endregion
