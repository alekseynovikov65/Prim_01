Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input task number (34,36,38): ");
        switch (Console.ReadLine())
        {
            case "34": Task34(); break;
            case "36": Task36(); break;
            case "38": Task38(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}

/*
 Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
void Task34()
{
    int length = ReadInt("Length of array");
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenCount++;
        }
    }
    Console.WriteLine($"Even numbers count:{evenCount}");

}

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void Task36()
{
    int length = ReadInt("Length of array");
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(10,100);
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) 
        {
            sum = sum + array[i];
        };
    }
    Console.WriteLine($"Sum of numbers with odd indexes: {sum}");
}

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
void Task38()
{
    int length = ReadInt("Length of array");
    double[] array = new double[length];
    Random random = new Random();
    double max = 0;
    double min = double.MaxValue;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(10,100) + Math.Round(random.NextDouble(), 2);
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];

        if (array[i] < min)
            min = array[i];
    }

    double result = max - min;
    Console.WriteLine($"Max: {max}");
    Console.WriteLine($"Min: {min}");
    Console.WriteLine($"Max - min = {result}");
}

int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}


