using System.Security.Cryptography;
// Задача 36: Напишите программу реализующую методы формирования массива,
//  заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;
using static System.Console;
Clear();

Write("Enter array size: ");

int arraysize = int.Parse(ReadLine()!);

Write("Enter array min Value: ");

int from = int.Parse(ReadLine()!);

Write("Enter array max Value: ");

int to = int.Parse(ReadLine()!);

int[] array = GetArray(arraysize, from, to);

WriteLine();
PrintArray(array);

WriteLine();





int summ = 0;
int index = 0;

foreach (var element in array)
{
    if(index % 2 != 0)
    {
        summ += element;
    }
    index++;
}

WriteLine();
WriteLine($"Summary of odd index elements: {summ}");
WriteLine();


int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(MinValue, MaxValue + 1);
    }
    return resultArray;
}


void PrintArray(int[] inArray)
{
    Write("[");     //альтернативный вариант "красивого" вывода массива
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]}");
        Write(i < inArray.Length - 1 ? ", " : "");
    }
    Write("]");
}
