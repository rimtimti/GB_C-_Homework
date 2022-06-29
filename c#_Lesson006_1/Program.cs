using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая просит у пользователя ввести с клавиатуры M чисел и считает, сколько чисел больше 0 введено.");

Write("Введите элементы массива (через пробелы или запятые): ");
int [] arr = GetArrayFromString(ReadLine());
WriteLine($"{(String.Join(", ", arr))}");
WriteLine($"Введено {GetCountPositiveNumbers(arr)} чисел больше 0");

int [] GetArrayFromString (string arrayStr)
{
    string [] ArS = arrayStr.Split(new char[]{' ',','},StringSplitOptions.RemoveEmptyEntries);
    int [] result = new int [ArS.Length];
    for (int i = 0; i < ArS.Length; i++)
    {
        result [i] = int.Parse(ArS[i]);
    }
    return result;
}

int GetCountPositiveNumbers (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0) count++;
    }
    return count;
}