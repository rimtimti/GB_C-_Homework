using System;
using static System.Console;

Clear();
WriteLine ("Это программа, которая задаёт двумерный массив заданного размера, заполненный случайными целыми числами,");
WriteLine ("После этого вычисляет среднее арифметическое среди элементов в каждом столбце.");

Write("Введите в указанном порядке (целым числом): число строк, число столбцов, минимальное и максимальное число, возможное в массиве (через пробел или запятую): ");

int [] parametersMatrix = GetArrayFromString(ReadLine());
int [,] arr = RandomArrayFromArray(parametersMatrix);
PrintArrayInt(arr);
WriteLine("Среднее арифметическое по столбцам:");
PrintArrayDouble(GetMeanColumnArray (arr));

double [,] GetMeanColumnArray (int [,] array)
{
    double [,] result = new double [1, array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
    double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
        sum += array [i,j];
        }    
    result [0, j] = Math.Round (sum / (array.GetLength(0)), 1);
    }
    return result;
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

int [,] RandomArrayFromArray(int [] array)
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

void PrintArrayInt(int [,] array)
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

void PrintArrayDouble(double [,] array)
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