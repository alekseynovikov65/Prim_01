using System;

Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input task number (54,56,58,60,62): ");
        switch (Console.ReadLine())
        {
            case "54": Task54(); break;
            case "56": Task56(); break;
            case "58": Task58(); break;
            case "60": Task60(); break;
            case "62": Task62(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}

/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
void Task54()
{
    Console.WriteLine("Array m*n");
    Random random = new Random();
    int m = ReadInt("m");
    int n = ReadInt("n");
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = random.Next(1, 10);
        }

    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write($"{array[i, k]} ");
        }
        Console.WriteLine();

    }

    Console.WriteLine("Sorted array:");


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1; j > 0; j--)
        {
            for (int k = 0; k < j; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        } 
    }


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write($"{array[i, k]} ");
        }
        Console.WriteLine();

    }
}

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void Task56()
{
    Console.WriteLine("Array m*n");
    Random random = new Random();
    int m = ReadInt("m");
    int n = ReadInt("n");
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = random.Next(1, 10);
        }

    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write($"{array[i, k]} ");
        }
        Console.WriteLine();

    }

    Console.WriteLine("Sorted array:");

    int[] sumArray = new int[m];

    for (int i = 0; i < sumArray.Length; i++)
    {
        int sum = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            sum = sum + array[i, k];
        }
        sumArray[i] = sum;
    }

    int min = int.MaxValue;
    int minRow = 0;
    for (int i = 0; i < sumArray.Length; i++)
    {
        if(min > sumArray[i])
        {
            min = sumArray[i];
            minRow = i + 1;
        }
    }

    Console.WriteLine($"{minRow} строка");
}

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
void Task58()
{
    Random rand = new Random();
    int[,] a = new int[2, 2];
    int[,] b = new int[2, 2];
    int[,] c = new int[2, 2];

    Console.WriteLine("Array a:");
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = ReadInt("");//rand.Next(1, 10);
        }
    }

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int k = 0; k < a.GetLength(1); k++)
        {
            Console.Write($"{a[i, k]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Array b:");
    for (int i = 0; i < b.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            b[i, j] = ReadInt("");//rand.Next(1, 10);
        }
    }

    for (int i = 0; i < b.GetLength(0); i++)
    {
        for (int k = 0; k < b.GetLength(1); k++)
        {
            Console.Write($"{b[i, k]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("a*b:");
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                c[i, j] += a[i, k] * b[k, j];
            }
        }
    }


    for (int i = 0; i < c.GetLength(0); i++)
    {
        for (int k = 0; k < c.GetLength(1); k++)
        {
            Console.Write($"{c[i, k]} ");
        }
        Console.WriteLine();

    }
}



/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)
*/
void Task60()
{
    Console.WriteLine("Array 2*2*2");
    Random random = new Random();
    int[,,] array = new int[2,2,2];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, k, j] = random.Next(1, 99);
            }
        }
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, k, j]}({i},{k},{j}) ");
            }
            Console.WriteLine();
        }
    }
}



/*
Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void Task62()
{
    int numberOfRows = 4;
    int numberOfColumns = 4;
    Console.WriteLine($"Array {numberOfRows}*{numberOfColumns}");
    Random random = new Random();
    int[,] array = new int[numberOfRows, numberOfColumns];
     

    int columnStart = 0;
    int columnEnd = 0;
    int rowStart = 0;
    int rowEnd = 0;

    int number = 1;
    int columnIndex = 0;
    int rowIndex = 0;

    while (number <= numberOfRows * numberOfColumns)
    {
        array[columnIndex, rowIndex] = number;
        if (columnIndex == columnStart && rowIndex < numberOfColumns - rowEnd - 1)
            ++rowIndex;
        else if (rowIndex == numberOfColumns - rowEnd - 1 && columnIndex < numberOfRows - columnEnd - 1)
            ++columnIndex;
        else if (columnIndex == numberOfRows - columnEnd - 1 && rowIndex > rowStart)
            --rowIndex;
        else
            --columnIndex;

        if ((columnIndex == columnStart + 1) && (rowIndex == rowStart) && (rowStart != numberOfColumns - rowEnd - 1))
        {
            ++columnStart;
            ++columnEnd;
            ++rowStart;
            ++rowEnd;
        }
        ++number;
    }

    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write($"{array[a, b].ToString("D2")} ");
        }
        Console.WriteLine();

    }
}


int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}
