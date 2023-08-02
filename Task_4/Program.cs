#region Task_1 (возведение числа А в степень В)
int a = 4;
int b =5;

Console.WriteLine("{0}^{1} -> {2}",a,b,CustomPow(a,b));
Console.WriteLine("{0}^{1} -> {2}",a,b,Math.Pow(a,b));

int CustomPow (int _a, int _b)
{
    int _result =1;
    for (int i=0;i<b;i++)
    {
        _result = _result*_a;
    }
    return _result;
}

#endregion

#region Task_2 (сумма всех цифр в числе)
// int num = 68765;

// Console.WriteLine("{0} -> {1}",num, SummNum(num));

// int SummNum (int _num)
// {
//     Console.WriteLine(_num);
//     Console.WriteLine(_num.ToString());
//     int _result = 0;

//     Console.WriteLine(_num.ToString());
//     for (int i=0;i<_num.ToString().Length;i++)
//     { 
//         _result = _result + Convert.ToInt32(_num.ToString()[i].ToString());
//     }
    
//     return _result;
// }
#endregion

#region Task_3 (конверт строки в массив и вывод в консоль)

// foreach (int item in ConverToArray(4,6,4,3,6,8,9,0))
// {
//     Console.Write("{0} ",item);
// }

// int[] ConverToArray (params int[] args)
// {    
//     return args;
// }
#endregion
