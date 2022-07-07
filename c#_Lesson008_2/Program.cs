using System;
using static System.Console;

Clear();
WriteLine ("Это программа, которая задаёт двумерный массив заданного размера, заполненный случайными целыми числами.");
WriteLine ("Затем программа найдет строку с наименьшей суммой элементов.");

Write("Введите в указанном порядке (целым числом): число строк, число столбцов, минимальное и максимальное число, возможное в массиве (через пробел или запятую): ");

int [] parametersMatrix = GetArrayFromString(ReadLine());
int [,] arr = RandomArray(parametersMatrix);
PrintArray(arr);
WriteLine();
WriteLine($"Строка {GetMaxIndex(arr)} - наименьшая сумма элементов.");


int GetMaxIndex(int [,] array)
{
    int min = 0;
    int x = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array [i,j];
        }
        if ( sum < min || min == 0)
        {
            min = sum;
            x = i;
        } 
    }
    return x + 1;
}

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

int [,] RandomArray(int [] array)
{
    int [,] result = new int [array [0], array [1]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result [i,j] = new Random().Next(array [2], array [3] + 1);
        }
    }
    return result;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array [i,j]}\t");
        }
        WriteLine();
    }
}