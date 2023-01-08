Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input task number (47,50,52): ");
        switch (Console.ReadLine())
        {
            case "47": Task47(); break;
            case "50": Task50(); break;
            case "52": Task52(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}

/*
Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
void Task47()
{
    Console.WriteLine("Array m*n");
    Random random = new Random();
    int m = ReadInt("m");
    int n = ReadInt("n");
    double[,] array = new double[m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = random.Next(-9,10) + Math.Round(random.NextDouble(),1);
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
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17->такого числа в массиве нет
*/

void Task50()
{
    Console.WriteLine("Array m*n");
    Random random = new Random();
    int m = 3;
    int n = 4;
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = random.Next(10, 100);
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

    var positionsCount = m * n;
    var position = ReadInt("Position (from 1)");

    if (position > positionsCount)
    {
        Console.WriteLine("Такой позиции в массиве нет");
    }
    else
    {
        int a = position / m;
        int b = position % n;
        Console.WriteLine(array[a-1,b-1]);
    }
}

void Task50_()
{
    Random random = new Random();
    int m = 3;
    int n = 4;
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = random.Next(10, 100);
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
    var positionsCount = m * n;
    var a = ReadInt("a");
    var b = ReadInt("b");

    if (a > m || b > n)
    {
        Console.WriteLine("Такой позиции в массиве нет");
    }
    else
    {
        Console.WriteLine(array[a-1, b-1]);
    }
}


/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
void Task52()
{
    Random random = new Random();
    int m = 3;
    int n = 4;
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = random.Next(10, 100);
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

    Console.Write($"Average: ");
    for (int k = 0; k < array.GetLength(1); k++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, k];
        }
        double average = 0; 
        average = (double)sum / array.GetLength(0);

        Console.Write($"{Math.Round(average, 1)} ");
    }
}


int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}