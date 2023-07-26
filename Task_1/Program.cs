//Task_1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write ("Введите первое число и нажмите Enter: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число и нажмите Enter: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Большее число: "+ (a>b?a:b).ToString());


//Task_2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write ("Введите второе число и нажмите Enter: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число и нажмите Enter: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a>b?a:b;
max = max>c?max:c;
Console.WriteLine("Большее число:{0}",max);

//Task_3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write ("Введите число и нажмите Enter: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a%2==0);

//Task_3. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Введите число N и нажмите Enter: ");
int a = Convert.ToInt32(Console.ReadLine());
int index =1;
while (index<=a){
    if(index%2==0){
        Console.WriteLine (index);
    }
    index++;
}


