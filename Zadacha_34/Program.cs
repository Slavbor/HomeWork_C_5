// Задача 34: Напишите программу реализующую методы формирования массива, 
// заполненного случайными положительными трёхзначными числами, 
// и подсчета количества чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using System;
using static System.Console;
Clear();

Write("Введите размер массива: ");

int arraysize = int.Parse(ReadLine()!);

int[] array = GetArray(arraysize);

WriteLine();
PrintArray(array);

WriteLine();





int count = 0;

foreach (var element in array)
{
    if(element % 2 == 0)
    {
        count += 1;
    }
}
WriteLine();
WriteLine($"Quantity of even number: {count}");
WriteLine();


int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(100, 1000);
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
