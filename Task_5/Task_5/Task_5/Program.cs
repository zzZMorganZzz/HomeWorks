using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_5
{


    //Задачи 5 семинара.

    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    //[345, 897, 568, 234] -> 2

    //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0

    //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    //[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76





    public static class ExtensionClass
    {
        public static void FillRandonItem(this int [] collection,bool IsPositiveNumber = true,int NumberOfDigits =2)
        {
            Random _rnd = new Random();
            int _correct = IsPositiveNumber ? 0 : -1;
            for (int i = 0; i < collection.Length; i++)
            {
                collection[i] = _rnd.Next((int)Math.Pow(10, NumberOfDigits) * _correct, (int)Math.Pow(10, NumberOfDigits));
            }
        }

        public static void FillRandonItem(this double[] collection, bool IsPositiveNumber = true, int NumberOfDigits = 2)
        {
            Random _rnd = new Random();
            int _correct = IsPositiveNumber ? 0 : -1;
            for (int i = 0; i < collection.Length; i++)
            {
                collection[i] = (double)_rnd.Next((int)Math.Pow(10, NumberOfDigits) * _correct, (int)Math.Pow(10, NumberOfDigits)) + Math.Round(_rnd.NextDouble(),2);
            }
        }

        public static int GetCountEvenNumber(this int[] collection)
        {
            int _result = 0;
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] % 2 == 0)
                { 
                    _result = _result + 1;
                }
            }
            return _result;
        }

        public static double GetMaxItem(this double[] collection)
        {
            double _result = collection[0];
            for (int i = 0; i < collection.Length; i++)
            {
                _result = collection[i] > _result ? collection[i] : _result;
            }
            return _result;
        }

        public static double GetMinItem(this double[] collection)
        {
            double _result = collection[0];
            for (int i = 0; i < collection.Length; i++)
            {
                _result = collection[i] < _result ? collection[i] : _result;
            }
            return _result;
        }

        public static int GetSummItemOddPosition(this int[] collection)
        {
            int _result = 0;
            int offset = collection.Length / 2;// +collection.Length % 2;
            for (int i = 1; i <= offset; i++)
            {             
                _result = _result + collection[i * 2 - 1];            
            }
            return _result;
        }

        public static string GetStringItemArray(double[] collection)
        {
            string _result = string.Format("[{0}", collection[0]); 
            int i = 1;
            do
            {
                _result = string.Format("{0};{1}",_result,collection[i]);
                i++;

            } 
            while (i != collection.Length);
            return _result+"]";
        }
        public static string GetStringItemArray(int[] collection)
        {
            string _result = "["+collection[0];
            int i = 1;
            do
            {
                _result = string.Format("{0},{1}", _result, collection[i].ToString());
                i++;

            }
            while (i != collection.Length);
            return _result + "]";
        }

    }


    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
            Random _rnd = new Random();
            int[] CollectionItem = new int[_rnd.Next(5,20)];
            CollectionItem.FillRandonItem(true,3);

            Console.WriteLine("{0} -> {1}", ExtensionClass.GetStringItemArray(CollectionItem), CollectionItem.GetCountEvenNumber());
            Console.WriteLine();


            Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
            int[] CollectionItem2 = new int[_rnd.Next(5, 10)];
            CollectionItem2.FillRandonItem();

            Console.WriteLine("{0} -> {1}", ExtensionClass.GetStringItemArray(CollectionItem2), CollectionItem2.GetSummItemOddPosition());
            Console.WriteLine();


            Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
            double[] CollectionItem3 = new double[_rnd.Next(5, 10)];
            CollectionItem3.FillRandonItem();           
            Console.WriteLine("{0} => {1} - {2} = {3}", ExtensionClass.GetStringItemArray(CollectionItem3), CollectionItem3.GetMaxItem(), CollectionItem3.GetMinItem(), CollectionItem3.GetMaxItem() - CollectionItem3.GetMinItem());
            Console.WriteLine();
           
            
            
            
        }


    }
}

