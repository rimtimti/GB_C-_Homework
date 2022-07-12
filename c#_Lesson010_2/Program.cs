using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая принимает число строк и показывает треугольник Паскаля в виде равнобедренного треугольника.");
int number;
Write("Введите необходимое число строк треугольника Паскаля: ");
if (!int.TryParse(ReadLine(), out number))
{
    Write("Ошибка ввода числа!");
    return;
}

PrintArrayPiramid(FillTrianglePascalArray(number));

void PrintArrayPiramid(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j == 0)
            {
                for (int k = 0; k < ((array.GetLength(0) - 1 - i)); k++)
                {
                    Write("   ");
                }
            }
            Write($"{String.Format("{0,-6:###0.#}", array[i, j])}");
        }
        WriteLine();
    }
}

int [,] FillTrianglePascalArray(int n)
{
    int[,] array = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if ( j == i) array [i, j] = 1;
            if ( j == 0) array [i, j] = 1;
            if ( j >  0 && j < i) array [i, j] = array [i - 1, j] + array [i - 1, j - 1];
        }
    }
    return array;
}