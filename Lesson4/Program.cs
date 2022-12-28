Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input task number: ");
        switch (Console.ReadLine())
        {
            case "25": Task25(); break;
            case "27": Task27(); break;
            case "29": Task29(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}

/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
void Task25()
{
    int a = ReadInt("A");
    int b = ReadInt("B");
    double result = Math.Pow(a, b);
    Console.Write("Number A in natural power B: ");
    Console.WriteLine(result);
}

/*

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
void Task27()
{
    int number = ReadInt("Number");
    string strNumber = number.ToString();
    int sum = 0;
    for (int i = 0; i < strNumber.Length; i++)
    {
        int digit = int.Parse(strNumber[i].ToString());
        sum = sum + digit;
    }
    Console.Write("Sum of digits: ");
    Console.WriteLine(sum);

}

/*

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
void Task29()
{
    Console.WriteLine("Input 8 elements.");
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"element #{i+1}");
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

}
int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}


