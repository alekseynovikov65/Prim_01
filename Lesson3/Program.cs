Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input task number: ");
        switch (Console.ReadLine())
        {
            case "19": Task19(); break;
            case "21": Task21(); break;
            case "23": Task23(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}

/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
void Task19()
{
    Console.WriteLine("Task19");

    string number = ReadInt("number").ToString();

    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("It's a palindrom");
    }
    else
    {
        Console.WriteLine("It's not a palindrom");
    }
}

int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

int GetDigitFromNumber(int number, int digitPosition)
{
    string numberString = number.ToString();
    int move = numberString.Length - digitPosition;

    return int.Parse(numberString[numberString.Length - digitPosition].ToString());
}

int Pow(int firstNumber, int secondNumber)
{
    int result = 1;

    for (int i = 0; i < secondNumber; i++)
    {
        result *= firstNumber;
    }

    return result;
}

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B(2, 1, -7), -> 15.84
A(7, -5, 0); B(1, -1, 9)-> 11.53*/
void Task21()
{
    Console.WriteLine("Task21");
    int xA = ReadInt("xA");
    int yA = ReadInt("yA");
    int zA = ReadInt("zA");
    int xB = ReadInt("xB");
    int yB = ReadInt("yB");
    int zB = ReadInt("zB");

    double result = 0;

    result = Math.Sqrt(Math.Pow(yA - yB, 2) + Math.Pow(xA - xB, 2) + Math.Pow(zA - zB, 2));
    Console.WriteLine(result);
}

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
void Task23()
{
    Console.WriteLine("Task23");
    int number = ReadInt("Number");
    int i = 1;
    while(i <= number)
    {
        double result = Math.Pow(i, 3);
        Console.Write($"{result} ");
        i++;
    }
}