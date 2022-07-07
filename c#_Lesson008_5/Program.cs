using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая задаёт двумерный квадратный массив заданного размера А*А.");
WriteLine("Затем заполняет этот массив спирально по возрастанию чисел от 1.");

int x;
Write("Введите А: ");
if (!int.TryParse(ReadLine(), out x))
{
    Write("Ошибка ввода числа!");
    return;
}

PrintArray(GetArraySpiral(x));

int[,] GetArraySpiral(int number)
{
    int[,] result = new int[number, number];
    int count = 1;
    int i = 0;
    int j = 0;
    while (count <= number * number)
    {
        result [i, j] = count;
        count++;
        if (i <= j + 1 && i + j < number - 1)
            j++;
        else if (i < j && i + j >= number - 1)
            i++;
        else if (i >= j && i + j > number - 1)
            j--;
        else
            i--;
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]}\t");
        }
        WriteLine();
    }
}