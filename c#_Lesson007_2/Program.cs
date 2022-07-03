using System;
using static System.Console;

Clear();
WriteLine ("Это программа, которая задаёт двумерный массив заданного размера, заполненный случайными целыми числами,");
WriteLine ("Затем на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

Write("Введите в указанном порядке (целым числом): число строк, число столбцов, минимальное и максимальное число, возможное в массиве (через пробел или запятую): ");

int [] parametersMatrix = GetArrayFromString(ReadLine());
int [,] arr = RandomArray(parametersMatrix);
PrintArray(arr);

int row;
Write("Введите номер нужной строки: ");
if (!int.TryParse(ReadLine(), out row))
{
    Write("Ошибка ввода числа!");
    return;
}
int column;
Write("Введите номер нужного столбца: ");
if (!int.TryParse(ReadLine(), out column))
{
    Write("Ошибка ввода числа!");
    return;
}

SearchPosition(row, column, arr);



void SearchPosition (int x, int y, int [,] array)
{
    if (x <= array.GetLength(0) && y <= array.GetLength(1)) Write ($"{array[x-1,y-1]}");
    else Write("Такого элемента нет!");
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