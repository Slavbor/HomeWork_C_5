// Задача 38: Напишите программу реализующую методы формирования массива, 
// заполненного случайными вещественными числами 
// и вычисления разницы между максимальным и минимальным элементов массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76

using System;
using static System.Console;
Clear();

Write("Enter array size: ");

int arraysize = int.Parse(ReadLine()!);

Write("Enter array min Value: ");

double from = Double.Parse(ReadLine()!);

Write("Enter array max Value: ");

double to = Double.Parse(ReadLine()!);

double[] array = GetArray(arraysize, from, to);

WriteLine();
PrintArray(array);


WriteLine();



double maxArrValue = array.Max();
double minArrValue = array.Min();
WriteLine();
WriteLine($"max values = {Math.Round(maxArrValue, 1)}; min values = {Math.Round(minArrValue, 1)}");
WriteLine($"Difference between max and min values: {Math.Round(maxArrValue - minArrValue, 1)}");
WriteLine();


double[] GetArray(int size, double MinValue, double MaxValue)
{
    double[] resultArray = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.NextDouble() * (MaxValue - MinValue) + MinValue;; 
       // resultArray[i] = rnd.Next(MinValue, MaxValue) + rnd.NextDouble();
        

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