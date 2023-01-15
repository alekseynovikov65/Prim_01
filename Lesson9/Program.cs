using System;

Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input task number (64,66,68): ");
        switch (Console.ReadLine())
        {
            case "64": Task64(); break;
            case "66": Task66(); break;
            case "68": Task68(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}

/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
void Task64()
{
    int n = ReadInt("N");
    Write(n);
}

void Write(int n)
{
    Console.Write(n);
    int nextN = n - 1;
    if (nextN >= 1)
    {
        Console.Write(" ");
        Write(nextN);
    }
}

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void Task66()
{
    int m = ReadInt("m");
    int n = ReadInt("n");
    int sum = Sum(m, m, n);
    Console.Write("Sum: ");
    Console.WriteLine(sum);
}

int Sum(int currentSum, int currentNaturalNumber, int endNaturalNumber)
{
    int sum;
    int nextNaturalNumber = currentNaturalNumber + 1;
    if (nextNaturalNumber <= endNaturalNumber)
    {
        sum = currentSum + nextNaturalNumber;
        return Sum(sum, nextNaturalNumber, endNaturalNumber);
    }
    else
    {
        sum = currentSum;
    }
    return sum;
}

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
void Task68()
{
    int m = ReadInt("m");
    int n = ReadInt("n");
    int resultAkkerman = CalcAkkerman(m, n);
    Console.WriteLine($"Akkerman: {resultAkkerman}");
}

int CalcAkkerman(int n, int m)
{
    if(n == 0)
    {
        return m + 1;
    }   
    else if(m == 0)
    {
        return CalcAkkerman(n - 1, 1);
    }
    else
    {
        return CalcAkkerman(n - 1, CalcAkkerman(n, m - 1));
    }
}


int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}
