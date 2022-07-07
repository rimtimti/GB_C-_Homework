using System;
using static System.Console;

Clear();
WriteLine ("Это программа, которая задаёт двумерный массив заданного размера, заполненный случайными целыми числами");
WriteLine ("Затем печатает его и упорядочивает по убыванию элементы каждой строки этого массива.");

Write("Введите в указанном порядке (целым числом): число строк, число столбцов, минимальное и максимальное число, возможное в массиве (через пробел или запятую): ");

int [] parametersMatrix = GetArrayFromString(ReadLine());
int [,] arr = RandomArray(parametersMatrix);
PrintArray(arr);
WriteLine();

PrintArray(GetArrayFromMaxToMinInRow(arr));

int [,] GetArrayFromMaxToMinInRow (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j; k < array.GetLength(1); k++)
            {
                int max = array [i,j];
                int x = i;
                int y = j;
                if (array[i,k]>max)
                {
                    max = array[i,k];
                    x = i;
                    y = k;
                }
                array[x,y] = array [i,j];
                array [i,j] = max;
            }
        }
    }
return array;
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