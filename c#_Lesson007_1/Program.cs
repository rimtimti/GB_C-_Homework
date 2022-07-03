using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая задаёт двумерный массив заданного размера, заполненный случайными вещественными числами.");
Write("Введите в указанном порядке (целым числом): число строк, число столбцов, минимальное и максимальное число, возможное в массиве (через пробел или запятую): ");

int [] parametersMatrix = GetArrayFromString(ReadLine());
PrintArray(RandomArray(parametersMatrix));

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

double [,] RandomArray(int [] array)
{
    double [,] result = new double [array [0], array [1]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result [i,j] = new Random().Next(array [2], array [3]) + new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{Math.Round(array [i,j], 1)}\t");
        }
        WriteLine();
    }
}