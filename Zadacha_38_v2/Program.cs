// Задача 38: Напишите программу реализующую методы формирования массива, 
// заполненного случайными вещественными числами 
// и вычисления разницы между максимальным и минимальным элементов массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76


//                                 Без встроенных функций Min Max
using System;
using static System.Console;
Clear();

Write("Enter array size: ");

int arraysize = int.Parse(ReadLine()!);

Write("Enter array min Value: ");

double ValueFrom = Double.Parse(ReadLine()!);

Write("Enter array max Value: ");

double ValueTo = Double.Parse(ReadLine()!);

double[] array = GetArray(arraysize, ValueFrom, ValueTo);

WriteLine();
PrintArray(array);


WriteLine();


double max = array[0];
double min = array[0];

foreach (var element in array)
{
    if(element > max)
    {
        max = element;
    }

    if(element < min)
    {
        min = element;
    }
}

WriteLine();
WriteLine($"max value = {Math.Round(max, 1)}; min value = {Math.Round(min, 1)}");
WriteLine();
WriteLine($"Difference between max and min values: {Math.Round(max - min, 1)}");
WriteLine();


double[] GetArray(int size, double MinValue, double MaxValue)
{
    double[] resultArray = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.NextDouble() * (MaxValue - MinValue) + MinValue; 
    }
    return resultArray;
}


void PrintArray(double[] inArray)
{
    Write("[");     //альтернативный вариант "красивого" вывода массива
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{Math.Round(inArray[i], 1)}");
        Write(i < inArray.Length - 1 ? ", " : "");
    }
    Write("]");
}