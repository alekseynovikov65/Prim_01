Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input task number (41,43): ");
        switch (Console.ReadLine())
        {
            case "41": Task41(); break;
            case "43": Task43(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}

/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
void Task41()
{
    int m = ReadInt("M");
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        int number = ReadInt($"Number #{i+1}");
        if (number > 0)
            count++;
    }
    Console.WriteLine($"Count of numbers > 0: {count}");
}

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
void Task43()
{
    Console.WriteLine($"y = k1 * x + b1, y = k2 * x + b2;");
    int b1 = ReadInt("b1");
    int k1 = ReadInt("k1");
    int b2 = ReadInt("b2");
    int k2 = ReadInt("k2");

    double x = (double)(b2 - b1) /(k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"({x};{y})");
}

int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}


