using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая задаёт трехмерный массив заданного размера из неповторяющихся двузначных чисел");
WriteLine("Затем печатает построчно, добавляя индексы каждого элемента.");
int x;
Write("Введите необходимое число строк массива: ");
if (!int.TryParse(ReadLine(), out x))
{
    Write("Ошибка ввода числа!");
    return;
}
int y;
Write("Введите необходимое число столбцов массива: ");
if (!int.TryParse(ReadLine(), out y))
{
    Write("Ошибка ввода числа!");
    return;
}
int z;
Write("Введите необходимое число слоев массива: ");
if (!int.TryParse(ReadLine(), out z))
{
    Write("Ошибка ввода числа!");
    return;
}

if (x * y * z <= 90)
{
    WriteLine("Пусть массив будет такой");
    int[] arr = CreateArrayUniqNumbers(x, y, z);
    PrintArray(FillArray3FromArray1(arr, x, y, z));
}
else WriteLine("Такой массив не заполнить неповторяющимися двузначными числами!!!");


int[] CreateArrayUniqNumbers(int a, int b, int c)
{
    int[] randomNumbers = new int[a * b * c];
    for (int i = 0; i < randomNumbers.GetLength(0); i++)
    {
        randomNumbers[i] = new Random().Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (randomNumbers[i] == randomNumbers[j])
                {
                    randomNumbers[i] = new Random().Next(10, 100);
                    j = 0;
                }
            }
        }
    }
    return randomNumbers;
}

int[,,] FillArray3FromArray1(int[] array, int a, int b, int c)
{
    int[,,] result = new int[a, b, c];
    int count = 0;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                result[i, j, k] = array[count];
                count++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]} ({i},{j},{k})\t");
            }
        }
        WriteLine();
    }
    WriteLine();
}